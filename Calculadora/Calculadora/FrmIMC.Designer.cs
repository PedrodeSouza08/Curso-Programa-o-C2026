namespace Calculadora
{
    partial class FrmIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIMC));
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            lbPeso = new Label();
            lbAltura = new Label();
            btnIMC = new Button();
            SuspendLayout();
            // 
            // txtPeso
            // 
            txtPeso.BackColor = SystemColors.Info;
            txtPeso.Location = new Point(152, 26);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 0;
            // 
            // txtAltura
            // 
            txtAltura.BackColor = SystemColors.Info;
            txtAltura.Location = new Point(152, 71);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 1;
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.Location = new Point(114, 34);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(32, 15);
            lbPeso.TabIndex = 2;
            lbPeso.Text = "Peso";
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.Location = new Point(107, 79);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(39, 15);
            lbAltura.TabIndex = 3;
            lbAltura.Text = "Altura";
            // 
            // btnIMC
            // 
            btnIMC.Location = new Point(161, 122);
            btnIMC.Name = "btnIMC";
            btnIMC.Size = new Size(75, 23);
            btnIMC.TabIndex = 4;
            btnIMC.Text = "IMC";
            btnIMC.UseVisualStyleBackColor = true;
            // 
            // FrmIMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIMC);
            Controls.Add(lbAltura);
            Controls.Add(lbPeso);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmIMC";
            Text = "FrmIMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPeso;
        private TextBox txtAltura;
        private Label lbPeso;
        private Label lbAltura;
        private Button btnIMC;
    }
}