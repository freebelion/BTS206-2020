namespace OyunProje
{
    partial class OyunForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyunForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBaslat = new System.Windows.Forms.ToolStripButton();
            this.btnDur = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tbPuan = new System.Windows.Forms.ToolStripTextBox();
            this.OyunPanel = new System.Windows.Forms.Panel();
            this.Zamanlayici = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBaslat,
            this.btnDur,
            this.toolStripButton3,
            this.tbPuan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBaslat
            // 
            this.btnBaslat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBaslat.Image = global::OyunProje.Properties.Resources.imgBaslat;
            this.btnBaslat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(23, 22);
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnDur
            // 
            this.btnDur.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDur.Image = global::OyunProje.Properties.Resources.imgDur;
            this.btnDur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(23, 22);
            this.btnDur.Text = "DUR";
            this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // tbPuan
            // 
            this.tbPuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPuan.Name = "tbPuan";
            this.tbPuan.ReadOnly = true;
            this.tbPuan.Size = new System.Drawing.Size(100, 25);
            // 
            // OyunPanel
            // 
            this.OyunPanel.BackColor = System.Drawing.Color.LemonChiffon;
            this.OyunPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OyunPanel.Location = new System.Drawing.Point(0, 25);
            this.OyunPanel.Name = "OyunPanel";
            this.OyunPanel.Size = new System.Drawing.Size(800, 425);
            this.OyunPanel.TabIndex = 1;
            this.OyunPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OyunPanel_Paint);
            this.OyunPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OyunPanel_MouseDown);
            // 
            // Zamanlayici
            // 
            this.Zamanlayici.Tick += new System.EventHandler(this.Zamanlayici_Tick);
            // 
            // OyunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OyunPanel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "OyunForm";
            this.Text = "Oyun Form";
            this.Load += new System.EventHandler(this.OyunForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBaslat;
        private System.Windows.Forms.ToolStripButton btnDur;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripTextBox tbPuan;
        private System.Windows.Forms.Panel OyunPanel;
        private System.Windows.Forms.Timer Zamanlayici;
    }
}

