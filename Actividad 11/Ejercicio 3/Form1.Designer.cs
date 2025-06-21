namespace Ejercicio_3
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
            lbResultado = new Label();
            btnRegistrar = new Button();
            btnCalcularPromedio = new Button();
            tbResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 90);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 148);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Promedio";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(189, 87);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 2;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(220, 148);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 15);
            lbResultado.TabIndex = 3;
            lbResultado.Text = "lbResultado";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(341, 87);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(132, 23);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(341, 144);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(132, 23);
            btnCalcularPromedio.TabIndex = 5;
            btnCalcularPromedio.Text = "Calcular Promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(145, 200);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(328, 116);
            tbResultado.TabIndex = 6;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 372);
            Controls.Add(tbResultado);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(btnRegistrar);
            Controls.Add(lbResultado);
            Controls.Add(tbValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbValor;
        private Label lbResultado;
        private Button btnRegistrar;
        private Button btnCalcularPromedio;
        private TextBox tbResultado;
    }
}
