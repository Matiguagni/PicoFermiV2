namespace JMPracticaFinal
{
    partial class IngresoNumero
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
            btnEnviarNumero = new Button();
            lblRegla = new Label();
            textboxAgregarnro = new TextBox();
            btnSiguiente = new Button();
            SuspendLayout();
            // 
            // btnEnviarNumero
            // 
            btnEnviarNumero.Location = new Point(468, 195);
            btnEnviarNumero.Name = "btnEnviarNumero";
            btnEnviarNumero.Size = new Size(110, 34);
            btnEnviarNumero.TabIndex = 0;
            btnEnviarNumero.Text = "Enviar Número";
            btnEnviarNumero.UseVisualStyleBackColor = true;
            btnEnviarNumero.Click += btnEnviarNumero_Click;
            // 
            // lblRegla
            // 
            lblRegla.AutoSize = true;
            lblRegla.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegla.Location = new Point(12, 64);
            lblRegla.Name = "lblRegla";
            lblRegla.Size = new Size(51, 21);
            lblRegla.TabIndex = 1;
            lblRegla.Text = "label1";
            // 
            // textboxAgregarnro
            // 
            textboxAgregarnro.Location = new Point(327, 195);
            textboxAgregarnro.Multiline = true;
            textboxAgregarnro.Name = "textboxAgregarnro";
            textboxAgregarnro.Size = new Size(101, 34);
            textboxAgregarnro.TabIndex = 2;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(624, 289);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(110, 34);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // IngresoNumero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSiguiente);
            Controls.Add(textboxAgregarnro);
            Controls.Add(lblRegla);
            Controls.Add(btnEnviarNumero);
            Name = "IngresoNumero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IngresoNumero";
            Load += IngresoNumero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviarNumero;
        private Label lblRegla;
        private TextBox textboxAgregarnro;
        private Button btnSiguiente;
    }
}