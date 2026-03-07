namespace WinFormsApp
{
    partial class FrmCalculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculos));
            lbIdade = new Label();
            txtIdade = new TextBox();
            btnGerar = new Button();
            lbValor1 = new Label();
            lbValor2 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            btnCalcular = new Button();
            btnMultiplicar = new Button();
            btnSubtrair = new Button();
            lbPeso = new Label();
            txtPeso = new TextBox();
            btnIMC = new Button();
            lbAltura = new Label();
            txtAltura = new TextBox();
            SuspendLayout();
            // 
            // lbIdade
            // 
            lbIdade.AutoSize = true;
            lbIdade.Location = new Point(12, 20);
            lbIdade.Name = "lbIdade";
            lbIdade.Size = new Size(36, 15);
            lbIdade.TabIndex = 0;
            lbIdade.Text = "Idade";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(54, 17);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 1;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(160, 17);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(85, 23);
            btnGerar.TabIndex = 2;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // lbValor1
            // 
            lbValor1.AutoSize = true;
            lbValor1.Location = new Point(22, 89);
            lbValor1.Name = "lbValor1";
            lbValor1.Size = new Size(42, 15);
            lbValor1.TabIndex = 3;
            lbValor1.Text = "Valor 1";
            // 
            // lbValor2
            // 
            lbValor2.AutoSize = true;
            lbValor2.Location = new Point(22, 126);
            lbValor2.Name = "lbValor2";
            lbValor2.Size = new Size(42, 15);
            lbValor2.TabIndex = 4;
            lbValor2.Text = "Valor 2";
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(80, 86);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(100, 23);
            txtValor1.TabIndex = 5;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(80, 123);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(100, 23);
            txtValor2.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(80, 164);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(85, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(171, 164);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 8;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(80, 202);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(85, 22);
            btnSubtrair.TabIndex = 9;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.BackColor = SystemColors.Menu;
            lbPeso.ForeColor = Color.Green;
            lbPeso.Location = new Point(505, 24);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(32, 15);
            lbPeso.TabIndex = 10;
            lbPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(540, 20);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 11;
            // 
            // btnIMC
            // 
            btnIMC.BackColor = SystemColors.ButtonFace;
            btnIMC.ForeColor = Color.Red;
            btnIMC.Location = new Point(556, 118);
            btnIMC.Name = "btnIMC";
            btnIMC.Size = new Size(75, 23);
            btnIMC.TabIndex = 12;
            btnIMC.Text = "IMC";
            btnIMC.UseVisualStyleBackColor = false;
            btnIMC.Click += btnIMC_Click;
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.ForeColor = Color.Green;
            lbAltura.Location = new Point(504, 63);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(39, 15);
            lbAltura.TabIndex = 13;
            lbAltura.Text = "Altura";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(540, 60);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 14;
            // 
            // FrmCalculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 251);
            Controls.Add(txtAltura);
            Controls.Add(lbAltura);
            Controls.Add(btnIMC);
            Controls.Add(txtPeso);
            Controls.Add(lbPeso);
            Controls.Add(btnSubtrair);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnCalcular);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(lbValor2);
            Controls.Add(lbValor1);
            Controls.Add(btnGerar);
            Controls.Add(txtIdade);
            Controls.Add(lbIdade);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCalculos";
            Text = "Formulario Calculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIdade;
        private TextBox txtIdade;
        private Button btnGerar;
        private Label lbValor1;
        private Label lbValor2;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Button btnCalcular;
        private Button btnMultiplicar;
        private Button btnSubtrair;
        private Label lbPeso;
        private TextBox txtPeso;
        private Button btnIMC;
        private Label lbAltura;
        private TextBox txtAltura;
    }
}
