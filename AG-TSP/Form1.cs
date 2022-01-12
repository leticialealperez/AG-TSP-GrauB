using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AG_TSP.AGClass;
using ZedGraph;
using AG_TSP.AGClass;

namespace AG_TSP
{
    public partial class Form1 : Form
    {

        Graphics g;                                 //Desenhar elementos na tela
        int count = 0;                              //Contador para verificar quantidade de pontos na tela
        int pointCount = 0;                         //Sequenciador para indentificar pontos na tela

        //ZedGraph
        private GraphPane paneMedia;
        private PointPairList mediaPopulacao = new PointPairList();


        //Objeto Populacao
        Population pop;

        int evolucoes = 0;
        int i = 0;
        int iTemp = 0;          //intacoes
        double bestAux = double.PositiveInfinity;

        //Construtor
        public Form1()
        {
            InitializeComponent();

            paneMedia = zedMedia.GraphPane;
            paneMedia.Title.Text = "Média da População";
            paneMedia.XAxis.Title.Text = "Evolucão";
            paneMedia.YAxis.Title.Text = "Média Fitness";
            zedMedia.Refresh();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }



        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            //Console.WriteLine("Point Insert");

            //Criar um lapis
            Pen blackPen = new Pen(Color.Red, 3);
            int X = e.X;
            int Y = e.Y;
            //Console.WriteLine("X: " + X + " Y: " + Y);

            TablePoints.addPoint(X, Y);

            Rectangle rect = new Rectangle(X - 5, Y - 5, 10, 10);
            g.DrawEllipse(blackPen, rect);
            g.DrawString((pointCount + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, X + 3, Y);
            g.DrawString("X:" + X.ToString(), new Font("Arial Black", 6), Brushes.Black, X - 20, Y - 25);
            g.DrawString("Y:" + Y.ToString(), new Font("Arial Black", 6), Brushes.Black, X - 20, Y - 18);

            pointCount++;
            lbQtdeCidades.Text = pointCount.ToString();
            lbComplex.Text = Fatorial((ulong)pointCount).ToString();

            if(++count >= 4)
            {
                btnCriarPop.Enabled = true;
            }

            if(++count >= 1)
            {
                btnLimpar.Enabled = true;
            }
            else
            {
                btnLimpar.Enabled = false;
            }

            Console.WriteLine(TablePoints.print());
        }

        public ulong Fatorial(ulong number)
        {
            if (number <= 1)
                return 1;
            else return number * Fatorial(number - 1);


        }
        
