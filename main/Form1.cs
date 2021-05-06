using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Form1 : Form
    {
        int turno = 1;
        int[,] tabla;
        int PuntosPlayer1 = 0;
        int PuntosPlayer2 = 0;
        bool hayGanador;

        public Form1()
        {
            InitializeComponent();
            IniciarJuego();
        }

        private void IniciarJuego()
        {
            turno = 1;
            tabla = new int[3, 3];
            hayGanador = false;

            picGanador.Image = Properties.Resources.f_0;
            tablaGame.Controls.Clear();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var fichaJuego = new PictureBox();
                    fichaJuego.Image = Properties.Resources.f_0;
                    fichaJuego.Name = string.Format("{0}", i + "_" + j);
                    fichaJuego.Dock = DockStyle.Fill;
                    fichaJuego.Cursor = Cursors.Hand;
                    fichaJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    fichaJuego.Click += Jugar;
                    tablaGame.Controls.Add(fichaJuego, j, i);
                    tabla[i, j] = 0;

                }
            }
        }

        private void Jugar(object sender, EventArgs e)
        {
            var FichaSeleccionadaUsuario = (PictureBox)sender;
            FichaSeleccionadaUsuario.Enabled = false;
            FichaSeleccionadaUsuario.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turno);
            string[] Posicion = FichaSeleccionadaUsuario.Name.Split("_".ToCharArray());
            int Fila = Convert.ToInt32(Posicion[0]);
            int Columna = Convert.ToInt32(Posicion[1]);
            tabla[Fila, Columna] = turno;
            VerificarJuego(Fila, Columna);
            turno = (turno == 1) ? 2 : 1;
        }

        private void VerificarJuego(int Fila, int Columna)
        {
            int GanoFilas = 0;
            int GanoColumnas = 0;
            int DiagonalPrincipal = 0;
            int DiagonalInversa = 0;
            int TamanioGato = 3;
            
            for (var i = 0; i < TamanioGato; i++)
            {
                for (var j = 0; j < TamanioGato; j++)
                {

                    if (i == Fila)
                    {
                        if (tabla[i, j] == turno)
                        {
                            GanoFilas++;
                        }
                    }
                    if (j == Columna)
                    {
                        if (tabla[i, j] == turno)
                        {
                            GanoColumnas++;
                        }
                    }
                    if (i == j) // Diagonal principal
                    {
                        if (tabla[i, j] == turno)
                        {
                            DiagonalPrincipal++;
                        }
                    }

                    if ((i + j) == (TamanioGato - 1)) // Diagonal Inversa
                    {
                        if (tabla[i, j] == turno)
                        {
                            DiagonalInversa++;

                        }
                    }



                }
            }

            if ((GanoFilas == TamanioGato) || (GanoColumnas == TamanioGato) || (DiagonalInversa == TamanioGato) || (DiagonalPrincipal == TamanioGato))
            {
                this.hayGanador = true;
            }
            else
            {
                bool Empate = true;
                for (var i = 0; i < TamanioGato; i++)
                {
                    for (var j = 0; j < TamanioGato; j++)
                    {
                        if (tabla[i, j] == 0)
                        {
                            Empate = false;
                        }

                    }
                }
                if (Empate)
                {
                    MessageBox.Show("Esto es un empate ¡Reinicia el juego!");
                    IniciarJuego();
                }

            }
            if (hayGanador)
            {

                MessageBox.Show("Ya hay ganador");
                picGanador.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("f_" + turno);
                if (turno == 1)
                {
                    PuntosPlayer1++;
                    lblPlayer1.Text = PuntosPlayer1.ToString();
                }
                else
                {
                    PuntosPlayer2++;
                    lblPlayer2.Text = PuntosPlayer2.ToString();
                }

                IniciarJuego();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tablaGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picGanador_Click(object sender, EventArgs e)
        {

        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            PuntosPlayer1 = 0;
            lblPlayer1.Text = PuntosPlayer1.ToString();
            PuntosPlayer2 = 0;
            lblPlayer2.Text = PuntosPlayer2.ToString();
            IniciarJuego();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
