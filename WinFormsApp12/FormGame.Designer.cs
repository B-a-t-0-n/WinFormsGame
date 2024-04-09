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
            player = new Panel();
            mouth = new Panel();
            eye2 = new Panel();
            eye1 = new Panel();
            GravitationTimer = new System.Windows.Forms.Timer(components);
            UpTimer = new System.Windows.Forms.Timer(components);
            MainTimer = new System.Windows.Forms.Timer(components);
            playerZone.SuspendLayout();
            player.SuspendLayout();
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
            // player
            // 
            player.BackColor = Color.FromArgb(128, 128, 255);
            player.Controls.Add(mouth);
            player.Controls.Add(eye2);
            player.Controls.Add(eye1);
            player.Location = new Point(12, 329);
            player.Name = "player";
            player.Size = new Size(80, 79);
            player.TabIndex = 2;
            // 
            // mouth
            // 
            mouth.BackColor = Color.FromArgb(192, 255, 192);
            mouth.Location = new Point(22, 55);
            mouth.Name = "mouth";
            mouth.Size = new Size(37, 18);
            mouth.TabIndex = 2;
            // 
            // eye2
            // 
            eye2.BackColor = Color.FromArgb(192, 255, 192);
            eye2.Location = new Point(49, 18);
            eye2.Name = "eye2";
            eye2.Size = new Size(19, 18);
            eye2.TabIndex = 1;
            // 
            // eye1
            // 
            eye1.BackColor = Color.FromArgb(192, 255, 192);
            eye1.Location = new Point(13, 18);
            eye1.Name = "eye1";
            eye1.Size = new Size(19, 18);
            eye1.TabIndex = 0;
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
            player.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel bottomZone;
        private Panel playerZone;
        private Panel player;
        private Panel mouth;
        private Panel eye2;
        private Panel eye1;
        private System.Windows.Forms.Timer GravitationTimer;
        private System.Windows.Forms.Timer UpTimer;
        private System.Windows.Forms.Timer MainTimer;
    }
}
