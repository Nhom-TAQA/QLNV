namespace QLNV
{
    partial class nhanvien
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOVNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lUONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAPHONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NVDataSet_nhanvien = new QLNV.QL_NVDataSet_nhanvien();
            this.nHANVIENTableAdapter = new QLNV.QL_NVDataSet_nhanvienTableAdapters.NHANVIENTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.tbmaphong = new System.Windows.Forms.TextBox();
            this.tbtienluong = new System.Windows.Forms.TextBox();
            this.tbgioitinh = new System.Windows.Forms.TextBox();
            this.tbngaysinh = new System.Windows.Forms.TextBox();
            this.tbtennv = new System.Windows.Forms.TextBox();
            this.tbmanv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NVDataSet_nhanvien)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANVDataGridViewTextBoxColumn,
            this.hOVNDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.gTDataGridViewCheckBoxColumn,
            this.lUONGDataGridViewTextBoxColumn,
            this.mAPHONGDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nHANVIENBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "MANV";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.ReadOnly = true;
            this.mANVDataGridViewTextBoxColumn.Width = 50;
            // 
            // hOVNDataGridViewTextBoxColumn
            // 
            this.hOVNDataGridViewTextBoxColumn.DataPropertyName = "HOVN";
            this.hOVNDataGridViewTextBoxColumn.HeaderText = "HOVN";
            this.hOVNDataGridViewTextBoxColumn.Name = "hOVNDataGridViewTextBoxColumn";
            this.hOVNDataGridViewTextBoxColumn.Width = 170;
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            // 
            // gTDataGridViewCheckBoxColumn
            // 
            this.gTDataGridViewCheckBoxColumn.DataPropertyName = "GT";
            this.gTDataGridViewCheckBoxColumn.HeaderText = "GT";
            this.gTDataGridViewCheckBoxColumn.Name = "gTDataGridViewCheckBoxColumn";
            this.gTDataGridViewCheckBoxColumn.Width = 30;
            // 
            // lUONGDataGridViewTextBoxColumn
            // 
            this.lUONGDataGridViewTextBoxColumn.DataPropertyName = "LUONG";
            this.lUONGDataGridViewTextBoxColumn.HeaderText = "LUONG";
            this.lUONGDataGridViewTextBoxColumn.Name = "lUONGDataGridViewTextBoxColumn";
            // 
            // mAPHONGDataGridViewTextBoxColumn
            // 
            this.mAPHONGDataGridViewTextBoxColumn.DataPropertyName = "MAPHONG";
            this.mAPHONGDataGridViewTextBoxColumn.HeaderText = "MAPHONG";
            this.mAPHONGDataGridViewTextBoxColumn.Name = "mAPHONGDataGridViewTextBoxColumn";
            this.mAPHONGDataGridViewTextBoxColumn.Width = 70;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 190;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qL_NVDataSet_nhanvien;
            // 
            // qL_NVDataSet_nhanvien
            // 
            this.qL_NVDataSet_nhanvien.DataSetName = "QL_NVDataSet_nhanvien";
            this.qL_NVDataSet_nhanvien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.tbemail);
            this.panel1.Controls.Add(this.tbsdt);
            this.panel1.Controls.Add(this.tbmaphong);
            this.panel1.Controls.Add(this.tbtienluong);
            this.panel1.Controls.Add(this.tbgioitinh);
            this.panel1.Controls.Add(this.tbngaysinh);
            this.panel1.Controls.Add(this.tbtennv);
            this.panel1.Controls.Add(this.tbmanv);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 181);
            this.panel1.TabIndex = 1;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(544, 135);
            this.tbemail.Multiline = true;
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(233, 25);
            this.tbemail.TabIndex = 15;
            // 
            // tbsdt
            // 
            this.tbsdt.Location = new System.Drawing.Point(544, 97);
            this.tbsdt.Multiline = true;
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(233, 25);
            this.tbsdt.TabIndex = 14;
            // 
            // tbmaphong
            // 
            this.tbmaphong.Location = new System.Drawing.Point(544, 59);
            this.tbmaphong.Multiline = true;
            this.tbmaphong.Name = "tbmaphong";
            this.tbmaphong.Size = new System.Drawing.Size(233, 25);
            this.tbmaphong.TabIndex = 13;
            // 
            // tbtienluong
            // 
            this.tbtienluong.Location = new System.Drawing.Point(544, 21);
            this.tbtienluong.Multiline = true;
            this.tbtienluong.Name = "tbtienluong";
            this.tbtienluong.Size = new System.Drawing.Size(233, 23);
            this.tbtienluong.TabIndex = 12;
            // 
            // tbgioitinh
            // 
            this.tbgioitinh.Location = new System.Drawing.Point(132, 135);
            this.tbgioitinh.Multiline = true;
            this.tbgioitinh.Name = "tbgioitinh";
            this.tbgioitinh.Size = new System.Drawing.Size(233, 23);
            this.tbgioitinh.TabIndex = 11;
            // 
            // tbngaysinh
            // 
            this.tbngaysinh.Location = new System.Drawing.Point(132, 97);
            this.tbngaysinh.Multiline = true;
            this.tbngaysinh.Name = "tbngaysinh";
            this.tbngaysinh.Size = new System.Drawing.Size(233, 23);
            this.tbngaysinh.TabIndex = 10;
            // 
            // tbtennv
            // 
            this.tbtennv.Location = new System.Drawing.Point(132, 59);
            this.tbtennv.Multiline = true;
            this.tbtennv.Name = "tbtennv";
            this.tbtennv.Size = new System.Drawing.Size(233, 23);
            this.tbtennv.TabIndex = 9;
            // 
            // tbmanv
            // 
            this.tbmanv.Enabled = false;
            this.tbmanv.Location = new System.Drawing.Point(132, 21);
            this.tbmanv.Multiline = true;
            this.tbmanv.Name = "tbmanv";
            this.tbmanv.Size = new System.Drawing.Size(233, 23);
            this.tbmanv.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Aqua;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tiền Lương";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Aqua;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã phòng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Aqua;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(430, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "SĐT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Aqua;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(430, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "giới tính";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Aqua;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ngày sinh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Aqua;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(2, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 72);
            this.panel2.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(264, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 47);
            this.button5.TabIndex = 4;
            this.button5.Text = "SỬA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(752, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "TÌM KIỂM";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(508, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "XÓA";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "THÊM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "nhanvien";
            this.Text = "nhanvien";
            this.Load += new System.EventHandler(this.nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NVDataSet_nhanvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QL_NVDataSet_nhanvien qL_NVDataSet_nhanvien;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QL_NVDataSet_nhanvienTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hOVNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gTDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAPHONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.TextBox tbmaphong;
        private System.Windows.Forms.TextBox tbtienluong;
        private System.Windows.Forms.TextBox tbgioitinh;
        private System.Windows.Forms.TextBox tbngaysinh;
        private System.Windows.Forms.TextBox tbtennv;
        private System.Windows.Forms.TextBox tbmanv;
        private System.Windows.Forms.Button button5;
    }
}