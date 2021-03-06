﻿namespace ColetaneaDeLouvor.Forms
{
    partial class FormEscolaSabatina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEscolaSabatina));
            this.btnFecharContagem = new System.Windows.Forms.Button();
            this.btnIniciarContagem = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFecharContagem
            // 
            this.btnFecharContagem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFecharContagem.Location = new System.Drawing.Point(132, 115);
            this.btnFecharContagem.Name = "btnFecharContagem";
            this.btnFecharContagem.Size = new System.Drawing.Size(110, 23);
            this.btnFecharContagem.TabIndex = 25;
            this.btnFecharContagem.Text = "Fechar Contagem";
            this.btnFecharContagem.UseVisualStyleBackColor = true;
            this.btnFecharContagem.Click += new System.EventHandler(this.btnFecharContagem_Click);
            // 
            // btnIniciarContagem
            // 
            this.btnIniciarContagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarContagem.Location = new System.Drawing.Point(15, 72);
            this.btnIniciarContagem.Name = "btnIniciarContagem";
            this.btnIniciarContagem.Size = new System.Drawing.Size(359, 37);
            this.btnIniciarContagem.TabIndex = 24;
            this.btnIniciarContagem.Text = "Iniciar Contagem";
            this.btnIniciarContagem.UseVisualStyleBackColor = true;
            this.btnIniciarContagem.Click += new System.EventHandler(this.btnIniciarContagem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy - HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(359, 29);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Selecione o Horário do Término:";
            // 
            // FormEscolaSabatina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(388, 148);
            this.Controls.Add(this.btnFecharContagem);
            this.Controls.Add(this.btnIniciarContagem);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEscolaSabatina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escola Sabatina";
            this.Load += new System.EventHandler(this.FormEscolaSabatina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFecharContagem;
        private System.Windows.Forms.Button btnIniciarContagem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}