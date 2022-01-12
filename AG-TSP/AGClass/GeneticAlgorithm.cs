using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG_TSP.AGClass
{
    public class GeneticAlgorithm
    {
        private double rateCrossover;               //Taxa de cruzamento
        private double rateMutation;                //Taxa de mutação

        public delegate Individual[] Crossover(Individual father1, Individual father2);
        public Crossover crossover;

        public delegate Individual Selection(Population pop);
        public Selection selection;


        public GeneticAlgorithm()
        {
            //Parametros iniciais
            this.crossover = CrossoverPMX;
            this.selection = Tournament;

            this.rateCrossover = ConfigurationGA.rateCrossover;
            this.rateMutation = ConfigurationGA.rateMutation;
        }

        //Execução do AG
        public Population executeGA(Population pop)
        {
            
            //Criar a pop: vem por parametro
            //Inicio do AG
            //Avaliar a pop

            Population newPopulation = new Population();
            List<Individual> popTemp = new List<Individual>();

            //Atribuir individuos a pop temp
            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                popTemp.Add(pop.getPopulation()[i]);
            }
            
            //Elitismo
            Individual[] IndElit = new Individual[ConfigurationGA.sizeElitism];

            //Caso optar por elistimo
            if(ConfigurationGA.elitism)
            {
                //Ordernar a pop
                pop.OrderPopulation();

                for(int i = 0; i < ConfigurationGA.sizeElitism; i++)
                {
                    IndElit[i] = pop.getPopulation()[i];
                }
            }
            

            for (int i = 0; i < (ConfigurationGA.sizePopulation/2); i++)
            {
                //Seleção dos pais
                Individual father1 = selection(pop);
                Individual father2 = selection(pop);

                //Cruzamento dos pais
                double sortCrossNum = ConfigurationGA.random.NextDouble();

                if (sortCrossNum <= rateCrossover)
                {
                    //Console.WriteLine("Crossover em: " + i);
                   Individual[] children =  crossover(father1, father2);
                    
                    //Mutação
                    if (ConfigurationGA.mutationType == ConfigurationGA.Mutation.NewIndividual)
                    {
                        children[0] = Mutation(children[0]);
                        children[1] = Mutation(children[1]);
                    }
                    
                    //Rearranjar os filhos no vetor
                    children[0].indexOfVector = father1.indexOfVector;
                    children[1].indexOfVector = father2.indexOfVector;

                    popTemp[father1.indexOfVector] = children[0];
                    popTemp[father2.indexOfVector] = children[1];
                    
                }
                else
                {
                    popTemp[father1.indexOfVector] = father1;
                    popTemp[father2.indexOfVector] = father2;
                }
            }

            //Apagar os velhos membros
            //Inserir os novos membros

            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                newPopulation.setIndividuals(i, popTemp[i]);
            }
            
            popTemp = null;

            //Aplicação de mutacao na pop
            if(ConfigurationGA.mutationType == ConfigurationGA.Mutation.InPopulation)
            {
                newPopulation = MutationThePopulation(newPopulation);
            }
            
            //Inserir nova pop
            //Inserindo os individuos do elitismo na nova pop
            if (ConfigurationGA.elitism)
            {
                //Avaliar a pop
                newPopulation.Evaluate();
                //Orderar a pop
                newPopulation.OrderPopulation();
         
                int initPoint = ConfigurationGA.sizePopulation - ConfigurationGA.sizeElitism;
                int count = 0;

                for (int i = initPoint; i < ConfigurationGA.sizePopulation; i++)
                {
                    newPopulation.getPopulation()[i] = IndElit[count];
                    count++;
                }
                //Console.WriteLine("11");
            }

            //Avaliação
            newPopulation.Evaluate();
            return newPopulation;
        }

        //Cruzamento
        public Individual[] CrossoverPMX(Individual father1, Individual father2)
        {

            //Variavel de retorno
            Individual[] newInd = new Individual[2];

            int[] parent1 = new int[ConfigurationGA.sizeChromosome];
            int[] parent2 = new int[ConfigurationGA.sizeChromosome];

            int[] offspring1Vector = new int[ConfigurationGA.sizeChromosome];
            int[] offspring2Vector = new int[ConfigurationGA.sizeChromosome];

            int[] replacement1 = new int[ConfigurationGA.sizeChromosome];
            int[] replacement2 = new int[ConfigurationGA.sizeChromosome];

            //Seleção dos pontos para cruzamento
            int firstPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);
            int secondPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);

            /*if(firstPoint == secondPoint)
            {
                secondPoint = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);
            }*/

            if(secondPoint < firstPoint)
            {
                int tmp = secondPoint;
                secondPoint = firstPoint;
                firstPoint = tmp;
            }
            else if(firstPoint == secondPoint)
            {
                secondPoint++;
            }

            //Console.WriteLine("P1: " + firstPoint + " P2: " + secondPoint);

            newInd[0] = new Individual();
            newInd[1] = new Individual();

            //Transferir os genes para um parent
            for(int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                parent1[i] = offspring1Vector[i] = father1.getGene(i);
                parent2[i] = offspring2Vector[i] = father2.getGene(i);
            }

            //popular o replacemente em valores abaixo de 0
            for (int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                replacement1[i] = replacement2[i] = -1;
            }

            //Passo de cruzamento
            for(int i = firstPoint; i <= secondPoint; i++)
            {
                offspring1Vector[i] = parent2[i];
                offspring2Vector[i] = parent1[i];

                replacement1[parent2[i]] = parent1[i];
                replacement2[parent1[i]] = parent2[i];
            }

            //troca de genes repetidos
            for(int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                if ((i >= firstPoint) && (i <= secondPoint))
                    continue;

                //troca
                int n1 = parent1[i];
                int m1 = replacement1[n1];

                int n2 = parent2[i];
                int m2 = replacement2[n2];


                while(m1 != -1)
                {
                    n1 = m1;
                    m1 = replacement1[m1];
                }

                while(m2 != -1)
                {
                    n2 = m2;
                    m2 = replacement2[m2];
                }

                offspring1Vector[i] = n1;
                offspring2Vector[i] = n2;
            }

            for (int i = 0; i < ConfigurationGA.sizeChromosome; i++)
            {
                newInd[0].setGene(i, offspring1Vector[i]);
                newInd[1].setGene(i, offspring2Vector[i]);
            }

            newInd[0].CalcFitness();
            newInd[1].CalcFitness();
            return newInd;
        }

        //Mutação tipo SWAP
        public Individual Mutation(Individual ind)
        {
            //Verifica se vai mutar
            if(ConfigurationGA.random.NextDouble() <= rateMutation)
            {
                Console.WriteLine("Mutacao");
                //escolher os pontos de mutação
                int genePosition1 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);
                int genePosition2 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);

                //Console.WriteLine("P1: " + genePosition1 + " P2: " + genePosition2);

                if (genePosition1 == genePosition2)
                {
                    if(genePosition2 < ConfigurationGA.sizeChromosome - 2)
                    {
                        genePosition2++;
                    }
                }

                ind.mutate(genePosition1, genePosition2);
                return ind;
            }
            return ind;
        }

        //Mutar cada individuo da populacao
        public Population MutationThePopulation(Population pop)
        {

            for (int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                //Verifica se vai mutar
                if (ConfigurationGA.random.NextDouble() <= rateMutation)
                {
                    //escolher os pontos de mutação
                    int genePosition1 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);
                    int genePosition2 = ConfigurationGA.random.Next(0, ConfigurationGA.sizeChromosome - 1);

                    if (genePosition1 == genePosition2)
                    {
                        if (genePosition2 < ConfigurationGA.sizeChromosome - 2)
                        {
                            genePosition2++;
                        }
                        else
                        {
                            genePosition2 -= 2;
                        }
                    }
                    pop.getPopulation()[i].mutate(genePosition1, genePosition2);
                }
            }

            return pop;
        }

        //Mutar cada gene em relacao a pop
        public Population MutationGenesOfPopulation(Population pop)
        {
            return null;
        }

        //Seleção por torneio
        public Individual Tournament(Population pop)
        {
            Individual[] competitors = new Individual[ConfigurationGA.numbOfCompetitors];

            Individual aux = new Individual();
            aux.setFitness(float.PositiveInfinity);

            //Selecao de competidores
            for(int i = 0; i < ConfigurationGA.numbOfCompetitors; i++)
            {
                competitors[i] = new Individual();
                competitors[i] = pop.getPopulation()[ConfigurationGA.random.Next(0, ConfigurationGA.sizePopulation - 1)];
                //Console.WriteLine(competitors[i]);
            }

            //Escolher o vencedor
            for (int i = 0; i < ConfigurationGA.numbOfCompetitors; i++)
            {
                if(competitors[i].getFitness() < aux.getFitness())
                {
                    aux = competitors[i];
                    aux.CalcFitness();
                }
            }
            return aux;
        }
    }
}
