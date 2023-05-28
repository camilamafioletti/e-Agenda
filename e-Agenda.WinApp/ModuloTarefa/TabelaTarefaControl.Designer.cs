namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TabelaTarefaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridTarefa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridTarefa).BeginInit();
            SuspendLayout();
            // 
            // gridTarefa
            // 
            gridTarefa.AllowUserToAddRows = false;
            gridTarefa.AllowUserToDeleteRows = false;
            gridTarefa.AllowUserToResizeColumns = false;
            gridTarefa.AllowUserToResizeRows = false;
            gridTarefa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridTarefa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTarefa.Dock = DockStyle.Fill;
            gridTarefa.Location = new Point(0, 0);
            gridTarefa.MultiSelect = false;
            gridTarefa.Name = "gridTarefa";
            gridTarefa.RowTemplate.Height = 25;
            gridTarefa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridTarefa.Size = new Size(441, 316);
            gridTarefa.TabIndex = 0;
            // 
            // TabelaTarefaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridTarefa);
            Name = "TabelaTarefaControl";
            Size = new Size(441, 316);
            ((System.ComponentModel.ISupportInitialize)gridTarefa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridTarefa;
    }
}
