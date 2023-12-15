namespace Library
{
    partial class AddBook
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genresComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.NumbUD = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceNumUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.PublishTextBox = new System.Windows.Forms.TextBox();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NumbBookTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumbUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genresComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.YearTextBox);
            this.groupBox1.Controls.Add(this.NumbUD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.PriceNumUD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PublishTextBox);
            this.groupBox1.Controls.Add(this.AddBookButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NameTextBox);
            this.groupBox1.Controls.Add(this.NumbBookTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 278);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить книгу";
            // 
            // genresComboBox
            // 
            this.genresComboBox.FormattingEnabled = true;
            this.genresComboBox.Location = new System.Drawing.Point(19, 139);
            this.genresComboBox.Name = "genresComboBox";
            this.genresComboBox.Size = new System.Drawing.Size(197, 21);
            this.genresComboBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Год издания";
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(283, 141);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(134, 20);
            this.YearTextBox.TabIndex = 15;
            // 
            // NumbUD
            // 
            this.NumbUD.Location = new System.Drawing.Point(283, 99);
            this.NumbUD.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumbUD.Name = "NumbUD";
            this.NumbUD.Size = new System.Drawing.Size(132, 20);
            this.NumbUD.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Количество экземпляров";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Цена книги";
            // 
            // PriceNumUD
            // 
            this.PriceNumUD.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.PriceNumUD.Location = new System.Drawing.Point(283, 53);
            this.PriceNumUD.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.PriceNumUD.Name = "PriceNumUD";
            this.PriceNumUD.Size = new System.Drawing.Size(132, 20);
            this.PriceNumUD.TabIndex = 11;
            this.PriceNumUD.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Издательство";
            // 
            // PublishTextBox
            // 
            this.PublishTextBox.Location = new System.Drawing.Point(19, 191);
            this.PublishTextBox.Name = "PublishTextBox";
            this.PublishTextBox.Size = new System.Drawing.Size(197, 20);
            this.PublishTextBox.TabIndex = 9;
            // 
            // AddBookButton
            // 
            this.AddBookButton.BackColor = System.Drawing.Color.Khaki;
            this.AddBookButton.Location = new System.Drawing.Point(179, 234);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(118, 38);
            this.AddBookButton.TabIndex = 8;
            this.AddBookButton.Text = "Добавить";
            this.AddBookButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Жанр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Шифр книги";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(19, 98);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(197, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // NumbBookTextBox
            // 
            this.NumbBookTextBox.Location = new System.Drawing.Point(19, 53);
            this.NumbBookTextBox.Name = "NumbBookTextBox";
            this.NumbBookTextBox.Size = new System.Drawing.Size(197, 20);
            this.NumbBookTextBox.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Khaki;
            this.BackButton.Location = new System.Drawing.Point(354, 296);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 329);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumbUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox NumbBookTextBox;
        private System.Windows.Forms.NumericUpDown NumbUD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown PriceNumUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PublishTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.ComboBox genresComboBox;
        private System.Windows.Forms.Button BackButton;
    }
}