namespace VisualizadorDeImagens
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.chkEstender = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCorDeFundo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cldMudarCor = new System.Windows.Forms.ColorDialog();
            this.ofdSelecionarImagem = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.picImagem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkEstender, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 312);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picImagem
            // 
            this.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.picImagem, 2);
            this.picImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImagem.Location = new System.Drawing.Point(3, 3);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(528, 274);
            this.picImagem.TabIndex = 0;
            this.picImagem.TabStop = false;
            // 
            // chkEstender
            // 
            this.chkEstender.AutoSize = true;
            this.chkEstender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEstender.Location = new System.Drawing.Point(3, 283);
            this.chkEstender.Name = "chkEstender";
            this.chkEstender.Size = new System.Drawing.Size(74, 26);
            this.chkEstender.TabIndex = 1;
            this.chkEstender.Text = "Estender";
            this.chkEstender.UseVisualStyleBackColor = true;
            this.chkEstender.CheckedChanged += new System.EventHandler(this.chkEstender_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMostrar);
            this.flowLayoutPanel1.Controls.Add(this.btnLimpar);
            this.flowLayoutPanel1.Controls.Add(this.btnCorDeFundo);
            this.flowLayoutPanel1.Controls.Add(this.btnFechar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(83, 283);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(448, 26);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.AutoSize = true;
            this.btnMostrar.Location = new System.Drawing.Point(3, 3);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(92, 23);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar Imagem";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.Location = new System.Drawing.Point(101, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 23);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar a Imagem";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCorDeFundo
            // 
            this.btnCorDeFundo.AutoSize = true;
            this.btnCorDeFundo.Location = new System.Drawing.Point(204, 3);
            this.btnCorDeFundo.Name = "btnCorDeFundo";
            this.btnCorDeFundo.Size = new System.Drawing.Size(154, 23);
            this.btnCorDeFundo.TabIndex = 2;
            this.btnCorDeFundo.Text = "Definir a cor da tela de fundo";
            this.btnCorDeFundo.UseVisualStyleBackColor = true;
            this.btnCorDeFundo.Click += new System.EventHandler(this.btnCorDeFundo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.AutoSize = true;
            this.btnFechar.Location = new System.Drawing.Point(364, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // ofdSelecionarImagem
            // 
            this.ofdSelecionarImagem.FileName = "openFileDialog1";
            this.ofdSelecionarImagem.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.ofdSelecionarImagem.Title = "Selecionar um arquivo de imagem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 312);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Visualizador de Imagens";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.CheckBox chkEstender;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCorDeFundo;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ColorDialog cldMudarCor;
        private System.Windows.Forms.OpenFileDialog ofdSelecionarImagem;
    }
}

