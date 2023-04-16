﻿using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryAutomation.Entities;

namespace LibraryAutomation.Pages.Specification.Cabinet
{
    public partial class CabinetAdd : Form
    {
        public DatabaseContext _db = new DatabaseContext();
        public CabinetAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.BackColor = Color.White;



                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.BackColor = Color.Red;
                    textBox1.Focus();
                }
            }
            else
            {
                var answer = MessageBox.Show("Eklemek istediginizden emin misiniz ?", "Ekle", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (answer == DialogResult.Yes)
                {
                    try
                    {
                        var cabinetNo = Convert.ToInt32(textBox1.Text);

                        Entities.Cabinet cabinet = new Entities.Cabinet()
                        {
                            CabinetNo = cabinetNo,
                            CreatedDate = DateTime.Now,
                        };

                        _db.Cabinets.Add(cabinet);
                        _db.SaveChanges();
                        MessageBox.Show("Başarıyla eklendi", "Başarılı", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Hide();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Hata ile karşılaşıldı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        this.Hide();
                    }
                }
                else
                {
                    this.Hide();
                }
            }
        }
    }
}