using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automata_equivalente.model
{
    /// <summary>
    /// Class <c>Moore</c> create the states' table of a moore automate to use.
    /// </summary>
    class Moore
    {
        private string[,] table;
        private int rowsNumber;
        private int columnNumber;
        /// <summary>
        /// This constructor create de states'table with (<paramref name="sigma"/>,
        /// <paramref name="rows"/>,<paramref name="outputs"/>).
        /// </summary>
        /// <param name="sigma">Is the alphabet for the automata</param>
        /// <param name="rows">All the transitions of all states, having in the first 
        /// position the state name</param>
        /// <param name="outputs">The output of all states order according to the states</param>
        public Moore(string[] sigma, string[] rows, string[] outputs) 
        {
            rowsNumber = rows.Length + 1;
            columnNumber = sigma.Length + 2;
            table = new string[rows.Length + 1, sigma.Length + 2];
            for (int i = 0; i < sigma.Length; i++)
            {
                table[0, i + 1] = sigma[i];
            }
            for (int i = 0; i < rows.Length; i++)
            {
                string[] stateInfo = rows[i].Split(' ');
                for (int j = 0; j < stateInfo.Length; j++)
                {
                    table[i + 1, j] = stateInfo[j];
                }
            }
            for(int i = 0; i < outputs.Length; i++)
            {
                table[i + 1, columnNumber - 1] = outputs[i];
            }
        }
        /// <summary>
        /// This method returns the transitions of a specific state<paramref name="state"/> in the table.
        /// </summary>
        /// <param name="state">is the state to look for its transitions</param>
        /// <returns>The transitions of the given state</returns>
        public List<string> GetTransitions(string state)
        {
            List<string> trans = new List<string>();
            int statePos = 0;
            bool found = false;
            for (int k = 1; k < rowsNumber && !found; k++)
            {
                if (table[k, 0].Equals(state))
                {
                    statePos = k;
                    found = true;
                }
            }
            for (int j = 1; j < columnNumber-1; j++)
            {
                trans.Add(table[statePos, j]);
            }
            return trans;
        }
        /// <summary>
        /// This method returns the output of a specific state<paramref name="state"/> in the table.
        /// </summary>
        /// <param name="state">is the state to look for its output</param>
        /// <returns>The output of the given state</returns>
        public string GetOutputOfState(string state)
        {
            string output;
            int statePos = 0;
            bool found = false;
            for (int k = 1; k < rowsNumber && !found; k++)
            {
                if (table[k, 0].Equals(state))
                {
                    statePos = k;
                    found = true;
                }
            }
            output = table[statePos, columnNumber - 1];
            return output;
        }
        /// <summary>
        /// This method returns the states reachable from the initial state.
        /// </summary>
        /// <returns>A list with all reachable states</returns>
        private List<string> ReachableStates()
        {
            List<string> states = new List<string>();
            states.Add(table[1, 0]);
            for (int i = 0; i < states.Count && states.Count < rowsNumber - 1; i++)
            {
                List<string> transitions = GetTransitions(states[i]);
                for (int j = 0; j < transitions.Count; j++)
                {
                    bool found = false;
                    for (int k = 0; k < states.Count && !found; k++)
                    {
                        if (states[k].Equals(transitions[j]))
                        {
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        states.Add(transitions[j]);
                    }
                }
            }
            return states;
        }
        /// <summary>
        /// This method returns the first partition using the reachable states.
        /// </summary>
        /// <returns>The first partition of the automata</returns>
        /// <exception cref="Exception"></exception>
        public List<string> FirstPartition()
        {
            try
            {
                List<string> partition = new List<string>();
                List<string> states = ReachableStates();
                List<string> outputs = new List<string>();
                for (int i = 0; i < states.Count; i++)
                {
                    string output = GetOutputOfState(states[i]);
                    int partitionPos = 0;
                    bool found = false;
                    for (int k = 0; k < outputs.Count && !found; k++)
                    {
                        if (outputs[k].Equals(output))
                        {
                            found = true;
                            partitionPos = k;
                        }
                    }
                    if (found)
                    {
                        string block = partition[partitionPos] + ',' + states[i];
                        partition[partitionPos] = block;
                    }
                    else
                    {
                        outputs.Add(output);
                        partition.Add(states[i]);
                    }
                }
                return partition;
            }catch(Exception e)
            {
                throw e;
            }
            
        }
        /// <summary>
        /// This method returns the alphabet of the automata.
        /// </summary>
        /// <returns>A list of alphabet collection of the automata</returns>
        public List<string> GetSigma()
        {
            List<string> sigma = new List<string>();
            for (int i = 1; i < columnNumber-1; i++)
            {
                sigma.Add(table[0, i]);
            }
            return sigma;
        }
        /// <summary>
        /// This method returns the partition states that contains a specif state.
        /// </summary>
        /// <param name="state">The state that's looking for in the partition</param>
        /// <param name="partitions">The list of partition to look for the state</param>
        /// <returns>The states of a partition that contains the receiving state</returns>
        public string GetPartitionOfState(string state, List<string> partitions)
        {
            string partition = "";
            bool found = false;
            for (int i = 0; i < partitions.Count && !found; i++)
            {
                if (partitions[i].Contains(state))
                {
                    found = true;
                    partition = partitions[i];
                }
            }
            return partition;
        }
        /// <summary>
        /// This method generate partitions until the previous is the same of the new partition.
        /// </summary>
        /// <param name="partition">Is the previous partition use for create a new one</param>
        /// <returns>The new partition that is equals of the receiving partition</returns>
        public List<string> GeneratePartition(List<string> partition)
        {
            List<string> newPartition = new List<string>();
            int partitionNumber = 0;
            for (int i = 0; i < partition.Count; i++)
            {
                List<string> positionsPartition = new List<string>();
                string[] states = partition[i].Split(',');
                for (int j = 0; j < states.Length; j++)
                {
                    List<string> transitions = GetTransitions(states[j]);
                    string position = "";
                    bool found;
                    for (int k = 0; k < transitions.Count; k++)
                    {
                        found = false;
                        for (int m = 0; m < partition.Count && !found; m++)
                        {
                            if (partition[m].Contains(transitions[k]))
                            {
                                found = true;
                                position += m;
                            }
                        }
                    }
                    found = false;
                    int p=0;
                    for (int k = 0; k < positionsPartition.Count && !found; k++)
                    {
                        string[] temp = positionsPartition[k].Split(',');
                        if (temp[0].Equals(position))
                        {
                            found = true;
                            p = k;
                        }
                    }
                    if (found)
                    {
                        string[] temp = positionsPartition[p].Split(',');
                        int number = int.Parse(temp[1]);
                        newPartition[number] = newPartition[number] + ',' + states[j];
                    }
                    else
                    {
                        positionsPartition.Add(position+','+partitionNumber);
                        newPartition.Add(states[j]);
                        partitionNumber++;
                    }
                }
            }
            if (!PartitionsEquals(partition, newPartition))
            {
                return GeneratePartition(newPartition);
            }
            return newPartition;
        }
        /// <summary>
        /// This method compare two partitions and check if they are equal.
        /// </summary>
        /// <param name="partition1">The first partition to be compared</param>
        /// <param name="partition2">the second partition to be compared</param>
        /// <returns>A bool that is true if the partitions are the same, otherwise is false</returns>
        public bool PartitionsEquals(List<string> partition1, List<string> partition2)
        {
            bool equals = true;
            if (partition1.Count == partition2.Count)
            {
                for (int i = 0; i < partition1.Count; i++)
                {
                    int states1 = partition1[i].Length;
                    int states2 = partition2[i].Length;
                    if (states1 != states2)
                    {
                        equals = false;
                    }
                }
            }
            else
            {
                equals = false;
            }
            return equals;
        }
    }
}
