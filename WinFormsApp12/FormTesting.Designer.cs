namespace WinFormGame
{
    partial class FormTesting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTest = new Panel();
            panelHeader = new Panel();
            button1 = new Button();
            block1 = new Game.GameFormElement.Block();
            block2 = new Game.GameFormElement.Block();
            panelTest.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelTest
            // 
            panelTest.BackColor = SystemColors.ActiveBorder;
            panelTest.Controls.Add(block2);
            panelTest.Controls.Add(block1);
            panelTest.Dock = DockStyle.Fill;
            panelTest.Location = new Point(0, 0);
            panelTest.Name = "panelTest";
            panelTest.Size = new Size(676, 574);
            panelTest.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(button1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(676, 58);
            panelHeader.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(444, 12);
            button1.Name = "button1";
            button1.Size = new Size(156, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // block1
            // 
            block1.BackColor = SystemColors.ButtonFace;
            block1.IsEmpty = false;
            block1.Location = new Point(59, 141);
            block1.Name = "block1";
            block1.Size = new Size(121, 134);
            block1.TabIndex = 0;
            // 
            // block2
            // 
            block2.BackColor = SystemColors.AppWorkspace;
            block2.IsEmpty = false;
            block2.Location = new Point(309, 272);
            block2.Name = "block2";
            block2.Size = new Size(289, 235);
            block2.TabIndex = 1;
            // 
            // FormTesting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 574);
            Controls.Add(panelHeader);
            Controls.Add(panelTest);
            Name = "FormTesting";
            Text = "FormTesting";
            panelTest.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTest;
        private Panel panelHeader;
        private Button button1;
        private Game.GameFormElement.Block block2;
        private Game.GameFormElement.Block block1;
    }
}