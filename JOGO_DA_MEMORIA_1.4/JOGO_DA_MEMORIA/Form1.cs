using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOGO_DA_MEMORIA
{
    public partial class Form1 : Form
    {
        Int32[] sorteio = new Int32[20];
        Int32[] reg_sorteio = new Int32[20];
        Int32[] valor_botao = new Int32[20];
        Random r = new Random();
        Int32 botao1, botao2; //marca a carta, 1,2, etc.
        Int32 vbotao1, vbotao2; //marca o valor da carta
        Int32 clique = 0; //clique 1 ou 2, equivale ao ato de olhar 2 cartas
        Int32 numero_de_erros = 0;
        Int32 numero_de_acertos = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        void limpar()
        {            
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
        }
        
        void sortear()
        {
            Int32 contador = 1;
            while (contador <= 16)
            {
                sorteio[contador] = r.Next(1, 9);
                while (reg_sorteio[sorteio[contador]] == 2)
                {
                    sorteio[contador] = r.Next(1, 9);
                }
                valor_botao[contador] = sorteio[contador];
                reg_sorteio[sorteio[contador]]++;
                contador++;
            }
        }

        void limpar_sorteio()
        {
            Int32 contador = 1;
            while (contador <= 8)
            {
                sorteio[contador] = 0;
                reg_sorteio[contador] = 0;                
                contador++;
            }
        }

        void botoes(bool mostrar)
        {
            button2.Visible = mostrar;
            button3.Visible = mostrar;
            button4.Visible = mostrar;
            button5.Visible = mostrar;
            button6.Visible = mostrar;
            button7.Visible = mostrar;
            button8.Visible = mostrar;
            button9.Visible = mostrar;
            button10.Visible = mostrar;
            button11.Visible = mostrar;
            button12.Visible = mostrar;
            button13.Visible = mostrar;
            button14.Visible = mostrar;
            button15.Visible = mostrar;
            button16.Visible = mostrar;
            button17.Visible = mostrar;
        }

        //carregar
        private void Form1_Load(object sender, EventArgs e)
        {
            botoes(false);
            button18.Visible = false;
        }

        //BATÃO JOGAR
        private void button1_Click(object sender, EventArgs e)
        {      
            button1.Visible = false;
            sortear();
            button2.Text = Convert.ToString(sorteio[1]);
            button3.Text = Convert.ToString(sorteio[2]);
            button4.Text = Convert.ToString(sorteio[3]);
            button5.Text = Convert.ToString(sorteio[4]);
            button6.Text = Convert.ToString(sorteio[5]);
            button7.Text = Convert.ToString(sorteio[6]);
            button8.Text = Convert.ToString(sorteio[7]);
            button9.Text = Convert.ToString(sorteio[8]);
            button10.Text = Convert.ToString(sorteio[9]);
            button11.Text = Convert.ToString(sorteio[10]);
            button12.Text = Convert.ToString(sorteio[11]);
            button13.Text = Convert.ToString(sorteio[12]);
            button14.Text = Convert.ToString(sorteio[13]);
            button15.Text = Convert.ToString(sorteio[14]);
            button16.Text = Convert.ToString(sorteio[15]);
            button17.Text = Convert.ToString(sorteio[16]);            
            botoes(true);

            timer1.Enabled = true;
            timer1.Start();
        }

        void habilitar_botoes(bool estado)
        {
            button2.Enabled = estado;
            button3.Enabled = estado;
            button4.Enabled = estado;
            button5.Enabled = estado;
            button6.Enabled = estado;
            button7.Enabled = estado;
            button8.Enabled = estado;
            button9.Enabled = estado;
            button10.Enabled = estado;
            button11.Enabled = estado;
            button12.Enabled = estado;
            button13.Enabled = estado;
            button14.Enabled = estado;
            button15.Enabled = estado;
            button16.Enabled = estado;
            button17.Enabled = estado;
        }

        void manter_carta_virada(String b1, String vb1, String b2, String vb2, Boolean estado_do_botao)
        {
            if (estado_do_botao)
            {
                vb1 = vb2 = "";
            }

            if (b1 == "1")
            {
                button2.Text = Convert.ToString(vb1);
                button2.Enabled = estado_do_botao;
            }
            if (b1 == "2")
            {
                button3.Text = Convert.ToString(vb1);
                button3.Enabled = estado_do_botao;
            }
            if (b1 == "3")
            {
                button4.Text = Convert.ToString(vb1);
                button4.Enabled = estado_do_botao;
            }
            if (b1 == "4")
            {
                button5.Text = Convert.ToString(vb1);
                button5.Enabled = estado_do_botao;
            }
            if (b1 == "5")
            {
                button6.Text = Convert.ToString(vb1);
                button6.Enabled = estado_do_botao;
            }
            if (b1 == "6")
            {
                button7.Text = Convert.ToString(vb1);
                button7.Enabled = estado_do_botao;
            }
            if (b1 == "7")
            {
                button8.Text = Convert.ToString(vb1);
                button8.Enabled = estado_do_botao;
            }
            if (b1 == "8")
            {
                button9.Text = Convert.ToString(vb1);
                button9.Enabled = estado_do_botao;
            }
            if (b1 == "9")
            {
                button10.Text = Convert.ToString(vb1);
                button10.Enabled = estado_do_botao;
            }
            if (b1 == "10")
            {
                button11.Text = Convert.ToString(vb1);
                button11.Enabled = estado_do_botao;
            }
            if (b1 == "11")
            {
                button12.Text = Convert.ToString(vb1);
                button12.Enabled = estado_do_botao;
            }
            if (b1 == "12")
            {
                button13.Text = Convert.ToString(vb1);
                button13.Enabled = estado_do_botao;
            }
            if (b1 == "13")
            {
                button14.Text = Convert.ToString(vb1);
                button14.Enabled = estado_do_botao;
            }
            if (b1 == "14")
            {
                button15.Text = Convert.ToString(vb1);
                button15.Enabled = estado_do_botao;
            }
            if (b1 == "15")
            {
                button16.Text = Convert.ToString(vb1);
                button16.Enabled = estado_do_botao;
            }
            if (b1 == "16")
            {
                button17.Text = Convert.ToString(vb1);
                button17.Enabled = estado_do_botao;
            }

            b1 = b2;
            vb1 = vb2;

            if (b1 == "1")
            {
                button2.Text = Convert.ToString(vb1);
                button2.Enabled = estado_do_botao;
            }
            if (b1 == "2")
            {
                button3.Text = Convert.ToString(vb1);
                button3.Enabled = estado_do_botao;
            }
            if (b1 == "3")
            {
                button4.Text = Convert.ToString(vb1);
                button4.Enabled = estado_do_botao;
            }
            if (b1 == "4")
            {
                button5.Text = Convert.ToString(vb1);
                button5.Enabled = estado_do_botao;
            }
            if (b1 == "5")
            {
                button6.Text = Convert.ToString(vb1);
                button6.Enabled = estado_do_botao;
            }
            if (b1 == "6")
            {
                button7.Text = Convert.ToString(vb1);
                button7.Enabled = estado_do_botao;
            }
            if (b1 == "7")
            {
                button8.Text = Convert.ToString(vb1);
                button8.Enabled = estado_do_botao;
            }
            if (b1 == "8")
            {
                button9.Text = Convert.ToString(vb1);
                button9.Enabled = estado_do_botao;
            }
            if (b1 == "9")
            {
                button10.Text = Convert.ToString(vb1);
                button10.Enabled = estado_do_botao;
            }
            if (b1 == "10")
            {
                button11.Text = Convert.ToString(vb1);
                button11.Enabled = estado_do_botao;
            }
            if (b1 == "11")
            {
                button12.Text = Convert.ToString(vb1);
                button12.Enabled = estado_do_botao;
            }
            if (b1 == "12")
            {
                button13.Text = Convert.ToString(vb1);
                button13.Enabled = estado_do_botao;
            }
            if (b1 == "13")
            {
                button14.Text = Convert.ToString(vb1);
                button14.Enabled = estado_do_botao;
            }
            if (b1 == "14")
            {
                button15.Text = Convert.ToString(vb1);
                button15.Enabled = estado_do_botao;
            }
            if (b1 == "15")
            {
                button16.Text = Convert.ToString(vb1);
                button16.Enabled = estado_do_botao;
            }
            if (b1 == "16")
            {
                button17.Text = Convert.ToString(vb1);
                button17.Enabled = estado_do_botao;
            }
        }

        void olhar_carta(Int32 b)
        {
            clique++;
            if (clique == 1)
            {
                botao1 = b;
                vbotao1 = sorteio[b];
            }
            else
            {
                botao2 = b;
                vbotao2 = sorteio[b];

                if (vbotao1 == vbotao2)
                {
                    manter_carta_virada(Convert.ToString(botao1), 
                        Convert.ToString(vbotao1), 
                        Convert.ToString(botao2), 
                        Convert.ToString(vbotao2), false);
                    numero_de_acertos++;
                    if (numero_de_acertos == 8)
                    {
                        MessageBox.Show("PARABÉNS");
                        button18.Visible = true;
                    }
                }
                else
                {                    
                    timer2.Enabled = true;
                    timer2.Start();
                    numero_de_erros++;
                    if (numero_de_erros >= 4)
                    {
                        MessageBox.Show("GAME OVER");
                        timer3.Enabled = true;
                        timer3.Start();                        
                    }
                }
                clique = 0;
            }
        }

        //1° CARTA
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = Convert.ToString(sorteio[1]);
            olhar_carta(1);
        }

        //2° CARTA
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = Convert.ToString(sorteio[2]);
            olhar_carta(2);
        }

        //3° CARTA
        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = Convert.ToString(sorteio[3]);
            olhar_carta(3);
        }

        //4° CARTA
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = Convert.ToString(sorteio[4]);
            olhar_carta(4);
        }

        //5° CARTA
        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = Convert.ToString(sorteio[5]);
            olhar_carta(5);
        }

        //6° CARTA
        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = Convert.ToString(sorteio[6]);
            olhar_carta(6);
        }

        //7° CARTA
        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = Convert.ToString(sorteio[7]);
            olhar_carta(7);
        }

        //8° CARTA
        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = Convert.ToString(sorteio[8]);
            olhar_carta(8);
        }

        //9° CARTA
        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = Convert.ToString(sorteio[9]);
            olhar_carta(9);
        }

        //10° CARTA
        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = Convert.ToString(sorteio[10]);
            olhar_carta(10);
        }

        //11° CARTA
        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = Convert.ToString(sorteio[11]);
            olhar_carta(11);
        }

        //12° CARTA
        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = Convert.ToString(sorteio[12]);
            olhar_carta(12);
        }

        //13° CARTA
        private void button14_Click(object sender, EventArgs e)
        {
            button14.Text = Convert.ToString(sorteio[13]);
            olhar_carta(13);
        }

        //14° CARTA
        private void button15_Click(object sender, EventArgs e)
        {
            button15.Text = Convert.ToString(sorteio[14]);
            olhar_carta(14);
        }

        //15° CARTA
        private void button16_Click(object sender, EventArgs e)
        {
            button16.Text = Convert.ToString(sorteio[15]);
            olhar_carta(15);
        }

        //16° CARTA
        private void button17_Click(object sender, EventArgs e)
        {
            button17.Text = Convert.ToString(sorteio[16]);
            olhar_carta(16);
        }

        //JOGAR NOVAMENTE
        private void button18_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {        
            limpar();
            timer1.Enabled = false;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            manter_carta_virada(Convert.ToString(botao1),
                Convert.ToString(vbotao1),
                Convert.ToString(botao2),
                Convert.ToString(vbotao2), true);
            timer2.Enabled = false;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            habilitar_botoes(false);
        }
    }
}