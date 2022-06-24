using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;
namespace Hayvan_Sağlık_Sistemi
{
    public partial class Vet : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\OneDrive\\Belgeler\\Vet.accdb");
        public Vet()
        {
            InitializeComponent();
            this.BackColor = Color.Orange;
            button1.BackColor = Color.White;
            button1.Font = new Font("Monotype Corsiva", 8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa rt = new Anasayfa();
            rt.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Vet_Load(object sender, EventArgs e)
        {

        }
    }
}
