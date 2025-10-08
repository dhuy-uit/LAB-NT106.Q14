namespace Lab01
{
    partial class Lab01_Bai06
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
            lblA = new Label();
            label2 = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtResult = new TextBox();
            lblTable = new Label();
            cboAction = new ComboBox();
            lblResult = new Label();
            btnCalc = new Button();
            btnExit = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(309, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bài 6";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 73);
            label1.Name = "label1";
            label1.Size = new Size(109, 27);
            label1.TabIndex = 0;
            label1.Text = "(Tính toán)";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblA.Location = new Point(67, 119);
            lblA.Name = "lblA";
            lblA.Size = new Size(122, 39);
            lblA.TabIndex = 1;
            lblA.Text = "Nhập A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(426, 119);
            label2.Name = "label2";
            label2.Size = new Size(120, 39);
            label2.TabIndex = 1;
            label2.Text = "Nhập B:";
            // 
            // txtA
            // 
            txtA.Location = new Point(195, 126);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 31);
            txtA.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(552, 127);
            txtB.Name = "txtB";
            txtB.Size = new Size(150, 31);
            txtB.TabIndex = 2;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(67, 338);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(635, 296);
            txtResult.TabIndex = 3;
            // 
            // lblTable
            // 
            lblTable.AutoSize = true;
            lblTable.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTable.Location = new Point(205, 193);
            lblTable.Name = "lblTable";
            lblTable.Size = new Size(104, 35);
            lblTable.TabIndex = 4;
            lblTable.Text = "Yêu cầu";
            // 
            // cboAction
            // 
            cboAction.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboAction.FormattingEnabled = true;
            cboAction.Location = new Point(326, 193);
            cboAction.Name = "cboAction";
            cboAction.Size = new Size(182, 35);
            cboAction.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(552, 319);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(103, 35);
            lblResult.TabIndex = 4;
            lblResult.Text = "Kết quả";
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalc.Location = new Point(326, 259);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(112, 34);
            btnCalc.TabIndex = 6;
            btnCalc.Text = "Tính";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(590, 259);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 6;
            btnExit.Text = "Quay lại";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(67, 259);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 6;
            btnClear.Text = "Xóa";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // Lab01_Bai06
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 670);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(btnCalc);
            Controls.Add(cboAction);
            Controls.Add(lblResult);
            Controls.Add(lblTable);
            Controls.Add(txtResult);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(label2);
            Controls.Add(lblA);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "Lab01_Bai06";
            Text = "Lab01_Bai06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label lblA;
        private Label label2;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtResult;
        private Label lblTable;
        private ComboBox cboAction;
        private Label lblResult;
        private Button btnCalc;
        private Button btnExit;
        private Button btnClear;
    }
}