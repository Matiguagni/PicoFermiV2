﻿namespace JMPracticaFinal
{
    partial class Form1
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
            btnEnviar = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            textboxNumero = new TextBox();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(432, 256);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 32);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar Numero";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(584, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(316, 484);
            listBox1.TabIndex = 2;
            // 
            // textboxNumero
            // 
            textboxNumero.Location = new Point(279, 256);
            textboxNumero.Multiline = true;
            textboxNumero.Name = "textboxNumero";
            textboxNumero.Size = new Size(136, 32);
            textboxNumero.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 522);
            Controls.Add(textboxNumero);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(btnEnviar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private Label label1;
        private ListBox listBox1;
        private TextBox textboxNumero;
    }
}
