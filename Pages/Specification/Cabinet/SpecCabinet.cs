﻿using LibraryAutomation.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryAutomation.Pages.Specification.Cabinet
{
    public partial class SpecCabinet : Form
    {
        public DatabaseContext _db = new DatabaseContext();

        public SpecCabinet()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.Cabinets
                .Select(x => new
                {
                    x.Id,
                    x.CabinetNo,
                }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CabinetAdd add = new CabinetAdd();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CabinetUpdate update = new CabinetUpdate();
            update.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            update.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            update.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CabinetRemove remove = new CabinetRemove();
            remove.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            remove.textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            remove.ShowDialog();
        }

        private void SpecCabinet_Load(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = _db.Cabinets
                .Select(x => new
                {
                    x.Id,
                    x.CabinetNo,
                }).ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var conver = Convert.ToInt32(txtAdara.Text);
            var books = _db.Cabinets.Where(x => x.CabinetNo.Equals(conver)).ToList();

            dataGridView1.DataSource = books.Select(x => new
            {
                x.Id,
                x.CabinetNo,
                x.CreatedDate
            }).ToList();
        }
    }
}
