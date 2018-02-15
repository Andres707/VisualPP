using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventadecomida
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {                        
                contar contar = new contar();
                label3.Text = "" + contar.getc1().ToString();
                label4.Text = "" + contar.getc2().ToString();
                label5.Text = "" + contar.cal1().ToString();
                label6.Text = "" + contar.cal2().ToString();
                label7.Text = "Total: " + contar.getc3().ToString();                  
        }
    }
}
