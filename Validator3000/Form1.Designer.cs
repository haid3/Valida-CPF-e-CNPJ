namespace Validator3000
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
            this.btnCpf = new System.Windows.Forms.Button();
            this.btnCNPJ = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.MaskedTextBox();
            this.lblValidador = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCpf
            // 
            this.btnCpf.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCpf.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCpf.Location = new System.Drawing.Point(12, 82);
            this.btnCpf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCpf.Name = "btnCpf";
            this.btnCpf.Size = new System.Drawing.Size(112, 41);
            this.btnCpf.TabIndex = 0;
            this.btnCpf.Text = "CPF";
            this.btnCpf.UseVisualStyleBackColor = false;
            this.btnCpf.Click += new System.EventHandler(this.btnCpf_Click);
            // 
            // btnCNPJ
            // 
            this.btnCNPJ.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCNPJ.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCNPJ.Location = new System.Drawing.Point(132, 82);
            this.btnCNPJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCNPJ.Name = "btnCNPJ";
            this.btnCNPJ.Size = new System.Drawing.Size(112, 41);
            this.btnCNPJ.TabIndex = 1;
            this.btnCNPJ.Text = "CNPJ";
            this.btnCNPJ.UseVisualStyleBackColor = false;
            this.btnCNPJ.Click += new System.EventHandler(this.btnCNPJ_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 220);
            this.txtInput.Mask = "000.000.000-00";
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(232, 35);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtInput.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtInput_MaskInputRejected);
            // 
            // lblValidador
            // 
            this.lblValidador.AutoSize = true;
            this.lblValidador.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidador.Location = new System.Drawing.Point(86, 38);
            this.lblValidador.Name = "lblValidador";
            this.lblValidador.Size = new System.Drawing.Size(102, 29);
            this.lblValidador.TabIndex = 3;
            this.lblValidador.Text = "Validador";
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnValidar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Location = new System.Drawing.Point(70, 133);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(112, 41);
            this.btnValidar.TabIndex = 5;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(12, 194);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(54, 29);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 260);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lblValidador);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCNPJ);
            this.Controls.Add(this.btnCpf);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCpf;
        private System.Windows.Forms.Button btnCNPJ;
        private System.Windows.Forms.MaskedTextBox txtInput;
        private System.Windows.Forms.Label lblValidador;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblTipo;
    }
}

