namespace SwapRes
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.settingsLabel = new System.Windows.Forms.Label();
            this.baseResText = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Label();
            this.targetResText = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.secResText = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.baseX = new Guna.UI2.WinForms.Guna2TextBox();
            this.baseY = new Guna.UI2.WinForms.Guna2TextBox();
            this.msgDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.selectedScreen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tarY = new Guna.UI2.WinForms.Guna2TextBox();
            this.tarX = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.STargetY = new Guna.UI2.WinForms.Guna2TextBox();
            this.STargetX = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.secondaryCheckbox = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.applyButton = new Guna.UI2.WinForms.Guna2Button();
            this.swapButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.Font = new System.Drawing.Font("Outfit SemiBold", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(25, 80);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(96, 29);
            this.settingsLabel.TabIndex = 1;
            this.settingsLabel.Text = "Settings";
            // 
            // baseResText
            // 
            this.baseResText.AutoSize = true;
            this.baseResText.Font = new System.Drawing.Font("Outfit", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseResText.Location = new System.Drawing.Point(27, 127);
            this.baseResText.Name = "baseResText";
            this.baseResText.Size = new System.Drawing.Size(121, 20);
            this.baseResText.TabIndex = 4;
            this.baseResText.Text = "Base Resolution";
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Font = new System.Drawing.Font("Outfit", 9.25F, System.Drawing.FontStyle.Bold);
            this.x1.Location = new System.Drawing.Point(123, 157);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(14, 16);
            this.x1.TabIndex = 6;
            this.x1.Text = "x";
            // 
            // targetResText
            // 
            this.targetResText.AutoSize = true;
            this.targetResText.Font = new System.Drawing.Font("Outfit", 12F);
            this.targetResText.Location = new System.Drawing.Point(26, 193);
            this.targetResText.Name = "targetResText";
            this.targetResText.Size = new System.Drawing.Size(133, 20);
            this.targetResText.TabIndex = 8;
            this.targetResText.Text = "Target Resolution";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Swap Res";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // secResText
            // 
            this.secResText.AutoSize = true;
            this.secResText.Font = new System.Drawing.Font("Outfit", 12F);
            this.secResText.Location = new System.Drawing.Point(28, 258);
            this.secResText.Name = "secResText";
            this.secResText.Size = new System.Drawing.Size(162, 20);
            this.secResText.TabIndex = 12;
            this.secResText.Text = "Secondary Resolution";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 100;
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(-7, -6);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(413, 44);
            this.guna2Panel1.TabIndex = 21;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // baseX
            // 
            this.baseX.Animated = true;
            this.baseX.AutoRoundedCorners = true;
            this.baseX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.baseX.DefaultText = "";
            this.baseX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.baseX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.baseX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.baseX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.baseX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.baseX.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseX.ForeColor = System.Drawing.Color.Black;
            this.baseX.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.baseX.Location = new System.Drawing.Point(31, 154);
            this.baseX.Name = "baseX";
            this.baseX.PlaceholderText = "";
            this.baseX.SelectedText = "";
            this.baseX.Size = new System.Drawing.Size(86, 24);
            this.baseX.TabIndex = 22;
            this.baseX.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // baseY
            // 
            this.baseY.Animated = true;
            this.baseY.AutoRoundedCorners = true;
            this.baseY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.baseY.DefaultText = "";
            this.baseY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.baseY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.baseY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.baseY.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.baseY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.baseY.Font = new System.Drawing.Font("Outfit", 9F);
            this.baseY.ForeColor = System.Drawing.Color.Black;
            this.baseY.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.baseY.Location = new System.Drawing.Point(143, 154);
            this.baseY.Name = "baseY";
            this.baseY.PlaceholderText = "";
            this.baseY.SelectedText = "";
            this.baseY.Size = new System.Drawing.Size(86, 24);
            this.baseY.TabIndex = 23;
            // 
            // msgDialog
            // 
            this.msgDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgDialog.Caption = null;
            this.msgDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.msgDialog.Parent = null;
            this.msgDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgDialog.Text = null;
            // 
            // selectedScreen
            // 
            this.selectedScreen.AutoRoundedCorners = true;
            this.selectedScreen.BackColor = System.Drawing.Color.Transparent;
            this.selectedScreen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectedScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectedScreen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selectedScreen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selectedScreen.Font = new System.Drawing.Font("Outfit", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.selectedScreen.ItemHeight = 30;
            this.selectedScreen.Location = new System.Drawing.Point(30, 355);
            this.selectedScreen.Name = "selectedScreen";
            this.selectedScreen.Size = new System.Drawing.Size(198, 36);
            this.selectedScreen.TabIndex = 24;
            this.selectedScreen.SelectedIndexChanged += new System.EventHandler(this.selectedScreen_SelectedIndexChanged);
            // 
            // tarY
            // 
            this.tarY.Animated = true;
            this.tarY.AutoRoundedCorners = true;
            this.tarY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tarY.DefaultText = "";
            this.tarY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tarY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tarY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tarY.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tarY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tarY.Font = new System.Drawing.Font("Outfit", 9F);
            this.tarY.ForeColor = System.Drawing.Color.Black;
            this.tarY.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tarY.Location = new System.Drawing.Point(142, 220);
            this.tarY.Name = "tarY";
            this.tarY.PlaceholderText = "";
            this.tarY.SelectedText = "";
            this.tarY.Size = new System.Drawing.Size(86, 24);
            this.tarY.TabIndex = 27;
            // 
            // tarX
            // 
            this.tarX.Animated = true;
            this.tarX.AutoRoundedCorners = true;
            this.tarX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tarX.DefaultText = "";
            this.tarX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tarX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tarX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tarX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tarX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tarX.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarX.ForeColor = System.Drawing.Color.Black;
            this.tarX.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tarX.Location = new System.Drawing.Point(30, 220);
            this.tarX.Name = "tarX";
            this.tarX.PlaceholderText = "";
            this.tarX.SelectedText = "";
            this.tarX.Size = new System.Drawing.Size(86, 24);
            this.tarX.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Outfit", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(122, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "x";
            // 
            // STargetY
            // 
            this.STargetY.Animated = true;
            this.STargetY.AutoRoundedCorners = true;
            this.STargetY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.STargetY.DefaultText = "";
            this.STargetY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.STargetY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.STargetY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.STargetY.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.STargetY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.STargetY.Font = new System.Drawing.Font("Outfit", 9F);
            this.STargetY.ForeColor = System.Drawing.Color.Black;
            this.STargetY.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.STargetY.Location = new System.Drawing.Point(142, 286);
            this.STargetY.Name = "STargetY";
            this.STargetY.PlaceholderText = "";
            this.STargetY.SelectedText = "";
            this.STargetY.Size = new System.Drawing.Size(86, 24);
            this.STargetY.TabIndex = 30;
            // 
            // STargetX
            // 
            this.STargetX.Animated = true;
            this.STargetX.AutoRoundedCorners = true;
            this.STargetX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.STargetX.DefaultText = "";
            this.STargetX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.STargetX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.STargetX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.STargetX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.STargetX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.STargetX.Font = new System.Drawing.Font("Outfit", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STargetX.ForeColor = System.Drawing.Color.Black;
            this.STargetX.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.STargetX.Location = new System.Drawing.Point(30, 286);
            this.STargetX.Name = "STargetX";
            this.STargetX.PlaceholderText = "";
            this.STargetX.SelectedText = "";
            this.STargetX.Size = new System.Drawing.Size(86, 24);
            this.STargetX.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Outfit", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(122, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Outfit", 12F);
            this.label3.Location = new System.Drawing.Point(28, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Target Screen";
            // 
            // secondaryCheckbox
            // 
            this.secondaryCheckbox.Animated = true;
            this.secondaryCheckbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secondaryCheckbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secondaryCheckbox.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.secondaryCheckbox.CheckedState.InnerColor = System.Drawing.Color.White;
            this.secondaryCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secondaryCheckbox.Location = new System.Drawing.Point(237, 289);
            this.secondaryCheckbox.Name = "secondaryCheckbox";
            this.secondaryCheckbox.Size = new System.Drawing.Size(35, 18);
            this.secondaryCheckbox.TabIndex = 32;
            this.secondaryCheckbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.secondaryCheckbox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.secondaryCheckbox.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.secondaryCheckbox.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.secondaryCheckbox.CheckedChanged += new System.EventHandler(this.secondaryCheckbox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Outfit", 10F);
            this.label4.Location = new System.Drawing.Point(277, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Enable";
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.Animated = true;
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(32, 411);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 18);
            this.guna2ToggleSwitch1.TabIndex = 34;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Outfit", 10F);
            this.label5.Location = new System.Drawing.Point(73, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 35;
            this.label5.Text = "Launch on startup";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Outfit", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(178, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "v1.0.0 - made with <3 by selyansel";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::SwapRes.Properties.Resources.github_white_icon;
            this.guna2Button1.Location = new System.Drawing.Point(339, 123);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(50, 50);
            this.guna2Button1.TabIndex = 36;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::SwapRes.Properties.Resources.swapresicon;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(20, 15);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 22;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // exitButton
            // 
            this.exitButton.Animated = true;
            this.exitButton.BorderRadius = 10;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.Font = new System.Drawing.Font("Outfit SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = global::SwapRes.Properties.Resources.leave;
            this.exitButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exitButton.ImageOffset = new System.Drawing.Point(5, 0);
            this.exitButton.ImageSize = new System.Drawing.Size(15, 15);
            this.exitButton.Location = new System.Drawing.Point(142, 490);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 41);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "Exit";
            this.exitButton.TextOffset = new System.Drawing.Point(5, 0);
            this.exitButton.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // applyButton
            // 
            this.applyButton.Animated = true;
            this.applyButton.BorderRadius = 10;
            this.applyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.applyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.applyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.applyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.applyButton.Font = new System.Drawing.Font("Outfit SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.ForeColor = System.Drawing.Color.White;
            this.applyButton.Image = global::SwapRes.Properties.Resources.task_checklist;
            this.applyButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.applyButton.ImageOffset = new System.Drawing.Point(5, 0);
            this.applyButton.ImageSize = new System.Drawing.Size(15, 15);
            this.applyButton.Location = new System.Drawing.Point(242, 490);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(150, 41);
            this.applyButton.TabIndex = 19;
            this.applyButton.Text = "Apply changes";
            this.applyButton.TextOffset = new System.Drawing.Point(5, 0);
            this.applyButton.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // swapButton
            // 
            this.swapButton.Animated = true;
            this.swapButton.BorderRadius = 10;
            this.swapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swapButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.swapButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.swapButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.swapButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.swapButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.swapButton.ForeColor = System.Drawing.Color.White;
            this.swapButton.Image = global::SwapRes.Properties.Resources.swap;
            this.swapButton.Location = new System.Drawing.Point(339, 58);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(50, 50);
            this.swapButton.TabIndex = 18;
            this.swapButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 543);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.secondaryCheckbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.STargetY);
            this.Controls.Add(this.STargetX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tarY);
            this.Controls.Add(this.tarX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedScreen);
            this.Controls.Add(this.baseY);
            this.Controls.Add(this.baseX);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.swapButton);
            this.Controls.Add(this.secResText);
            this.Controls.Add(this.targetResText);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.baseResText);
            this.Controls.Add(this.settingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SwapRes";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label baseResText;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Label targetResText;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label secResText;
        private Guna.UI2.WinForms.Guna2Button swapButton;
        private Guna.UI2.WinForms.Guna2Button applyButton;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox baseX;
        private Guna.UI2.WinForms.Guna2TextBox baseY;
        private Guna.UI2.WinForms.Guna2MessageDialog msgDialog;
        private Guna.UI2.WinForms.Guna2ComboBox selectedScreen;
        private Guna.UI2.WinForms.Guna2TextBox tarY;
        private Guna.UI2.WinForms.Guna2TextBox tarX;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox STargetY;
        private Guna.UI2.WinForms.Guna2TextBox STargetX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ToggleSwitch secondaryCheckbox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

