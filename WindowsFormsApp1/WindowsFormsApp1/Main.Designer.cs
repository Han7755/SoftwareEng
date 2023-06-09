namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.가공식품검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.레시피검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.병원검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.개인정보등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.가공식품검색ToolStripMenuItem,
            this.레시피검색ToolStripMenuItem,
            this.병원검색ToolStripMenuItem,
            this.개인정보등록ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 가공식품검색ToolStripMenuItem
            // 
            this.가공식품검색ToolStripMenuItem.Name = "가공식품검색ToolStripMenuItem";
            this.가공식품검색ToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.가공식품검색ToolStripMenuItem.Text = "가공식품 검색";
            this.가공식품검색ToolStripMenuItem.Click += new System.EventHandler(this.가공식품검색ToolStripMenuItem_Click);
            // 
            // 레시피검색ToolStripMenuItem
            // 
            this.레시피검색ToolStripMenuItem.Name = "레시피검색ToolStripMenuItem";
            this.레시피검색ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.레시피검색ToolStripMenuItem.Text = "레시피 검색";
            this.레시피검색ToolStripMenuItem.Click += new System.EventHandler(this.레시피검색ToolStripMenuItem_Click);
            // 
            // 병원검색ToolStripMenuItem
            // 
            this.병원검색ToolStripMenuItem.Name = "병원검색ToolStripMenuItem";
            this.병원검색ToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.병원검색ToolStripMenuItem.Text = "병원 검색";
            // 
            // 개인정보등록ToolStripMenuItem
            // 
            this.개인정보등록ToolStripMenuItem.Name = "개인정보등록ToolStripMenuItem";
            this.개인정보등록ToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.개인정보등록ToolStripMenuItem.Text = "개인정보 등록";
            this.개인정보등록ToolStripMenuItem.Click += new System.EventHandler(this.개인정보등록ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 가공식품검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 레시피검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 병원검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 개인정보등록ToolStripMenuItem;
    }
}