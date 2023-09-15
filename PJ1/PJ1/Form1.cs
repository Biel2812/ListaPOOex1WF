using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculararea(object sender, EventArgs e)
        {
            Retangulo r;
            r = new Retangulo();
            r.setBase(int.Parse(txtbase.Text));
            r.setAltura(int.Parse(txtaltura.Text));
            r.calcularArea();

            lblResultadodaArea.Text = r.getArea().ToString();
                 

        }
    }
}
