namespace WFA_BurgerAdam.UIForm
{
    partial class OrdersDetails
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSoldMenuCount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalPriceOfExtraMaterial = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalOrderCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiro = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSoldMenuCount);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(561, 324);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 88);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Satılan Ürün Adedi:";
            // 
            // txtSoldMenuCount
            // 
            this.txtSoldMenuCount.AutoSize = true;
            this.txtSoldMenuCount.Location = new System.Drawing.Point(70, 43);
            this.txtSoldMenuCount.Name = "txtSoldMenuCount";
            this.txtSoldMenuCount.Size = new System.Drawing.Size(70, 26);
            this.txtSoldMenuCount.TabIndex = 0;
            this.txtSoldMenuCount.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalPriceOfExtraMaterial);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(561, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 88);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extra Malzeme Geliri:";
            // 
            // txtTotalPriceOfExtraMaterial
            // 
            this.txtTotalPriceOfExtraMaterial.AutoSize = true;
            this.txtTotalPriceOfExtraMaterial.Location = new System.Drawing.Point(70, 50);
            this.txtTotalPriceOfExtraMaterial.Name = "txtTotalPriceOfExtraMaterial";
            this.txtTotalPriceOfExtraMaterial.Size = new System.Drawing.Size(70, 26);
            this.txtTotalPriceOfExtraMaterial.TabIndex = 0;
            this.txtTotalPriceOfExtraMaterial.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalOrderCount);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(561, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 88);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam Sipariş Sayısı:";
            // 
            // txtTotalOrderCount
            // 
            this.txtTotalOrderCount.AutoSize = true;
            this.txtTotalOrderCount.Location = new System.Drawing.Point(70, 41);
            this.txtTotalOrderCount.Name = "txtTotalOrderCount";
            this.txtTotalOrderCount.Size = new System.Drawing.Size(70, 26);
            this.txtTotalOrderCount.TabIndex = 0;
            this.txtTotalOrderCount.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiro);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(561, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 86);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciro";
            // 
            // txtGiro
            // 
            this.txtGiro.AutoSize = true;
            this.txtGiro.Location = new System.Drawing.Point(70, 28);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(70, 26);
            this.txtGiro.TabIndex = 0;
            this.txtGiro.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(494, 394);
            this.listBox1.TabIndex = 2;
            // 
            // OrdersDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 465);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "OrdersDetails";
            this.Text = "Siparişler";
            this.Load += new System.EventHandler(this.OrdersDetails_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label txtSoldMenuCount;
        private System.Windows.Forms.Label txtTotalPriceOfExtraMaterial;
        private System.Windows.Forms.Label txtTotalOrderCount;
        private System.Windows.Forms.Label txtGiro;
    }
}