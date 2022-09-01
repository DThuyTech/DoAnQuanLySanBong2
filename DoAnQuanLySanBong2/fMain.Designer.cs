
namespace DoAnQuanLySanBong2
{
    partial class fMain
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
            this.gbThongtin = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuyluusan = new System.Windows.Forms.Button();
            this.btnLuusan = new System.Windows.Forms.Button();
            this.btnSuasan = new System.Windows.Forms.Button();
            this.btnXoasan = new System.Windows.Forms.Button();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.txtTensan = new System.Windows.Forms.TextBox();
            this.txtLoaisan = new System.Windows.Forms.TextBox();
            this.txtMasan = new System.Windows.Forms.TextBox();
            this.labelTrangthai = new System.Windows.Forms.Label();
            this.labelLoaisan = new System.Windows.Forms.Label();
            this.labelTensan = new System.Windows.Forms.Label();
            this.labelMasan = new System.Windows.Forms.Label();
            this.qLSBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbThongtin
            // 
            this.gbThongtin.Controls.Add(this.dataGridView1);
            this.gbThongtin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongtin.Location = new System.Drawing.Point(9, 2);
            this.gbThongtin.Name = "gbThongtin";
            this.gbThongtin.Size = new System.Drawing.Size(812, 274);
            this.gbThongtin.TabIndex = 0;
            this.gbThongtin.TabStop = false;
            this.gbThongtin.Text = "Thông tin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masanDataGridViewTextBoxColumn,
            this.tensanDataGridViewTextBoxColumn,
            this.maloaiDataGridViewTextBoxColumn,
            this.trangthaiDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.sanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(790, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnHuyluusan);
            this.groupBox1.Controls.Add(this.btnLuusan);
            this.groupBox1.Controls.Add(this.btnSuasan);
            this.groupBox1.Controls.Add(this.btnXoasan);
            this.groupBox1.Controls.Add(this.txtTrangthai);
            this.groupBox1.Controls.Add(this.txtTensan);
            this.groupBox1.Controls.Add(this.txtLoaisan);
            this.groupBox1.Controls.Add(this.txtMasan);
            this.groupBox1.Controls.Add(this.labelTrangthai);
            this.groupBox1.Controls.Add(this.labelLoaisan);
            this.groupBox1.Controls.Add(this.labelTensan);
            this.groupBox1.Controls.Add(this.labelMasan);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(404, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuyluusan
            // 
            this.btnHuyluusan.Enabled = false;
            this.btnHuyluusan.Location = new System.Drawing.Point(728, 19);
            this.btnHuyluusan.Name = "btnHuyluusan";
            this.btnHuyluusan.Size = new System.Drawing.Size(75, 23);
            this.btnHuyluusan.TabIndex = 12;
            this.btnHuyluusan.Text = "Huỷ lưu";
            this.btnHuyluusan.UseVisualStyleBackColor = true;
            this.btnHuyluusan.Click += new System.EventHandler(this.btnHuyluusan_Click);
            // 
            // btnLuusan
            // 
            this.btnLuusan.Enabled = false;
            this.btnLuusan.Location = new System.Drawing.Point(647, 19);
            this.btnLuusan.Name = "btnLuusan";
            this.btnLuusan.Size = new System.Drawing.Size(75, 23);
            this.btnLuusan.TabIndex = 11;
            this.btnLuusan.Text = "Lưu";
            this.btnLuusan.UseVisualStyleBackColor = true;
            this.btnLuusan.Click += new System.EventHandler(this.btnLuusan_Click);
            // 
            // btnSuasan
            // 
            this.btnSuasan.Location = new System.Drawing.Point(566, 19);
            this.btnSuasan.Name = "btnSuasan";
            this.btnSuasan.Size = new System.Drawing.Size(75, 23);
            this.btnSuasan.TabIndex = 10;
            this.btnSuasan.Text = "Sửa";
            this.btnSuasan.UseVisualStyleBackColor = true;
            this.btnSuasan.Click += new System.EventHandler(this.btnSuasan_Click);
            // 
            // btnXoasan
            // 
            this.btnXoasan.Location = new System.Drawing.Point(485, 19);
            this.btnXoasan.Name = "btnXoasan";
            this.btnXoasan.Size = new System.Drawing.Size(75, 23);
            this.btnXoasan.TabIndex = 9;
            this.btnXoasan.Text = "Xoá";
            this.btnXoasan.UseVisualStyleBackColor = true;
            this.btnXoasan.Click += new System.EventHandler(this.btnXoasan_Click);
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(276, 99);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(100, 26);
            this.txtTrangthai.TabIndex = 7;
            // 
            // txtTensan
            // 
            this.txtTensan.Location = new System.Drawing.Point(276, 24);
            this.txtTensan.Name = "txtTensan";
            this.txtTensan.Size = new System.Drawing.Size(100, 26);
            this.txtTensan.TabIndex = 5;
            // 
            // txtLoaisan
            // 
            this.txtLoaisan.Location = new System.Drawing.Point(89, 99);
            this.txtLoaisan.Name = "txtLoaisan";
            this.txtLoaisan.Size = new System.Drawing.Size(100, 26);
            this.txtLoaisan.TabIndex = 6;
            // 
            // txtMasan
            // 
            this.txtMasan.Location = new System.Drawing.Point(84, 19);
            this.txtMasan.Name = "txtMasan";
            this.txtMasan.Size = new System.Drawing.Size(100, 26);
            this.txtMasan.TabIndex = 4;
            this.txtMasan.TextChanged += new System.EventHandler(this.txtMasan_TextChanged);
            // 
            // labelTrangthai
            // 
            this.labelTrangthai.AutoSize = true;
            this.labelTrangthai.Location = new System.Drawing.Point(198, 102);
            this.labelTrangthai.Name = "labelTrangthai";
            this.labelTrangthai.Size = new System.Drawing.Size(80, 18);
            this.labelTrangthai.TabIndex = 3;
            this.labelTrangthai.Text = "Trạng thái:";
            // 
            // labelLoaisan
            // 
            this.labelLoaisan.AutoSize = true;
            this.labelLoaisan.Location = new System.Drawing.Point(19, 107);
            this.labelLoaisan.Name = "labelLoaisan";
            this.labelLoaisan.Size = new System.Drawing.Size(72, 18);
            this.labelLoaisan.TabIndex = 2;
            this.labelLoaisan.Text = "Loại sân:";
            // 
            // labelTensan
            // 
            this.labelTensan.AutoSize = true;
            this.labelTensan.Location = new System.Drawing.Point(211, 27);
            this.labelTensan.Name = "labelTensan";
            this.labelTensan.Size = new System.Drawing.Size(67, 18);
            this.labelTensan.TabIndex = 1;
            this.labelTensan.Text = "Tên sân:";
            // 
            // labelMasan
            // 
            this.labelMasan.AutoSize = true;
            this.labelMasan.Location = new System.Drawing.Point(19, 27);
            this.labelMasan.Name = "labelMasan";
            this.labelMasan.Size = new System.Drawing.Size(63, 18);
            this.labelMasan.TabIndex = 0;
            this.labelMasan.Text = "Mã sân:";
            // 
            // qLSBDataSet
            // 
            // 
            // qLSBDataSetBindingSource
            // 
            this.qLSBDataSetBindingSource.Position = 0;
            // 
            // qLSBDataSet1
            // 
            // 
            // sanBindingSource
            // 
            this.sanBindingSource.DataMember = "San";
            // 
            // sanTableAdapter
            // 
            // 
            // masanDataGridViewTextBoxColumn
            // 
            this.masanDataGridViewTextBoxColumn.DataPropertyName = "masan";
            this.masanDataGridViewTextBoxColumn.HeaderText = "Mã sân";
            this.masanDataGridViewTextBoxColumn.Name = "masanDataGridViewTextBoxColumn";
            this.masanDataGridViewTextBoxColumn.ReadOnly = true;
            this.masanDataGridViewTextBoxColumn.Width = 200;
            // 
            // tensanDataGridViewTextBoxColumn
            // 
            this.tensanDataGridViewTextBoxColumn.DataPropertyName = "tensan";
            this.tensanDataGridViewTextBoxColumn.HeaderText = "Tên sân";
            this.tensanDataGridViewTextBoxColumn.Name = "tensanDataGridViewTextBoxColumn";
            this.tensanDataGridViewTextBoxColumn.Width = 200;
            // 
            // maloaiDataGridViewTextBoxColumn
            // 
            this.maloaiDataGridViewTextBoxColumn.DataPropertyName = "maloai";
            this.maloaiDataGridViewTextBoxColumn.HeaderText = "Mã loại";
            this.maloaiDataGridViewTextBoxColumn.Name = "maloaiDataGridViewTextBoxColumn";
            this.maloaiDataGridViewTextBoxColumn.Width = 200;
            // 
            // trangthaiDataGridViewCheckBoxColumn
            // 
            this.trangthaiDataGridViewCheckBoxColumn.DataPropertyName = "trangthai";
            this.trangthaiDataGridViewCheckBoxColumn.HeaderText = "Trạng thái";
            this.trangthaiDataGridViewCheckBoxColumn.Name = "trangthaiDataGridViewCheckBoxColumn";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbThongtin);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sân";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.gbThongtin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongtin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuyluusan;
        private System.Windows.Forms.Button btnLuusan;
        private System.Windows.Forms.Button btnSuasan;
        private System.Windows.Forms.Button btnXoasan;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.TextBox txtTensan;
        private System.Windows.Forms.TextBox txtLoaisan;
        private System.Windows.Forms.TextBox txtMasan;
        private System.Windows.Forms.Label labelTrangthai;
        private System.Windows.Forms.Label labelLoaisan;
        private System.Windows.Forms.Label labelTensan;
        private System.Windows.Forms.Label labelMasan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.BindingSource qLSBDataSetBindingSource;


        private System.Windows.Forms.BindingSource sanBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn masanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangthaiDataGridViewCheckBoxColumn;
    }
}

