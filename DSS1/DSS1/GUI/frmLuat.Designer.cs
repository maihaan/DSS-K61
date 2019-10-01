namespace DSS1.GUI
{
    partial class frmLuat
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMoTa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVePhai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.clbVeTrai = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên luật";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(16, 30);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(451, 20);
            this.tbTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả";
            // 
            // tbMoTa
            // 
            this.tbMoTa.Location = new System.Drawing.Point(16, 74);
            this.tbMoTa.Multiline = true;
            this.tbMoTa.Name = "tbMoTa";
            this.tbMoTa.Size = new System.Drawing.Size(451, 78);
            this.tbMoTa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vế phải";
            // 
            // cbVePhai
            // 
            this.cbVePhai.FormattingEnabled = true;
            this.cbVePhai.Location = new System.Drawing.Point(16, 176);
            this.cbVePhai.Name = "cbVePhai";
            this.cbVePhai.Size = new System.Drawing.Size(451, 21);
            this.cbVePhai.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vế trái";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(474, 12);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(677, 562);
            this.dgvDanhSach.TabIndex = 11;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(76, 546);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 28);
            this.btThem.TabIndex = 12;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(157, 546);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 28);
            this.btLuu.TabIndex = 13;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(238, 546);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 28);
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btLamMoi
            // 
            this.btLamMoi.Location = new System.Drawing.Point(319, 546);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(75, 28);
            this.btLamMoi.TabIndex = 15;
            this.btLamMoi.Text = "Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            // 
            // clbVeTrai
            // 
            this.clbVeTrai.FormattingEnabled = true;
            this.clbVeTrai.Location = new System.Drawing.Point(16, 221);
            this.clbVeTrai.Name = "clbVeTrai";
            this.clbVeTrai.Size = new System.Drawing.Size(451, 319);
            this.clbVeTrai.TabIndex = 16;
            // 
            // frmLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 586);
            this.Controls.Add(this.clbVeTrai);
            this.Controls.Add(this.btLamMoi);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbVePhai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMoTa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.label1);
            this.Name = "frmLuat";
            this.Text = "frmLuat";
            this.Load += new System.EventHandler(this.frmLuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMoTa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVePhai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.CheckedListBox clbVeTrai;
    }
}