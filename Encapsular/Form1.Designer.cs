
namespace Encapsular
{
    partial class frmCalcular
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
            this.lblValor = new System.Windows.Forms.Label();
            this.rbtLeite = new System.Windows.Forms.RadioButton();
            this.rbtMartelo = new System.Windows.Forms.RadioButton();
            this.rbtProtetor = new System.Windows.Forms.RadioButton();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rdbFeijao = new System.Windows.Forms.RadioButton();
            this.rdbFuradeira = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(83, 161);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(64, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor Inicial:";
            // 
            // rbtLeite
            // 
            this.rbtLeite.AutoSize = true;
            this.rbtLeite.Location = new System.Drawing.Point(86, 37);
            this.rbtLeite.Name = "rbtLeite";
            this.rbtLeite.Size = new System.Drawing.Size(48, 17);
            this.rbtLeite.TabIndex = 4;
            this.rbtLeite.TabStop = true;
            this.rbtLeite.Text = "Leite";
            this.rbtLeite.UseVisualStyleBackColor = true;
            // 
            // rbtMartelo
            // 
            this.rbtMartelo.AutoSize = true;
            this.rbtMartelo.Location = new System.Drawing.Point(86, 73);
            this.rbtMartelo.Name = "rbtMartelo";
            this.rbtMartelo.Size = new System.Drawing.Size(60, 17);
            this.rbtMartelo.TabIndex = 5;
            this.rbtMartelo.TabStop = true;
            this.rbtMartelo.Text = "Martelo";
            this.rbtMartelo.UseVisualStyleBackColor = true;
            // 
            // rbtProtetor
            // 
            this.rbtProtetor.AutoSize = true;
            this.rbtProtetor.Location = new System.Drawing.Point(86, 106);
            this.rbtProtetor.Name = "rbtProtetor";
            this.rbtProtetor.Size = new System.Drawing.Size(89, 17);
            this.rbtProtetor.TabIndex = 6;
            this.rbtProtetor.TabStop = true;
            this.rbtProtetor.Text = "Protetor Solar";
            this.rbtProtetor.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(86, 177);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(207, 175);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(83, 215);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado:";
            // 
            // rdbFeijao
            // 
            this.rdbFeijao.AutoSize = true;
            this.rdbFeijao.Location = new System.Drawing.Point(207, 37);
            this.rdbFeijao.Name = "rdbFeijao";
            this.rdbFeijao.Size = new System.Drawing.Size(53, 17);
            this.rdbFeijao.TabIndex = 10;
            this.rdbFeijao.TabStop = true;
            this.rdbFeijao.Text = "Feijão";
            this.rdbFeijao.UseVisualStyleBackColor = true;
            // 
            // rdbFuradeira
            // 
            this.rdbFuradeira.AutoSize = true;
            this.rdbFuradeira.Location = new System.Drawing.Point(207, 73);
            this.rdbFuradeira.Name = "rdbFuradeira";
            this.rdbFuradeira.Size = new System.Drawing.Size(69, 17);
            this.rdbFuradeira.TabIndex = 11;
            this.rdbFuradeira.TabStop = true;
            this.rdbFuradeira.Text = "Furadeira";
            this.rdbFuradeira.UseVisualStyleBackColor = true;
            // 
            // frmCalcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 299);
            this.Controls.Add(this.rdbFuradeira);
            this.Controls.Add(this.rdbFeijao);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.rbtProtetor);
            this.Controls.Add(this.rbtMartelo);
            this.Controls.Add(this.rbtLeite);
            this.Controls.Add(this.lblValor);
            this.Name = "frmCalcular";
            this.Text = "Calcular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.RadioButton rbtLeite;
        private System.Windows.Forms.RadioButton rbtMartelo;
        private System.Windows.Forms.RadioButton rbtProtetor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RadioButton rdbFeijao;
        private System.Windows.Forms.RadioButton rdbFuradeira;
    }
}

