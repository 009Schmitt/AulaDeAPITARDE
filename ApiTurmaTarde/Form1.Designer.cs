
namespace ApiTurmaTarde
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnET = new System.Windows.Forms.Button();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.btnCep = new System.Windows.Forms.Button();
            this.lblCep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 348);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(760, 53);
            this.txtEmail.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(12, 407);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(156, 67);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(174, 407);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 67);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnET
            // 
            this.btnET.Location = new System.Drawing.Point(174, 480);
            this.btnET.Name = "btnET";
            this.btnET.Size = new System.Drawing.Size(238, 68);
            this.btnET.TabIndex = 3;
            this.btnET.Text = "Envia Tudo";
            this.btnET.UseVisualStyleBackColor = true;
            this.btnET.Click += new System.EventHandler(this.btnET_Click);
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(12, 12);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(250, 53);
            this.txtCep.TabIndex = 4;
            // 
            // btnCep
            // 
            this.btnCep.Location = new System.Drawing.Point(12, 71);
            this.btnCep.Name = "btnCep";
            this.btnCep.Size = new System.Drawing.Size(195, 67);
            this.btnCep.TabIndex = 5;
            this.btnCep.Text = "BUSCA";
            this.btnCep.UseVisualStyleBackColor = true;
            this.btnCep.Click += new System.EventHandler(this.btnCep_Click);
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(286, 19);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(126, 46);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.btnCep);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.btnET);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEmail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnET;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Button btnCep;
        private System.Windows.Forms.Label lblCep;
    }
}

