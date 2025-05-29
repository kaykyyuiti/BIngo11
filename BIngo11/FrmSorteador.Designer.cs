namespace Bingo
{
    partial class FrmSorteador
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.btProximo = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btHistorico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(1, 141);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(619, 119);
            this.lblNumero.TabIndex = 0;
            // 
            // btProximo
            // 
            this.btProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProximo.Location = new System.Drawing.Point(39, 314);
            this.btProximo.Name = "btProximo";
            this.btProximo.Size = new System.Drawing.Size(174, 50);
            this.btProximo.TabIndex = 1;
            this.btProximo.Text = "&Próximo número";
            this.btProximo.UseVisualStyleBackColor = true;
            this.btProximo.Click += new System.EventHandler(this.btProximo_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(359, 314);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(174, 50);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btHistorico
            // 
            this.btHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistorico.Location = new System.Drawing.Point(359, 48);
            this.btHistorico.Name = "btHistorico";
            this.btHistorico.Size = new System.Drawing.Size(174, 50);
            this.btHistorico.TabIndex = 3;
            this.btHistorico.Text = "Histórico";
            this.btHistorico.UseVisualStyleBackColor = true;
            // 
            // FrmSorteador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 470);
            this.Controls.Add(this.btHistorico);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btProximo);
            this.Controls.Add(this.lblNumero);
            this.Name = "FrmSorteador";
            this.Text = "Sorteador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btProximo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btHistorico;
    }
}