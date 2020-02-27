namespace ListeFormApp
{
    partial class ListeForm
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
            this.lbListe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbListe
            // 
            this.lbListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbListe.FormattingEnabled = true;
            this.lbListe.ItemHeight = 24;
            this.lbListe.Items.AddRange(new object[] {
            "Dubai",
            "Envai",
            "Mesai",
            "Nevai",
            "Recai",
            "Sezai"});
            this.lbListe.Location = new System.Drawing.Point(0, 0);
            this.lbListe.Name = "lbListe";
            this.lbListe.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbListe.Size = new System.Drawing.Size(230, 254);
            this.lbListe.TabIndex = 0;
            this.lbListe.SelectedIndexChanged += new System.EventHandler(this.lbListe_SelectedIndexChanged);
            this.lbListe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbListe_KeyDown);
            // 
            // ListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 254);
            this.Controls.Add(this.lbListe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ListeForm";
            this.Text = "Liste Form";
            this.Load += new System.EventHandler(this.ListeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListe;
    }
}

