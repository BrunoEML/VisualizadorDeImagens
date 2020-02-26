using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizadorDeImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Ao se apertar o botão de mostrar imagem, caso uma imagem tenha sido
            //selecionada (retornado um "OK", mostramos ela na caixa picImagem
            if (ofdSelecionarImagem.ShowDialog() == DialogResult.OK)
            {
                picImagem.Load(ofdSelecionarImagem.FileName);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCorDeFundo_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

        }

        private void chkEstender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void picImagem_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
