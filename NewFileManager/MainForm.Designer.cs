namespace NewFileManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BolmeliPanel = new System.Windows.Forms.SplitContainer();
            this.KlasorPanel = new System.Windows.Forms.TreeView();
            this.klasorSimgeler = new System.Windows.Forms.ImageList(this.components);
            this.DosyaPanel = new System.Windows.Forms.ListView();
            this.kucukSimgeler = new System.Windows.Forms.ImageList(this.components);
            this.buyukSimgeler = new System.Windows.Forms.ImageList(this.components);
            this.gorunumMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sckKucukSimgeler = new System.Windows.Forms.ToolStripMenuItem();
            this.sckBuyukSimgeler = new System.Windows.Forms.ToolStripMenuItem();
            this.sckDose = new System.Windows.Forms.ToolStripMenuItem();
            this.sckListe = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.BolmeliPanel)).BeginInit();
            this.BolmeliPanel.Panel1.SuspendLayout();
            this.BolmeliPanel.Panel2.SuspendLayout();
            this.BolmeliPanel.SuspendLayout();
            this.gorunumMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BolmeliPanel
            // 
            this.BolmeliPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BolmeliPanel.Location = new System.Drawing.Point(0, 0);
            this.BolmeliPanel.Name = "BolmeliPanel";
            // 
            // BolmeliPanel.Panel1
            // 
            this.BolmeliPanel.Panel1.Controls.Add(this.KlasorPanel);
            // 
            // BolmeliPanel.Panel2
            // 
            this.BolmeliPanel.Panel2.Controls.Add(this.DosyaPanel);
            this.BolmeliPanel.Size = new System.Drawing.Size(715, 521);
            this.BolmeliPanel.SplitterDistance = 238;
            this.BolmeliPanel.TabIndex = 0;
            // 
            // KlasorPanel
            // 
            this.KlasorPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.KlasorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KlasorPanel.ImageIndex = 0;
            this.KlasorPanel.ImageList = this.klasorSimgeler;
            this.KlasorPanel.Location = new System.Drawing.Point(0, 0);
            this.KlasorPanel.Name = "KlasorPanel";
            this.KlasorPanel.SelectedImageIndex = 0;
            this.KlasorPanel.Size = new System.Drawing.Size(238, 521);
            this.KlasorPanel.TabIndex = 0;
            this.KlasorPanel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.KlasorPanel_AfterSelect);
            // 
            // klasorSimgeler
            // 
            this.klasorSimgeler.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("klasorSimgeler.ImageStream")));
            this.klasorSimgeler.TransparentColor = System.Drawing.Color.Magenta;
            this.klasorSimgeler.Images.SetKeyName(0, "bmpKlasor.bmp");
            // 
            // DosyaPanel
            // 
            this.DosyaPanel.BackColor = System.Drawing.Color.Lavender;
            this.DosyaPanel.ContextMenuStrip = this.gorunumMenu;
            this.DosyaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DosyaPanel.HideSelection = false;
            this.DosyaPanel.LabelEdit = true;
            this.DosyaPanel.LargeImageList = this.buyukSimgeler;
            this.DosyaPanel.Location = new System.Drawing.Point(0, 0);
            this.DosyaPanel.Name = "DosyaPanel";
            this.DosyaPanel.Size = new System.Drawing.Size(473, 521);
            this.DosyaPanel.SmallImageList = this.kucukSimgeler;
            this.DosyaPanel.TabIndex = 0;
            this.DosyaPanel.UseCompatibleStateImageBehavior = false;
            this.DosyaPanel.View = System.Windows.Forms.View.List;
            this.DosyaPanel.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.DosyaPanel_AfterLabelEdit);
            // 
            // kucukSimgeler
            // 
            this.kucukSimgeler.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("kucukSimgeler.ImageStream")));
            this.kucukSimgeler.TransparentColor = System.Drawing.Color.White;
            this.kucukSimgeler.Images.SetKeyName(0, "file-in-folder_16.png");
            this.kucukSimgeler.Images.SetKeyName(1, "pdf-file-format-symbol_16.png");
            this.kucukSimgeler.Images.SetKeyName(2, "images-button_16.png");
            // 
            // buyukSimgeler
            // 
            this.buyukSimgeler.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buyukSimgeler.ImageStream")));
            this.buyukSimgeler.TransparentColor = System.Drawing.Color.White;
            this.buyukSimgeler.Images.SetKeyName(0, "file-in-folder_32.png");
            this.buyukSimgeler.Images.SetKeyName(1, "pdf-file-format-symbol_32.png");
            this.buyukSimgeler.Images.SetKeyName(2, "images-button_32.png");
            // 
            // gorunumMenu
            // 
            this.gorunumMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sckKucukSimgeler,
            this.sckBuyukSimgeler,
            this.sckDose,
            this.sckListe});
            this.gorunumMenu.Name = "gorunumMenu";
            this.gorunumMenu.Size = new System.Drawing.Size(157, 92);
            // 
            // sckKucukSimgeler
            // 
            this.sckKucukSimgeler.Name = "sckKucukSimgeler";
            this.sckKucukSimgeler.Size = new System.Drawing.Size(180, 22);
            this.sckKucukSimgeler.Text = "Küçük Simgeler";
            this.sckKucukSimgeler.Click += new System.EventHandler(this.sckKucukSimgeler_Click);
            // 
            // sckBuyukSimgeler
            // 
            this.sckBuyukSimgeler.Name = "sckBuyukSimgeler";
            this.sckBuyukSimgeler.Size = new System.Drawing.Size(180, 22);
            this.sckBuyukSimgeler.Text = "Büyük Simgeler";
            this.sckBuyukSimgeler.Click += new System.EventHandler(this.sckBuyukSimgeler_Click);
            // 
            // sckDose
            // 
            this.sckDose.Name = "sckDose";
            this.sckDose.Size = new System.Drawing.Size(180, 22);
            this.sckDose.Text = "Döşe";
            this.sckDose.Click += new System.EventHandler(this.sckDose_Click);
            // 
            // sckListe
            // 
            this.sckListe.Name = "sckListe";
            this.sckListe.Size = new System.Drawing.Size(180, 22);
            this.sckListe.Text = "Liste";
            this.sckListe.Click += new System.EventHandler(this.sckListe_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 521);
            this.Controls.Add(this.BolmeliPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BolmeliPanel.Panel1.ResumeLayout(false);
            this.BolmeliPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BolmeliPanel)).EndInit();
            this.BolmeliPanel.ResumeLayout(false);
            this.gorunumMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer BolmeliPanel;
        private System.Windows.Forms.TreeView KlasorPanel;
        private System.Windows.Forms.ListView DosyaPanel;
        private System.Windows.Forms.ImageList klasorSimgeler;
        private System.Windows.Forms.ImageList kucukSimgeler;
        private System.Windows.Forms.ImageList buyukSimgeler;
        private System.Windows.Forms.ContextMenuStrip gorunumMenu;
        private System.Windows.Forms.ToolStripMenuItem sckKucukSimgeler;
        private System.Windows.Forms.ToolStripMenuItem sckBuyukSimgeler;
        private System.Windows.Forms.ToolStripMenuItem sckDose;
        private System.Windows.Forms.ToolStripMenuItem sckListe;
    }
}

