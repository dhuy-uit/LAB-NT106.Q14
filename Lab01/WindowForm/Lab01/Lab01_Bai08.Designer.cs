namespace Lab01
{
    partial class Lab01_Bai08
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
            lblInput = new Label();
            txtInput = new TextBox();
            label2 = new Label();
            txtOutput = new TextBox();
            btnProcess = new Button();
            btnBack = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(319, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bài 8";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 79);
            label1.Name = "label1";
            label1.Size = new Size(117, 27);
            label1.TabIndex = 0;
            label1.Text = "(Xử lí chuỗi)";
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInput.Location = new Point(73, 133);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(186, 35);
            lblInput.TabIndex = 1;
            lblInput.Text = "Nhập thông tin";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(265, 122);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(451, 46);
            txtInput.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 273);
            label2.Name = "label2";
            label2.Size = new Size(219, 35);
            label2.TabIndex = 1;
            label2.Text = "Thông tin của bạn";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(265, 273);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(451, 229);
            txtOutput.TabIndex = 2;
            // 
            // btnProcess
            // 
            btnProcess.Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcess.Location = new Point(335, 195);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(112, 48);
            btnProcess.TabIndex = 3;
            btnProcess.Text = "Xử lí";
            btnProcess.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(604, 195);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 48);
            btnBack.TabIndex = 3;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(73, 195);
            button1.Name = "button1";
            button1.Size = new Size(112, 48);
            button1.TabIndex = 3;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Lab01_Bai08
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(button1);
            Controls.Add(btnBack);
            Controls.Add(btnProcess);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(label2);
            Controls.Add(lblInput);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Name = "Lab01_Bai08";
            Text = "Lab01_Bai08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private Label lblInput;
        private TextBox txtInput;
        private Label label2;
        private TextBox txtOutput;
        private Button btnProcess;
        private Button btnBack;
        private Button button1;
    }
}