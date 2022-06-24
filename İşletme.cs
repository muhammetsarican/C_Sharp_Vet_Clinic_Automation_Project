using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hayvan_Sağlık_Sistemi
{
    public partial class İşletme : Form
    {
        public İşletme()
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

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Hide();
        }
    }
}
