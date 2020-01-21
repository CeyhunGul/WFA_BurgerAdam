namespace WFA_BurgerAdam.UIForm
{
    partial class HomeForm
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
            this.menuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişDetaylarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEkleToolStripMenuItem,
            this.siparişVerToolStripMenuItem,
            this.siparişDetaylarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuEkleToolStripMenuItem
            // 
            this.menuEkleToolStripMenuItem.Name = "menuEkleToolStripMenuItem";
            this.menuEkleToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.menuEkleToolStripMenuItem.Text = "Menu Ekle";
            this.menuEkleToolStripMenuItem.Click += new System.EventHandler(this.menuEkleToolStripMenuItem_Click);
            // 
            // siparişVerToolStripMenuItem
            // 
            this.siparişVerToolStripMenuItem.Name = "siparişVerToolStripMenuItem";
            this.siparişVerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.siparişVerToolStripMenuItem.Text = "Sipariş Ver";
            this.siparişVerToolStripMenuItem.Click += new System.EventHandler(this.siparişVerToolStripMenuItem_Click);
            // 
            // siparişDetaylarToolStripMenuItem
            // 
            this.siparişDetaylarToolStripMenuItem.Name = "siparişDetaylarToolStripMenuItem";
            this.siparişDetaylarToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.siparişDetaylarToolStripMenuItem.Text = "Sipariş Detaylar";
            this.siparişDetaylarToolStripMenuItem.Click += new System.EventHandler(this.siparişDetaylarToolStripMenuItem_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 630);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "Hoş Geldiniz";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişVerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişDetaylarToolStripMenuItem;
    }
}