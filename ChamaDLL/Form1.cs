using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLLPropImagem;

namespace ChamaDLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            executa();
        }

        private void executa()
        {
            var dll = new DLLPropImagem.DLLPropImagem();
            string path = textBox1.Text.ToString();
            latitude.Text = Convert.ToString(dll.RetornaLat(path));
            longitude.Text = Convert.ToString(dll.RetornaLong(path));
            data.Text = Convert.ToString(dll.RetornaData(path));
        }
    }
}
