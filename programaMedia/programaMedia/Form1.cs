using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programaMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float nota1, nota2, nota3, nota4, resultado;
            string status;

            bool verifica;

            verifica = float.TryParse(txtNota1.Text, out nota1);

            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido na nota 1.");
                return;
            }

            verifica = float.TryParse(txtNota2.Text, out nota2);

            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido na nota 2.");
                return;
            }

            verifica = float.TryParse(txtNota3.Text, out nota3);

            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido na nota 3.");
                return;
            }

            verifica = float.TryParse(txtNota4.Text, out nota4);

            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido na nota 4.");
                return;
            }

            resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            if (resultado >= 7)
            {
                status = "Aluno aprovado!";
            }
            else
            {
                status = "Aluno reprovado!";
            }

            lblResultado.Text = string.Format("Média: {0} - {1}", Math.Round(resultado, 2), status);
        }
    }
}
