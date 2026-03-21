namespace Apresentacao
{
    partial class FrrmInsAltExcAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrrmInsAltExcAluno));
            pbLogoAluno = new PictureBox();
            btnCadastrar = new Button();
            btnAlterar = new Button();
            btnSair = new Button();
            btnExcluir = new Button();
            lbId = new Label();
            lbNome = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogoAluno).BeginInit();
            SuspendLayout();
            // 
            // pbLogoAluno
            // 
            pbLogoAluno.Image = (Image)resources.GetObject("pbLogoAluno.Image");
            pbLogoAluno.Location = new Point(32, 12);
            pbLogoAluno.Name = "pbLogoAluno";
            pbLogoAluno.Size = new Size(105, 112);
            pbLogoAluno.SizeMode = PictureBoxSizeMode.CenterImage;
            pbLogoAluno.TabIndex = 5;
            pbLogoAluno.TabStop = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DodgerBlue;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(190, 166);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(129, 48);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Inserir";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.Gold;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Image = (Image)resources.GetObject("btnAlterar.Image");
            btnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterar.Location = new Point(350, 166);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(129, 48);
            btnAlterar.TabIndex = 7;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(350, 237);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(129, 48);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Salmon;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(191, 237);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(128, 48);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(177, 42);
            lbId.Name = "lbId";
            lbId.Size = new Size(18, 15);
            lbId.TabIndex = 10;
            lbId.Text = "ID";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(167, 77);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 11;
            lbNome.Text = "Nome";
            // 
            // txtId
            // 
            txtId.Location = new Point(213, 42);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 12;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(213, 74);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(188, 23);
            txtNome.TabIndex = 13;
            // 
            // FrrmInsAltExcAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 309);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(lbNome);
            Controls.Add(lbId);
            Controls.Add(btnExcluir);
            Controls.Add(btnSair);
            Controls.Add(btnAlterar);
            Controls.Add(btnCadastrar);
            Controls.Add(pbLogoAluno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FrrmInsAltExcAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmInsAltExcAluno";
            Load += FrrmInsAltExcAluno_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogoAluno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogoAluno;
        private Button btnCadastrar;
        private Button btnAlterar;
        private Button btnSair;
        private Button btnExcluir;
        private Label lbId;
        private Label lbNome;
        private TextBox txtId;
        private TextBox txtNome;
    }
}