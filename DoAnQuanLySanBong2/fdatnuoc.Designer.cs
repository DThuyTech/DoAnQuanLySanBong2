namespace DoAnQuanLySanBong2
{
    partial class fdatnuoc
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudSoluong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGiatien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ccbNuoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgLoadnuoc = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLoadnuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 117);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nudSoluong);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(402, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 40);
            this.panel4.TabIndex = 2;
            // 
            // nudSoluong
            // 
            this.nudSoluong.Location = new System.Drawing.Point(202, 10);
            this.nudSoluong.Name = "nudSoluong";
            this.nudSoluong.Size = new System.Drawing.Size(120, 22);
            this.nudSoluong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "So luong";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtGiatien);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 40);
            this.panel3.TabIndex = 1;
            // 
            // txtGiatien
            // 
            this.txtGiatien.Location = new System.Drawing.Point(178, 7);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(212, 22);
            this.txtGiatien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gia tien";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ccbNuoc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 40);
            this.panel2.TabIndex = 0;
            // 
            // ccbNuoc
            // 
            this.ccbNuoc.FormattingEnabled = true;
            this.ccbNuoc.Location = new System.Drawing.Point(178, 9);
            this.ccbNuoc.Name = "ccbNuoc";
            this.ccbNuoc.Size = new System.Drawing.Size(212, 24);
            this.ccbNuoc.TabIndex = 1;
            this.ccbNuoc.SelectedValueChanged += new System.EventHandler(this.ccbNuoc_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten nuoc";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(745, 135);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(459, 346);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // dtgLoadnuoc
            // 
            this.dtgLoadnuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLoadnuoc.Location = new System.Drawing.Point(12, 135);
            this.dtgLoadnuoc.Name = "dtgLoadnuoc";
            this.dtgLoadnuoc.RowHeadersWidth = 51;
            this.dtgLoadnuoc.RowTemplate.Height = 24;
            this.dtgLoadnuoc.Size = new System.Drawing.Size(727, 346);
            this.dtgLoadnuoc.TabIndex = 2;
            this.dtgLoadnuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLoadnuoc_CellContentClick);
            // 
            // fdatnuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 493);
            this.Controls.Add(this.dtgLoadnuoc);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Name = "fdatnuoc";
            this.Text = "fdatnuoc";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLoadnuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dtgLoadnuoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ccbNuoc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtGiatien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nudSoluong;
        private System.Windows.Forms.Label label3;
    }
}