namespace EditorApp
{
    partial class EditorForm
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
            this.AnaMenu = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KontrolSeriti = new System.Windows.Forms.ToolStrip();
            this.editor = new System.Windows.Forms.RichTextBox();
            this.btnKalin = new System.Windows.Forms.ToolStripButton();
            this.btnYatik = new System.Windows.Forms.ToolStripButton();
            this.AnaMenu.SuspendLayout();
            this.KontrolSeriti.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnaMenu
            // 
            this.AnaMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.AnaMenu.Location = new System.Drawing.Point(0, 0);
            this.AnaMenu.Name = "AnaMenu";
            this.AnaMenu.Size = new System.Drawing.Size(607, 24);
            this.AnaMenu.TabIndex = 0;
            this.AnaMenu.Text = "Ana Menü";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.yükleToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kaydetToolStripMenuItem.Text = "&Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // yükleToolStripMenuItem
            // 
            this.yükleToolStripMenuItem.Name = "yükleToolStripMenuItem";
            this.yükleToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.yükleToolStripMenuItem.Text = "&Yükle";
            this.yükleToolStripMenuItem.Click += new System.EventHandler(this.yükleToolStripMenuItem_Click);
            // 
            // KontrolSeriti
            // 
            this.KontrolSeriti.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KontrolSeriti.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKalin,
            this.btnYatik});
            this.KontrolSeriti.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.KontrolSeriti.Location = new System.Drawing.Point(0, 24);
            this.KontrolSeriti.Name = "KontrolSeriti";
            this.KontrolSeriti.Size = new System.Drawing.Size(607, 25);
            this.KontrolSeriti.TabIndex = 2;
            this.KontrolSeriti.Text = "Kontrol Şeriti";
            // 
            // editor
            // 
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.Location = new System.Drawing.Point(0, 49);
            this.editor.Name = "editor";
            this.editor.Size = new System.Drawing.Size(607, 303);
            this.editor.TabIndex = 3;
            this.editor.Text = "";
            // 
            // btnKalin
            // 
            this.btnKalin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKalin.Image = global::EditorApp.Properties.Resources.imgKalin;
            this.btnKalin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKalin.Name = "btnKalin";
            this.btnKalin.Size = new System.Drawing.Size(23, 22);
            this.btnKalin.Text = "Kalın";
            this.btnKalin.ToolTipText = "Kalın Yazı";
            this.btnKalin.Click += new System.EventHandler(this.btnKalin_Click);
            // 
            // btnYatik
            // 
            this.btnYatik.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnYatik.Image = global::EditorApp.Properties.Resources.imgYatik;
            this.btnYatik.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYatik.Name = "btnYatik";
            this.btnYatik.Size = new System.Drawing.Size(23, 22);
            this.btnYatik.Text = "Yatık";
            this.btnYatik.ToolTipText = "Yatık Yazı";
            this.btnYatik.Click += new System.EventHandler(this.btnYatik_Click);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 352);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.KontrolSeriti);
            this.Controls.Add(this.AnaMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.AnaMenu;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditorForm";
            this.Text = "Metin Düzenleyici";
            this.AnaMenu.ResumeLayout(false);
            this.AnaMenu.PerformLayout();
            this.KontrolSeriti.ResumeLayout(false);
            this.KontrolSeriti.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AnaMenu;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yükleToolStripMenuItem;
        private System.Windows.Forms.ToolStrip KontrolSeriti;
        private System.Windows.Forms.ToolStripButton btnKalin;
        private System.Windows.Forms.ToolStripButton btnYatik;
        private System.Windows.Forms.RichTextBox editor;
    }
}

