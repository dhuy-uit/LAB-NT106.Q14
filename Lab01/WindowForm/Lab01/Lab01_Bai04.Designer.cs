namespace Lab01
{
    partial class Lab01_Bai04
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
            lblTitle = new Label();
            label1 = new Label();
            btnBack = new Button();
            btnClr = new Button();
            btnDoc = new Button();
            txtText = new TextBox();
            txtN = new TextBox();
            lblText = new Label();
            lblN = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(339, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(133, 64);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bài 4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 89);
            label1.Name = "label1";
            label1.Size = new Size(140, 22);
            label1.TabIndex = 0;
            label1.Text = "(Đọc số nâng cao)";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(668, 330);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 57);
            btnBack.TabIndex = 10;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClr
            // 
            btnClr.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClr.Location = new Point(500, 312);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(112, 89);
            btnClr.TabIndex = 11;
            btnClr.Text = "Xóa";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // btnDoc
            // 
            btnDoc.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDoc.Location = new Point(668, 194);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(112, 89);
            btnDoc.TabIndex = 12;
            btnDoc.Text = "Đọc";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // txtText
            // 
            txtText.Location = new Point(285, 252);
            txtText.Name = "txtText";
            txtText.ReadOnly = true;
            txtText.Size = new Size(327, 31);
            txtText.TabIndex = 8;
            // 
            // txtN
            // 
            txtN.Location = new Point(285, 194);
            txtN.Name = "txtN";
            txtN.PlaceholderText = "Nhập số n (tối đa 12 chữ số)";
            txtN.Size = new Size(327, 31);
            txtN.TabIndex = 9;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblText.Location = new Point(131, 244);
            lblText.Name = "lblText";
            lblText.Size = new Size(116, 39);
            lblText.TabIndex = 6;
            lblText.Text = "Kết quả";
            // 
            // lblN
            // 
            lblN.AutoSize = true;
            lblN.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblN.Location = new Point(20, 186);
            lblN.Name = "lblN";
            lblN.Size = new Size(227, 39);
            lblN.TabIndex = 7;
            lblN.Text = "Nhập số nguyên";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 13;
            // 
            // Lab01_Bai04
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnClr);
            Controls.Add(btnDoc);
            Controls.Add(txtText);
            Controls.Add(txtN);
            Controls.Add(lblText);
            Controls.Add(label2);
            Controls.Add(lblN);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "Lab01_Bai04";
            Text = "Lab01_Bai04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Button btnBack;
        private Button btnClr;
        private Button btnDoc;
        private TextBox txtText;
        private TextBox txtN;
        private Label lblText;
        private Label lblN;
        private Label label2;
    }
}