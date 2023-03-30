using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automata_equivalente.ui
{
    /// <summary>
    /// Class <c>EquivalentView</c> manage the window that shows the equivalent states table.
    /// </summary>
    public partial class EquivalentView : Form
    {
        /// <summary>
        /// This constructor initizalize the window and send the creation of the table.
        /// </summary>
        /// <param name="table">A matrix with the equivalent states table</param>
        /// <param name="isMoore">A bool that says true if its a moore automata</param>
        public EquivalentView(string[,] table,bool isMoore)
        {
            InitializeComponent();
            generateTable(table, isMoore);
        }
        /// <summary>
        /// This method create the data grid view that shows the equivalent states table.
        /// </summary>
        /// <param name="table">A matrix with the equivalent states table</param>
        /// <param name="isMoore">A bool that says true if its a moore automata</param>
        private void generateTable(string[,] table, bool isMoore)
        {
            int column = table.GetLength(1);
            int row = table.GetLength(0);
            dgvEquivalent.ColumnCount = column;
            dgvEquivalent.RowCount = row;
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    dgvEquivalent.Rows[i].Cells[j].Value = table[i, j];
                }
            }
            dgvEquivalent.Rows[0].Cells[0].Value = "Estados";
            if (isMoore)
            {
            dgvEquivalent.Rows[0].Cells[column - 1].Value = "Salida";
            }
        }
    }
}
