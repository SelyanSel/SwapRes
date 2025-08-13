using Newtonsoft.Json;
using SwapRes.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SwapRes.Core.ScreenAPI;

namespace SwapRes
{
    public partial class Form1 : Form
    {
        SavedSettings settings = new SavedSettings();

        class ProfileData
        { 
            public int TargetX { get; set; } = 1920;
            public int TargetY { get; set; } = 1080;
        }

        class SavedSettings
        {
            public ProfileData BaseProfile { get; set; } = new ProfileData();
            public ProfileData TargetProfile { get; set; } = new ProfileData();
            public ProfileData SecondaryProfile { get; set; } = new ProfileData();
            public bool enableSecondaryProfile { get; set; } = false;
            public bool SwappedRes { get; set; } = false;
            public bool firstTime { get; set; } = true;
            public int screenIndex { get; set; } = 0;
        }

        public Form1()
        {
            InitializeComponent();

            // init screenapi

            msgDialog.Parent = this;

            selectedScreen.Items.Clear();
            foreach (var screen in ScreenAPI.GetScreenNames())
            {
                selectedScreen.Items.Add(screen);
            }

            // init fonts

            baseX.Font = Outfit.Regular(9f);
            baseY.Font = Outfit.Regular(9f);
            tarX.Font = Outfit.Regular(9f);
            tarY.Font = Outfit.Regular(9f);
            STargetX.Font = Outfit.Regular(9f);
            STargetY.Font = Outfit.Regular(9f);

            settingsLabel.Font = Outfit.SemiBold(16f);

            swapButton.Font = Outfit.Bold(9f);
            exitButton.Font = Outfit.Bold(9f);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settings = new SavedSettings();

            if (File.Exists(Application.StartupPath + @"/settings.bin"))
            {
                settings = JsonConvert.DeserializeObject<SavedSettings>(File.ReadAllText(Application.StartupPath + @"/settings.bin"));
            }
            else
            {
                settings.SecondaryProfile.TargetX = -1;
                settings.SecondaryProfile.TargetY = -1;
                File.WriteAllText(Application.StartupPath + @"/settings.bin", JsonConvert.SerializeObject(settings));
            }

            selectedScreen.SelectedItem = selectedScreen.Items[settings.screenIndex];

            baseX.Text = settings.BaseProfile.TargetX.ToString();
            baseY.Text = settings.BaseProfile.TargetY.ToString();

            tarX.Text = settings.TargetProfile.TargetX.ToString();
            tarY.Text = settings.TargetProfile.TargetY.ToString();

            if (settings.SecondaryProfile.TargetX != -1)
            {
                STargetX.Text = settings.SecondaryProfile.TargetX.ToString();
                STargetY.Text = settings.SecondaryProfile.TargetY.ToString();
            }

            secondaryCheckbox.Checked = settings.enableSecondaryProfile;

            if (settings.firstTime)
            {
                settings.firstTime = false;
                msgDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                msgDialog.Show("Hey!\nWelcome to SwapRes.\nThis program lets you swap rapidly between resolutions," +
                    " just by double clicking the icon in your Icon Tray. (the up arrow on the right of your " +
                    "taskbar.)\n\nOnly resolutions supported by the selected monitor can be applied!" +
                    "\nCheck your Screen settings in the Settings app to check supported resolutions for your monitor.\n" +
                    "If you input a wrong or unsupported resolution, you won't be able to apply changes.\n" +
                    "The Base resolution is the base resolution you want to use.\n" +
                    "The Target one is the one that will be switched up to when you double-click (it goes back and" +
                    " forth to the base resolution.)" +
                    "\nThe secondary one replaces the Target resolution when it is enabled, allowing you to have 2 swappable resolutions." +
                    "\n(Profiles feature in the future? Let me know if you would be interested!)" +
                    "\n\nFeel free to explore the program! If you need any help, refer to the wiki on the github page :)" +
                    "\n\n-selyansel");
                File.WriteAllText(Application.StartupPath + @"/settings.bin", JsonConvert.SerializeObject(settings));
                msgDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                StartupManager.EnableStartup();
            }

            if (StartupManager.IsStartupEnabled())
            {
                guna2ToggleSwitch1.Checked = true;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Hide();
            SwapRes();
        }

        void SwapRes()
        {
            if (settings.SwappedRes)
            {
                settings.SwappedRes = false;
                ChangeScreenResolution(Screen.PrimaryScreen, settings.BaseProfile.TargetX, settings.BaseProfile.TargetY);
            }
            else
            {
                settings.SwappedRes = true;
                if (settings.enableSecondaryProfile)
                {
                    ChangeScreenResolution(Screen.PrimaryScreen, settings.SecondaryProfile.TargetX, settings.SecondaryProfile.TargetY);
                }
                else
                {
                    ChangeScreenResolution(Screen.PrimaryScreen, settings.TargetProfile.TargetX, settings.TargetProfile.TargetY);
                }
            }
            File.WriteAllText(Application.StartupPath + @"/settings.bin", JsonConvert.SerializeObject(settings));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SwapRes();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // verify if each resolution is valid before continuing

            if (!IsValidRes(baseX.Text, baseY.Text, settings.screenIndex))
            {
                msgDialog.Show("The selected resolution for Base Resolution is invalid" +
                    " or unsupported by your screen.");
                return;
            }

            if (!IsValidRes(tarX.Text, tarY.Text, settings.screenIndex))
            {
                msgDialog.Show("The selected resolution for Target Resolution is invalid" +
                    " or unsupported by your screen.");
                return;
            }
            
            // secondary resolution check

            if (STargetX.Text != "" ||  STargetY.Text != "")
            {
                if (!IsValidRes(STargetX.Text, STargetY.Text, settings.screenIndex))
                {
                    msgDialog.Show("The selected resolution for Secondary Resolution is invalid" +
                        " or unsupported by your screen.");
                    return;
                }

                settings.SecondaryProfile.TargetX = int.Parse(STargetX.Text);
                settings.SecondaryProfile.TargetY = int.Parse(STargetY.Text);

                settings.enableSecondaryProfile = secondaryCheckbox.Checked;
            }
            else
            {
                settings.enableSecondaryProfile = false;
                settings.SecondaryProfile.TargetX = -1;
                settings.SecondaryProfile.TargetY = -1;
            }

            settings.BaseProfile.TargetX = int.Parse(baseX.Text);
            settings.BaseProfile.TargetY = int.Parse(baseY.Text);

            settings.TargetProfile.TargetX = int.Parse(tarX.Text);
            settings.TargetProfile.TargetY = int.Parse(tarY.Text);

            File.WriteAllText(Application.StartupPath + @"/settings.bin", JsonConvert.SerializeObject(settings));
            Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectedScreen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int scrIndex = selectedScreen.SelectedIndex;

            var screens = Screen.AllScreens; // i'll ALWAYS verify what you input.
            if (scrIndex < 0 || scrIndex >= screens.Length) { msgDialog.Show("ERROR: Screen Index is invalid ! Please restart" +
                "the application. If you believe this is an error, please make an issue on the github page.");return; }

            SelectedScreenPreview sel = new SelectedScreenPreview(scrIndex);
            sel.Show();
            settings.screenIndex = selectedScreen.SelectedIndex;
            File.WriteAllText(Application.StartupPath + @"/settings.bin", JsonConvert.SerializeObject(settings));
        }

        private void secondaryCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (settings.SecondaryProfile.TargetX == -1 && secondaryCheckbox.Checked == true)
            {
                secondaryCheckbox.Checked = false;
            }
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true) 
            {
                StartupManager.EnableStartup();
            }
            else
            {
                StartupManager.DisableStartup();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://github.com/SelyanSel/SwapRes");
        }
    }
}
