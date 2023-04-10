using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPrincipal
{
    public partial class Form1 : Form
    {
        float nota1, nota2, nota3, nota4, media;

        private void lblsituacao_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nota1 = float.Parse(textBox1.Text);
            nota2 = float.Parse(txtnota2.Text);
            nota3 = float.Parse(txtnota3.Text);
            nota4 = float.Parse(txtnota4.Text);
            media = (nota1 + nota2 + nota3 + nota4) / 4;

            txtmedia.Text = Convert.ToString(media);

            if (media >= 5) {
                lblsituacao.Text = "Arpovado!";
                lblsituacao.ForeColor = Color.Green;
            }
            else
            {
                lblsituacao.Text = "Reprovado!";
                lblsituacao.ForeColor = Color.Red; 
            }
        }
    }
}
