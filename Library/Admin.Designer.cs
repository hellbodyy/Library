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
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.ChangeTableButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FioLabel = new System.Windows.Forms.Label();
            this.TableName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.AllowUserToOrderColumns = true;
            this.DataTable.AllowUserToResizeRows = false;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Location = new System.Drawing.Point(229, 71);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.Size = new System.Drawing.Size(621, 361);
            this.DataTable.TabIndex = 4;
            // 
            // ChangeTableButton
            // 
            this.ChangeTableButton.BackColor = System.Drawing.Color.Khaki;
            this.ChangeTableButton.Location = new System.Drawing.Point(24, 71);
            this.ChangeTableButton.Name = "ChangeTableButton";
            this.ChangeTableButton.Size = new System.Drawing.Size(184, 35);
            this.ChangeTableButton.TabIndex = 6;
            this.ChangeTableButton.Text = "Переключить таблицу";
            this.ChangeTableButton.UseVisualStyleBackColor = false;
            this.ChangeTableButton.Click += new System.EventHandler(this.ChangeTableButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IdTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ChangeButton);
            this.groupBox2.Location = new System.Drawing.Point(24, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 140);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(6, 75);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(75, 20);
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
            this.ChangeButton.BackColor = System.Drawing.Color.Khaki;
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
            this.ExitButton.BackColor = System.Drawing.Color.Khaki;
            this.ExitButton.Location = new System.Drawing.Point(30, 409);
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
            this.FioLabel.Location = new System.Drawing.Point(21, 18);
            this.FioLabel.Name = "FioLabel";
            this.FioLabel.Size = new System.Drawing.Size(35, 13);
            this.FioLabel.TabIndex = 12;
            this.FioLabel.Text = "label2";
            // 
            // TableName
            // 
            this.TableName.AutoSize = true;
            this.TableName.Location = new System.Drawing.Point(226, 46);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(35, 13);
            this.TableName.TabIndex = 13;
            this.TableName.Text = "label2";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
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
    }
}