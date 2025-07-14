namespace WindowsForms
{
    partial class Form8
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.girişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem,
            this.kategoriYönetimiToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // girişToolStripMenuItem
            // 
            this.girişToolStripMenuItem.Name = "girişToolStripMenuItem";
            this.girişToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.girişToolStripMenuItem.Text = "Giriş";
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünListesiToolStripMenuItem,
            this.yeniEkleToolStripMenuItem});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // ürünListesiToolStripMenuItem
            // 
            this.ürünListesiToolStripMenuItem.Name = "ürünListesiToolStripMenuItem";
            this.ürünListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ürünListesiToolStripMenuItem.Text = "Ürün Listesi";
            // 
            // yeniEkleToolStripMenuItem
            // 
            this.yeniEkleToolStripMenuItem.Name = "yeniEkleToolStripMenuItem";
            this.yeniEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniEkleToolStripMenuItem.Text = "Yeni Ekle";
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            this.kategoriYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriListesiToolStripMenuItem,
            this.yeniEkleToolStripMenuItem1});
            this.kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            this.kategoriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            // 
            // kategoriListesiToolStripMenuItem
            // 
            this.kategoriListesiToolStripMenuItem.Name = "kategoriListesiToolStripMenuItem";
            this.kategoriListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kategoriListesiToolStripMenuItem.Text = "Kategori Listesi";
            // 
            // yeniEkleToolStripMenuItem1
            // 
            this.yeniEkleToolStripMenuItem1.Name = "yeniEkleToolStripMenuItem1";
            this.yeniEkleToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.yeniEkleToolStripMenuItem1.Text = "Yeni Ekle";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(249, 187);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 58);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Context menü sağ tık menüsü yapar";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seçToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.kesToolStripMenuItem,
            this.yapıştırToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 136);
            // 
            // seçToolStripMenuItem
            // 
            this.seçToolStripMenuItem.Name = "seçToolStripMenuItem";
            this.seçToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seçToolStripMenuItem.Text = "Seç";
            this.seçToolStripMenuItem.Click += new System.EventHandler(this.seçToolStripMenuItem_Click);
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kopyalaToolStripMenuItem.Text = "Kopyala";
            this.kopyalaToolStripMenuItem.Click += new System.EventHandler(this.kopyalaToolStripMenuItem_Click);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yapıştırToolStripMenuItem.Text = "Yapıştır";
            this.yapıştırToolStripMenuItem.Click += new System.EventHandler(this.yapıştırToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}