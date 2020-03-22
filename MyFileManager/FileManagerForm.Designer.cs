namespace MyFileManager
{
    partial class FileManagerForm
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
            this.cbKlasorler = new System.Windows.Forms.ComboBox();
            this.lbDosyalar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbKlasorler
            // 
            this.cbKlasorler.BackColor = System.Drawing.Color.Bisque;
            this.cbKlasorler.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbKlasorler.FormattingEnabled = true;
            this.cbKlasorler.Location = new System.Drawing.Point(0, 0);
            this.cbKlasorler.Name = "cbKlasorler";
            this.cbKlasorler.Size = new System.Drawing.Size(391, 32);
            this.cbKlasorler.TabIndex = 0;
            this.cbKlasorler.SelectedIndexChanged += new System.EventHandler(this.cbKlasorler_SelectedIndexChanged);
            // 
            // lbDosyalar
            // 
            this.lbDosyalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDosyalar.FormattingEnabled = true;
            this.lbDosyalar.ItemHeight = 24;
            this.lbDosyalar.Location = new System.Drawing.Point(0, 32);
            this.lbDosyalar.Name = "lbDosyalar";
            this.lbDosyalar.Size = new System.Drawing.Size(391, 474);
            this.lbDosyalar.TabIndex = 1;
            this.lbDosyalar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbDosyalar_KeyDown);
            // 
            // FileManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 506);
            this.Controls.Add(this.lbDosyalar);
            this.Controls.Add(this.cbKlasorler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FileManagerForm";
            this.Text = "My File Manager";
            this.Load += new System.EventHandler(this.FileManagerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKlasorler;
        private System.Windows.Forms.ListBox lbDosyalar;
    }
}

