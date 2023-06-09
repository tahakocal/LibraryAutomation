﻿using LibraryAutomation.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryAutomation.Pages
{
    public partial class Register : Form
    {
        private DatabaseContext _db = new DatabaseContext();
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                textBox5.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox1.BackColor = Color.White;

                if (string.IsNullOrEmpty(textBox5.Text))
                {
                    textBox5.BackColor = Color.DarkRed;
                    textBox5.Focus();
                }
                if (string.IsNullOrEmpty(textBox4.Text))
                {
                    textBox4.BackColor = Color.DarkRed;
                    textBox4.Focus();
                }
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    textBox3.BackColor = Color.DarkRed;
                    textBox3.Focus();
                }
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    textBox2.BackColor = Color.DarkRed;
                    textBox2.Focus();
                }
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.BackColor = Color.DarkRed;
                    textBox1.Focus();
                }
            }
            else
            {
                textBox5.BackColor = Color.White;
                textBox4.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox1.BackColor = Color.White;
                try
                {
                    User user = new User()
                    {
                        Name = textBox1.Text,
                        Surname = textBox2.Text,
                        Username = textBox5.Text,
                        Email = textBox3.Text,
                        Password = textBox4.Text,
                        CreatedDate = DateTime.Now,
                    };

                    _db.Users.Add(user);
                    _db.SaveChanges();
                    MessageBox.Show("Kayıt olundu", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Welcome welcome = new Welcome();
                    welcome.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt olurken hata ile karşılaşıldı. Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }
    }
}
