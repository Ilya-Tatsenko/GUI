namespace GUI
{
    partial class FormEdit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowCity = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteCity = new System.Windows.Forms.Button();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.btnSearchCity = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gvCity = new System.Windows.Forms.DataGridView();
            this.btnClearCity = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeleteCountry = new System.Windows.Forms.Button();
            this.btnSearchCountry = new System.Windows.Forms.Button();
            this.gvCountry = new System.Windows.Forms.DataGridView();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDropDB = new System.Windows.Forms.Button();
            this.btnClearTables = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowCountry = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCity)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCountry)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnShowCity);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDeleteCity);
            this.panel1.Controls.Add(this.btnAddCity);
            this.panel1.Controls.Add(this.btnSearchCity);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.gvCity);
            this.panel1.Controls.Add(this.btnClearCity);
            this.panel1.Location = new System.Drawing.Point(10, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 360);
            this.panel1.TabIndex = 0;
            // 
            // btnShowCity
            // 
            this.btnShowCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShowCity.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowCity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnShowCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnShowCity.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowCity.Location = new System.Drawing.Point(7, 34);
            this.btnShowCity.Name = "btnShowCity";
            this.btnShowCity.Size = new System.Drawing.Size(251, 20);
            this.btnShowCity.TabIndex = 19;
            this.btnShowCity.Text = "Показать данные";
            this.btnShowCity.UseVisualStyleBackColor = false;
            this.btnShowCity.Click += new System.EventHandler(this.btnShowCity_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 285);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 20);
            this.textBox3.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Столица(да/нет):";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 260);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id страны:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Название города:";
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeleteCity.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteCity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteCity.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCity.Location = new System.Drawing.Point(261, 34);
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.Size = new System.Drawing.Size(109, 20);
            this.btnDeleteCity.TabIndex = 12;
            this.btnDeleteCity.Text = "Удалить";
            this.btnDeleteCity.UseVisualStyleBackColor = false;
            this.btnDeleteCity.Click += new System.EventHandler(this.btnDeleteCity_Click);
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddCity.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddCity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddCity.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCity.Location = new System.Drawing.Point(264, 260);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(109, 20);
            this.btnAddCity.TabIndex = 10;
            this.btnAddCity.Text = "Добавить";
            this.btnAddCity.UseVisualStyleBackColor = false;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // btnSearchCity
            // 
            this.btnSearchCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSearchCity.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchCity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearchCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearchCity.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchCity.Location = new System.Drawing.Point(261, 12);
            this.btnSearchCity.Name = "btnSearchCity";
            this.btnSearchCity.Size = new System.Drawing.Size(109, 20);
            this.btnSearchCity.TabIndex = 9;
            this.btnSearchCity.Text = "Поиск";
            this.btnSearchCity.UseVisualStyleBackColor = false;
            this.btnSearchCity.Click += new System.EventHandler(this.btnSearchCity_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(129, 12);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(126, 20);
            this.txtCity.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Название города:";
            // 
            // gvCity
            // 
            this.gvCity.BackgroundColor = System.Drawing.Color.White;
            this.gvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCity.Location = new System.Drawing.Point(4, 58);
            this.gvCity.Name = "gvCity";
            this.gvCity.Size = new System.Drawing.Size(369, 175);
            this.gvCity.TabIndex = 6;
            // 
            // btnClearCity
            // 
            this.btnClearCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClearCity.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearCity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClearCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClearCity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearCity.Location = new System.Drawing.Point(12, 318);
            this.btnClearCity.Name = "btnClearCity";
            this.btnClearCity.Size = new System.Drawing.Size(352, 35);
            this.btnClearCity.TabIndex = 5;
            this.btnClearCity.Text = "Очистить таблицу";
            this.btnClearCity.UseVisualStyleBackColor = false;
            this.btnClearCity.Click += new System.EventHandler(this.btnClearCity_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnShowCountry);
            this.panel2.Controls.Add(this.btnAddCountry);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnDeleteCountry);
            this.panel2.Controls.Add(this.btnSearchCountry);
            this.panel2.Controls.Add(this.gvCountry);
            this.panel2.Controls.Add(this.txtCountry);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(412, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 360);
            this.panel2.TabIndex = 1;
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddCountry.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddCountry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddCountry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddCountry.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCountry.Location = new System.Drawing.Point(264, 278);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(109, 20);
            this.btnAddCountry.TabIndex = 19;
            this.btnAddCountry.Text = "Добавить";
            this.btnAddCountry.UseVisualStyleBackColor = false;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(130, 278);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(126, 20);
            this.textBox4.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(4, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Название страны:";
            // 
            // btnDeleteCountry
            // 
            this.btnDeleteCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeleteCountry.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeleteCountry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteCountry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteCountry.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCountry.Location = new System.Drawing.Point(260, 34);
            this.btnDeleteCountry.Name = "btnDeleteCountry";
            this.btnDeleteCountry.Size = new System.Drawing.Size(109, 20);
            this.btnDeleteCountry.TabIndex = 19;
            this.btnDeleteCountry.Text = "Удалить";
            this.btnDeleteCountry.UseVisualStyleBackColor = false;
            this.btnDeleteCountry.Click += new System.EventHandler(this.btnDeleteCountry_Click);
            // 
            // btnSearchCountry
            // 
            this.btnSearchCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSearchCountry.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchCountry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearchCountry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearchCountry.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchCountry.Location = new System.Drawing.Point(260, 12);
            this.btnSearchCountry.Name = "btnSearchCountry";
            this.btnSearchCountry.Size = new System.Drawing.Size(109, 20);
            this.btnSearchCountry.TabIndex = 12;
            this.btnSearchCountry.Text = "Поиск";
            this.btnSearchCountry.UseVisualStyleBackColor = false;
            this.btnSearchCountry.Click += new System.EventHandler(this.btnSearchCountry_Click);
            // 
            // gvCountry
            // 
            this.gvCountry.BackgroundColor = System.Drawing.Color.White;
            this.gvCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCountry.Location = new System.Drawing.Point(5, 58);
            this.gvCountry.Name = "gvCountry";
            this.gvCountry.Size = new System.Drawing.Size(368, 209);
            this.gvCountry.TabIndex = 7;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(128, 12);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(126, 20);
            this.txtCountry.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Название страны:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnDropDB);
            this.panel3.Controls.Add(this.btnClearTables);
            this.panel3.Location = new System.Drawing.Point(10, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 50);
            this.panel3.TabIndex = 1;
            // 
            // btnDropDB
            // 
            this.btnDropDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDropDB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDropDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDropDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDropDB.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDropDB.Location = new System.Drawing.Point(400, 8);
            this.btnDropDB.Name = "btnDropDB";
            this.btnDropDB.Size = new System.Drawing.Size(375, 35);
            this.btnDropDB.TabIndex = 4;
            this.btnDropDB.Text = "Удалить базу данных";
            this.btnDropDB.UseVisualStyleBackColor = false;
            this.btnDropDB.Click += new System.EventHandler(this.btnDropDB_Click);
            // 
            // btnClearTables
            // 
            this.btnClearTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClearTables.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClearTables.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClearTables.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClearTables.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearTables.Location = new System.Drawing.Point(3, 8);
            this.btnClearTables.Name = "btnClearTables";
            this.btnClearTables.Size = new System.Drawing.Size(375, 35);
            this.btnClearTables.TabIndex = 3;
            this.btnClearTables.Text = "Очистить таблицы";
            this.btnClearTables.UseVisualStyleBackColor = false;
            this.btnClearTables.Click += new System.EventHandler(this.btnClearTables_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Таблица \"Города\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(408, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Таблица \"Страны\"";
            // 
            // btnShowCountry
            // 
            this.btnShowCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnShowCountry.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShowCountry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnShowCountry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnShowCountry.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowCountry.Location = new System.Drawing.Point(5, 34);
            this.btnShowCountry.Name = "btnShowCountry";
            this.btnShowCountry.Size = new System.Drawing.Size(251, 20);
            this.btnShowCountry.TabIndex = 20;
            this.btnShowCountry.Text = "Показать данные";
            this.btnShowCountry.UseVisualStyleBackColor = false;
            this.btnShowCountry.Click += new System.EventHandler(this.btnShowCountry_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEdit";
            this.Text = "Управление базой данных";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCountry)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDropDB;
        private System.Windows.Forms.Button btnClearTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearCity;
        private System.Windows.Forms.DataGridView gvCity;
        private System.Windows.Forms.DataGridView gvCountry;
        private System.Windows.Forms.Button btnSearchCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteCity;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteCountry;
        private System.Windows.Forms.Button btnAddCountry;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnShowCity;
        private System.Windows.Forms.Button btnShowCountry;
    }
}