namespace WinFormsEntityFrameWork
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.priceOfDelivery = new System.Windows.Forms.TextBox();
            this.descriptionOfDelivery = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.addressOfDelivery = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.descFilter = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(462, 422);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // priceOfDelivery
            // 
            this.priceOfDelivery.Location = new System.Drawing.Point(39, 33);
            this.priceOfDelivery.Name = "priceOfDelivery";
            this.priceOfDelivery.Size = new System.Drawing.Size(153, 20);
            this.priceOfDelivery.TabIndex = 1;
            // 
            // descriptionOfDelivery
            // 
            this.descriptionOfDelivery.Location = new System.Drawing.Point(39, 87);
            this.descriptionOfDelivery.Name = "descriptionOfDelivery";
            this.descriptionOfDelivery.Size = new System.Drawing.Size(153, 20);
            this.descriptionOfDelivery.TabIndex = 3;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(39, 113);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(71, 26);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // addressOfDelivery
            // 
            this.addressOfDelivery.FormattingEnabled = true;
            this.addressOfDelivery.Items.AddRange(new object[] {"", "Москва", "Киров", "Пермь", "Воронеж"});
            this.addressOfDelivery.Location = new System.Drawing.Point(39, 60);
            this.addressOfDelivery.Name = "addressOfDelivery";
            this.addressOfDelivery.Size = new System.Drawing.Size(153, 21);
            this.addressOfDelivery.TabIndex = 5;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(121, 113);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(71, 26);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(83, 150);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(71, 26);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // descFilter
            // 
            this.descFilter.Location = new System.Drawing.Point(39, 266);
            this.descFilter.Name = "descFilter";
            this.descFilter.Size = new System.Drawing.Size(153, 20);
            this.descFilter.TabIndex = 10;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(83, 324);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(71, 26);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(198, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Описание";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(198, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(198, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(198, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Описание";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {"", "Москва", "Киров", "Пермь", "Воронеж"});
            this.comboBox1.Location = new System.Drawing.Point(39, 292);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(198, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Адрес";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.descFilter);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.addressOfDelivery);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.descriptionOfDelivery);
            this.Controls.Add(this.priceOfDelivery);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.TextBox descFilter;
        private System.Windows.Forms.Button buttonSearch;

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;

        private System.Windows.Forms.ComboBox addressOfDelivery;

        private System.Windows.Forms.Button btnInsert;

        private System.Windows.Forms.TextBox descriptionOfDelivery;

        private System.Windows.Forms.TextBox priceOfDelivery;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}