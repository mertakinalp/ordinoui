using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ordino_Otomasyon_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void bosyazisi()
        {

            foreach (Control c in Controls)
            {

                if (c is TextBox)
                    c.Text = "Boş Bıraktınız";

            }
        
        }

        private void btnyapilantumislemlerikaydet_MouseLeave(object sender, EventArgs e)
        {
        

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
          
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}