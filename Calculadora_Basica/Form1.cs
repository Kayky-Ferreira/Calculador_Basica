using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora_Basica
{
    public partial class Form1 : Form
    {
        //Globais
        Calculo CA = new Calculo();
        float tipo_operacao = 0;

        
        public Form1()
        {
            InitializeComponent();

            //metodo
            rd1Som.CheckedChanged += rd1Som_CheckedChanged;
            rd2Sub.CheckedChanged += rd1Som_CheckedChanged;
            rd3Mult.CheckedChanged += rd1Som_CheckedChanged;
            rd4Div.CheckedChanged += rd1Som_CheckedChanged;
            rd5Porcen.CheckedChanged += rd1Som_CheckedChanged;



        }
        private void btnExecutar_Click_1(object sender, EventArgs e)
        {

            //Avisos de erro ao Usuário
            if (txtValor1.Text == "Digite o primeiro valor")
            {
                MessageBox.Show("Preencha o primeiro campo");
                return;
            }
            else if (txtValor1.Text == "")
            {
                MessageBox.Show("Não deixe o primeiro campo vazio");
                return;
            }
            else if (txtValor2.Text == "Digite o segundo valor")
            {
                MessageBox.Show("Preencha o segundo campo");
                return;
            }
             else if (txtValor2.Text == "")
            {
                MessageBox.Show("Não deixe o segundo campo vazio");
                return;
            }



            float valor1 = float.Parse(txtValor1.Text);
            float valor2 = float.Parse(txtValor2.Text);

          

            
        //Para puchar o operador
            if (rd1Som.Checked)
            {
                tipo_operacao = 1;               
            }
            else if (rd2Sub.Checked)
            {
                tipo_operacao = 2;
            }
            else if (rd3Mult.Checked)
            {
                tipo_operacao = 3;
            }
            else if (rd4Div.Checked)
            {
                tipo_operacao = 4;
            }
            else if (rd5Porcen.Checked)
            {
                tipo_operacao=5;
            }
            
            MessageBox.Show("o resultado é: " + CA.calculo_operacao(valor1, valor2, tipo_operacao));
        }
             
        //Alterar texto que fica entre os valores para ficar a operação desejada
        private void rd1Som_CheckedChanged(object sender, EventArgs e)
        {
            if (rd1Som.Checked)
            {
                lbloperacao.Text = "+";
                return;
            }
            if (rd2Sub.Checked)
            {
                lbloperacao.Text = "-";
                return;
            }
            if (rd3Mult.Checked)
            {
                lbloperacao.Text = "x";
                return;
            }
            if (rd4Div.Checked)
            {
                lbloperacao.Text = "/";
                return;
            }
            if (rd5Porcen.Checked)
            {
                lbloperacao.Text = "%";
            }

        }

        //Dica nas caixas de texto dos valores
        private void txtValor1_Click(object sender, EventArgs e)
        {
            if (txtValor1.Text == "Digite o primeiro valor")
            {
                txtValor1.Text = "";
                txtValor1.ForeColor = SystemColors.WindowText;
            }
        }

        //Dica nas caixas de texto dos valores
        private void txtValor2_Click(object sender, EventArgs e)
        {
            if(txtValor2.Text == "Digite o segundo valor")
            {
                txtValor2.Text = "";
                txtValor2.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
