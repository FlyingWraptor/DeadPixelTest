using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeadPixelTest
{
    public partial class PixelTester : Form
    {
        private static readonly Color[] COLORS = new Color[]
            { Color.White, Color.Red, Color.Green, Color.Blue };
        private int currentColor = 0;
        private DateTime lastLeftClicked;
        public PixelTester()
        {
            InitializeComponent();
        }

        private void PixelTester_Load(object sender, EventArgs e)
        {
            setColor(0);
            resetWindow();
        }

        private void PixelTester_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            if (lastLeftClicked != null && lastLeftClicked > DateTime.Now.AddMilliseconds(-300))
            {
                lastLeftClicked = DateTime.Now;
                Screen screen = Screen.FromControl(this);
                switch (this.FormBorderStyle)
                {
                    case FormBorderStyle.Sizable:
                        this.FormBorderStyle = FormBorderStyle.None;
                        this.Size = screen.Bounds.Size;
                        this.Location = screen.Bounds.Location;
                        break;
                    default:
                        resetWindow();
                        this.CenterToScreen();
                        break;
                }

                return;
            }
            else
            {
                lastLeftClicked = DateTime.Now;
                switchColor();
            }
        }

        private void switchColor()
        {
            if (currentColor >= COLORS.Length - 1) {
                setColor(0);
                return;
            }

            setColor(currentColor + 1);
        }
        private void setColor(int color)
        {
            currentColor = color;
            this.BackColor = COLORS[currentColor];
        }

        private void PixelTester_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                resetWindow();
        }

        private void resetWindow()
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Size = new Size(500, 350);
        }
    }
}
