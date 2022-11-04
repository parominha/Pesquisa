
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
            this.grBoxDados = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.tBoxContato = new System.Windows.Forms.TextBox();
            this.tBoxEndereco = new System.Windows.Forms.TextBox();
            this.tBoxCredito = new System.Windows.Forms.TextBox();
            this.tBoxId = new System.Windows.Forms.TextBox();
            this.butIncluir = new System.Windows.Forms.Button();
            this.butAlterar = new System.Windows.Forms.Button();
            this.butExcluir = new System.Windows.Forms.Button();
            this.butNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            this.grBoxDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 21);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(141, 13);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Informe o dado da pesquisa:";
            this.lblPesquisa.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBoxPesquisa
            // 
            this.tBoxPesquisa.Location = new System.Drawing.Point(159, 18);
            this.tBoxPesquisa.Name = "tBoxPesquisa";
            this.tBoxPesquisa.Size = new System.Drawing.Size(377, 20);
            this.tBoxPesquisa.TabIndex = 1;
            // 
            // butPesquisa
            // 
            this.butPesquisa.Location = new System.Drawing.Point(564, 16);
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
            this.dgCliente.Size = new System.Drawing.Size(627, 321);
            this.dgCliente.TabIndex = 3;
            this.dgCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellDoubleClick);
            // 
            // grBoxDados
            // 
            this.grBoxDados.Controls.Add(this.butExcluir);
            this.grBoxDados.Controls.Add(this.butAlterar);
            this.grBoxDados.Controls.Add(this.butIncluir);
            this.grBoxDados.Controls.Add(this.tBoxId);
            this.grBoxDados.Controls.Add(this.tBoxCredito);
            this.grBoxDados.Controls.Add(this.tBoxEndereco);
            this.grBoxDados.Controls.Add(this.tBoxContato);
            this.grBoxDados.Controls.Add(this.tBoxNome);
            this.grBoxDados.Controls.Add(this.lblId);
            this.grBoxDados.Controls.Add(this.lblCredito);
            this.grBoxDados.Controls.Add(this.lblEndereco);
            this.grBoxDados.Controls.Add(this.lblContato);
            this.grBoxDados.Controls.Add(this.lblNome);
            this.grBoxDados.Location = new System.Drawing.Point(665, 95);
            this.grBoxDados.Name = "grBoxDados";
            this.grBoxDados.Size = new System.Drawing.Size(472, 223);
            this.grBoxDados.TabIndex = 4;
            this.grBoxDados.TabStop = false;
            this.grBoxDados.Text = "Dados";
            this.grBoxDados.Visible = false;
            this.grBoxDados.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(84, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(75, 67);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(44, 13);
            this.lblContato.TabIndex = 1;
            this.lblContato.Text = "Contato";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(66, 94);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 2;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(37, 125);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(82, 13);
            this.lblCredito.TabIndex = 3;
            this.lblCredito.Text = "Valor do Credito";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(101, 155);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID";
            // 
            // tBoxNome
            // 
            this.tBoxNome.Location = new System.Drawing.Point(125, 37);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(313, 20);
            this.tBoxNome.TabIndex = 5;
            // 
            // tBoxContato
            // 
            this.tBoxContato.Location = new System.Drawing.Point(125, 64);
            this.tBoxContato.Name = "tBoxContato";
            this.tBoxContato.Size = new System.Drawing.Size(313, 20);
            this.tBoxContato.TabIndex = 6;
            // 
            // tBoxEndereco
            // 
            this.tBoxEndereco.Location = new System.Drawing.Point(125, 91);
            this.tBoxEndereco.Name = "tBoxEndereco";
            this.tBoxEndereco.Size = new System.Drawing.Size(313, 20);
            this.tBoxEndereco.TabIndex = 7;
            // 
            // tBoxCredito
            // 
            this.tBoxCredito.Location = new System.Drawing.Point(125, 122);
            this.tBoxCredito.Name = "tBoxCredito";
            this.tBoxCredito.Size = new System.Drawing.Size(97, 20);
            this.tBoxCredito.TabIndex = 8;
            // 
            // tBoxId
            // 
            this.tBoxId.Location = new System.Drawing.Point(125, 152);
            this.tBoxId.Name = "tBoxId";
            this.tBoxId.ReadOnly = true;
            this.tBoxId.Size = new System.Drawing.Size(97, 20);
            this.tBoxId.TabIndex = 9;
            // 
            // butIncluir
            // 
            this.butIncluir.Location = new System.Drawing.Point(213, 194);
            this.butIncluir.Name = "butIncluir";
            this.butIncluir.Size = new System.Drawing.Size(75, 23);
            this.butIncluir.TabIndex = 10;
            this.butIncluir.Text = "Incluir";
            this.butIncluir.UseVisualStyleBackColor = true;
            this.butIncluir.Click += new System.EventHandler(this.butIncluir_Click);
            // 
            // butAlterar
            // 
            this.butAlterar.Location = new System.Drawing.Point(294, 194);
            this.butAlterar.Name = "butAlterar";
            this.butAlterar.Size = new System.Drawing.Size(75, 23);
            this.butAlterar.TabIndex = 11;
            this.butAlterar.Text = "Alterar";
            this.butAlterar.UseVisualStyleBackColor = true;
            // 
            // butExcluir
            // 
            this.butExcluir.Location = new System.Drawing.Point(375, 194);
            this.butExcluir.Name = "butExcluir";
            this.butExcluir.Size = new System.Drawing.Size(75, 23);
            this.butExcluir.TabIndex = 12;
            this.butExcluir.Text = "Excluir";
            this.butExcluir.UseVisualStyleBackColor = true;
            // 
            // butNovo
            // 
            this.butNovo.Location = new System.Drawing.Point(665, 353);
            this.butNovo.Name = "butNovo";
            this.butNovo.Size = new System.Drawing.Size(75, 23);
            this.butNovo.TabIndex = 5;
            this.butNovo.Text = "Novo";
            this.butNovo.UseVisualStyleBackColor = true;
            this.butNovo.Click += new System.EventHandler(this.butNovo_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 406);
            this.Controls.Add(this.butNovo);
            this.Controls.Add(this.grBoxDados);
            this.Controls.Add(this.dgCliente);
            this.Controls.Add(this.butPesquisa);
            this.Controls.Add(this.tBoxPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Name = "FrmCliente";
            this.Text = "PesquisaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            this.grBoxDados.ResumeLayout(false);
            this.grBoxDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox tBoxPesquisa;
        private System.Windows.Forms.Button butPesquisa;
        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.GroupBox grBoxDados;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button butExcluir;
        private System.Windows.Forms.Button butAlterar;
        private System.Windows.Forms.Button butIncluir;
        private System.Windows.Forms.TextBox tBoxId;
        private System.Windows.Forms.TextBox tBoxCredito;
        private System.Windows.Forms.TextBox tBoxEndereco;
        private System.Windows.Forms.TextBox tBoxContato;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.Button butNovo;
    }
}

