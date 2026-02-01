namespace beverages_menu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtSize = new TextBox();
            txtRoast = new TextBox();
            txtShots = new TextBox();
            chkIced = new CheckBox();
            chkCream = new CheckBox();
            chkSugar = new CheckBox();
            btnAdd = new Button();
            btnDelete = new Button();
            dgvCoffees = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCoffees).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(213, 46);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Ex: John Doe";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(352, 44);
            txtSize.Name = "txtSize";
            txtSize.PlaceholderText = "Ex: Small";
            txtSize.Size = new Size(100, 23);
            txtSize.TabIndex = 1;
            // 
            // txtRoast
            // 
            txtRoast.Location = new Point(481, 46);
            txtRoast.Name = "txtRoast";
            txtRoast.PlaceholderText = "Ex: Latte";
            txtRoast.Size = new Size(100, 23);
            txtRoast.TabIndex = 2;
            // 
            // txtShots
            // 
            txtShots.Location = new Point(613, 46);
            txtShots.Name = "txtShots";
            txtShots.PlaceholderText = "Ex: 3";
            txtShots.Size = new Size(100, 23);
            txtShots.TabIndex = 3;
            // 
            // chkIced
            // 
            chkIced.AutoSize = true;
            chkIced.Location = new Point(665, 88);
            chkIced.Name = "chkIced";
            chkIced.Size = new Size(48, 19);
            chkIced.TabIndex = 4;
            chkIced.Text = "Iced";
            chkIced.UseVisualStyleBackColor = true;
            // 
            // chkCream
            // 
            chkCream.AutoSize = true;
            chkCream.Location = new Point(495, 88);
            chkCream.Name = "chkCream";
            chkCream.Size = new Size(86, 19);
            chkCream.TabIndex = 5;
            chkCream.Text = "Add Cream";
            chkCream.UseVisualStyleBackColor = true;
            // 
            // chkSugar
            // 
            chkSugar.AutoSize = true;
            chkSugar.Location = new Point(352, 88);
            chkSugar.Name = "chkSugar";
            chkSugar.Size = new Size(81, 19);
            chkSugar.TabIndex = 6;
            chkSugar.Text = "Add Sugar";
            chkSugar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(557, 214);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Submit";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(213, 214);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(170, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCoffees
            // 
            dgvCoffees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoffees.Location = new Point(170, 243);
            dgvCoffees.Name = "dgvCoffees";
            dgvCoffees.Size = new Size(575, 186);
            dgvCoffees.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 28);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(383, 26);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 11;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(513, 28);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 12;
            label3.Text = "Roast";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(642, 28);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 13;
            label4.Text = "Shots";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCoffees);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(chkSugar);
            Controls.Add(chkCream);
            Controls.Add(chkIced);
            Controls.Add(txtShots);
            Controls.Add(txtRoast);
            Controls.Add(txtSize);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Quiroz Coffee Company";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCoffees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSize;
        private TextBox txtRoast;
        private TextBox txtShots;
        private CheckBox chkIced;
        private CheckBox chkCream;
        private CheckBox chkSugar;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dgvCoffees;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
