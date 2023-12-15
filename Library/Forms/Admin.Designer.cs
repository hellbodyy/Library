namespace Library
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.ChangeTableButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FioLabel = new System.Windows.Forms.Label();
            this.TableName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IdTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeletteButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.DataTable.Location = new System.Drawing.Point(235, 129);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.Size = new System.Drawing.Size(621, 361);
            this.DataTable.TabIndex = 4;
            // 
            // ChangeTableButton
            // 
            this.ChangeTableButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ChangeTableButton.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeTableButton.Location = new System.Drawing.Point(30, 129);
            this.ChangeTableButton.Name = "ChangeTableButton";
            this.ChangeTableButton.Size = new System.Drawing.Size(184, 35);
            this.ChangeTableButton.TabIndex = 6;
            this.ChangeTableButton.Text = "Переключить таблицу";
            this.ChangeTableButton.UseVisualStyleBackColor = false;
            this.ChangeTableButton.Click += new System.EventHandler(this.ChangeTableButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.IdTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ChangeButton);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 170);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 140);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DeleteButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 140);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Удаление";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите нужную таблицу и введите ID записи, которую нужно удалить";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Khaki;
            this.DeleteButton.Location = new System.Drawing.Point(6, 111);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(169, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Удалить запись";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(6, 75);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(75, 22);
            this.IdTextBox.TabIndex = 8;
            this.IdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите нужную таблицу и введите ID записи, которую нужно изменить\r\n";
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
            this.ExitButton.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(36, 484);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FioLabel
            // 
            this.FioLabel.AutoSize = true;
            this.FioLabel.BackColor = System.Drawing.Color.Transparent;
            this.FioLabel.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FioLabel.Location = new System.Drawing.Point(27, 36);
            this.FioLabel.Name = "FioLabel";
            this.FioLabel.Size = new System.Drawing.Size(50, 18);
            this.FioLabel.TabIndex = 12;
            this.FioLabel.Text = "label2";
            // 
            // TableName
            // 
            this.TableName.AutoSize = true;
            this.TableName.BackColor = System.Drawing.Color.Transparent;
            this.TableName.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableName.Location = new System.Drawing.Point(232, 104);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(46, 16);
            this.TableName.TabIndex = 13;
            this.TableName.Text = "label2";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.IdTextBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.DeletteButton);
            this.groupBox3.Font = new System.Drawing.Font("Montserrat Alternates SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(30, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 140);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Удаление";
            // 
            // IdTextBox1
            // 
            this.IdTextBox1.Location = new System.Drawing.Point(6, 75);
            this.IdTextBox1.Name = "IdTextBox1";
            this.IdTextBox1.Size = new System.Drawing.Size(75, 22);
            this.IdTextBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите нужную таблицу и введите ID записи, которую нужно удалить";
            // 
            // DeletteButton
            // 
            this.DeletteButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.DeletteButton.Location = new System.Drawing.Point(6, 111);
            this.DeletteButton.Name = "DeletteButton";
            this.DeletteButton.Size = new System.Drawing.Size(169, 23);
            this.DeletteButton.TabIndex = 6;
            this.DeletteButton.Text = "Удалить запись";
            this.DeletteButton.UseVisualStyleBackColor = false;
            this.DeletteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(752, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 94);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(517, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 54);
            this.label4.TabIndex = 16;
            this.label4.Text = "LIBRARY";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(880, 523);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.TableName);
            this.Controls.Add(this.FioLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ChangeTableButton);
            this.Controls.Add(this.DataTable);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Button ChangeTableButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label FioLabel;
        private System.Windows.Forms.Label TableName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox IdTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeletteButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}