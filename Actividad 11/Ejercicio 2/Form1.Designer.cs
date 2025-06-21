namespace Ejercicio_2
{
    partial class FormPrincipal
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
            label1 = new Label();
            label2 = new Label();
            tbValor = new TextBox();
            btnRegistrar = new Button();
            btnCalcularPromedio = new Button();
            tbResultado = new TextBox();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 96);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 158);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(201, 93);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(369, 93);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(369, 155);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(75, 23);
            btnCalcularPromedio.TabIndex = 5;
            btnCalcularPromedio.Text = "Calcular Promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(157, 227);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(287, 125);
            tbResultado.TabIndex = 6;
            
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(233, 159);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 15);
            lbResultado.TabIndex = 7;
            lbResultado.Text = "lbResultado";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 364);
            Controls.Add(lbResultado);
            Controls.Add(tbResultado);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(btnRegistrar);
            Controls.Add(tbValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbValor;
        private Button btnRegistrar;
        private Button btnCalcularPromedio;
        private TextBox tbResultado;
        private Label lbResultado;
    }
}
