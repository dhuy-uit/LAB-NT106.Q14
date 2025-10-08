namespace Lab01
{
    partial class Lab01_Bai02
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
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            lblTitle = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            lblSln = new Label();
            lblSnn = new Label();
            txtMax = new TextBox();
            txtMin = new TextBox();
            btnTim = new Button();
            btnClr = new Button();
            btnBack = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA.Location = new Point(66, 121);
            lblA.Name = "lblA";
            lblA.Size = new Size(36, 39);
            lblA.TabIndex = 0;
            lblA.Text = "A";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblB.Location = new Point(66, 187);
            lblB.Name = "lblB";
            lblB.Size = new Size(34, 39);
            lblB.TabIndex = 0;
            lblB.Text = "B";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblC.Location = new Point(66, 250);
            lblC.Name = "lblC";
            lblC.Size = new Size(34, 39);
            lblC.TabIndex = 0;
            lblC.Text = "C";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(339, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bài 2";
            // 
            // txtA
            // 
            txtA.Location = new Point(121, 128);
            txtA.Name = "txtA";
            txtA.PlaceholderText = "Nhập số A";
            txtA.Size = new Size(198, 31);
            txtA.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.Location = new Point(121, 194);
            txtB.Name = "txtB";
            txtB.PlaceholderText = "Nhập số B";
            txtB.Size = new Size(198, 31);
            txtB.TabIndex = 1;
            // 
            // txtC
            // 
            txtC.Location = new Point(121, 257);
            txtC.Name = "txtC";
            txtC.PlaceholderText = "Nhập số C";
            txtC.Size = new Size(198, 31);
            txtC.TabIndex = 1;
            // 
            // lblSln
            // 
            lblSln.AutoSize = true;
            lblSln.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSln.Location = new Point(389, 160);
            lblSln.Name = "lblSln";
            lblSln.Size = new Size(144, 35);
            lblSln.TabIndex = 0;
            lblSln.Text = "Số lớn nhất";
            // 
            // lblSnn
            // 
            lblSnn.AutoSize = true;
            lblSnn.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSnn.Location = new Point(381, 225);
            lblSnn.Name = "lblSnn";
            lblSnn.Size = new Size(152, 35);
            lblSnn.TabIndex = 0;
            lblSnn.Text = "Số nhỏ nhất";
            // 
            // txtMax
            // 
            txtMax.Location = new Point(548, 164);
            txtMax.Name = "txtMax";
            txtMax.ReadOnly = true;
            txtMax.Size = new Size(198, 31);
            txtMax.TabIndex = 1;
            // 
            // txtMin
            // 
            txtMin.Location = new Point(548, 229);
            txtMin.Name = "txtMin";
            txtMin.ReadOnly = true;
            txtMin.Size = new Size(198, 31);
            txtMin.TabIndex = 1;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(153, 325);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(116, 73);
            btnTim.TabIndex = 2;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnClr
            // 
            btnClr.Location = new Point(339, 325);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(116, 73);
            btnClr.TabIndex = 2;
            btnClr.Text = "Xóa";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(529, 325);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(116, 73);
            btnBack.TabIndex = 2;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 77);
            label1.Name = "label1";
            label1.Size = new Size(149, 27);
            label1.TabIndex = 0;
            label1.Text = "(Tìm min, max)";
            // 
            // Lab01_Bai02
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnClr);
            Controls.Add(btnTim);
            Controls.Add(txtC);
            Controls.Add(txtMin);
            Controls.Add(txtMax);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblSnn);
            Controls.Add(lblC);
            Controls.Add(lblB);
            Controls.Add(label1);
            Controls.Add(lblSln);
            Controls.Add(lblTitle);
            Controls.Add(lblA);
            Name = "Lab01_Bai02";
            Text = "Lab01_Bai02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private Label lblB;
        private Label lblC;
        private Label lblTitle;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label lblSln;
        private Label lblSnn;
        private TextBox txtMax;
        private TextBox txtMin;
        private Button btnTim;
        private Button btnClr;
        private Button btnBack;
        private Label label1;
    }
}