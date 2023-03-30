
namespace automata_equivalente
{
    partial class MainView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.gbTipoAutomata = new System.Windows.Forms.GroupBox();
            this.rbMoore = new System.Windows.Forms.RadioButton();
            this.rbMealy = new System.Windows.Forms.RadioButton();
            this.lblSigma = new System.Windows.Forms.Label();
            this.txtSigma = new System.Windows.Forms.TextBox();
            this.lblStates = new System.Windows.Forms.Label();
            this.txtStates = new System.Windows.Forms.TextBox();
            this.lblOutputs = new System.Windows.Forms.Label();
            this.txtOutputs = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblTransitions = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtTransitions = new System.Windows.Forms.TextBox();
            this.btnAddTransition = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgvAutomata = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblErrorTransition = new System.Windows.Forms.Label();
            this.lblErrorCreate = new System.Windows.Forms.Label();
            this.lblErrorTable = new System.Windows.Forms.Label();
            this.gbTipoAutomata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomata)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTipoAutomata
            // 
            this.gbTipoAutomata.Controls.Add(this.rbMoore);
            this.gbTipoAutomata.Controls.Add(this.rbMealy);
            this.gbTipoAutomata.Location = new System.Drawing.Point(12, 12);
            this.gbTipoAutomata.Name = "gbTipoAutomata";
            this.gbTipoAutomata.Size = new System.Drawing.Size(196, 80);
            this.gbTipoAutomata.TabIndex = 0;
            this.gbTipoAutomata.TabStop = false;
            this.gbTipoAutomata.Text = "Tipo de automata";
            // 
            // rbMoore
            // 
            this.rbMoore.AutoSize = true;
            this.rbMoore.Location = new System.Drawing.Point(109, 32);
            this.rbMoore.Name = "rbMoore";
            this.rbMoore.Size = new System.Drawing.Size(55, 17);
            this.rbMoore.TabIndex = 1;
            this.rbMoore.Text = "Moore";
            this.rbMoore.UseVisualStyleBackColor = true;
            this.rbMoore.Click += new System.EventHandler(this.rbMoore_Click);
            // 
            // rbMealy
            // 
            this.rbMealy.AutoSize = true;
            this.rbMealy.Checked = true;
            this.rbMealy.Location = new System.Drawing.Point(19, 32);
            this.rbMealy.Name = "rbMealy";
            this.rbMealy.Size = new System.Drawing.Size(53, 17);
            this.rbMealy.TabIndex = 0;
            this.rbMealy.TabStop = true;
            this.rbMealy.Text = "Mealy";
            this.rbMealy.UseVisualStyleBackColor = true;
            this.rbMealy.Click += new System.EventHandler(this.rbMealy_Click);
            // 
            // lblSigma
            // 
            this.lblSigma.AutoSize = true;
            this.lblSigma.Location = new System.Drawing.Point(20, 133);
            this.lblSigma.Name = "lblSigma";
            this.lblSigma.Size = new System.Drawing.Size(110, 13);
            this.lblSigma.TabIndex = 1;
            this.lblSigma.Text = "Alfabeto del automata";
            // 
            // txtSigma
            // 
            this.txtSigma.Location = new System.Drawing.Point(150, 130);
            this.txtSigma.Name = "txtSigma";
            this.txtSigma.Size = new System.Drawing.Size(221, 20);
            this.txtSigma.TabIndex = 2;
            // 
            // lblStates
            // 
            this.lblStates.AutoSize = true;
            this.lblStates.Location = new System.Drawing.Point(20, 168);
            this.lblStates.Name = "lblStates";
            this.lblStates.Size = new System.Drawing.Size(109, 13);
            this.lblStates.TabIndex = 3;
            this.lblStates.Text = "Estados del automata";
            // 
            // txtStates
            // 
            this.txtStates.Location = new System.Drawing.Point(150, 165);
            this.txtStates.Name = "txtStates";
            this.txtStates.Size = new System.Drawing.Size(221, 20);
            this.txtStates.TabIndex = 4;
            // 
            // lblOutputs
            // 
            this.lblOutputs.AutoSize = true;
            this.lblOutputs.Location = new System.Drawing.Point(20, 207);
            this.lblOutputs.Name = "lblOutputs";
            this.lblOutputs.Size = new System.Drawing.Size(112, 13);
            this.lblOutputs.TabIndex = 5;
            this.lblOutputs.Text = "Salidas de los estados";
            this.lblOutputs.Visible = false;
            // 
            // txtOutputs
            // 
            this.txtOutputs.Location = new System.Drawing.Point(150, 204);
            this.txtOutputs.Name = "txtOutputs";
            this.txtOutputs.Size = new System.Drawing.Size(221, 20);
            this.txtOutputs.TabIndex = 6;
            this.txtOutputs.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(214, 69);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(161, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Crear Automata";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblTransitions
            // 
            this.lblTransitions.AutoSize = true;
            this.lblTransitions.Location = new System.Drawing.Point(20, 265);
            this.lblTransitions.Name = "lblTransitions";
            this.lblTransitions.Size = new System.Drawing.Size(85, 13);
            this.lblTransitions.TabIndex = 8;
            this.lblTransitions.Text = "Transiciones de ";
            this.lblTransitions.Visible = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Red;
            this.lblState.Location = new System.Drawing.Point(101, 265);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(17, 17);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "A";
            this.lblState.Visible = false;
            // 
            // txtTransitions
            // 
            this.txtTransitions.Location = new System.Drawing.Point(150, 262);
            this.txtTransitions.Name = "txtTransitions";
            this.txtTransitions.Size = new System.Drawing.Size(221, 20);
            this.txtTransitions.TabIndex = 10;
            this.txtTransitions.Visible = false;
            // 
            // btnAddTransition
            // 
            this.btnAddTransition.Location = new System.Drawing.Point(12, 298);
            this.btnAddTransition.Name = "btnAddTransition";
            this.btnAddTransition.Size = new System.Drawing.Size(151, 23);
            this.btnAddTransition.TabIndex = 11;
            this.btnAddTransition.Text = "Agregar Transicion";
            this.btnAddTransition.UseVisualStyleBackColor = true;
            this.btnAddTransition.Visible = false;
            this.btnAddTransition.Click += new System.EventHandler(this.btnAddTransition_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(197, 298);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(174, 23);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generar Automata Equivalente";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Visible = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dgvAutomata
            // 
            this.dgvAutomata.AllowUserToAddRows = false;
            this.dgvAutomata.AllowUserToDeleteRows = false;
            this.dgvAutomata.AllowUserToResizeColumns = false;
            this.dgvAutomata.AllowUserToResizeRows = false;
            this.dgvAutomata.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAutomata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomata.Location = new System.Drawing.Point(423, 38);
            this.dgvAutomata.Name = "dgvAutomata";
            this.dgvAutomata.ReadOnly = true;
            this.dgvAutomata.Size = new System.Drawing.Size(587, 283);
            this.dgvAutomata.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(214, 28);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblErrorTransition
            // 
            this.lblErrorTransition.AutoSize = true;
            this.lblErrorTransition.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTransition.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTransition.Location = new System.Drawing.Point(20, 237);
            this.lblErrorTransition.Name = "lblErrorTransition";
            this.lblErrorTransition.Size = new System.Drawing.Size(0, 13);
            this.lblErrorTransition.TabIndex = 15;
            // 
            // lblErrorCreate
            // 
            this.lblErrorCreate.AutoSize = true;
            this.lblErrorCreate.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCreate.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCreate.Location = new System.Drawing.Point(20, 106);
            this.lblErrorCreate.Name = "lblErrorCreate";
            this.lblErrorCreate.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCreate.TabIndex = 16;
            // 
            // lblErrorTable
            // 
            this.lblErrorTable.AutoSize = true;
            this.lblErrorTable.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTable.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTable.Location = new System.Drawing.Point(420, 12);
            this.lblErrorTable.Name = "lblErrorTable";
            this.lblErrorTable.Size = new System.Drawing.Size(0, 13);
            this.lblErrorTable.TabIndex = 17;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 333);
            this.Controls.Add(this.lblErrorTable);
            this.Controls.Add(this.lblErrorCreate);
            this.Controls.Add(this.lblErrorTransition);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvAutomata);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnAddTransition);
            this.Controls.Add(this.txtTransitions);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblTransitions);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtOutputs);
            this.Controls.Add(this.lblOutputs);
            this.Controls.Add(this.txtStates);
            this.Controls.Add(this.lblStates);
            this.Controls.Add(this.txtSigma);
            this.Controls.Add(this.lblSigma);
            this.Controls.Add(this.gbTipoAutomata);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.Text = "Generador de automata equivalente";
            this.gbTipoAutomata.ResumeLayout(false);
            this.gbTipoAutomata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTipoAutomata;
        private System.Windows.Forms.RadioButton rbMoore;
        private System.Windows.Forms.RadioButton rbMealy;
        private System.Windows.Forms.Label lblSigma;
        private System.Windows.Forms.TextBox txtSigma;
        private System.Windows.Forms.Label lblStates;
        private System.Windows.Forms.TextBox txtStates;
        private System.Windows.Forms.Label lblOutputs;
        private System.Windows.Forms.TextBox txtOutputs;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblTransitions;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtTransitions;
        private System.Windows.Forms.Button btnAddTransition;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridView dgvAutomata;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblErrorTransition;
        private System.Windows.Forms.Label lblErrorCreate;
        private System.Windows.Forms.Label lblErrorTable;
    }
}