        private void plotPoints()
        {
            //Vericando se a tabela possui pontos
            if(TablePoints.pointCount > 0)
            {

                for(int i = 0; i < TablePoints.pointCount; i++)
                {
                    //Criar um lapis
                    Pen blackPen = new Pen(Color.Red, 3);
                    //Vetor de coordenadas (x, y) (0, 1)
                    int[] coo = TablePoints.getCoordinates(i);
                    Rectangle rect = new Rectangle(coo[0] - 5, coo[1] - 5, 10, 10);
                    g.DrawEllipse(blackPen, rect);
                    g.DrawString((i + 1).ToString(), new Font("Arial Black", 11), Brushes.Black, coo[0] + 3, coo[1]);
                    g.DrawString("X:" + coo[0].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 25);
                    g.DrawString("Y:" + coo[1].ToString(), new Font("Arial Black", 6), Brushes.Black, coo[0] - 20, coo[1] - 18);
                }
            }
        }

        
        private void plotLines(Population pop, Color color)
        {
            Pen penBest = new Pen(color, 4);
            int genA, genB;

            Individual best = pop.getBest();

            for(int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                if(i < ConfigurationGA.sizeChromosome - 1)
                {
                    genA = best.getGene(i);
                    genB = best.getGene(i + 1);
                }
                else
                {
                    genA = best.getGene(i);
                    genB = best.getGene(0);
                }

                int[] vetA = TablePoints.getCoordinates(genA);
                int[] vetB = TablePoints.getCoordinates(genB);

                g.DrawLine(penBest, vetA[0], vetA[1], vetB[0], vetB[1]);

            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCriarPop_Click(object sender, EventArgs e)
        {
            ConfigurationGA.sizePopulation = int.Parse(txtTamPop.Text);
            pop = new Population();
            btnExecutar.Enabled = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pointCount = 0;
            i = 0;
            iTemp = 0;
            evolucoes = 0;
            lbEvolucoes.Text = "00";

            ConfigurationGA.sizePopulation = 0;
            TablePoints.clear();
            pop = null;

            lbQtdeCidades.Text = "--";

            btnCriarPop.Enabled = false;
            btnExecutar.Enabled = false;
            btnLimpar.Enabled = false;

            g.Clear(Color.White);
            count = 0;

            mediaPopulacao.Clear();
            zedMedia.Refresh();

        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            btnCriarPop.Enabled = false;

            float taxaMutacao = float.Parse(txtTaxaMutacao.Text);
            float taxaCrossover = float.Parse(txtTaxaCrossover.Text);
            int torneio = int.Parse(txtQtdeTorneio.Text);
            evolucoes += int.Parse(txtEvolucao.Text);

            bestAux = double.PositiveInfinity;

            //Configurar AG
            ConfigurationGA.rateCrossover = taxaCrossover;
            ConfigurationGA.rateMutation = taxaMutacao;
            ConfigurationGA.numbOfCompetitors = torneio;
            ConfigurationGA.Mutation mutacao = ConfigurationGA.Mutation.NewIndividual;

            if(rbNovoIndividuo.Checked)
            {
                mutacao = ConfigurationGA.Mutation.NewIndividual;
            }
            else if(rbPopulacao.Checked)
            {
                mutacao = ConfigurationGA.Mutation.InPopulation;
            }
            else if(rbGenesPop.Checked)
            {
                mutacao = ConfigurationGA.Mutation.InGenesPopulacao;
            }

            ConfigurationGA.mutationType = mutacao;

            //Elitismo
            if(chElitismo.Checked)
            {
                ConfigurationGA.elitism = true;
                ConfigurationGA.sizeElitism = int.Parse(txtQtdeElitismo.Text);
            }
            else
            {
                ConfigurationGA.elitism = false;
            }

            Console.Write("---------------------------------------------------------------- \n");
            Console.Write("TIPO CROSSOVER: " + "PMX" + "\n");
            Console.Write("TIPO MUTACAO: " + ConfigurationGA.mutationType + "\n");
            Console.Write("TIPO SELECAO: " + "Torneio" + "\n");
            Console.Write("ELITISMO: " + ConfigurationGA.elitism + "  QTDE: " + ConfigurationGA.sizeElitism + "\n");
            Console.Write("TAXA MUTACAO: " + ConfigurationGA.rateMutation + "\n");
            Console.Write("TAXA CROSSOVER: " + ConfigurationGA.rateCrossover + "\n");
            Console.Write("EVOLUCOES: " + evolucoes.ToString() + "\n");
            Console.Write("---------------------------------------------------------------- \n");

            GeneticAlgorithm AG = new GeneticAlgorithm();

            for (i = iTemp; i < evolucoes; i++)
            {
                iTemp++;

                lbEvolucoes.Text = i.ToString();
                lbEvolucoes.Refresh();

                //Evolucao do Algorit Genetico
                pop = AG.executeGA(pop);

                //Limpar o grafico
                zedMedia.GraphPane.CurveList.Clear();
                zedMedia.GraphPane.GraphObjList.Clear();

                double mediaPop = pop.getAveragePopulation();
                mediaPopulacao.Add(i, mediaPop);

                double bestFitness = pop.getBest().getFitness();
                lbMenorDistancia.Text = bestFitness.ToString();
                lbMenorDistancia.Refresh();

                LineItem media = paneMedia.AddCurve("Média", mediaPopulacao, Color.Red, SymbolType.None);

                //Print linhas a cada 6 evolucoes
                if(i%6 == 0 && bestFitness < bestAux)
                {
                    bestAux = bestFitness;
                    g.Clear(Color.White);
                    plotLines(pop, Color.Blue);
                    plotPoints();
                }

                zedMedia.AxisChange();
                zedMedia.Invalidate();
                zedMedia.Refresh();
            }

            g.Clear(Color.White);
            plotLines(pop, Color.Blue);
            plotPoints();
        }
    }
}
