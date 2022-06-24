using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hayvan_Sağlık_Sistemi
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
            Button mybuton = new Button();
            mybuton.Location = new Point(225, 198);
            mybuton.Text = "Submit";
            mybuton.AutoSize = true;
            mybuton.BackColor = Color.LightGray;
            button1.Padding = new Padding(3);
            button2.Padding = new Padding(3);

            // Set font of the text present in the button
            button1.Font = new Font("Monotype Corsiva", 18);
            button2.Font = new Font("Monotype Corsiva", 18);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vet vet = new Vet();
            vet.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İşletme işl = new İşletme();
            işl.Show();
            this.Hide();
        }
    }
}
