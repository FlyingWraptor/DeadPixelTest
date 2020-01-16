namespace DeadPixelTest
{
    partial class PixelTester
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // 
            // PixelTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "PixelTester";
            this.Text = "Pixel tester";
            this.Load += new System.EventHandler(this.PixelTester_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PixelTester_KeyDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PixelTester_MouseUp);

        }

        #endregion
    }
}

