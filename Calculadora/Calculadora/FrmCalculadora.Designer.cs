namespace Calculadora
{
    partial class FrmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculadora));
            txtCalculadora = new TextBox();
            btnSete = new Button();
            btnZero = new Button();
            btnIgual = new Button();
            btnSoma = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnNove = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnOito = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnC = new Button();
            btnDividir = new Button();
            btnCE = new Button();
            btnVirgula = new Button();
            SuspendLayout();
            // 
            // txtCalculadora
            // 
            txtCalculadora.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCalculadora.Location = new Point(12, 12);
            txtCalculadora.Multiline = true;
            txtCalculadora.Name = "txtCalculadora";
            txtCalculadora.Size = new Size(376, 84);
            txtCalculadora.TabIndex = 0;
            // 
            // btnSete
            // 
            btnSete.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSete.Location = new Point(12, 205);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(83, 77);
            btnSete.TabIndex = 1;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += Botao_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZero.Location = new Point(119, 469);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(83, 77);
            btnZero.TabIndex = 2;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += Botao_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.DarkViolet;
            btnIgual.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIgual.ForeColor = SystemColors.ControlText;
            btnIgual.Location = new Point(221, 469);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(184, 77);
            btnIgual.TabIndex = 3;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnCalcular_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.RoyalBlue;
            btnSoma.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSoma.Location = new Point(322, 371);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(83, 77);
            btnSoma.TabIndex = 4;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += Operador_Click;
            // 
            // btnUm
            // 
            btnUm.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUm.Location = new Point(12, 371);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(83, 77);
            btnUm.TabIndex = 5;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += Botao_Click;
            // 
            // btnDois
            // 
            btnDois.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDois.Location = new Point(119, 371);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(83, 77);
            btnDois.TabIndex = 6;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += Botao_Click;
            // 
            // btnTres
            // 
            btnTres.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTres.Location = new Point(221, 371);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(83, 77);
            btnTres.TabIndex = 7;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += Botao_Click;
            // 
            // btnNove
            // 
            btnNove.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNove.Location = new Point(221, 205);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(83, 77);
            btnNove.TabIndex = 8;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += Botao_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuatro.Location = new Point(12, 288);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(83, 77);
            btnQuatro.TabIndex = 9;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += Botao_Click;
            // 
            // btnCinco
            // 
            btnCinco.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCinco.Location = new Point(119, 288);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(83, 77);
            btnCinco.TabIndex = 10;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += Botao_Click;
            // 
            // btnSeis
            // 
            btnSeis.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeis.Location = new Point(221, 288);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(83, 77);
            btnSeis.TabIndex = 11;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += Botao_Click;
            // 
            // btnOito
            // 
            btnOito.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOito.Location = new Point(119, 205);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(83, 77);
            btnOito.TabIndex = 12;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += Botao_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.BackColor = Color.RoyalBlue;
            btnSubtrair.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubtrair.Location = new Point(322, 288);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(83, 77);
            btnSubtrair.TabIndex = 13;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = false;
            btnSubtrair.Click += Operador_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = Color.RoyalBlue;
            btnMultiplicar.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(322, 205);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(83, 77);
            btnMultiplicar.TabIndex = 14;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += Operador_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.DarkViolet;
            btnC.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnC.Location = new Point(12, 113);
            btnC.Name = "btnC";
            btnC.Size = new Size(83, 77);
            btnC.TabIndex = 15;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += Operador_Click;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = Color.RoyalBlue;
            btnDividir.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(322, 113);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(83, 77);
            btnDividir.TabIndex = 16;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += Operador_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.DarkViolet;
            btnCE.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCE.Location = new Point(119, 113);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(185, 77);
            btnCE.TabIndex = 17;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += Operador_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.RoyalBlue;
            btnVirgula.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVirgula.Location = new Point(12, 469);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(83, 77);
            btnVirgula.TabIndex = 18;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += Botao_Click;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(417, 558);
            Controls.Add(btnVirgula);
            Controls.Add(btnCE);
            Controls.Add(btnDividir);
            Controls.Add(btnC);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnOito);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnNove);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnSoma);
            Controls.Add(btnIgual);
            Controls.Add(btnZero);
            Controls.Add(btnSete);
            Controls.Add(txtCalculadora);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCalculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCalculadora;
        private Button btnSete;
        private Button btnZero;
        private Button btnIgual;
        private Button btnSoma;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnNove;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnOito;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnC;
        private Button btnDividir;
        private Button btnCE;
        private Button btnVirgula;
    }
}
