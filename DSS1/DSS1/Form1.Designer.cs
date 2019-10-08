namespace DSS1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLMệnhĐềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qLLuậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suyDiễnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtThúcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLMệnhĐềToolStripMenuItem,
            this.qLLuậtToolStripMenuItem,
            this.suyDiễnToolStripMenuItem,
            this.kếtThúcToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // qLMệnhĐềToolStripMenuItem
            // 
            this.qLMệnhĐềToolStripMenuItem.Name = "qLMệnhĐềToolStripMenuItem";
            this.qLMệnhĐềToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.qLMệnhĐềToolStripMenuItem.Text = "QL Mệnh đề";
            this.qLMệnhĐềToolStripMenuItem.Click += new System.EventHandler(this.qLMệnhĐềToolStripMenuItem_Click);
            // 
            // qLLuậtToolStripMenuItem
            // 
            this.qLLuậtToolStripMenuItem.Name = "qLLuậtToolStripMenuItem";
            this.qLLuậtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.qLLuậtToolStripMenuItem.Text = "QL Luật";
            this.qLLuậtToolStripMenuItem.Click += new System.EventHandler(this.qLLuậtToolStripMenuItem_Click);
            // 
            // suyDiễnToolStripMenuItem
            // 
            this.suyDiễnToolStripMenuItem.Name = "suyDiễnToolStripMenuItem";
            this.suyDiễnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.suyDiễnToolStripMenuItem.Text = "Suy diễn";
            this.suyDiễnToolStripMenuItem.Click += new System.EventHandler(this.suyDiễnToolStripMenuItem_Click);
            // 
            // kếtThúcToolStripMenuItem
            // 
            this.kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            this.kếtThúcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kếtThúcToolStripMenuItem.Text = "Kết thúc";
            this.kếtThúcToolStripMenuItem.Click += new System.EventHandler(this.kếtThúcToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLMệnhĐềToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qLLuậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suyDiễnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtThúcToolStripMenuItem;
    }
}

