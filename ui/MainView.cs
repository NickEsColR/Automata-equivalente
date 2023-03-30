using automata_equivalente.model;
using automata_equivalente.ui;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace automata_equivalente
{
    /// <summary>
    /// Class <c>MainView</c> manage the window that create the states table to be minimized.
    /// </summary>
    public partial class MainView : Form
    {
        private Conversor conversor;
        private string[] sigma;
        private string[] states;
        private string[] outputs;
        private string[] rows;
        private int actualState;
        private EquivalentView equivalentView;
        /// <summary>
        /// This constructor initialize the window and create the Conversor entity
        /// </summary>
        public MainView()
        {
            InitializeComponent();
            conversor = new Conversor();
        }
        /// <summary>
        /// This method ensure to close the equivalent window when the main window is closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
             equivalentView.Close();
        }
        /// <summary>
        /// This method manage the option of select the moore creation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbMoore_Click(object sender, System.EventArgs e)
        {
            lblOutputs.Visible = true;
            txtOutputs.Visible = true;
        }
        /// <summary>
        /// This method manage the option of select the mealy creation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbMealy_Click(object sender, System.EventArgs e)
        {
            lblOutputs.Visible = false;
            txtOutputs.Visible = false;
        }
        /// <summary>
        /// This method manage the creation of the state table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            if (txtSigma.Text != "")
            {
                sigma = txtSigma.Text.Split(' ');
                if (txtStates.Text != "")
                {
                    states = txtStates.Text.Split(' ');
                    if (rbMoore.Checked == true)
                    {
                        if(txtOutputs.Text != "")
                        {
                            outputs = txtOutputs.Text.Split(' ');
                            lblTransitions.Visible = true;
                            txtTransitions.Visible = true;
                            btnAddTransition.Visible = true;
                            btnGenerate.Visible = true;
                            lblState.Visible = true;
                            lblState.Text = states[0];
                            createTable();
                            actualState = 0;
                            rows = new string[states.Length];
                            rbMoore.Enabled = false;
                            rbMealy.Enabled = false;
                            btnCreate.Visible = false;
                            txtSigma.Text = "";
                            txtStates.Text = "";
                            txtOutputs.Text = "";
                            lblSigma.Visible = false;
                            lblStates.Visible = false;
                            txtSigma.Visible = false;
                            txtStates.Visible = false;
                            lblOutputs.Visible = false;
                            txtOutputs.Visible = false;
                            lblErrorCreate.Text = "";
                        }
                        else
                        {
                            lblErrorCreate.Text = "Por favor ingrese las salidas de los estados";
                        }
                    }
                    else
                    {
                        lblTransitions.Visible = true;
                        txtTransitions.Visible = true;
                        btnAddTransition.Visible = true;
                        btnGenerate.Visible = true;
                        lblState.Visible = true;
                        lblState.Text = states[0];
                        createTable();
                        actualState = 0;
                        rows = new string[states.Length];
                        rbMoore.Enabled = false;
                        rbMealy.Enabled = false;
                        btnCreate.Visible = false;
                        txtSigma.Text = "";
                        txtStates.Text = "";
                        lblSigma.Visible = false;
                        lblStates.Visible = false;
                        txtSigma.Visible = false;
                        txtStates.Visible = false;
                        lblErrorCreate.Text = "";
                    }
                }
                else
                {
                    lblErrorCreate.Text = "Por favor ingrese los estados del automata";
                }
            }
            else
            {
                lblErrorCreate.Text = "Por favor ingrese el alfabeto del automata";
            }   
        }
        /// <summary>
        /// this method create a data grid view in order the user can see what is introduced.
        /// </summary>
        private void createTable()
        {
            dgvAutomata.Columns.Add("Estados", "Estados");
            for(int i = 0; i < sigma.Length; i++)
            {
                dgvAutomata.Columns.Add(sigma[i],sigma[i]);
            }
            for(int i = 0; i < states.Length; i++)
            {
                dgvAutomata.Rows.Add();
                dgvAutomata.Rows[i].Cells[0].Value = states[i];
            }
            if (rbMoore.Checked == true)
            {
                dgvAutomata.Columns.Add("Salida", "Salida");
                for(int i = 0; i < outputs.Length; i++)
                {
                    dgvAutomata.Rows[i].Cells[sigma.Length+1].Value = outputs[i];
                }
            }
        }
        /// <summary>
        /// This method clear all previously assigned in order to introduce a new automata.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, System.EventArgs e)
        {
            txtOutputs.Text = "";
            txtSigma.Text = "";
            txtStates.Text = "";
            txtTransitions.Text = "";
            dgvAutomata.Columns.Clear();
            lblTransitions.Visible = false;
            lblState.Visible = false;
            txtTransitions.Visible = false;
            btnAddTransition.Visible = false;
            btnGenerate.Visible = false;
            rbMoore.Enabled = true;
            rbMealy.Enabled = true;
            btnCreate.Visible = true;
            lblSigma.Visible = true;
            lblStates.Visible = true;
            txtSigma.Visible = true;
            txtStates.Visible = true;
            lblErrorCreate.Text = "";
            lblErrorTable.Text = "";
            lblErrorTransition.Text = "";
            conversor.clear();
            btnAddTransition.Enabled = true;
            btnGenerate.Enabled = false;
        }
        /// <summary>
        /// This method manage when the user add the transitions of a state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTransition_Click(object sender, System.EventArgs e)
        {
            if (txtTransitions.Text != "")
            {
                string row = states[actualState];
                string[] transitions = txtTransitions.Text.Split(' ');
                for(int i = 0; i < transitions.Length; i++)
                {
                    row += ' '+transitions[i];
                    dgvAutomata.Rows[actualState].Cells[i + 1].Value = transitions[i];
                }
                rows[actualState] = row;
                actualState++;
                txtTransitions.Text = "";
                lblErrorTransition.Text = "";
                if (actualState < states.Length)
                {
                    lblState.Text = states[actualState];
                }
                else
                {
                    btnGenerate.Enabled = true;
                    btnAddTransition.Enabled = false;
                    
                }
            }
            else
            {
                lblErrorTransition.Text = "Por favor ingrese la transicion del estado " + states[actualState];
            }
        }
        /// <summary>
        /// This method manage the generation of the equivalent states table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerate_Click(object sender, System.EventArgs e)
        {
            if (rbMealy.Checked == true)
            {
                conversor.CreateMealy(sigma, rows);    
            }
            else
            {
                conversor.CreateMooore(sigma, rows, outputs);
            }
            try
            {
            string[,] equivalent = conversor.GenerateEquivalent();
            equivalentView = new EquivalentView(equivalent, rbMoore.Checked);
            equivalentView.Show();
            }catch(Exception exc)
            {
                lblErrorTable.Text = "No se puede generar un automata equivalente, " +
                    "revisa que la tabla cumpla los requisitos";
            }
        }
    }
}
