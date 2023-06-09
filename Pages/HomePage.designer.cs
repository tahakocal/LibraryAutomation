﻿using System.Windows.Forms;

namespace LibraryAutomation.Pages
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.üyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapÖdünçAlmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapTürleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayınEviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raflarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeleriRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelleriRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarıRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplariRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonlarıRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raflarıRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümleriRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayıncılarıRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorileriRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolaplarıRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ödünçVerilenKitapRapırlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyelerToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.kitapKayıtToolStripMenuItem,
            this.kitapÖdünçAlmaToolStripMenuItem,
            this.tanımlamalarToolStripMenuItem,
            this.raporlaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(894, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // üyelerToolStripMenuItem
            // 
            this.üyelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeEkleToolStripMenuItem});
            this.üyelerToolStripMenuItem.Image = global::LibraryAutomation.Properties.Resources.user;
            this.üyelerToolStripMenuItem.Name = "üyelerToolStripMenuItem";
            this.üyelerToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.üyelerToolStripMenuItem.Text = "Üyeler";
            // 
            // üyeEkleToolStripMenuItem
            // 
            this.üyeEkleToolStripMenuItem.Name = "üyeEkleToolStripMenuItem";
            this.üyeEkleToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.üyeEkleToolStripMenuItem.Text = "Üye İşlemleri";
            this.üyeEkleToolStripMenuItem.Click += new System.EventHandler(this.üyeEkleToolStripMenuItem_Click_1);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem});
            this.personelToolStripMenuItem.Image = global::LibraryAutomation.Properties.Resources.teamwork;
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.personelToolStripMenuItem.Text = "Personel";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.personelEkleToolStripMenuItem.Text = "Personel İşlemleri";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click_1);
            // 
            // kitapKayıtToolStripMenuItem
            // 
            this.kitapKayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapListeleToolStripMenuItem});
            this.kitapKayıtToolStripMenuItem.Image = global::LibraryAutomation.Properties.Resources.open_book;
            this.kitapKayıtToolStripMenuItem.Name = "kitapKayıtToolStripMenuItem";
            this.kitapKayıtToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.kitapKayıtToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // kitapListeleToolStripMenuItem
            // 
            this.kitapListeleToolStripMenuItem.Name = "kitapListeleToolStripMenuItem";
            this.kitapListeleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.kitapListeleToolStripMenuItem.Text = "Kitap Listele";
            this.kitapListeleToolStripMenuItem.Click += new System.EventHandler(this.kitapListeleToolStripMenuItem_Click_1);
            // 
            // kitapÖdünçAlmaToolStripMenuItem
            // 
            this.kitapÖdünçAlmaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapVerToolStripMenuItem});
            this.kitapÖdünçAlmaToolStripMenuItem.Image = global::LibraryAutomation.Properties.Resources.agenda;
            this.kitapÖdünçAlmaToolStripMenuItem.Name = "kitapÖdünçAlmaToolStripMenuItem";
            this.kitapÖdünçAlmaToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.kitapÖdünçAlmaToolStripMenuItem.Text = "Kitap Ödünç Alma";
            // 
            // kitapVerToolStripMenuItem
            // 
            this.kitapVerToolStripMenuItem.Name = "kitapVerToolStripMenuItem";
            this.kitapVerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.kitapVerToolStripMenuItem.Text = "Kitap Ödünç İşlemleri";
            this.kitapVerToolStripMenuItem.Click += new System.EventHandler(this.kitapVerToolStripMenuItem_Click_1);
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapTürleriToolStripMenuItem,
            this.yayınEviToolStripMenuItem,
            this.yazarToolStripMenuItem,
            this.dolaplarToolStripMenuItem,
            this.salonlarToolStripMenuItem,
            this.raflarToolStripMenuItem,
            this.bölümlerToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Image = global::LibraryAutomation.Properties.Resources.menu_bar;
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // kitapTürleriToolStripMenuItem
            // 
            this.kitapTürleriToolStripMenuItem.Name = "kitapTürleriToolStripMenuItem";
            this.kitapTürleriToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.kitapTürleriToolStripMenuItem.Text = "Kategoriler";
            this.kitapTürleriToolStripMenuItem.Click += new System.EventHandler(this.kitapTürleriToolStripMenuItem_Click_1);
            // 
            // yayınEviToolStripMenuItem
            // 
            this.yayınEviToolStripMenuItem.Name = "yayınEviToolStripMenuItem";
            this.yayınEviToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.yayınEviToolStripMenuItem.Text = "Yayın Evi";
            this.yayınEviToolStripMenuItem.Click += new System.EventHandler(this.yayınEviToolStripMenuItem_Click_1);
            // 
            // yazarToolStripMenuItem
            // 
            this.yazarToolStripMenuItem.Name = "yazarToolStripMenuItem";
            this.yazarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.yazarToolStripMenuItem.Text = "Yazar";
            this.yazarToolStripMenuItem.Click += new System.EventHandler(this.yazarToolStripMenuItem_Click_1);
            // 
            // dolaplarToolStripMenuItem
            // 
            this.dolaplarToolStripMenuItem.Name = "dolaplarToolStripMenuItem";
            this.dolaplarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.dolaplarToolStripMenuItem.Text = "Dolaplar";
            this.dolaplarToolStripMenuItem.Click += new System.EventHandler(this.dolaplarToolStripMenuItem_Click_1);
            // 
            // salonlarToolStripMenuItem
            // 
            this.salonlarToolStripMenuItem.Name = "salonlarToolStripMenuItem";
            this.salonlarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.salonlarToolStripMenuItem.Text = "Salonlar";
            this.salonlarToolStripMenuItem.Click += new System.EventHandler(this.salonlarToolStripMenuItem_Click_1);
            // 
            // raflarToolStripMenuItem
            // 
            this.raflarToolStripMenuItem.Name = "raflarToolStripMenuItem";
            this.raflarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.raflarToolStripMenuItem.Text = "Raflar";
            this.raflarToolStripMenuItem.Click += new System.EventHandler(this.raflarToolStripMenuItem_Click_1);
            // 
            // bölümlerToolStripMenuItem
            // 
            this.bölümlerToolStripMenuItem.Name = "bölümlerToolStripMenuItem";
            this.bölümlerToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.bölümlerToolStripMenuItem.Text = "Bölümler";
            this.bölümlerToolStripMenuItem.Click += new System.EventHandler(this.bölümlerToolStripMenuItem_Click);
            // 
            // raporlaToolStripMenuItem
            // 
            this.raporlaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeleriRaporlaToolStripMenuItem,
            this.personelleriRaporlaToolStripMenuItem,
            this.yazarlarıRaporlaToolStripMenuItem,
            this.kitaplariRaporlaToolStripMenuItem,
            this.salonlarıRaporlaToolStripMenuItem,
            this.raflarıRaporlaToolStripMenuItem,
            this.bölümleriRaporlaToolStripMenuItem,
            this.yayıncılarıRaporlaToolStripMenuItem,
            this.kategorileriRaporlaToolStripMenuItem,
            this.dolaplarıRaporlaToolStripMenuItem,
            this.ödünçVerilenKitapRapırlaToolStripMenuItem});
            this.raporlaToolStripMenuItem.Image = global::LibraryAutomation.Properties.Resources.png_transparent_computer_icons_report_icon_angle_text_cost;
            this.raporlaToolStripMenuItem.Name = "raporlaToolStripMenuItem";
            this.raporlaToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.raporlaToolStripMenuItem.Text = "Raporlama";
            // 
            // üyeleriRaporlaToolStripMenuItem
            // 
            this.üyeleriRaporlaToolStripMenuItem.Name = "üyeleriRaporlaToolStripMenuItem";
            this.üyeleriRaporlaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.üyeleriRaporlaToolStripMenuItem.Text = "Üyeleri Raporla";
            this.üyeleriRaporlaToolStripMenuItem.Click += new System.EventHandler(this.üyeleriRaporlaToolStripMenuItem_Click);
            // 
            // personelleriRaporlaToolStripMenuItem
            // 
            this.personelleriRaporlaToolStripMenuItem.Name = "personelleriRaporlaToolStripMenuItem";
            this.personelleriRaporlaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.personelleriRaporlaToolStripMenuItem.Text = "Personelleri Raporla";
            this.personelleriRaporlaToolStripMenuItem.Click += new System.EventHandler(this.personelleriRaporlaToolStripMenuItem_Click);
            // 
            // yazarlarıRaporlaToolStripMenuItem
            // 
            this.yazarlarıRaporlaToolStripMenuItem.Name = "yazarlarıRaporlaToolStripMenuItem";
            this.yazarlarıRaporlaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.yazarlarıRaporlaToolStripMenuItem.Text = "Yazarları Raporla";
            this.yazarlarıRaporlaToolStripMenuItem.Click += new System.EventHandler(this.yazarlarıRaporlaToolStripMenuItem_Click);
            // 
            // kitaplariRaporlaToolStripMenuItem
            // 
            this.kitaplariRaporlaToolStripMenuItem.Name = "kitaplariRaporlaToolStripMenuItem";
            this.kitaplariRaporlaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.kitaplariRaporlaToolStripMenuItem.Text = "Kitaplari Raporla";
            this.kitaplariRaporlaToolStripMenuItem.Click += new System.EventHandler(this.kitaplariRaporlaToolStripMenuItem_Click);
            // 
            // salonlarıRaporlaToolStripMenuItem
            // 
            this.salonlarıRaporlaToolStripMenuItem.Name = "salonlarıRaporlaToolStripMenuItem";
            this.salonlarıRaporlaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.salonlarıRaporlaToolStripMenuItem.Text = "Salonları Raporla";
            this.salonlarıRaporlaToolStripMenuItem.Click += new System.EventHandler(this.salonlarıRaporlaToolStripMenuItem_Click);
            // 
            // raflarıRaporlaToolStripMenuItem
            // 
            this.raflarıRaporlaToolStripMenuItem.Name = "raflarıRaporlaToolStripMenuItem";
            this.raflarıRaporlaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.raflarıRaporlaToolStripMenuItem.Text = "Rafları Raporla";
            this.raflarıRaporlaToolStripMenuItem.Click += new System.EventHandler(this.raflarıRaporlaToolStripMenuItem_Click);
            // 
            // bölümleriRaporlaToolStripMenuItem
            // 
            this.bölümleriRaporlaToolStripMenuItem.Name = "bölümleriRaporlaToolStripMenuItem";
            this.bölümleriRaporlaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.bölümleriRaporlaToolStripMenuItem.Text = "Bölümleri Raporla";
            this.bölümleriRaporlaToolStripMenuItem.Click += new System.EventHandler(this.bölümleriRaporlaToolStripMenuItem_Click);
            // 
            // yayıncılarıRaporlaToolStripMenuItem
            // 
            this.yayıncılarıRaporlaToolStripMenuItem.Name = "yayıncılarıRaporlaToolStripMenuItem";
            this.yayıncılarıRaporlaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.yayıncılarıRaporlaToolStripMenuItem.Text = "Yayıncıları Raporla";
            this.yayıncılarıRaporlaToolStripMenuItem.Click += new System.EventHandler(this.yayıncılarıRaporlaToolStripMenuItem_Click);
            // 
            // kategorileriRaporlaToolStripMenuItem
            // 
            this.kategorileriRaporlaToolStripMenuItem.Name = "kategorileriRaporlaToolStripMenuItem";
            this.kategorileriRaporlaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.kategorileriRaporlaToolStripMenuItem.Text = "Kategorileri Raporla";
            this.kategorileriRaporlaToolStripMenuItem.Click += new System.EventHandler(this.kategorileriRaporlaToolStripMenuItem_Click);
            // 
            // dolaplarıRaporlaToolStripMenuItem
            // 
            this.dolaplarıRaporlaToolStripMenuItem.Name = "dolaplarıRaporlaToolStripMenuItem";
            this.dolaplarıRaporlaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.dolaplarıRaporlaToolStripMenuItem.Text = "Dolapları Raporla";
            this.dolaplarıRaporlaToolStripMenuItem.Click += new System.EventHandler(this.dolaplarıRaporlaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = global::LibraryAutomation.Properties.Resources.door;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(894, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::LibraryAutomation.Properties.Resources.Octicons_mark_github_svg;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 20);
            this.toolStripStatusLabel1.Text = "Taha Koçal";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.IsLink = true;
            this.toolStripStatusLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(165, 20);
            this.toolStripStatusLabel2.Text = "https://github.com/tahakocal";
            // 
            // ödünçVerilenKitapRapırlaToolStripMenuItem
            // 
            this.ödünçVerilenKitapRapırlaToolStripMenuItem.Name = "ödünçVerilenKitapRapırlaToolStripMenuItem";
            this.ödünçVerilenKitapRapırlaToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.ödünçVerilenKitapRapırlaToolStripMenuItem.Text = "Ödünç Verilen Kitap Rapırla";
            this.ödünçVerilenKitapRapırlaToolStripMenuItem.Click += new System.EventHandler(this.ödünçVerilenKitapRapırlaToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::LibraryAutomation.Properties.Resources.librayHomePage;
            this.ClientSize = new System.Drawing.Size(894, 462);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Anasayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem üyelerToolStripMenuItem;
        private ToolStripMenuItem üyeEkleToolStripMenuItem;
        private ToolStripMenuItem personelToolStripMenuItem;
        private ToolStripMenuItem personelEkleToolStripMenuItem;
        private ToolStripMenuItem kitapKayıtToolStripMenuItem;
        private ToolStripMenuItem kitapListeleToolStripMenuItem;
        private ToolStripMenuItem kitapÖdünçAlmaToolStripMenuItem;
        private ToolStripMenuItem kitapVerToolStripMenuItem;
        private ToolStripMenuItem raporlaToolStripMenuItem;
        private ToolStripMenuItem üyeleriRaporlaToolStripMenuItem;
        private ToolStripMenuItem personelleriRaporlaToolStripMenuItem;
        private ToolStripMenuItem yazarlarıRaporlaToolStripMenuItem;
        private ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private ToolStripMenuItem kitapTürleriToolStripMenuItem;
        private ToolStripMenuItem yayınEviToolStripMenuItem;
        private ToolStripMenuItem yazarToolStripMenuItem;
        private ToolStripMenuItem dolaplarToolStripMenuItem;
        private ToolStripMenuItem salonlarToolStripMenuItem;
        private ToolStripMenuItem raflarToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem bölümlerToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem kitaplariRaporlaToolStripMenuItem;
        private ToolStripMenuItem salonlarıRaporlaToolStripMenuItem;
        private ToolStripMenuItem raflarıRaporlaToolStripMenuItem;
        private ToolStripMenuItem bölümleriRaporlaToolStripMenuItem;
        private ToolStripMenuItem yayıncılarıRaporlaToolStripMenuItem;
        private ToolStripMenuItem kategorileriRaporlaToolStripMenuItem;
        private ToolStripMenuItem dolaplarıRaporlaToolStripMenuItem;
        private ToolStripMenuItem ödünçVerilenKitapRapırlaToolStripMenuItem;
    }
}