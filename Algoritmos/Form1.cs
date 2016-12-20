using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
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

        private void Calcular_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text;
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);
            double nota3 = double.Parse(txtNota3.Text);
            string conceito = string.Empty;

            bool APROVADO = false;


            double media = (nota1 + (nota2*2) + (nota3*3))/6;


            if (media >= 9)
                conceito = "A";
            else if (media >= 7.5 && media < 9)
                conceito = "B";
            else if (media >= 6 && media < 7.5)
                conceito = "C";
            else if (media >= 4 && media < 6)
                conceito = "D";
            else if (media < 4)
                conceito = "D";

            if (conceito == "A" || conceito == "B" || conceito == "C")
                APROVADO = true;


            string msg = "Matrícula: " + txtMatricula.Text;
            msg += " Nota 1: " + txtNota1.Text;
            msg += " Nota 2: " + txtNota2.Text;
            msg += " Nota 3: " + txtNota3.Text;
            msg += " Média: " + media.ToString();

            if (APROVADO)
                msg += " O Aluno está aprovado!";
            else
                msg += " O Aluno está reprovado.";



            MessageBox.Show(msg, "Resultado da Avaliação:");



        }
    }
}
