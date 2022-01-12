namespace AG_TSP
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zedMedia = new ZedGraph.ZedGraphControl();
            this.lbMenorDistancia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbEvolucoes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnCriarPop = new System.Windows.Forms.Button();
            this.gbMutacao = new System.Windows.Forms.GroupBox();
            this.rbGenesPop = new System.Windows.Forms.RadioButton();
            this.rbPopulacao = new System.Windows.Forms.RadioButton();
            this.rbNovoIndividuo = new System.Windows.Forms.RadioButton();
            this.txtQtdeTorneio = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtdeElitismo = new System.Windows.Forms.MaskedTextBox();
            this.chElitismo = new System.Windows.Forms.CheckBox();
            this.txtEvolucao = new System.Windows.Forms.MaskedTextBox();
            this.txtTaxaMutacao = new System.Windows.Forms.MaskedTextBox();
            this.txtTaxaCrossover = new System.Windows.Forms.MaskedTextBox();
            this.txtTamPop = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbQtdeCidades = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbComplex = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbMutacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.zedMedia);
            this.panel1.Controls.Add(this.lbMenorDistancia);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbEvolucoes);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnExecutar);
            this.panel1.Controls.Add(this.btnCriarPop);
            this.panel1.Controls.Add(this.gbMutacao);
            this.panel1.Controls.Add(this.txtQtdeTorneio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtQtdeElitismo);
            this.panel1.Controls.Add(this.chElitismo);
            this.panel1.Controls.Add(this.txtEvolucao);
            this.panel1.Controls.Add(this.txtTaxaMutacao);
            this.panel1.Controls.Add(this.txtTaxaCrossover);
            this.panel1.Controls.Add(this.txtTamPop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 716);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // zedMedia
            // 
            this.zedMedia.Location = new System.Drawing.Point(13, 405);
            this.zedMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedMedia.Name = "zedMedia";
            this.zedMedia.ScrollGrace = 0D;
            this.zedMedia.ScrollMaxX = 0D;
            this.zedMedia.ScrollMaxY = 0D;
            this.zedMedia.ScrollMaxY2 = 0D;
            this.zedMedia.ScrollMinX = 0D;
            this.zedMedia.ScrollMinY = 0D;
            this.zedMedia.ScrollMinY2 = 0D;
            this.zedMedia.Size = new System.Drawing.Size(598, 298);
            this.zedMedia.TabIndex = 20;
            // 
            // lbMenorDistancia
            // 
            this.lbMenorDistancia.AutoSize = true;
            this.lbMenorDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenorDistancia.Location = new System.Drawing.Point(230, 362);
            this.lbMenorDistancia.Name = "lbMenorDistancia";
            this.lbMenorDistancia.Size = new System.Drawing.Size(38, 26);
            this.lbMenorDistancia.TabIndex = 19;
            this.lbMenorDistancia.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "Menor Distância:";
            // 
            // lbEvolucoes
            // 
            this.lbEvolucoes.AutoSize = true;
            this.lbEvolucoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEvolucoes.Location = new System.Drawing.Point(163, 333);
            this.lbEvolucoes.Name = "lbEvolucoes";
            this.lbEvolucoes.Size = new System.Drawing.Size(38, 26);
            this.lbEvolucoes.TabIndex = 17;
            this.lbEvolucoes.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Evoluções:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(383, 252);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(219, 62);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExecutar
            // 
            this.btnExecutar.Enabled = false;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(383, 184);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(219, 62);
            this.btnExecutar.TabIndex = 14;
            this.btnExecutar.Text = "Executar/Continuar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnCriarPop
            // 
            this.btnCriarPop.Enabled = false;
            this.btnCriarPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPop.Location = new System.Drawing.Point(383, 116);
            this.btnCriarPop.Name = "btnCriarPop";
            this.btnCriarPop.Size = new System.Drawing.Size(219, 62);
            this.btnCriarPop.TabIndex = 13;
            this.btnCriarPop.Text = "Criar População";
            this.btnCriarPop.UseVisualStyleBackColor = true;
            this.btnCriarPop.Click += new System.EventHandler(this.btnCriarPop_Click);
            // 
            // gbMutacao
            // 
            this.gbMutacao.Controls.Add(this.rbGenesPop);
            this.gbMutacao.Controls.Add(this.rbPopulacao);
            this.gbMutacao.Controls.Add(this.rbNovoIndividuo);
            this.gbMutacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMutacao.Location = new System.Drawing.Point(18, 179);
            this.gbMutacao.Name = "gbMutacao";
            this.gbMutacao.Size = new System.Drawing.Size(337, 132);
            this.gbMutacao.TabIndex = 12;
            this.gbMutacao.TabStop = false;
            this.gbMutacao.Text = "Mutação";
            // 
            // rbGenesPop
            // 
            this.rbGenesPop.AutoSize = true;
            this.rbGenesPop.Enabled = false;
            this.rbGenesPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGenesPop.Location = new System.Drawing.Point(27, 88);
            this.rbGenesPop.Name = "rbGenesPop";
            this.rbGenesPop.Size = new System.Drawing.Size(189, 29);
            this.rbGenesPop.TabIndex = 15;
            this.rbGenesPop.Text = "Genes População";
            this.rbGenesPop.UseVisualStyleBackColor = true;
            // 
            // rbPopulacao
            // 
            this.rbPopulacao.AutoSize = true;
            this.rbPopulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPopulacao.Location = new System.Drawing.Point(27, 61);
            this.rbPopulacao.Name = "rbPopulacao";
            this.rbPopulacao.Size = new System.Drawing.Size(178, 29);
            this.rbPopulacao.TabIndex = 14;
            this.rbPopulacao.Text = "População Geral";
            this.rbPopulacao.UseVisualStyleBackColor = true;
            // 
            // rbNovoIndividuo
            // 
            this.rbNovoIndividuo.AutoSize = true;
            this.rbNovoIndividuo.Checked = true;
            this.rbNovoIndividuo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNovoIndividuo.Location = new System.Drawing.Point(27, 34);
            this.rbNovoIndividuo.Name = "rbNovoIndividuo";
            this.rbNovoIndividuo.Size = new System.Drawing.Size(162, 29);
            this.rbNovoIndividuo.TabIndex = 13;
            this.rbNovoIndividuo.TabStop = true;
            this.rbNovoIndividuo.Text = "Novo Indivíduo";
            this.rbNovoIndividuo.UseVisualStyleBackColor = true;
            // 
            // txtQtdeTorneio
            // 
            this.txtQtdeTorneio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeTorneio.Location = new System.Drawing.Point(518, 65);
            this.txtQtdeTorneio.Mask = "0";
            this.txtQtdeTorneio.Name = "txtQtdeTorneio";
            this.txtQtdeTorneio.Size = new System.Drawing.Size(37, 30);
            this.txtQtdeTorneio.TabIndex = 11;
            this.txtQtdeTorneio.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Torneio:";
            // 
            // txtQtdeElitismo
            // 
            this.txtQtdeElitismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeElitismo.Location = new System.Drawing.Point(518, 27);
            this.txtQtdeElitismo.Mask = "0";
            this.txtQtdeElitismo.Name = "txtQtdeElitismo";
            this.txtQtdeElitismo.Size = new System.Drawing.Size(37, 30);
            this.txtQtdeElitismo.TabIndex = 9;
            this.txtQtdeElitismo.Text = "3";
            // 
            // chElitismo
            // 
            this.chElitismo.AutoSize = true;
            this.chElitismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chElitismo.Location = new System.Drawing.Point(383, 27);
            this.chElitismo.Name = "chElitismo";
            this.chElitismo.Size = new System.Drawing.Size(97, 28);
            this.chElitismo.TabIndex = 8;
            this.chElitismo.Text = "Elitismo";
            this.chElitismo.UseVisualStyleBackColor = true;
            // 
            // txtEvolucao
            // 
            this.txtEvolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvolucao.Location = new System.Drawing.Point(194, 131);
            this.txtEvolucao.Mask = "0000";
            this.txtEvolucao.Name = "txtEvolucao";
            this.txtEvolucao.Size = new System.Drawing.Size(161, 30);
            this.txtEvolucao.TabIndex = 7;
            this.txtEvolucao.Text = "100";
            // 
            // txtTaxaMutacao
            // 
            this.txtTaxaMutacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaMutacao.Location = new System.Drawing.Point(194, 95);
            this.txtTaxaMutacao.Mask = "0.0000";
            this.txtTaxaMutacao.Name = "txtTaxaMutacao";
            this.txtTaxaMutacao.Size = new System.Drawing.Size(161, 30);
            this.txtTaxaMutacao.TabIndex = 6;
            this.txtTaxaMutacao.Text = "0001";
            // 
            // txtTaxaCrossover
            // 
            this.txtTaxaCrossover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxaCrossover.Location = new System.Drawing.Point(194, 60);
            this.txtTaxaCrossover.Mask = "0.000";
            this.txtTaxaCrossover.Name = "txtTaxaCrossover";
            this.txtTaxaCrossover.Size = new System.Drawing.Size(161, 30);
            this.txtTaxaCrossover.TabIndex = 5;
            this.txtTaxaCrossover.Text = "0600";
            // 
            // txtTamPop
            // 
            this.txtTamPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamPop.Location = new System.Drawing.Point(194, 24);
            this.txtTamPop.Mask = "00000";
            this.txtTamPop.Name = "txtTamPop";
            this.txtTamPop.Size = new System.Drawing.Size(161, 30);
            this.txtTamPop.TabIndex = 4;
            this.txtTamPop.Text = "50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Evoluções:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taxa de Mutação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taxa de Crossver:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamanho Pop:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(627, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Quantidade de Cidades:";
            // 
            // lbQtdeCidades
            // 
            this.lbQtdeCidades.AutoSize = true;
            this.lbQtdeCidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQtdeCidades.Location = new System.Drawing.Point(847, 9);
            this.lbQtdeCidades.Name = "lbQtdeCidades";
            this.lbQtdeCidades.Size = new System.Drawing.Size(26, 25);
            this.lbQtdeCidades.TabIndex = 2;
            this.lbQtdeCidades.Text = "--";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(627, 682);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Complexidade:";
            // 
            // lbComplex
            // 
            this.lbComplex.AutoSize = true;
            this.lbComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplex.Location = new System.Drawing.Point(752, 682);
            this.lbComplex.Name = "lbComplex";
            this.lbComplex.Size = new System.Drawing.Size(18, 20);
            this.lbComplex.TabIndex = 4;
            this.lbComplex.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1437, 710);
            this.Controls.Add(this.lbComplex);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbQtdeCidades);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMutacao.ResumeLayout(false);
            this.gbMutacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMutacao;
        private System.Windows.Forms.RadioButton rbGenesPop;
        private System.Windows.Forms.RadioButton rbPopulacao;
        private System.Windows.Forms.RadioButton rbNovoIndividuo;
        private System.Windows.Forms.MaskedTextBox txtQtdeTorneio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtQtdeElitismo;
        private System.Windows.Forms.CheckBox chElitismo;
        private System.Windows.Forms.MaskedTextBox txtEvolucao;
        private System.Windows.Forms.MaskedTextBox txtTaxaMutacao;
        private System.Windows.Forms.MaskedTextBox txtTaxaCrossover;
        private System.Windows.Forms.MaskedTextBox txtTamPop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnCriarPop;
        private ZedGraph.ZedGraphControl zedMedia;
        private System.Windows.Forms.Label lbMenorDistancia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbEvolucoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbQtdeCidades;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbComplex;
    }
}

