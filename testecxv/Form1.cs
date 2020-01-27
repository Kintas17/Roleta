using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testecxv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        rodar E = new rodar();
        private void Button1_Click(object sender, EventArgs e)
        {
            int[] ns;
            ns = E.nsorteio.ToArray();
            n1.Text = ns[0].ToString();
            string frase = "Parabéns! Acertou em ";
            frase += E.ncertos.ToString() + " números";
            MessageBox.Show(frase);
        }

        private void numeros(object sender, EventArgs e)
        {
            Label tmp = (Label)sender;
            tmp.Text = E.numero(Convert.ToInt32(tmp.Tag) - 1);
        }
    }
}
