namespace WinFormsAppConsumirAPI
{
    partial class FrmAPI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAno = new TextBox();
            btnGerar = new Button();
            dgvFeriados = new DataGridView();
            dgvCep = new DataGridView();
            Cep = new DataGridViewTextBoxColumn();
            State = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            Neighborhood = new DataGridViewTextBoxColumn();
            Street = new DataGridViewTextBoxColumn();
            Service = new DataGridViewTextBoxColumn();
            txtCep = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFeriados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCep).BeginInit();
            SuspendLayout();
            // 
            // txtAno
            // 
            txtAno.Location = new Point(12, 12);
            txtAno.Multiline = true;
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(163, 29);
            txtAno.TabIndex = 0;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(634, 16);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(78, 29);
            btnGerar.TabIndex = 1;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // dgvFeriados
            // 
            dgvFeriados.AllowUserToAddRows = false;
            dgvFeriados.AllowUserToDeleteRows = false;
            dgvFeriados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeriados.Location = new Point(12, 60);
            dgvFeriados.Name = "dgvFeriados";
            dgvFeriados.ReadOnly = true;
            dgvFeriados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFeriados.Size = new Size(228, 522);
            dgvFeriados.TabIndex = 2;
            // 
            // dgvCep
            // 
            dgvCep.AllowUserToAddRows = false;
            dgvCep.AllowUserToDeleteRows = false;
            dgvCep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCep.Columns.AddRange(new DataGridViewColumn[] { Cep, State, City, Neighborhood, Street, Service });
            dgvCep.Location = new Point(404, 60);
            dgvCep.Name = "dgvCep";
            dgvCep.ReadOnly = true;
            dgvCep.Size = new Size(599, 522);
            dgvCep.TabIndex = 3;
            // 
            // Cep
            // 
            Cep.DataPropertyName = "cep";
            Cep.HeaderText = "Cep";
            Cep.Name = "Cep";
            Cep.ReadOnly = true;
            // 
            // State
            // 
            State.DataPropertyName = "state";
            State.HeaderText = "State";
            State.Name = "State";
            State.ReadOnly = true;
            // 
            // City
            // 
            City.DataPropertyName = "city";
            City.HeaderText = "City";
            City.Name = "City";
            City.ReadOnly = true;
            // 
            // Neighborhood
            // 
            Neighborhood.DataPropertyName = "neighborhood";
            Neighborhood.HeaderText = "Neighborhood";
            Neighborhood.Name = "Neighborhood";
            Neighborhood.ReadOnly = true;
            // 
            // Street
            // 
            Street.DataPropertyName = "street";
            Street.HeaderText = "Street";
            Street.Name = "Street";
            Street.ReadOnly = true;
            // 
            // Service
            // 
            Service.DataPropertyName = "service";
            Service.HeaderText = "Service";
            Service.Name = "Service";
            Service.ReadOnly = true;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(446, 16);
            txtCep.Multiline = true;
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(163, 29);
            txtCep.TabIndex = 4;
            // 
            // FrmAPI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 614);
            Controls.Add(txtCep);
            Controls.Add(dgvCep);
            Controls.Add(dgvFeriados);
            Controls.Add(btnGerar);
            Controls.Add(txtAno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmAPI";
            Text = "FrmAPI";
            ((System.ComponentModel.ISupportInitialize)dgvFeriados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAno;
        private Button btnGerar;
        private DataGridView dgvFeriados;
        private DataGridView dgvCep;
        private DataGridViewTextBoxColumn Cep;
        private DataGridViewTextBoxColumn State;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn Neighborhood;
        private DataGridViewTextBoxColumn Street;
        private DataGridViewTextBoxColumn Service;
        private TextBox txtCep;
    }
}
