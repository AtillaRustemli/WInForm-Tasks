namespace Task_2
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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            seria = new MaskedTextBox();
            phoneNumber = new MaskedTextBox();
            buy = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            email = new TextBox();
            nameSurname = new TextBox();
            groupBox1 = new GroupBox();
            time = new MaskedTextBox();
            date = new MaskedTextBox();
            to = new ComboBox();
            from = new ComboBox();
            placeLabel = new Label();
            timeLabel = new Label();
            dateLabel = new Label();
            toLabel = new Label();
            fromLabel = new Label();
            place = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            deleteFromList = new Button();
            exit = new Button();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 308);
            panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(seria);
            groupBox2.Controls.Add(phoneNumber);
            groupBox2.Controls.Add(buy);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(email);
            groupBox2.Controls.Add(nameSurname);
            groupBox2.Location = new Point(545, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(456, 246);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Passanger Info";
            // 
            // seria
            // 
            seria.Location = new Point(219, 64);
            seria.Mask = "00000000";
            seria.Name = "seria";
            seria.Size = new Size(231, 23);
            seria.TabIndex = 28;
            seria.ValidatingType = typeof(int);
            // 
            // phoneNumber
            // 
            phoneNumber.Location = new Point(219, 105);
            phoneNumber.Mask = "(+999) 000-00-00";
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(231, 23);
            phoneNumber.TabIndex = 27;
            // 
            // buy
            // 
            buy.BackColor = Color.SeaGreen;
            buy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buy.Location = new Point(219, 193);
            buy.Name = "buy";
            buy.Size = new Size(231, 35);
            buy.TabIndex = 23;
            buy.Text = "Buy";
            buy.TextAlign = ContentAlignment.TopCenter;
            buy.UseVisualStyleBackColor = false;
            buy.Click += buy_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.Location = new Point(136, 146);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 22;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGray;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(56, 103);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 21;
            label3.Text = "Phone number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkGray;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.Location = new Point(113, 64);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 20;
            label4.Text = "ID/Seria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkGray;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label5.Location = new Point(15, 22);
            label5.Name = "label5";
            label5.Size = new Size(184, 25);
            label5.TabIndex = 19;
            label5.Text = "Name and Surname:";
            // 
            // email
            // 
            email.Location = new Point(219, 148);
            email.Name = "email";
            email.Size = new Size(231, 23);
            email.TabIndex = 16;
            // 
            // nameSurname
            // 
            nameSurname.Location = new Point(219, 24);
            nameSurname.Name = "nameSurname";
            nameSurname.Size = new Size(231, 23);
            nameSurname.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(time);
            groupBox1.Controls.Add(date);
            groupBox1.Controls.Add(to);
            groupBox1.Controls.Add(from);
            groupBox1.Controls.Add(placeLabel);
            groupBox1.Controls.Add(timeLabel);
            groupBox1.Controls.Add(dateLabel);
            groupBox1.Controls.Add(toLabel);
            groupBox1.Controls.Add(fromLabel);
            groupBox1.Controls.Add(place);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(22, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(456, 246);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Route";
            // 
            // time
            // 
            time.Location = new Point(152, 148);
            time.Mask = "00:00";
            time.Name = "time";
            time.Size = new Size(231, 25);
            time.TabIndex = 27;
            time.ValidatingType = typeof(DateTime);
            // 
            // date
            // 
            date.Location = new Point(152, 107);
            date.Mask = "00/00/0000";
            date.Name = "date";
            date.Size = new Size(231, 25);
            date.TabIndex = 26;
            date.ValidatingType = typeof(DateTime);
            // 
            // to
            // 
            to.FormattingEnabled = true;
            to.Items.AddRange(new object[] { "City1", "City2", "City3" });
            to.Location = new Point(152, 64);
            to.Name = "to";
            to.Size = new Size(231, 25);
            to.TabIndex = 27;
            // 
            // from
            // 
            from.FormattingEnabled = true;
            from.Items.AddRange(new object[] { "City1", "City2", "City3" });
            from.Location = new Point(152, 24);
            from.Name = "from";
            from.Size = new Size(231, 25);
            from.TabIndex = 26;
            // 
            // placeLabel
            // 
            placeLabel.AutoSize = true;
            placeLabel.BackColor = Color.DarkGray;
            placeLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            placeLabel.Location = new Point(60, 191);
            placeLabel.Name = "placeLabel";
            placeLabel.Size = new Size(62, 25);
            placeLabel.TabIndex = 13;
            placeLabel.Text = "Place:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.BackColor = Color.DarkGray;
            timeLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            timeLabel.Location = new Point(63, 148);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(59, 25);
            timeLabel.TabIndex = 11;
            timeLabel.Text = "Time:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.BackColor = Color.DarkGray;
            dateLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            dateLabel.Location = new Point(65, 105);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 25);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Date:";
            // 
            // toLabel
            // 
            toLabel.AutoSize = true;
            toLabel.BackColor = Color.DarkGray;
            toLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            toLabel.Location = new Point(85, 64);
            toLabel.Name = "toLabel";
            toLabel.Size = new Size(37, 25);
            toLabel.TabIndex = 7;
            toLabel.Text = "To:";
            // 
            // fromLabel
            // 
            fromLabel.AutoSize = true;
            fromLabel.BackColor = Color.DarkGray;
            fromLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            fromLabel.Location = new Point(62, 24);
            fromLabel.Name = "fromLabel";
            fromLabel.Size = new Size(60, 25);
            fromLabel.TabIndex = 5;
            fromLabel.Text = "From:";
            // 
            // place
            // 
            place.Location = new Point(152, 191);
            place.Name = "place";
            place.Size = new Size(231, 25);
            place.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSalmon;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(15, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1057, 74);
            panel2.TabIndex = 25;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(858, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(199, 71);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 35F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(345, 0);
            label6.Name = "label6";
            label6.Size = new Size(284, 62);
            label6.TabIndex = 3;
            label6.Text = "BMU Travel";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(12, 415);
            panel3.Name = "panel3";
            panel3.Size = new Size(1060, 148);
            panel3.TabIndex = 26;
            // 
            // deleteFromList
            // 
            deleteFromList.BackColor = Color.DarkGreen;
            deleteFromList.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            deleteFromList.Location = new Point(12, 584);
            deleteFromList.Name = "deleteFromList";
            deleteFromList.Size = new Size(164, 34);
            deleteFromList.TabIndex = 27;
            deleteFromList.Text = "Delete from List";
            deleteFromList.UseVisualStyleBackColor = false;
            deleteFromList.Click += deleteFromList_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.Red;
            exit.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            exit.Location = new Point(840, 595);
            exit.Name = "exit";
            exit.Size = new Size(164, 34);
            exit.TabIndex = 28;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(1084, 661);
            Controls.Add(exit);
            Controls.Add(deleteFromList);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket buy form";
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label toLabel;
        private Label fromLabel;
        private TextBox place;
        private Label placeLabel;
        private Label timeLabel;
        private Label dateLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox email;
        private TextBox nameSurname;
        private Button buy;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label6;
        private Label label1;
        private PictureBox pictureBox3;
        private ComboBox from;
        private ComboBox to;
        private MaskedTextBox time;
        private MaskedTextBox date;
        private MaskedTextBox phoneNumber;
        private MaskedTextBox seria;
        private Panel panel3;
        private Button deleteFromList;
        private Button exit;
    }
}
