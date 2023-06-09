﻿using LibraryAutomation.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Specification.Shelve
{
    public partial class SpecShelve : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public SpecShelve()
        {
            InitializeComponent();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Shelves
                .Select(x => new
                {
                    x.Id,
                    x.ShelveNo,
                    x.CreatedDate
                }).ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShelveAdd add = new ShelveAdd();
            add.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ShelveUpdate update = new ShelveUpdate();
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ShelveDelete remove = new ShelveDelete();
            remove.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            remove.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            remove.ShowDialog();
        }

        private void SpecShelve_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Shelves
                .Select(x => new
                {
                    x.Id,
                    x.ShelveNo,
                    x.CreatedDate
                }).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var conver = Convert.ToInt32(txtAdara.Text);
            var books = _db.Shelves.Where(x => x.ShelveNo == conver).ToList();

            dataGridView1.DataSource = books.Select(x => new
            {
                x.Id,
                x.ShelveNo,
                x.CreatedDate
            }).ToList();
        }
    }
}
