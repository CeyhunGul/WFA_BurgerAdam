namespace WFA_BurgerAdam
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdmLarge = new System.Windows.Forms.RadioButton();
            this.rdmXLarge = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lstOrderList = new System.Windows.Forms.ListBox();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lvlTotalPrice = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 139);
            this.label1.TabIndex = 0;
            this.label1.Text = "Burger Adam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMenu
            // 
            this.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(65, 167);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(247, 21);
            this.cmbMenu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menü:";
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Checked = true;
            this.rdbMedium.Location = new System.Drawing.Point(24, 205);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(45, 17);
            this.rdbMedium.TabIndex = 3;
            this.rdbMedium.TabStop = true;
            this.rdbMedium.Text = "Orta";
            this.rdbMedium.UseVisualStyleBackColor = true;
            // 
            // rdmLarge
            // 
            this.rdmLarge.AutoSize = true;
            this.rdmLarge.Location = new System.Drawing.Point(118, 205);
            this.rdmLarge.Name = "rdmLarge";
            this.rdmLarge.Size = new System.Drawing.Size(55, 17);
            this.rdmLarge.TabIndex = 3;
            this.rdmLarge.Text = "Büyük";
            this.rdmLarge.UseVisualStyleBackColor = true;
            // 
            // rdmXLarge
            // 
            this.rdmXLarge.AutoSize = true;
            this.rdmXLarge.Location = new System.Drawing.Point(225, 205);
            this.rdmXLarge.Name = "rdmXLarge";
            this.rdmXLarge.Size = new System.Drawing.Size(46, 17);
            this.rdmXLarge.TabIndex = 3;
            this.rdmXLarge.Text = "King";
            this.rdmXLarge.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adet:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(48, 381);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(79, 20);
            this.nudQuantity.TabIndex = 6;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(139, 378);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(173, 23);
            this.btnAddOrder.TabIndex = 7;
            this.btnAddOrder.Text = "SİPARİŞ EKLE";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
            // 
            // lstOrderList
            // 
            this.lstOrderList.FormattingEnabled = true;
            this.lstOrderList.Location = new System.Drawing.Point(332, 13);
            this.lstOrderList.Name = "lstOrderList";
            this.lstOrderList.Size = new System.Drawing.Size(669, 342);
            this.lstOrderList.TabIndex = 8;
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(828, 361);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(173, 23);
            this.btnTamamla.TabIndex = 7;
            this.btnTamamla.Text = "Sipariş Ver";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.BtnCompleteOrder_Click);
            // 
            // lvlTotalPrice
            // 
            this.lvlTotalPrice.AutoSize = true;
            this.lvlTotalPrice.Location = new System.Drawing.Point(415, 358);
            this.lvlTotalPrice.Name = "lvlTotalPrice";
            this.lvlTotalPrice.Size = new System.Drawing.Size(0, 13);
            this.lvlTotalPrice.TabIndex = 5;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(342, 358);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(67, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Toplam Fiyat";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 238);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 117);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 648);
            this.Controls.Add(this.rdbMedium);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rdmLarge);
            this.Controls.Add(this.rdmXLarge);
            this.Controls.Add(this.lstOrderList);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lvlTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sipariş Ver";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdmLarge;
        private System.Windows.Forms.RadioButton rdmXLarge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAddOrder;
        public System.Windows.Forms.ListBox lstOrderList;
        private System.Windows.Forms.Button btnTamamla;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lvlTotalPrice;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

