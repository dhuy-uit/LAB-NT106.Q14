namespace Lab01
{
    partial class Lab01_Bai09
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
            lbl = new Label();
            lblFood = new Label();
            txtNewDish = new TextBox();
            btnAdd = new Button();
            btnPick = new Button();
            button2 = new Button();
            label1 = new Label();
            txtToday = new TextBox();
            lstDishes = new ListBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(329, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 68);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bài 9";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Calibri", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl.Location = new Point(323, 83);
            lbl.Name = "lbl";
            lbl.Size = new Size(153, 27);
            lbl.TabIndex = 0;
            lbl.Text = "(Hôm nay ăn gì)";
            // 
            // lblFood
            // 
            lblFood.AutoSize = true;
            lblFood.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFood.Location = new Point(77, 126);
            lblFood.Name = "lblFood";
            lblFood.Size = new Size(168, 35);
            lblFood.TabIndex = 1;
            lblFood.Text = "Nhập món ăn";
            // 
            // txtNewDish
            // 
            txtNewDish.Location = new Point(251, 130);
            txtNewDish.Name = "txtNewDish";
            txtNewDish.Size = new Size(221, 31);
            txtNewDish.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(360, 182);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnPick
            // 
            btnPick.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPick.Location = new Point(77, 264);
            btnPick.Name = "btnPick";
            btnPick.Size = new Size(168, 45);
            btnPick.TabIndex = 4;
            btnPick.Text = "Tìm món ăn";
            btnPick.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(380, 264);
            button2.Name = "button2";
            button2.Size = new Size(92, 45);
            button2.TabIndex = 4;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 334);
            label1.Name = "label1";
            label1.Size = new Size(149, 35);
            label1.TabIndex = 1;
            label1.Text = "Hôm nay ăn";
            // 
            // txtToday
            // 
            txtToday.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtToday.Location = new Point(329, 372);
            txtToday.Name = "txtToday";
            txtToday.ReadOnly = true;
            txtToday.Size = new Size(151, 37);
            txtToday.TabIndex = 2;
            // 
            // lstDishes
            // 
            lstDishes.FormattingEnabled = true;
            lstDishes.ItemHeight = 25;
            lstDishes.Location = new Point(495, 130);
            lstDishes.Name = "lstDishes";
            lstDishes.Size = new Size(255, 179);
            lstDishes.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(658, 372);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(92, 37);
            btnBack.TabIndex = 4;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // Lab01_Bai09
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(lstDishes);
            Controls.Add(btnBack);
            Controls.Add(button2);
            Controls.Add(btnPick);
            Controls.Add(btnAdd);
            Controls.Add(txtToday);
            Controls.Add(txtNewDish);
            Controls.Add(label1);
            Controls.Add(lblFood);
            Controls.Add(lbl);
            Controls.Add(lblTitle);
            Name = "Lab01_Bai09";
            Text = "Lab01_Bai09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lbl;
        private Label lblFood;
        private TextBox txtNewDish;
        private Button btnAdd;
        private Button btnPick;
        private Button button2;
        private Label label1;
        private TextBox txtToday;
        private ListBox lstDishes;
        private Button btnBack;
    }
}