namespace Lab02
{
    partial class Lab02_Bai01
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
            btnRead = new Button();
            btnWrite = new Button();
            rtbContent = new RichTextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.Location = new Point(20, 23);
            btnRead.Margin = new Padding(5, 6, 5, 6);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(200, 96);
            btnRead.TabIndex = 0;
            btnRead.Text = "ĐỌC FILE";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWrite.Location = new Point(20, 158);
            btnWrite.Margin = new Padding(5, 6, 5, 6);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(200, 96);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "GHI FILE";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // rtbContent
            // 
            rtbContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbContent.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbContent.Location = new Point(250, 23);
            rtbContent.Margin = new Padding(5, 6, 5, 6);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(534, 375);
            rtbContent.TabIndex = 2;
            rtbContent.Text = "";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(71, 318);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 3;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Lab02_Bai01
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 425);
            Controls.Add(btnBack);
            Controls.Add(rtbContent);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Margin = new Padding(5, 6, 5, 6);
            MinimumSize = new Size(569, 333);
            Name = "Lab02_Bai01";
            Text = "Lab 02 - Bài 01 - Ghi và Đọc File";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.RichTextBox rtbContent;
        private Button btnBack;
    }
}