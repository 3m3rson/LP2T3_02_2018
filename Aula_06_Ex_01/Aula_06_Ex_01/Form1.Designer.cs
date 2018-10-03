namespace Aula_06_Ex_01
{
    partial class Form1
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
            this.lbLargura = new System.Windows.Forms.Label();
            this.lbComprimento = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.lbTotalValor = new System.Windows.Forms.Label();
            this.lbAreaValor = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.txtComprimento = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnPreco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLargura
            // 
            this.lbLargura.AutoSize = true;
            this.lbLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLargura.Location = new System.Drawing.Point(58, 9);
            this.lbLargura.Name = "lbLargura";
            this.lbLargura.Size = new System.Drawing.Size(85, 25);
            this.lbLargura.TabIndex = 0;
            this.lbLargura.Text = "Largura:";
            // 
            // lbComprimento
            // 
            this.lbComprimento.AutoSize = true;
            this.lbComprimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComprimento.Location = new System.Drawing.Point(8, 48);
            this.lbComprimento.Name = "lbComprimento";
            this.lbComprimento.Size = new System.Drawing.Size(135, 25);
            this.lbComprimento.TabIndex = 1;
            this.lbComprimento.Text = "Comprimento:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(28, 86);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(115, 25);
            this.lbPreco.TabIndex = 2;
            this.lbPreco.Text = "Preço (m2):";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(25, 142);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(118, 25);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "Preço Total:";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArea.Location = new System.Drawing.Point(83, 185);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(60, 25);
            this.lbArea.TabIndex = 4;
            this.lbArea.Text = "Área:";
            // 
            // lbTotalValor
            // 
            this.lbTotalValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalValor.Location = new System.Drawing.Point(154, 142);
            this.lbTotalValor.Name = "lbTotalValor";
            this.lbTotalValor.Size = new System.Drawing.Size(137, 25);
            this.lbTotalValor.TabIndex = 5;
            // 
            // lbAreaValor
            // 
            this.lbAreaValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAreaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAreaValor.Location = new System.Drawing.Point(154, 185);
            this.lbAreaValor.Name = "lbAreaValor";
            this.lbAreaValor.Size = new System.Drawing.Size(137, 25);
            this.lbAreaValor.TabIndex = 6;
            // 
            // txtLargura
            // 
            this.txtLargura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLargura.Location = new System.Drawing.Point(154, 15);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(137, 22);
            this.txtLargura.TabIndex = 7;
            // 
            // txtComprimento
            // 
            this.txtComprimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComprimento.Location = new System.Drawing.Point(154, 54);
            this.txtComprimento.Name = "txtComprimento";
            this.txtComprimento.Size = new System.Drawing.Size(137, 22);
            this.txtComprimento.TabIndex = 8;
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreco.Location = new System.Drawing.Point(154, 92);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(137, 22);
            this.txtPreco.TabIndex = 9;
            // 
            // btnArea
            // 
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(43, 241);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(121, 63);
            this.btnArea.TabIndex = 10;
            this.btnArea.Text = "Calcular Área";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnPreco
            // 
            this.btnPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreco.Location = new System.Drawing.Point(170, 241);
            this.btnPreco.Name = "btnPreco";
            this.btnPreco.Size = new System.Drawing.Size(121, 63);
            this.btnPreco.TabIndex = 11;
            this.btnPreco.Text = "Calcular Preço";
            this.btnPreco.UseVisualStyleBackColor = true;
            this.btnPreco.Click += new System.EventHandler(this.btnPreco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 330);
            this.Controls.Add(this.btnPreco);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtComprimento);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.lbAreaValor);
            this.Controls.Add(this.lbTotalValor);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbComprimento);
            this.Controls.Add(this.lbLargura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLargura;
        private System.Windows.Forms.Label lbComprimento;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label lbTotalValor;
        private System.Windows.Forms.Label lbAreaValor;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.TextBox txtComprimento;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnPreco;
    }
}

