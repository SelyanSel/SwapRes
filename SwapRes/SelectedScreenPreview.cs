using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwapRes
{
    public partial class SelectedScreenPreview : Form
    {
        public SelectedScreenPreview(int screenIndex)
        {
            InitializeComponent();

            var screens = Screen.AllScreens;

            if (screenIndex < 0 || screenIndex >= screens.Length)
                throw new ArgumentOutOfRangeException(nameof(screenIndex), "Écran inexistant.");

            var screen = screens[screenIndex];

            int x = screen.Bounds.X + (screen.Bounds.Width - this.Width) / 2;
            int y = screen.Bounds.Y + (screen.Bounds.Height - this.Height) / 2;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(x, y);
        }

        private void SelectedScreenPreview_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
