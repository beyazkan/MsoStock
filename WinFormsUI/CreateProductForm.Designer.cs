namespace WinFormsUI
{
    partial class CreateProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProductForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddUsefulType = new System.Windows.Forms.Button();
            this.btnAddProductType = new System.Windows.Forms.Button();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nUDWarranty = new System.Windows.Forms.NumericUpDown();
            this.cbxUsefulType = new System.Windows.Forms.ComboBox();
            this.cbxProductType = new System.Windows.Forms.ComboBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxMarks = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDWarranty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddUsefulType);
            this.groupBox1.Controls.Add(this.btnAddProductType);
            this.groupBox1.Controls.Add(this.tbxPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nUDWarranty);
            this.groupBox1.Controls.Add(this.cbxUsefulType);
            this.groupBox1.Controls.Add(this.cbxProductType);
            this.groupBox1.Controls.Add(this.tbxModel);
            this.groupBox1.Controls.Add(this.tbxMarks);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Oluştur";
            // 
            // btnAddUsefulType
            // 
            this.btnAddUsefulType.Location = new System.Drawing.Point(369, 130);
            this.btnAddUsefulType.Name = "btnAddUsefulType";
            this.btnAddUsefulType.Size = new System.Drawing.Size(24, 21);
            this.btnAddUsefulType.TabIndex = 16;
            this.btnAddUsefulType.Text = "+";
            this.btnAddUsefulType.UseVisualStyleBackColor = true;
            // 
            // btnAddProductType
            // 
            this.btnAddProductType.Location = new System.Drawing.Point(369, 102);
            this.btnAddProductType.Name = "btnAddProductType";
            this.btnAddProductType.Size = new System.Drawing.Size(24, 21);
            this.btnAddProductType.TabIndex = 15;
            this.btnAddProductType.Text = "+";
            this.btnAddProductType.UseVisualStyleBackColor = true;
            this.btnAddProductType.Click += new System.EventHandler(this.btnAddProductType_Click);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(93, 184);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(269, 20);
            this.tbxPrice.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Yıl";
            // 
            // nUDWarranty
            // 
            this.nUDWarranty.Location = new System.Drawing.Point(93, 157);
            this.nUDWarranty.Name = "nUDWarranty";
            this.nUDWarranty.Size = new System.Drawing.Size(38, 20);
            this.nUDWarranty.TabIndex = 12;
            this.nUDWarranty.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cbxUsefulType
            // 
            this.cbxUsefulType.FormattingEnabled = true;
            this.cbxUsefulType.Location = new System.Drawing.Point(93, 130);
            this.cbxUsefulType.Name = "cbxUsefulType";
            this.cbxUsefulType.Size = new System.Drawing.Size(269, 21);
            this.cbxUsefulType.TabIndex = 11;
            // 
            // cbxProductType
            // 
            this.cbxProductType.FormattingEnabled = true;
            this.cbxProductType.Location = new System.Drawing.Point(93, 102);
            this.cbxProductType.Name = "cbxProductType";
            this.cbxProductType.Size = new System.Drawing.Size(269, 21);
            this.cbxProductType.TabIndex = 10;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(93, 77);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(269, 20);
            this.tbxModel.TabIndex = 9;
            // 
            // tbxMarks
            // 
            this.tbxMarks.Location = new System.Drawing.Point(93, 52);
            this.tbxMarks.Name = "tbxMarks";
            this.tbxMarks.Size = new System.Drawing.Size(269, 20);
            this.tbxMarks.TabIndex = 8;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(93, 27);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(269, 20);
            this.tbxName.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(287, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Oluştur";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fiyatı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Garanti Süresi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kullanım Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Tipi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modeli :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Markası :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // CreateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 288);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProductForm";
            this.Text = "Ürün Oluştur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDWarranty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nUDWarranty;
        private System.Windows.Forms.ComboBox cbxUsefulType;
        private System.Windows.Forms.ComboBox cbxProductType;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxMarks;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddUsefulType;
        private System.Windows.Forms.Button btnAddProductType;
    }
}