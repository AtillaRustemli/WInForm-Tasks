namespace Task_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            background = new Panel();
            menuBoard = new Panel();
            lostMessage = new Label();
            start = new Button();
            boy = new PictureBox();
            panel2 = new Panel();
            left = new PictureBox();
            right = new PictureBox();
            background.SuspendLayout();
            menuBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)right).BeginInit();
            SuspendLayout();
            // 
            // background
            // 
            background.BackColor = Color.LightSkyBlue;
            background.Controls.Add(menuBoard);
            background.Controls.Add(boy);
            background.Location = new Point(3, 1);
            background.Name = "background";
            background.Size = new Size(494, 454);
            background.TabIndex = 0;
            // 
            // menuBoard
            // 
            menuBoard.BackColor = Color.LightCyan;
            menuBoard.Controls.Add(lostMessage);
            menuBoard.Controls.Add(start);
            menuBoard.Location = new Point(83, 141);
            menuBoard.Name = "menuBoard";
            menuBoard.Size = new Size(309, 245);
            menuBoard.TabIndex = 1;
            // 
            // lostMessage
            // 
            lostMessage.AutoSize = true;
            lostMessage.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lostMessage.ForeColor = Color.Red;
            lostMessage.Location = new Point(100, 65);
            lostMessage.Name = "lostMessage";
            lostMessage.Size = new Size(90, 28);
            lostMessage.TabIndex = 1;
            lostMessage.Text = "You Lost";
            lostMessage.Visible = false;
            // 
            // start
            // 
            start.Location = new Point(95, 116);
            start.Name = "start";
            start.Size = new Size(104, 36);
            start.TabIndex = 0;
            start.Text = "Start game";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // boy
            // 
            boy.Image = Properties.Resources.Boy;
            boy.Location = new Point(219, 331);
            boy.Margin = new Padding(0);
            boy.Name = "boy";
            boy.Size = new Size(45, 144);
            boy.SizeMode = PictureBoxSizeMode.Zoom;
            boy.TabIndex = 0;
            boy.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 0);
            panel2.Location = new Point(3, 452);
            panel2.Name = "panel2";
            panel2.Size = new Size(494, 58);
            panel2.TabIndex = 1;
            // 
            // left
            // 
            left.Cursor = Cursors.Hand;
            left.Image = (Image)resources.GetObject("left.Image");
            left.Location = new Point(59, 541);
            left.Name = "left";
            left.Size = new Size(100, 61);
            left.SizeMode = PictureBoxSizeMode.Zoom;
            left.TabIndex = 4;
            left.TabStop = false;
            left.MouseDown += left_MouseDown;
            // 
            // right
            // 
            right.Cursor = Cursors.Hand;
            right.Image = Properties.Resources.Button_Arrow_Right_icon;
            right.Location = new Point(333, 541);
            right.Name = "right";
            right.Size = new Size(90, 61);
            right.SizeMode = PictureBoxSizeMode.Zoom;
            right.TabIndex = 5;
            right.TabStop = false;
            right.MouseDown += right_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 661);
            Controls.Add(right);
            Controls.Add(left);
            Controls.Add(panel2);
            Controls.Add(background);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            background.ResumeLayout(false);
            menuBoard.ResumeLayout(false);
            menuBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)boy).EndInit();
            ((System.ComponentModel.ISupportInitialize)left).EndInit();
            ((System.ComponentModel.ISupportInitialize)right).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel background;
        private Panel panel2;
        private PictureBox left;
        private PictureBox right;
        private PictureBox boy;
        private Panel menuBoard;
        private Button start;
        private Label lostMessage;
    }
}
