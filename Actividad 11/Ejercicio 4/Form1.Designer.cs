namespace Ejercicio_4
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
            tbBuscar = new TextBox();
            btnBuscar = new Button();
            btnListarOrdenado = new Button();
            lsbResultado = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 88);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 137);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Promedio";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(211, 85);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 2;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(242, 137);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 15);
            lbResultado.TabIndex = 3;
            lbResultado.Text = "lbResultado";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(362, 85);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(362, 133);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(75, 23);
            btnCalcularPromedio.TabIndex = 5;
            btnCalcularPromedio.Text = "Calcular Promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click_1;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(172, 177);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(139, 23);
            tbBuscar.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(362, 177);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnListarOrdenado
            // 
            btnListarOrdenado.Location = new Point(443, 227);
            btnListarOrdenado.Name = "btnListarOrdenado";
            btnListarOrdenado.Size = new Size(75, 49);
            btnListarOrdenado.TabIndex = 9;
            btnListarOrdenado.Text = "Listar Ordenado";
            btnListarOrdenado.UseVisualStyleBackColor = true;
            // 
            // lsbResultado
            // 
            lsbResultado.FormattingEnabled = true;
            lsbResultado.ItemHeight = 15;
            lsbResultado.Location = new Point(172, 227);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.Size = new Size(265, 49);
            lsbResultado.TabIndex = 10;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 368);
            Controls.Add(lsbResultado);
            Controls.Add(btnListarOrdenado);
            Controls.Add(btnBuscar);
            Controls.Add(tbBuscar);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(btnRegistrar);
            Controls.Add(lbResultado);
            Controls.Add(tbValor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPrincipal";
            Text = "Busqueda y Ordenamiento";
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
        private TextBox tbBuscar;
        private Button btnBuscar;
        private Button btnListarOrdenado;
        private ListBox lsbResultado;
    }
}
