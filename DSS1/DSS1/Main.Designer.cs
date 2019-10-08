namespace DSS1
{
    partial class Main
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
            this.clbSuKienDaBiet = new System.Windows.Forms.CheckedListBox();
            this.clbSuKienChuaBiet = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDienGiai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSuyLuan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các sự kiện đã biệt";
            // 
            // clbSuKienDaBiet
            // 
            this.clbSuKienDaBiet.CheckOnClick = true;
            this.clbSuKienDaBiet.FormattingEnabled = true;
            this.clbSuKienDaBiet.Location = new System.Drawing.Point(13, 30);
            this.clbSuKienDaBiet.Name = "clbSuKienDaBiet";
            this.clbSuKienDaBiet.Size = new System.Drawing.Size(187, 499);
            this.clbSuKienDaBiet.TabIndex = 1;
            // 
            // clbSuKienChuaBiet
            // 
            this.clbSuKienChuaBiet.CheckOnClick = true;
            this.clbSuKienChuaBiet.FormattingEnabled = true;
            this.clbSuKienChuaBiet.Location = new System.Drawing.Point(206, 30);
            this.clbSuKienChuaBiet.Name = "clbSuKienChuaBiet";
            this.clbSuKienChuaBiet.Size = new System.Drawing.Size(187, 499);
            this.clbSuKienChuaBiet.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Các sự kiện chưa biết";
            // 
            // tbDienGiai
            // 
            this.tbDienGiai.Location = new System.Drawing.Point(400, 30);
            this.tbDienGiai.Multiline = true;
            this.tbDienGiai.Name = "tbDienGiai";
            this.tbDienGiai.Size = new System.Drawing.Size(690, 544);
            this.tbDienGiai.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Diễn giải kết quả";
            // 
            // btSuyLuan
            // 
            this.btSuyLuan.Location = new System.Drawing.Point(12, 536);
            this.btSuyLuan.Name = "btSuyLuan";
            this.btSuyLuan.Size = new System.Drawing.Size(381, 38);
            this.btSuyLuan.TabIndex = 6;
            this.btSuyLuan.Text = "Suy luận";
            this.btSuyLuan.UseVisualStyleBackColor = true;
            this.btSuyLuan.Click += new System.EventHandler(this.btSuyLuan_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 590);
            this.Controls.Add(this.btSuyLuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDienGiai);
            this.Controls.Add(this.clbSuKienChuaBiet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clbSuKienDaBiet);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbSuKienDaBiet;
        private System.Windows.Forms.CheckedListBox clbSuKienChuaBiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDienGiai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSuyLuan;
    }
}