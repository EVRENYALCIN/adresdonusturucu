namespace _30_MetinCevirici
{
    partial class AdresDonusturucu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdresDonusturucu));
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtBuyukAdres = new System.Windows.Forms.TextBox();
            this.txtKucukAdres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(0, 2);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(577, 72);
            this.txtAdres.TabIndex = 0;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            // 
            // txtBuyukAdres
            // 
            this.txtBuyukAdres.Location = new System.Drawing.Point(0, 73);
            this.txtBuyukAdres.Multiline = true;
            this.txtBuyukAdres.Name = "txtBuyukAdres";
            this.txtBuyukAdres.Size = new System.Drawing.Size(577, 72);
            this.txtBuyukAdres.TabIndex = 1;
            // 
            // txtKucukAdres
            // 
            this.txtKucukAdres.Location = new System.Drawing.Point(1, 144);
            this.txtKucukAdres.Multiline = true;
            this.txtKucukAdres.Name = "txtKucukAdres";
            this.txtKucukAdres.Size = new System.Drawing.Size(577, 72);
            this.txtKucukAdres.TabIndex = 2;
            // 
            // AdresDonusturucu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 214);
            this.Controls.Add(this.txtKucukAdres);
            this.Controls.Add(this.txtBuyukAdres);
            this.Controls.Add(this.txtAdres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdresDonusturucu";
            this.Text = "Adres Dönüştürücü";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtBuyukAdres;
        private System.Windows.Forms.TextBox txtKucukAdres;
    }
}

