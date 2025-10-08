namespace Lab01
{
    partial class Lab01_Bai03
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
            lblN = new Label();
            lblText = new Label();
            txtN = new TextBox();
            txtText = new TextBox();
            btnDoc = new Button();
            btnClr = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(333, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bài 3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(359, 104);
            label1.Name = "label1";
            label1.Size = new Size(87, 27);
            label1.TabIndex = 0;
            label1.Text = "(Đọc số)";
            // 
            // lblN
            // 
            lblN.AutoSize = true;
            lblN.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblN.Location = new Point(12, 173);
            lblN.Name = "lblN";
            lblN.Size = new Size(368, 39);
            lblN.TabIndex = 1;
            lblN.Text = "Nhập số nguyên từ 0 đến 9";
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblText.Location = new Point(264, 230);
            lblText.Name = "lblText";
            lblText.Size = new Size(116, 39);
            lblText.TabIndex = 1;
            lblText.Text = "Kết quả";
            // 
            // txtN
            // 
            txtN.Location = new Point(418, 180);
            txtN.Name = "txtN";
            txtN.PlaceholderText = "Nhập số n";
            txtN.Size = new Size(185, 31);
            txtN.TabIndex = 2;
            // 
            // txtText
            // 
            txtText.Location = new Point(418, 238);
            txtText.Name = "txtText";
            txtText.ReadOnly = true;
            txtText.Size = new Size(185, 31);
            txtText.TabIndex = 2;
            // 
            // btnDoc
            // 
            btnDoc.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDoc.Location = new Point(659, 180);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(112, 89);
            btnDoc.TabIndex = 3;
            btnDoc.Text = "Đọc";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // btnClr
            // 
            btnClr.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClr.Location = new Point(491, 298);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(112, 89);
            btnClr.TabIndex = 3;
            btnClr.Text = "Xóa";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(659, 316);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 57);
            btnBack.TabIndex = 3;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Lab01_Bai03
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
            Controls.Add(lblN);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "Lab01_Bai03";
            Text = "Lab01_Bai03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label lblN;
        private Label lblText;
        private TextBox txtN;
        private TextBox txtText;
        private Button btnDoc;
        private Button btnClr;
        private Button btnBack;
    }
}