namespace Lab01
{
    partial class Lab01_Bai07
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
            dtpBirth = new DateTimePicker();
            lblTitle = new Label();
            label1 = new Label();
            lblBirth = new Label();
            lblResult = new Label();
            txtResult = new TextBox();
            btnCheck = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(336, 157);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(300, 31);
            dtpBirth.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(330, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 68);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Bài 7";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 64);
            label1.Name = "label1";
            label1.Size = new Size(205, 27);
            label1.TabIndex = 1;
            label1.Text = "(Tìm cung hoàng đạo)";
            // 
            // lblBirth
            // 
            lblBirth.AutoSize = true;
            lblBirth.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirth.Location = new Point(143, 155);
            lblBirth.Name = "lblBirth";
            lblBirth.Size = new Size(187, 35);
            lblBirth.TabIndex = 2;
            lblBirth.Text = "Nhập ngày sinh";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Calibri", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(249, 279);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(315, 35);
            lblResult.TabIndex = 2;
            lblResult.Text = "Cung hoàng đạo của bạn:";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(306, 317);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(216, 47);
            txtResult.TabIndex = 3;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(336, 211);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(112, 54);
            btnCheck.TabIndex = 4;
            btnCheck.Text = "Tìm";
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(659, 391);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 4;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // Lab01_Bai07
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnCheck);
            Controls.Add(txtResult);
            Controls.Add(lblResult);
            Controls.Add(lblBirth);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(dtpBirth);
            Name = "Lab01_Bai07";
            Text = "Lab01_Bai07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpBirth;
        private Label lblTitle;
        private Label label1;
        private Label lblBirth;
        private Label lblResult;
        private TextBox txtResult;
        private Button btnCheck;
        private Button btnBack;
    }
}