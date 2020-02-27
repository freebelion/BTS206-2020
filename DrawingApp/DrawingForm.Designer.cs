namespace DrawingApp
{
    partial class DrawingForm
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
            this.UstPanel = new System.Windows.Forms.Panel();
            this.cbKalinlik = new System.Windows.Forms.ComboBox();
            this.rbSurekliCizgi = new System.Windows.Forms.RadioButton();
            this.rbKirikCizgi = new System.Windows.Forms.RadioButton();
            this.CizimPaneli = new System.Windows.Forms.Panel();
            this.dlgRenk = new System.Windows.Forms.ColorDialog();
            this.btnRenk = new System.Windows.Forms.Button();
            this.UstPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UstPanel
            // 
            this.UstPanel.BackColor = System.Drawing.Color.SeaShell;
            this.UstPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UstPanel.Controls.Add(this.btnRenk);
            this.UstPanel.Controls.Add(this.cbKalinlik);
            this.UstPanel.Controls.Add(this.rbSurekliCizgi);
            this.UstPanel.Controls.Add(this.rbKirikCizgi);
            this.UstPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UstPanel.Location = new System.Drawing.Point(0, 0);
            this.UstPanel.Name = "UstPanel";
            this.UstPanel.Size = new System.Drawing.Size(535, 70);
            this.UstPanel.TabIndex = 0;
            // 
            // cbKalinlik
            // 
            this.cbKalinlik.FormattingEnabled = true;
            this.cbKalinlik.Items.AddRange(new object[] {
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.cbKalinlik.Location = new System.Drawing.Point(162, 4);
            this.cbKalinlik.Name = "cbKalinlik";
            this.cbKalinlik.Size = new System.Drawing.Size(121, 32);
            this.cbKalinlik.TabIndex = 2;
            this.cbKalinlik.SelectedIndexChanged += new System.EventHandler(this.cbKalinlik_SelectedIndexChanged);
            // 
            // rbSurekliCizgi
            // 
            this.rbSurekliCizgi.AutoSize = true;
            this.rbSurekliCizgi.Location = new System.Drawing.Point(11, 34);
            this.rbSurekliCizgi.Name = "rbSurekliCizgi";
            this.rbSurekliCizgi.Size = new System.Drawing.Size(136, 28);
            this.rbSurekliCizgi.TabIndex = 1;
            this.rbSurekliCizgi.TabStop = true;
            this.rbSurekliCizgi.Text = "Sürekli Çizim";
            this.rbSurekliCizgi.UseVisualStyleBackColor = true;
            this.rbSurekliCizgi.CheckedChanged += new System.EventHandler(this.rbSurekliCizgi_CheckedChanged);
            // 
            // rbKirikCizgi
            // 
            this.rbKirikCizgi.AutoSize = true;
            this.rbKirikCizgi.Location = new System.Drawing.Point(11, 4);
            this.rbKirikCizgi.Name = "rbKirikCizgi";
            this.rbKirikCizgi.Size = new System.Drawing.Size(109, 28);
            this.rbKirikCizgi.TabIndex = 0;
            this.rbKirikCizgi.TabStop = true;
            this.rbKirikCizgi.Text = "Kırık Çizgi";
            this.rbKirikCizgi.UseVisualStyleBackColor = true;
            this.rbKirikCizgi.CheckedChanged += new System.EventHandler(this.rbKirikCizgi_CheckedChanged);
            // 
            // CizimPaneli
            // 
            this.CizimPaneli.BackColor = System.Drawing.Color.LemonChiffon;
            this.CizimPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CizimPaneli.Location = new System.Drawing.Point(0, 70);
            this.CizimPaneli.Name = "CizimPaneli";
            this.CizimPaneli.Size = new System.Drawing.Size(535, 273);
            this.CizimPaneli.TabIndex = 1;
            this.CizimPaneli.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CizimPaneli_MouseClick);
            this.CizimPaneli.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CizimPaneli_MouseDown);
            this.CizimPaneli.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CizimPaneli_MouseMove);
            this.CizimPaneli.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CizimPaneli_MouseUp);
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(305, 3);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(77, 33);
            this.btnRenk.TabIndex = 3;
            this.btnRenk.Text = "RENK";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 343);
            this.Controls.Add(this.CizimPaneli);
            this.Controls.Add(this.UstPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DrawingForm";
            this.Text = "Drawing Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DrawingForm_Load);
            this.UstPanel.ResumeLayout(false);
            this.UstPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UstPanel;
        private System.Windows.Forms.Panel CizimPaneli;
        private System.Windows.Forms.RadioButton rbSurekliCizgi;
        private System.Windows.Forms.RadioButton rbKirikCizgi;
        private System.Windows.Forms.ComboBox cbKalinlik;
        private System.Windows.Forms.ColorDialog dlgRenk;
        private System.Windows.Forms.Button btnRenk;
    }
}

