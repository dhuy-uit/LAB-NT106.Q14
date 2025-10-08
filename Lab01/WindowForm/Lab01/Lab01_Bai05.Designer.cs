namespace Lab01
{
    partial class Lab01_Bai05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab01_Bai05));
            lblTitle = new Label();
            label1 = new Label();
            lblInfo = new Label();
            lblName = new Label();
            lblPhone = new Label();
            lblMovie = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            cbxMovie = new ComboBox();
            lblSeat = new Label();
            pctScreen = new PictureBox();
            lblRoom = new Label();
            cbxRoom = new ComboBox();
            btnBook = new Button();
            btnBack = new Button();
            checkedListBox1 = new CheckedListBox();
            lblNote = new Label();
            lblColumn = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pctScreen).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(383, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(133, 64);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bài 5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(360, 88);
            label1.Name = "label1";
            label1.Size = new Size(179, 27);
            label1.TabIndex = 0;
            label1.Text = "(Đặt vé xem phim)";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(281, 134);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(320, 49);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Thông tin vé phim";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(176, 220);
            lblName.Name = "lblName";
            lblName.Size = new Size(150, 39);
            lblName.TabIndex = 0;
            lblName.Text = "Họ và tên:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(251, 276);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(75, 39);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "SĐT:";
            // 
            // lblMovie
            // 
            lblMovie.AutoSize = true;
            lblMovie.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMovie.Location = new Point(180, 334);
            lblMovie.Name = "lblMovie";
            lblMovie.Size = new Size(146, 39);
            lblMovie.TabIndex = 0;
            lblMovie.Text = "Tên phim:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(344, 213);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nhập họ và tên";
            txtName.Size = new Size(337, 46);
            txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(344, 269);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Nhập SĐT";
            txtPhone.Size = new Size(337, 46);
            txtPhone.TabIndex = 1;
            // 
            // cbxMovie
            // 
            cbxMovie.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxMovie.FormattingEnabled = true;
            cbxMovie.Location = new Point(343, 330);
            cbxMovie.Name = "cbxMovie";
            cbxMovie.Size = new Size(338, 43);
            cbxMovie.TabIndex = 2;
            // 
            // lblSeat
            // 
            lblSeat.AutoSize = true;
            lblSeat.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeat.Location = new Point(360, 450);
            lblSeat.Name = "lblSeat";
            lblSeat.Size = new Size(176, 49);
            lblSeat.TabIndex = 0;
            lblSeat.Text = "Chọn ghế";
            // 
            // pctScreen
            // 
            pctScreen.ErrorImage = (Image)resources.GetObject("pctScreen.ErrorImage");
            pctScreen.Image = (Image)resources.GetObject("pctScreen.Image");
            pctScreen.InitialImage = (Image)resources.GetObject("pctScreen.InitialImage");
            pctScreen.Location = new Point(214, 515);
            pctScreen.Name = "pctScreen";
            pctScreen.Size = new Size(467, 338);
            pctScreen.SizeMode = PictureBoxSizeMode.StretchImage;
            pctScreen.TabIndex = 3;
            pctScreen.TabStop = false;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoom.Location = new Point(214, 399);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(112, 39);
            lblRoom.TabIndex = 0;
            lblRoom.Text = "Rạp số:";
            // 
            // cbxRoom
            // 
            cbxRoom.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxRoom.FormattingEnabled = true;
            cbxRoom.Location = new Point(343, 395);
            cbxRoom.Name = "cbxRoom";
            cbxRoom.Size = new Size(338, 43);
            cbxRoom.TabIndex = 2;
            // 
            // btnBook
            // 
            btnBook.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.Location = new Point(727, 707);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(121, 79);
            btnBook.TabIndex = 4;
            btnBook.Text = "Đặt vé";
            btnBook.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(727, 900);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(121, 43);
            btnBack.TabIndex = 4;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(29, 515);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(179, 340);
            checkedListBox1.TabIndex = 5;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(687, 515);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(196, 100);
            lblNote.TabIndex = 6;
            lblNote.Text = "Ghi chú:\r\n- Vé vip: B2, B3, B4\r\n- Vé vớt: A1, A5, C1, C5\r\n- Vé thường: Còn lại";
            // 
            // lblColumn
            // 
            lblColumn.AutoSize = true;
            lblColumn.BackColor = Color.White;
            lblColumn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColumn.ForeColor = SystemColors.ControlText;
            lblColumn.Location = new Point(225, 591);
            lblColumn.Name = "lblColumn";
            lblColumn.Size = new Size(28, 210);
            lblColumn.TabIndex = 7;
            lblColumn.Text = "A\r\n\r\n\r\nB\r\n\r\n\r\nC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(312, 591);
            label2.Name = "label2";
            label2.Size = new Size(270, 210);
            label2.TabIndex = 7;
            label2.Text = "1        2        3        4        5\r\n\r\n\r\n1        2        3        4        5\r\n\r\n\r\n1        2        3        4        5";
            // 
            // Lab01_Bai05
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(893, 955);
            Controls.Add(label2);
            Controls.Add(lblColumn);
            Controls.Add(lblNote);
            Controls.Add(checkedListBox1);
            Controls.Add(btnBack);
            Controls.Add(btnBook);
            Controls.Add(pctScreen);
            Controls.Add(cbxRoom);
            Controls.Add(cbxMovie);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lblSeat);
            Controls.Add(lblInfo);
            Controls.Add(lblRoom);
            Controls.Add(lblMovie);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "Lab01_Bai05";
            Text = "Lab01_Bai05";
            ((System.ComponentModel.ISupportInitialize)pctScreen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label lblInfo;
        private Label lblName;
        private Label lblPhone;
        private Label lblMovie;
        private TextBox txtName;
        private TextBox txtPhone;
        private ComboBox cbxMovie;
        private Label lblSeat;
        private PictureBox pctScreen;
        private Label lblRoom;
        private ComboBox cbxRoom;
        private Button btnBook;
        private Button btnBack;
        private CheckedListBox checkedListBox1;
        private Label lblNote;
        private Label lblColumn;
        private Label label2;
    }
}