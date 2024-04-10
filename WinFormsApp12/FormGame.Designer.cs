namespace WinFormGame
{
    partial class FormGame
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
            bottomZone = new Panel();
            playerZone = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            playerP = new PictureBox();
            GravitationTimer = new System.Windows.Forms.Timer(components);
            UpTimer = new System.Windows.Forms.Timer(components);
            MainTimer = new System.Windows.Forms.Timer(components);
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            playerZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playerP).BeginInit();
            SuspendLayout();
            // 
            // bottomZone
            // 
            bottomZone.BackColor = Color.FromArgb(64, 64, 64);
            bottomZone.Dock = DockStyle.Bottom;
            bottomZone.Location = new Point(0, 408);
            bottomZone.Name = "bottomZone";
            bottomZone.Size = new Size(800, 42);
            bottomZone.TabIndex = 0;
            // 
            // playerZone
            // 
            playerZone.Controls.Add(panel8);
            playerZone.Controls.Add(panel7);
            playerZone.Controls.Add(panel6);
            playerZone.Controls.Add(panel5);
            playerZone.Controls.Add(panel4);
            playerZone.Controls.Add(panel3);
            playerZone.Controls.Add(panel2);
            playerZone.Controls.Add(panel1);
            playerZone.Controls.Add(playerP);
            playerZone.Dock = DockStyle.Fill;
            playerZone.Location = new Point(0, 0);
            playerZone.Name = "playerZone";
            playerZone.Size = new Size(800, 408);
            playerZone.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(12, 291);
            panel4.Name = "panel4";
            panel4.Size = new Size(130, 32);
            panel4.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(495, 310);
            panel3.Name = "panel3";
            panel3.Size = new Size(130, 32);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(272, 252);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 32);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(272, 376);
            panel1.Name = "panel1";
            panel1.Size = new Size(130, 32);
            panel1.TabIndex = 1;
            // 
            // playerP
            // 
            playerP.Image = Properties.Resources.Снимок_экрана_2024_04_10_030551;
            playerP.Location = new Point(68, 329);
            playerP.Name = "playerP";
            playerP.Size = new Size(62, 79);
            playerP.SizeMode = PictureBoxSizeMode.Zoom;
            playerP.TabIndex = 0;
            playerP.TabStop = false;
            // 
            // GravitationTimer
            // 
            GravitationTimer.Interval = 1;
            GravitationTimer.Tick += GravitationTimer_Tick;
            // 
            // UpTimer
            // 
            UpTimer.Interval = 1;
            UpTimer.Tick += UpTimer_Tick;
            // 
            // MainTimer
            // 
            MainTimer.Interval = 20;
            MainTimer.Tick += MainTimer_Tick;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Location = new Point(468, 179);
            panel5.Name = "panel5";
            panel5.Size = new Size(130, 32);
            panel5.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Location = new Point(635, 124);
            panel6.Name = "panel6";
            panel6.Size = new Size(130, 32);
            panel6.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Silver;
            panel7.Location = new Point(495, 55);
            panel7.Name = "panel7";
            panel7.Size = new Size(130, 32);
            panel7.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Silver;
            panel8.Location = new Point(334, 12);
            panel8.Name = "panel8";
            panel8.Size = new Size(130, 32);
            panel8.TabIndex = 3;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(playerZone);
            Controls.Add(bottomZone);
            Name = "FormGame";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            playerZone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)playerP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bottomZone;
        private Panel playerZone;
        private System.Windows.Forms.Timer GravitationTimer;
        private System.Windows.Forms.Timer UpTimer;
        private System.Windows.Forms.Timer MainTimer;
        private PictureBox playerP;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
    }
}
