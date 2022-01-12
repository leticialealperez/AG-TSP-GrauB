using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AG_TSP.AGClass
{
    public class Population
    {
        public Individual[] population;                     //Grupo de individuos

        //Construtor
        public Population()
        {
            this.population = new Individual[ConfigurationGA.sizePopulation];

            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                this.population[i] = new Individual();
                this.population[i].indexOfVector = i;
            }

            //Avaliar
            calculateFitness();
        }

        //Calcular o fitness todos os inds
        public void calculateFitness()
        {
            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                population[i].CalcFitness();
            }
        }

        //Avaliar toda a populacao
        public void Evaluate()
        {
            refreshIndexOfIndividual();
            calculateFitness();
        }

        public void refreshIndexOfIndividual()
        {

            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                population[i].indexOfVector = i;
            }

        }

        //Retornar um vetor de inds
        public Individual[] getPopulation()
        {
            return this.population;
        }


        public void setIndividuals(int position, Individual individual)
        {
            this.population[position] = individual;
        }

        public double getAveragePopulation()
        {
            double sum = 0;

            foreach(Individual ind in this.population)
            {
                sum += ind.getFitness();
            }

            return (sum / ConfigurationGA.sizePopulation);


        }

        //Metodo para ordenar a populacao do melhor para o pior
        public void OrderPopulation()
        {
            Individual aux;

            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                for (int j = 0; j < ConfigurationGA.sizePopulation; j++)
                {
                    if(population[i].getFitness() < population[j].getFitness())
                    {
                        aux = population[i];
                        population[i] = population[j];
                        population[j] = aux;
                    }
                }
            }
        }

        //Retornar melhor ind
        public Individual getBest()
        {
            OrderPopulation();
            return population[0];
        }

        //Retornar o pior ind
        public Individual getBad()
        {
            OrderPopulation();
            return population[ConfigurationGA.sizePopulation - 1];
        }

        public override string ToString()
        {
            base.ToString();

            string result = string.Empty;

            for(int i = 0; i < ConfigurationGA.sizePopulation; i++)
            {
                result += population[i].ToString() + "\n";
            }

            return result;
        }
    }
}
