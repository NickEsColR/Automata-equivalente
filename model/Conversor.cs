using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automata_equivalente.model
{
    /// <summary>
    /// Class <c>Conversor</c> manage the automata and create its equivalent table.
    /// </summary>
    class Conversor
    {
        private Mealy mealy;
        private Moore moore;
        /// <summary>
        /// This constructor create the conversor manager and initializa the mealy and moore attributtes.
        /// </summary>
        public Conversor() { mealy = null; moore = null; }
        /// <summary>
        /// This method create a Mealy entity using its constructor.
        /// </summary>
        /// <param name="sigma">Is the alphabet for the automata</param>
        /// <param name="rows">All the transitions of all states, having in the first 
        /// position the state name</param>
        public void CreateMealy(string[] sigma, string[] rows)
        {
            mealy = new Mealy(sigma, rows);
        }
        /// <summary>
        /// This method create a Moore entity using its constructor.
        /// </summary>
        /// <param name="sigma">Is the alphabet for the automata</param>
        /// <param name="rows">All the transitions of all states, having in the first 
        /// position the state name</param>
        /// <param name="outputs">The output of all states order according to the states</param>
        public void CreateMooore(string[] sigma, string[] rows, string[] outputs)
        {
            moore = new Moore(sigma, rows, outputs);
        }
        /// <summary>
        /// This method generate an equivalent states table of the automata previous given
        /// </summary>
        /// <returns>A matrix that's the equivalent states table </returns>
        /// <exception cref="Exception"></exception>
        public string[,] GenerateEquivalent()
        {
            try
            {
                List<string> partition1 = new List<string>();

                string[,] table = null;
                if (mealy != null)
                {
                    partition1 = mealy.FirstPartition();
                    partition1 = mealy.GeneratePartition(partition1);
                    List<string> sigma = mealy.GetSigma();
                    table = new string[partition1.Count + 1, sigma.Count + 1];
                    for (int i = 0; i < sigma.Count; i++)
                    {
                        table[0, i + 1] = sigma[i];
                    }
                    for (int i = 0; i < partition1.Count; i++)
                    {
                        string[] state = partition1[i].Split(',');
                        List<string> transitions = mealy.GetTransitions(state[0]);
                        table[i + 1, 0] = partition1[i];
                        for (int j = 0; j < transitions.Count; j++)
                        {
                            string[] trans = transitions[j].Split(',');
                            string partitionState = mealy.GetPartitionOfState(trans[0], partition1);
                            table[i + 1, j + 1] = partitionState + ',' + trans[1];
                        }
                    }
                }
                else if (moore != null)
                {
                    partition1 = moore.FirstPartition();
                    partition1 = moore.GeneratePartition(partition1);
                    List<string> sigma = moore.GetSigma();
                    table = new string[partition1.Count + 1, sigma.Count + 2];
                    for (int i = 0; i < sigma.Count; i++)
                    {
                        table[0, i + 1] = sigma[i];
                    }
                    for (int i = 0; i < partition1.Count; i++)
                    {
                        string[] state = partition1[i].Split(',');
                        List<string> transitions = moore.GetTransitions(state[0]);
                        string outputState = moore.GetOutputOfState(state[0]);
                        table[i + 1, sigma.Count + 1] = outputState;
                        table[i + 1, 0] = partition1[i];
                        for (int j = 0; j < transitions.Count; j++)
                        {
                            string partitionState = moore.GetPartitionOfState(transitions[j], partition1);
                            table[i + 1, j + 1] = partitionState;
                        }
                    }
                }
                return table;
            }catch(Exception e)
            {
                throw e;
            }
            
        }
        /// <summary>
        /// This method clean the data for create a new equivalent states table.
        /// </summary>
        public void clear() { mealy = null; moore = null; }
    }
}
