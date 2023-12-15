namespace Library
{
    partial class Librarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Librarian));
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.ChangeTableButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.AddServiceButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FioLabel = new System.Windows.Forms.Label();
            this.TableName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.AllowUserToOrderColumns = true;
            this.DataTable.AllowUserToResizeRows = false;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(254, 135);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.Size = new System.Drawing.Size(637, 361);
            this.DataTable.TabIndex = 3;
            // 
            // ChangeTableButton
            // 
            this.ChangeTableButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ChangeTableButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.ChangeTableButton.FlatAppearance.BorderSize = 0;
            this.ChangeTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTableButton.Location = new System.Drawing.Point(42, 135);
            this.ChangeTableButton.Name = "ChangeTableButton";
            this.ChangeTableButton.Size = new System.Drawing.Size(184, 35);
            this.ChangeTableButton.TabIndex = 5;
            this.ChangeTableButton.Text = "Переключить таблицу";
            this.ChangeTableButton.UseVisualStyleBackColor = false;
            this.ChangeTableButton.Click += new System.EventHandler(this.ChangeTableButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.AddBookButton);
            this.groupBox1.Controls.Add(this.AddServiceButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 111);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление";
            // 
            // AddBookButton
            // 
            this.AddBookButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddBookButton.Location = new System.Drawing.Point(6, 29);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(169, 23);
            this.AddBookButton.TabIndex = 5;
            this.AddBookButton.Text = "Добавить книгу";
            this.AddBookButton.UseVisualStyleBackColor = false;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // AddServiceButton
            // 
            this.AddServiceButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddServiceButton.Location = new System.Drawing.Point(6, 71);
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(169, 23);
            this.AddServiceButton.TabIndex = 6;
            this.AddServiceButton.Text = "Добавить читателя";
            this.AddServiceButton.UseVisualStyleBackColor = false;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.IdTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ChangeButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(42, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 140);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(6, 75);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(75, 21);
            this.IdTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите нужную таблицу и введите ID записи, которую нужно изменить";
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ChangeButton.Location = new System.Drawing.Point(6, 111);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(169, 23);
            this.ChangeButton.TabIndex = 6;
            this.ChangeButton.Text = "Изменить запись";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(36, 510);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(184, 33);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FioLabel
            // 
            this.FioLabel.AutoSize = true;
            this.FioLabel.BackColor = System.Drawing.Color.Transparent;
            this.FioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FioLabel.Location = new System.Drawing.Point(39, 33);
            this.FioLabel.Name = "FioLabel";
            this.FioLabel.Size = new System.Drawing.Size(51, 16);
            this.FioLabel.TabIndex = 11;
            this.FioLabel.Text = "label1";
            // 
            // TableName
            // 
            this.TableName.AutoSize = true;
            this.TableName.BackColor = System.Drawing.Color.Transparent;
            this.TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableName.Location = new System.Drawing.Point(251, 109);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(47, 15);
            this.TableName.TabIndex = 12;
            this.TableName.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(787, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 94);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(552, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 54);
            this.label4.TabIndex = 17;
            this.label4.Text = "LIBRARY";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(42, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Посчитать количество записей";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Librarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(920, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TableName);
            this.Controls.Add(this.FioLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ChangeTableButton);
            this.Controls.Add(this.DataTable);
            this.Name = "Librarian";
            this.Text = "Librarian";
            this.Load += new System.EventHandler(this.Librerian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Button ChangeTableButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button AddServiceButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label FioLabel;
        private System.Windows.Forms.Label TableName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}