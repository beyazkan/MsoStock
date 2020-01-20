namespace WinFormsUI
{
    partial class ListofStoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListofStoresForm));
            this.dgwListofStores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListofStores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwListofStores
            // 
            this.dgwListofStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListofStores.Location = new System.Drawing.Point(13, 142);
            this.dgwListofStores.Name = "dgwListofStores";
            this.dgwListofStores.Size = new System.Drawing.Size(362, 296);
            this.dgwListofStores.TabIndex = 0;
            // 
            // ListofStoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 450);
            this.Controls.Add(this.dgwListofStores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListofStoresForm";
            this.Text = "Depo Listesi";
            this.Load += new System.EventHandler(this.ListofStoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListofStores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwListofStores;
    }
}