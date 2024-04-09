namespace WinFormsApp12
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            panelP = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            panelP.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 408);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 42);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelP);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 408);
            panel2.TabIndex = 1;
            // 
            // panelP
            // 
            panelP.BackColor = Color.FromArgb(128, 128, 255);
            panelP.Controls.Add(panel6);
            panelP.Controls.Add(panel5);
            panelP.Controls.Add(panel4);
            panelP.Location = new Point(12, 329);
            panelP.Name = "panelP";
            panelP.Size = new Size(80, 79);
            panelP.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(192, 255, 192);
            panel6.Location = new Point(22, 55);
            panel6.Name = "panel6";
            panel6.Size = new Size(37, 18);
            panel6.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(192, 255, 192);
            panel5.Location = new Point(49, 18);
            panel5.Name = "panel5";
            panel5.Size = new Size(19, 18);
            panel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 255, 192);
            panel4.Location = new Point(13, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(19, 18);
            panel4.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            panel2.ResumeLayout(false);
            panelP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelP;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
