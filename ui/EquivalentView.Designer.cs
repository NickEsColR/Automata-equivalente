
namespace automata_equivalente.ui
{
    partial class EquivalentView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquivalentView));
            this.dgvEquivalent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquivalent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquivalent
            // 
            this.dgvEquivalent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEquivalent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquivalent.Location = new System.Drawing.Point(12, 62);
            this.dgvEquivalent.Name = "dgvEquivalent";
            this.dgvEquivalent.Size = new System.Drawing.Size(655, 356);
            this.dgvEquivalent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "AUTOMA MINIMO EQUIVALENTE";
            // 
            // EquivalentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEquivalent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EquivalentView";
            this.Text = "EquivalentView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquivalent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEquivalent;
        private System.Windows.Forms.Label label1;
    }
}