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
            picImagem.Image = null;
        }

        private void btnCorDeFundo_Click(object sender, EventArgs e)
        {
            //Ao se apertar o botão de mudar a cor, caso uma cor tenha sido
            //selecionada (retornado um "OK", a colocamos com cor de fundo na caixa de imagem
            if (cldMudarCor.ShowDialog() == DialogResult.OK)
            {
                picImagem.BackColor = cldMudarCor.Color;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkEstender_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEstender.Checked)
            {
                picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
                picImagem.SizeMode = PictureBoxSizeMode.CenterImage;
        }

    }
}
