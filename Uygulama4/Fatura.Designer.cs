namespace Uygulama4
{
    partial class Fatura
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
            this.fis = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // fis
            // 
            this.fis.FormattingEnabled = true;
            this.fis.Location = new System.Drawing.Point(27, 25);
            this.fis.Name = "fis";
            this.fis.Size = new System.Drawing.Size(738, 394);
            this.fis.TabIndex = 0;
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fis);
            this.Name = "Fatura";
            this.Text = "Fatura";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox fis;
    }
}