using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class JogoDaVelha : Form
    {
        bool jogador = true;
        bool box1 = false, box2 = false, box3 = false, box4 = false, box5 = false, box6 = false, box7 = false, box8 = false, box9 = false;
        string valor1 = "", valor2 = "", valor3 = "", valor4 = "", valor5 = "", valor6 = "", valor7 = "", valor8 = "", valor9 = "";
        int placar1 = 0, placar2 = 0;

        public JogoDaVelha()
        {
            InitializeComponent();
        }

        private void JogoDaVelha_Load(object sender, EventArgs e)
        {            
        }

        public void NovoJogo()
        {
            jogador = true;
            box1 = false; box2 = false; box3 = false; box4 = false; box5 = false; box6 = false; box7 = false; box8 = false; box9 = false;
            valor1 = ""; valor2 = ""; valor3 = ""; valor4 = ""; valor5 = ""; valor6 = ""; valor7 = ""; valor8 = ""; valor9 = "";            

            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
        }

        public bool desenha(PictureBox picbox, bool jogador)
        {
            //vez do circulo
            if (jogador == false)
            {
                Pen caneta = new System.Drawing.Pen(System.Drawing.Color.Black, 2);
                Graphics formGraphics = picbox.CreateGraphics();                
                formGraphics.DrawEllipse(caneta, new Rectangle(10, 10, 110, 110));
                caneta.Dispose();
                formGraphics.Dispose();                
            }

            //vez do X
            else
            {
                Pen caneta = new System.Drawing.Pen(System.Drawing.Color.Black, 2);
                Graphics formGraphics = picbox.CreateGraphics();                
                formGraphics.DrawLine(caneta, 15, 115, 115, 15);                
                caneta.Dispose();
                formGraphics.Dispose();

                Pen caneta2 = new System.Drawing.Pen(System.Drawing.Color.Black, 2);
                Graphics formGraphics2 = picbox.CreateGraphics();
                formGraphics2.DrawLine(caneta2, 15, 15, 115, 115);
                caneta2.Dispose();
                formGraphics2.Dispose();
            }
            //troca de jogadores
            if (jogador)
            {
                return false;
            }
            else
            {
                return true;
            }
        }        

        public void checar(int[] posicao)
        {
            //primeira linha horizontal
            if (posicao[0] == 1)
            {               
                if (valor1.Equals(valor2) && valor2.Equals(valor3) && !String.IsNullOrEmpty(valor1))
                {
                    if (valor1 == "x")
                    {
                        MessageBox.Show("O jogador 1 é o vencedor!", "Final de Jogo!");
                        placar1++;
                        lblPlacar1.Text = placar1.ToString();
                        NovoJogo();
                    }
                    else
                    { 
                        MessageBox.Show("O jogador 2 é o vencedor!", "Final de Jogo!");
                        placar2++;
                        lblPlacar2.Text = placar2.ToString();
                        NovoJogo();
                    }
            }
                            
            }
            //segunda linha horizontal
            else if (posicao[0] == 2)
            {
                if (valor4.Equals(valor5) && valor5.Equals(valor6) && !String.IsNullOrEmpty(valor4))
                {
                    if (valor4 == "x")
                    {
                        MessageBox.Show("O jogador 1 é o vencedor!", "Final de Jogo!");
                        placar1++;
                        lblPlacar1.Text = placar1.ToString();
                        NovoJogo();
                    }
                    else
                    {
                        MessageBox.Show("O jogador 2 é o vencedor!", "Final de Jogo!");
                        placar2++;
                        lblPlacar2.Text = placar2.ToString();
                        NovoJogo();
                    }
                }
            }
            //terceira linha horizontal
            else if (posicao[0] == 3)
            {
                if (valor7.Equals(valor8) && valor8.Equals(valor9) && !String.IsNullOrEmpty(valor7))
                {
                    if (valor7 == "x")
                    {
                        MessageBox.Show("O jogador 1 é o vencedor!", "Final de Jogo!");
                        placar1++;
                        lblPlacar1.Text = placar1.ToString();
                        NovoJogo();
                    }
                    else
                    {
                        MessageBox.Show("O jogador 2 é o vencedor!", "Final de Jogo!");
                        placar2++;
                        lblPlacar2.Text = placar2.ToString();
                        NovoJogo();
                    }
                }
            }

            //primera coluna vertical
            if (posicao[1] == 1)
            {
                if (valor1.Equals(valor4) && valor4.Equals(valor7) && !String.IsNullOrEmpty(valor1))
                {
                    if (valor1 == "x")
                    {
                        MessageBox.Show("O jogador 1 é o vencedor!", "Final de Jogo!");
                        placar1++;
                        lblPlacar1.Text = placar1.ToString();
                        NovoJogo();
                    }
                    else
                    {
                        MessageBox.Show("O jogador 2 é o vencedor!", "Final de Jogo!");
                        placar2++;
                        lblPlacar2.Text = placar2.ToString();
                        NovoJogo();
                    }
                }

            }
            //segunda coluna vertical
            else if (posicao[1] == 2)
            {
                if (valor2.Equals(valor5) && valor5.Equals(valor8) && !String.IsNullOrEmpty(valor2))
                {
                    if (valor2 == "x")
                    {
                        MessageBox.Show("O jogador 1 é o vencedor!", "Final de Jogo!");
                        placar1++;
                        lblPlacar1.Text = placar1.ToString();
                        NovoJogo();
                    }
                    else
                    {
                        MessageBox.Show("O jogador 2 é o vencedor!", "Final de Jogo!");
                        placar2++;
                        lblPlacar2.Text = placar2.ToString();
                        NovoJogo();
                    }
                }
            }
            //terceira coluna vertical
            else if (posicao[1] == 3)
            {
                if (valor3.Equals(valor6) && valor6.Equals(valor9) && !String.IsNullOrEmpty(valor3))
                {
                    if (valor3 == "x")
                    {
                        MessageBox.Show("O jogador 1 é o vencedor!", "Final de Jogo!");
                        placar1++;
                        lblPlacar1.Text = placar1.ToString();
                        NovoJogo();
                    }
                    else
                    {
                        MessageBox.Show("O jogador 2 é o vencedor!", "Final de Jogo!");
                        placar2++;
                        lblPlacar2.Text = placar2.ToString();
                        NovoJogo();
                    }
                }
            }
            //diagonal 1
            if ((posicao[0] == 1 && posicao[1] == 1) || (posicao[0] == 2 && posicao[1] == 2) || (posicao[0] == 3 && posicao[1] == 3))
            {
                if (valor1.Equals(valor5) && valor5.Equals(valor9) && !String.IsNullOrEmpty(valor1))
                {
                    if (valor1 == "x")
                    {
                        MessageBox.Show("O jogador 1 é o vencedor!", "Final de Jogo!");
                        placar1++;
                        lblPlacar1.Text = placar1.ToString();
                        NovoJogo();
                    }
                    else
                    {
                        MessageBox.Show("O jogador 2 é o vencedor!", "Final de Jogo!");
                        placar2++;
                        lblPlacar2.Text = placar2.ToString();
                        NovoJogo();
                    }
                }
            }
            //diagonal 2
            if ((posicao[0] == 1 && posicao[1] == 3) || (posicao[0] == 2 && posicao[1] == 2) || (posicao[0] == 3 && posicao[1] == 1))
            {
                if (valor3.Equals(valor5) && valor5.Equals(valor7) && !String.IsNullOrEmpty(valor3))
                {
                    if (valor3 == "x")
                    {
                        MessageBox.Show("O jogador 1 é o vencedor!", "Final de Jogo!");
                        placar1++;
                        lblPlacar1.Text = placar1.ToString();
                        NovoJogo();
                    }
                    else
                    {
                        MessageBox.Show("O jogador 2 é o vencedor!", "Final de Jogo!");
                        placar2++;
                        lblPlacar2.Text = placar2.ToString();
                        NovoJogo();
                    }
                }
            }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int[] posicao = { 1, 1 };
            //check se está vazio
            if (box1 == false)
            {
                //verificação do jogaros
                if (jogador)                
                    valor1 = "x";
                
                else                
                    valor1 = "o";
                
                //desenha e passa a vez do jogador
                jogador = desenha(this.pictureBox1, jogador);
                //marca o box como preenchido
                box1 = true;
                //checar por vencedor
                checar(posicao);
            }            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int[] posicao = { 1, 2 };
            if (box2 == false)
            {
                if (jogador)
                    valor2 = "x";

                else
                    valor2 = "o";

                jogador = desenha(this.pictureBox2, jogador);
                box2 = true;
                checar(posicao);
            }
        }    

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int[] posicao = { 1, 3 };
            if (box3 == false)
            {
                if (jogador)
                    valor3 = "x";

                else
                    valor3 = "o";

                jogador = desenha(this.pictureBox3, jogador);
                box3 = true;
                checar(posicao);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int[] posicao = { 2, 1 };
            if (box4 == false)
            {
                if (jogador)
                    valor4 = "x";

                else
                    valor4 = "o";

                jogador = desenha(this.pictureBox4, jogador);
                box4 = true;
                checar(posicao);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int[] posicao = { 2, 2 };
            if (box5 == false)
            {
                if (jogador)
                    valor5 = "x";

                else
                    valor5 = "o";

                jogador = desenha(this.pictureBox5, jogador);
                box5 = true;
                checar(posicao);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int[] posicao = { 2, 3 };
            if (box6 == false)
            {
                if (jogador)
                    valor6 = "x";

                else
                    valor6 = "o";

                jogador = desenha(this.pictureBox6, jogador);
                box6 = true;
                checar(posicao);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int[] posicao = { 3, 1 };
            if (box7 == false)
            {
                if (jogador)
                    valor7 = "x";

                else
                    valor7 = "o";

                jogador = desenha(this.pictureBox7, jogador);
                box7 = true;
                checar(posicao);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int[] posicao = { 3, 2 };
            if (box8 == false)
            {
                if (jogador)
                    valor8 = "x";

                else
                    valor8 = "o";

                jogador = desenha(this.pictureBox8, jogador);
                box8 = true;
                checar(posicao);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            int[] posicao = { 3, 3 };
            if (box9 == false)
            {
                if (jogador)
                    valor9 = "x";

                else
                    valor9 = "o";

                jogador = desenha(this.pictureBox9, jogador);
                box9 = true;
                checar(posicao);
            }
        }
    }
}