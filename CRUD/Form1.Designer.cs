namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Student_ID = new System.Windows.Forms.Label();
            this.Student_Name = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.Birth = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stu_address_txt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.savebtn = new System.Windows.Forms.Button();
            this.updatabtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.Stu_ID_txt = new System.Windows.Forms.TextBox();
            this.Stu_Name_txt = new System.Windows.Forms.TextBox();
            this.Stu_Phone_txt = new System.Windows.Forms.TextBox();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Student_ID
            // 
            this.Student_ID.AutoSize = true;
            this.Student_ID.Location = new System.Drawing.Point(107, 88);
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.Size = new System.Drawing.Size(99, 18);
            this.Student_ID.TabIndex = 0;
            this.Student_ID.Text = "Student ID";
            // 
            // Student_Name
            // 
            this.Student_Name.AutoSize = true;
            this.Student_Name.Location = new System.Drawing.Point(81, 155);
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.Size = new System.Drawing.Size(130, 18);
            this.Student_Name.TabIndex = 2;
            this.Student_Name.Text = "Student Name";
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Location = new System.Drawing.Point(153, 222);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(53, 18);
            this.Class.TabIndex = 4;
            this.Class.Text = "Class";
            // 
            // Birth
            // 
            this.Birth.AutoSize = true;
            this.Birth.Location = new System.Drawing.Point(153, 298);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(52, 18);
            this.Birth.TabIndex = 6;
            this.Birth.Text = "Birth";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(128, 363);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(77, 18);
            this.Address.TabIndex = 8;
            this.Address.Text = "Address";
            this.Address.Click += new System.EventHandler(this.label5_Click);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(143, 510);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(62, 18);
            this.Phone.TabIndex = 10;
            this.Phone.Text = "Phone";
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(726, 84);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(67, 18);
            this.Search.TabIndex = 12;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(231, 293);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(196, 25);
            this.dateTimePicker.TabIndex = 0;
            // 
            // stu_address_txt
            // 
            this.stu_address_txt.Location = new System.Drawing.Point(231, 362);
            this.stu_address_txt.Multiline = true;
            this.stu_address_txt.Name = "stu_address_txt";
            this.stu_address_txt.Size = new System.Drawing.Size(196, 122);
            this.stu_address_txt.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(474, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 413);
            this.dataGridView1.TabIndex = 15;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.LimeGreen;
            this.savebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(84, 578);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(100, 50);
            this.savebtn.TabIndex = 16;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // updatabtn
            // 
            this.updatabtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.updatabtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updatabtn.FlatAppearance.BorderSize = 0;
            this.updatabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatabtn.ForeColor = System.Drawing.Color.White;
            this.updatabtn.Location = new System.Drawing.Point(219, 578);
            this.updatabtn.Name = "updatabtn";
            this.updatabtn.Size = new System.Drawing.Size(100, 50);
            this.updatabtn.TabIndex = 17;
            this.updatabtn.Text = "Update";
            this.updatabtn.UseVisualStyleBackColor = false;
            this.updatabtn.Click += new System.EventHandler(this.updatabtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.OrangeRed;
            this.deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(355, 578);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(100, 50);
            this.deletebtn.TabIndex = 18;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // Stu_ID_txt
            // 
            this.Stu_ID_txt.Location = new System.Drawing.Point(231, 81);
            this.Stu_ID_txt.Name = "Stu_ID_txt";
            this.Stu_ID_txt.Size = new System.Drawing.Size(196, 25);
            this.Stu_ID_txt.TabIndex = 19;
            // 
            // Stu_Name_txt
            // 
            this.Stu_Name_txt.Location = new System.Drawing.Point(231, 148);
            this.Stu_Name_txt.Name = "Stu_Name_txt";
            this.Stu_Name_txt.Size = new System.Drawing.Size(196, 25);
            this.Stu_Name_txt.TabIndex = 20;
            // 
            // Stu_Phone_txt
            // 
            this.Stu_Phone_txt.Location = new System.Drawing.Point(231, 508);
            this.Stu_Phone_txt.Name = "Stu_Phone_txt";
            this.Stu_Phone_txt.Size = new System.Drawing.Size(196, 25);
            this.Stu_Phone_txt.TabIndex = 22;
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(799, 81);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(344, 25);
            this.Search_txt.TabIndex = 23;
            this.Search_txt.TextChanged += new System.EventHandler(this.Search_txt_TextChanged);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "#";
            this.Column7.Name = "Column7";
            this.Column7.Width = 43;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "name";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "class";
            this.Column3.Name = "Column3";
            this.Column3.Width = 76;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "birth";
            this.Column4.Name = "Column4";
            this.Column4.Width = 76;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "address";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "phone";
            this.Column6.Name = "Column6";
            this.Column6.Width = 87;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "chinese",
            "english",
            "german",
            "spanish",
            "japanese"});
            this.comboBox1.Location = new System.Drawing.Point(231, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 26);
            this.comboBox1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Search_txt);
            this.Controls.Add(this.Stu_Phone_txt);
            this.Controls.Add(this.Stu_Name_txt);
            this.Controls.Add(this.Stu_ID_txt);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatabtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.stu_address_txt);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Student_Name);
            this.Controls.Add(this.Student_ID);
            this.Font = new System.Drawing.Font("源泉圓體 M", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Student_ID;
        private System.Windows.Forms.Label Student_Name;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label Birth;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox stu_address_txt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button updatabtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.TextBox Stu_ID_txt;
        private System.Windows.Forms.TextBox Stu_Name_txt;
        private System.Windows.Forms.TextBox Stu_Phone_txt;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

