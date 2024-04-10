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
            GravitationTimer = new System.Windows.Forms.Timer(components);
            UpTimer = new System.Windows.Forms.Timer(components);
            MainTimer = new System.Windows.Forms.Timer(components);
            player = new PictureBox();
            playerZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
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
            playerZone.Controls.Add(player);
            playerZone.Dock = DockStyle.Fill;
            playerZone.Location = new Point(0, 0);
            playerZone.Name = "playerZone";
            playerZone.Size = new Size(800, 408);
            playerZone.TabIndex = 1;
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
            // player
            // 
            player.Image = Properties.Resources.Снимок_экрана_2024_04_10_030551;
            player.Location = new Point(68, 329);
            player.Name = "player";
            player.Size = new Size(62, 79);
            player.SizeMode = PictureBoxSizeMode.Zoom;
            player.TabIndex = 0;
            player.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bottomZone;
        private Panel playerZone;
        private System.Windows.Forms.Timer GravitationTimer;
        private System.Windows.Forms.Timer UpTimer;
        private System.Windows.Forms.Timer MainTimer;
        private PictureBox player;
    }
}
