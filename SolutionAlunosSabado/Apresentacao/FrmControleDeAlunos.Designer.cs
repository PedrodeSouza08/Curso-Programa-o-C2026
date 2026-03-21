namespace Apresentacao
{
    partial class FrmControleDeAlunos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControleDeAlunos));
            btnBuscarAluno = new Button();
            dgvAluno = new DataGridView();
            txtBuscarAluno = new TextBox();
            pbLogoAluno = new PictureBox();
            imageList1 = new ImageList(components);
            btnCadastrar = new Button();
            btnAlterar = new Button();
            btnSair = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAluno).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoAluno).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarAluno
            // 
            btnBuscarAluno.BackColor = SystemColors.InactiveCaption;
            btnBuscarAluno.FlatStyle = FlatStyle.Flat;
            btnBuscarAluno.Image = Properties.Resources.preview_search_find_locate_1551;
            btnBuscarAluno.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarAluno.Location = new Point(347, 97);
            btnBuscarAluno.Name = "btnBuscarAluno";
            btnBuscarAluno.Size = new Size(108, 31);
            btnBuscarAluno.TabIndex = 0;
            btnBuscarAluno.Text = "Buscar";
            btnBuscarAluno.UseVisualStyleBackColor = false;
            // 
            // dgvAluno
            // 
            dgvAluno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAluno.Location = new Point(50, 134);
            dgvAluno.Name = "dgvAluno";
            dgvAluno.Size = new Size(472, 374);
            dgvAluno.TabIndex = 2;
            // 
            // txtBuscarAluno
            // 
            txtBuscarAluno.Location = new Point(153, 97);
            txtBuscarAluno.Multiline = true;
            txtBuscarAluno.Name = "txtBuscarAluno";
            txtBuscarAluno.PlaceholderText = "Informe o nome a buscar";
            txtBuscarAluno.Size = new Size(175, 27);
            txtBuscarAluno.TabIndex = 3;
            // 
            // pbLogoAluno
            // 
            pbLogoAluno.Image = (Image)resources.GetObject("pbLogoAluno.Image");
            pbLogoAluno.Location = new Point(33, 12);
            pbLogoAluno.Name = "pbLogoAluno";
            pbLogoAluno.Size = new Size(105, 112);
            pbLogoAluno.SizeMode = PictureBoxSizeMode.CenterImage;
            pbLogoAluno.TabIndex = 4;
            pbLogoAluno.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "preview_search_find_locate_1551.png");
            imageList1.Images.SetKeyName(1, "correct_apply_done_icon_176355.png");
            imageList1.Images.SetKeyName(2, "x_circle_icon_173469.png");
            imageList1.Images.SetKeyName(3, "two-clockwise-circular-rotating-arrows-circle_icon-icons.com_72907.png");
            imageList1.Images.SetKeyName(4, "1486504830-delete-dustbin-empty-recycle-recycling-remove-trash_81361.png");
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DodgerBlue;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.Location = new Point(50, 522);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 48);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Inserir";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.Gold;
            btnAlterar.FlatStyle = FlatStyle.Flat;
            btnAlterar.Image = (Image)resources.GetObject("btnAlterar.Image");
            btnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterar.Location = new Point(184, 522);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(129, 48);
            btnAlterar.TabIndex = 6;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Image = (Image)resources.GetObject("btnSair.Image");
            btnSair.ImageAlign = ContentAlignment.MiddleLeft;
            btnSair.Location = new Point(400, 522);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(122, 48);
            btnSair.TabIndex = 7;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            // 
            // FrmControleDeAlunos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(566, 599);
            Controls.Add(btnSair);
            Controls.Add(btnAlterar);
            Controls.Add(btnCadastrar);
            Controls.Add(pbLogoAluno);
            Controls.Add(txtBuscarAluno);
            Controls.Add(dgvAluno);
            Controls.Add(btnBuscarAluno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FrmControleDeAlunos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de Alunos";
            ((System.ComponentModel.ISupportInitialize)dgvAluno).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogoAluno).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarAluno;
        private DataGridView dgvAluno;
        private TextBox txtBuscarAluno;
        private PictureBox pbLogoAluno;
        private ImageList imageList1;
        private Button btnCadastrar;
        private Button btnAlterar;
        private Button btnSair;
    }
}
