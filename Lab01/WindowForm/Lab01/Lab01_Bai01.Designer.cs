namespace Lab01
{
    partial class Lab01_Bai01
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
            btnBack = new Button();
            txtA = new TextBox();
            txtB = new TextBox();
            lblA = new Label();
            lblTitle = new Label();
            lblB = new Label();
            lblSum = new Label();
            txtSum = new TextBox();
            btnCal = new Button();
            btnClr = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(682, 358);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(87, 65);
            btnBack.TabIndex = 0;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(238, 131);
            txtA.Name = "txtA";
            txtA.PlaceholderText = "Nhập số A";
            txtA.Size = new Size(309, 31);
            txtA.TabIndex = 1;
            // 
            // txtB
            // 
            txtB.Location = new Point(238, 187);
            txtB.Name = "txtB";
            txtB.PlaceholderText = "Nhập sô B";
            txtB.Size = new Size(309, 31);
            txtB.TabIndex = 1;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblA.Location = new Point(181, 123);
            lblA.Name = "lblA";
            lblA.Size = new Size(36, 39);
            lblA.TabIndex = 2;
            lblA.Text = "A";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(340, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(103, 49);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Bài 1";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblB.Location = new Point(181, 179);
            lblB.Name = "lblB";
            lblB.Size = new Size(35, 39);
            lblB.TabIndex = 2;
            lblB.Text = "B";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSum.Location = new Point(138, 266);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(79, 39);
            lblSum.TabIndex = 2;
            lblSum.Text = "Tổng";
            // 
            // txtSum
            // 
            txtSum.Location = new Point(238, 266);
            txtSum.Name = "txtSum";
            txtSum.ReadOnly = true;
            txtSum.Size = new Size(309, 31);
            txtSum.TabIndex = 1;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(592, 131);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(112, 87);
            btnCal.TabIndex = 3;
            btnCal.Text = "Tính";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // btnClr
            // 
            btnClr.Location = new Point(592, 266);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(112, 34);
            btnClr.TabIndex = 4;
            btnClr.Text = "Xóa";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 88);
            label1.Name = "label1";
            label1.Size = new Size(102, 24);
            label1.TabIndex = 2;
            label1.Text = "(Tính tổng)";
            // 
            // Lab01_Bai01
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClr);
            Controls.Add(btnCal);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(lblSum);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(txtSum);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(btnBack);
            Name = "Lab01_Bai01";
            Text = "Lab01_Bai01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private TextBox txtA;
        private TextBox txtB;
        private Label lblA;
        private Label lblTitle;
        private Label lblB;
        private Label lblSum;
        private TextBox txtSum;
        private Button btnCal;
        private Button btnClr;
        private Label label1;
    }
}