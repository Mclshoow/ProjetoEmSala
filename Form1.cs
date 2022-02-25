using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliaçãoBarigui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            
            if (rb_Maçãs.Checked)
            {
                rb_Resultado.Clear();
                txtb_Desconto.Clear();             
                double desconto, valorMaças = 1.30;
                double maças = double.Parse(txtb_ValorEntrada.Text);
               
                if (maças < 12)
                {

                    desconto = (maças * valorMaças);
                    txtb_Desconto.Text = txtb_Desconto.Text + "0";
                }
                else
                {
                    desconto = (valorMaças - 0.30) * maças;
                    txtb_Desconto.Text = txtb_Desconto.Text + "0.30 Un.";
                }

                rb_Resultado.Text = rb_Resultado.Text + desconto;
                
                

            }
            else if (rb_MediaAluno.Checked)
            {
                double n1, n2, med;

                n1 = double.Parse(txtb_ValorEntrada.Text);
                n2 = double.Parse(txtb_SegundoValorEntrada.Text);
                med = (n1 + n2) / 2;

                if (med >= 6)
                {
                    rb_Resultado.Text = "Aluno aprovado com média: " + med;
                }
                else
                {
                    rb_Resultado.Text = "Aluno reprovado com média: " + med;
                }

            }
            else if (rb_NumeroPN.Checked)
            {
                double n1;

                n1 = double.Parse(txtb_ValorEntrada.Text);

                if (n1 >= 0)
                {
                    rb_Resultado.Text = "Número positivo: " + n1;
                }
                else
                {
                    rb_Resultado.Text = "Número negativo: " + n1;
                }
            }
            else if (rb_HorasTrabalho.Checked)
            {
                double horasT, horasExtras, diasT = 28, salario, salarioExtra, diaDS;
                horasT = double.Parse(txtb_ValorEntrada.Text);
                salario = double.Parse(txtb_SegundoValorEntrada.Text);
               

                if(horasT <= 160)
                {
                    diaDS = (horasT / 4);
                    horasExtras = 0;
                    salario = (salario * horasT);
                    rb_Resultado.Text = "Horas trabalhas por semana: " + diaDS + 
                        "\nNo total de dias: " + diasT + 
                        "\nNão possuí acrescimo de horas extras." + 
                        "\nSalario total: " + Math.Round(salario);
                }
                else
                {
                    diaDS = (horasT / 4);
                    horasExtras = horasT - 160;
                    salarioExtra = Math.Round((horasExtras * (salario * 1.5)));
                    salario = (salario * horasT);
                    rb_Resultado.Text = "Horas trabalhas por semana: " + diaDS + 
                        "\nNo total de dias: " + diasT + 
                        "\nPossuí acrescimo de  " + horasExtras + " horas extras." + 
                        "\nSalario adicional: " + Math.Round(salarioExtra) + 
                        "\nSalario total: " + Math.Round(salario + salarioExtra);
                }
            }
            else if (rb_JogoFutebol.Checked)
            {
                string nome1, nome2;
                int golt1, golt2;

                
                nome1 = txtb_ValorEntrada.Text;
                nome2 = txtb_SegundoValorEntrada.Text;
                golt1 = int.Parse(txtb_golt1.Text);
                golt2 = int.Parse(txtb_golt2.Text);

                if(golt1 < golt2)
                {
                    rb_Resultado.Text = "Time vencedor: " + nome2 + "\nCom " + golt2 + " gols.";
                }
                else if (golt1 > golt2)
                {
                    rb_Resultado.Text = "Time vencedor: " + nome1 + "\nCom " + golt1 + " gols.";
                }
                else
                {
                    rb_Resultado.Text = "Empate!";
                }




            }
            else if (rb_AlgoritmoPortugol.Checked)
            {
                double x, y, z;

                x = double.Parse(txtb_ValorEntrada.Text);
                y = double.Parse(txtb_SegundoValorEntrada.Text);
                z = (x * y) + 5;
                if (z <= 0)
                {
                    rb_Resultado.Text = "Resposta A!";

                }
                else if (z <= 100)
                {
                    rb_Resultado.Text = "Resposta B!";
                }
                else
                {
                    rb_Resultado.Text = "Resposta C!";
                }
                rb_Resultado.Text = rb_Resultado.Text + "\n" + "Valor de z: " + z;

            }
            else
            {
                MessageBox.Show("Escolha uma opção!");
            }

            
        }

        private void rb_Maçãs_CheckedChanged(object sender, EventArgs e)
        {

            txtb_ValorEntrada.Clear();
            txtb_SegundoValorEntrada.Clear();
            txtb_golt1.Clear();
            txtb_golt2.Clear();
            txtb_Desconto.Clear();
            txtb_ValorEntrada.Text = "Quantidade de maças:";
            txtb_SegundoValorEntrada.Enabled = false;
            txtb_golt1.Enabled = false;
            txtb_golt2.Enabled = false;
            txtb_Desconto.Enabled = true;


        }

        private void rb_MediaAluno_CheckedChanged(object sender, EventArgs e)
        {
            txtb_ValorEntrada.Clear();
            txtb_SegundoValorEntrada.Clear();
            txtb_golt1.Clear();
            txtb_golt2.Clear();
            txtb_Desconto.Clear();
            txtb_ValorEntrada.Text = "Primeira nota:";
            txtb_SegundoValorEntrada.Text = "Segunda nota:";
            txtb_SegundoValorEntrada.Enabled = true;
            txtb_Desconto.Enabled = false;
            txtb_golt1.Enabled = false;
            txtb_golt2.Enabled = false;
        }

        private void rb_NumeroPN_CheckedChanged(object sender, EventArgs e)
        {
            txtb_ValorEntrada.Clear();
            txtb_SegundoValorEntrada.Clear();
            txtb_golt1.Clear();
            txtb_golt2.Clear();
            txtb_Desconto.Clear();
            txtb_ValorEntrada.Text = "Informe um número:";
            txtb_SegundoValorEntrada.Enabled = false;
            txtb_Desconto.Enabled = false;
            txtb_golt1.Enabled = false;
            txtb_golt2.Enabled = false;
        }

        private void rb_HorasTrabalho_CheckedChanged(object sender, EventArgs e)
        {
            txtb_ValorEntrada.Clear();
            txtb_SegundoValorEntrada.Clear();
            txtb_golt1.Clear();
            txtb_golt2.Clear();
            txtb_Desconto.Clear();
            txtb_ValorEntrada.Text = "Horas de trabalho mensal:";
            txtb_SegundoValorEntrada.Text = "Salario por hora em R$:";
            txtb_SegundoValorEntrada.Enabled = true;
            txtb_Desconto.Enabled = false;
            txtb_golt1.Enabled = false;
            txtb_golt2.Enabled = false;
        }

        private void rb_JogoFutebol_CheckedChanged(object sender, EventArgs e)
        {
            txtb_ValorEntrada.Clear();
            txtb_SegundoValorEntrada.Clear();
            txtb_golt1.Clear();
            txtb_golt2.Clear();
            txtb_Desconto.Clear();
            txtb_ValorEntrada.Text = "Nome primeiro time:";
            txtb_SegundoValorEntrada.Text = "Nome segundo time:";
            txtb_golt1.Text = "Qtd Gol T1.";
            txtb_golt2.Text = "Qtd Gol T2.";
            txtb_SegundoValorEntrada.Enabled = true;
            txtb_Desconto.Enabled = false;
            txtb_golt1.Enabled = true;
            txtb_golt2.Enabled = true;
        }

        private void rb_AlgoritmoPortugol_CheckedChanged(object sender, EventArgs e)
        {
            txtb_ValorEntrada.Clear();
            txtb_SegundoValorEntrada.Clear();
            txtb_golt1.Clear();
            txtb_golt2.Clear();
            txtb_Desconto.Clear();
            txtb_ValorEntrada.Text = "Informe valor de X: ";
            txtb_SegundoValorEntrada.Text = "Informe valor de Y: ";
            txtb_SegundoValorEntrada.Enabled = true;
            txtb_Desconto.Enabled = false;
            txtb_golt1.Enabled = false;
            txtb_golt2.Enabled = false;
        }

        private void txtb_Desconto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_LimparTela_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtb_ValorEntrada_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtb_SegundoValorEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn__LimparTela_Click(object sender, EventArgs e)
        {
            txtb_ValorEntrada.Clear();
            txtb_SegundoValorEntrada.Clear();
            txtb_Desconto.Clear();
            rb_Resultado.Clear();
            txtb_golt1.Clear();
            txtb_golt2.Clear();
        }

        private void txtb_golt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtb_golt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_LimparText(object sender, MouseEventArgs e)
        {
            txtb_ValorEntrada.Clear(); 
        }

        private void btn_LimparText2(object sender, MouseEventArgs e)
        {
            txtb_SegundoValorEntrada.Clear();
        }

        private void btn_LimparGol1(object sender, MouseEventArgs e)
        {
            txtb_golt1.Clear();
        }

        private void btn_LimparGol2(object sender, MouseEventArgs e)
        {
            txtb_golt2.Clear();
        }

        private void btn_LimparDesconto(object sender, MouseEventArgs e)
        {
            txtb_Desconto.Clear();
        }

        private void btn_LimparResultado(object sender, MouseEventArgs e)
        {
            rb_Resultado.Clear();
        }

        private void btn_DClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btn_DClick2(object sender, MouseEventArgs e)
        {

        }
    }
}
