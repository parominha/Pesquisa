
namespace Pesquisa
{
    partial class FrmCliente
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
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.tBoxPesquisa = new System.Windows.Forms.TextBox();
            this.butPesquisa = new System.Windows.Forms.Button();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(29, 21);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(141, 13);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Informe o dado da pesquisa:";
            this.lblPesquisa.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBoxPesquisa
            // 
            this.tBoxPesquisa.Location = new System.Drawing.Point(173, 18);
            this.tBoxPesquisa.Name = "tBoxPesquisa";
            this.tBoxPesquisa.Size = new System.Drawing.Size(466, 20);
            this.tBoxPesquisa.TabIndex = 1;
            // 
            // butPesquisa
            // 
            this.butPesquisa.Location = new System.Drawing.Point(661, 15);
            this.butPesquisa.Name = "butPesquisa";
            this.butPesquisa.Size = new System.Drawing.Size(75, 23);
            this.butPesquisa.TabIndex = 2;
            this.butPesquisa.Text = "Pesquisar";
            this.butPesquisa.UseVisualStyleBackColor = true;
            this.butPesquisa.Click += new System.EventHandler(this.butPesquisa_Click);
            // 
            // dgCliente
            // 
            this.dgCliente.AllowUserToAddRows = false;
            this.dgCliente.AllowUserToDeleteRows = false;
            this.dgCliente.AllowUserToOrderColumns = true;
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.Location = new System.Drawing.Point(12, 73);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.ReadOnly = true;
            this.dgCliente.Size = new System.Drawing.Size(776, 365);
            this.dgCliente.TabIndex = 3;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgCliente);
            this.Controls.Add(this.butPesquisa);
            this.Controls.Add(this.tBoxPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Name = "FrmCliente";
            this.Text = "PesquisaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox tBoxPesquisa;
        private System.Windows.Forms.Button butPesquisa;
        private System.Windows.Forms.DataGridView dgCliente;
    }
}

