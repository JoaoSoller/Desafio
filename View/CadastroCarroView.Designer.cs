
namespace CadastroCarros
{
    partial class CadastroCarroView
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
            this.lblChassi = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtChassi = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtTabelaFipe = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.lblTabelaFipe = new System.Windows.Forms.Label();
            this.txtmodeloano = new System.Windows.Forms.TextBox();
            this.txtfabricacaoano = new System.Windows.Forms.TextBox();
            this.lblAnoModelo = new System.Windows.Forms.Label();
            this.lblAnoFabricacao = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.cb_modelo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblChassi
            // 
            this.lblChassi.AutoSize = true;
            this.lblChassi.Location = new System.Drawing.Point(35, 70);
            this.lblChassi.Name = "lblChassi";
            this.lblChassi.Size = new System.Drawing.Size(41, 15);
            this.lblChassi.TabIndex = 1;
            this.lblChassi.Text = "Chassi";
            this.lblChassi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(35, 116);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 15);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(328, 41);
            this.txtPlaca.MaxLength = 8;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(239, 23);
            this.txtPlaca.TabIndex = 3;
            // 
            // txtChassi
            // 
            this.txtChassi.Location = new System.Drawing.Point(35, 88);
            this.txtChassi.MaxLength = 17;
            this.txtChassi.Name = "txtChassi";
            this.txtChassi.Size = new System.Drawing.Size(239, 23);
            this.txtChassi.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(31, 268);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(175, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(328, 23);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(35, 15);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(35, 166);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 15);
            this.lblModelo.TabIndex = 9;
            this.lblModelo.Text = "Modelo";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Location = new System.Drawing.Point(328, 180);
            this.txtObservacoes.MaxLength = 50;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(239, 23);
            this.txtObservacoes.TabIndex = 16;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(328, 132);
            this.txtValorVenda.MaxLength = 20;
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(239, 23);
            this.txtValorVenda.TabIndex = 15;
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // txtTabelaFipe
            // 
            this.txtTabelaFipe.Location = new System.Drawing.Point(328, 85);
            this.txtTabelaFipe.MaxLength = 20;
            this.txtTabelaFipe.Name = "txtTabelaFipe";
            this.txtTabelaFipe.Size = new System.Drawing.Size(239, 23);
            this.txtTabelaFipe.TabIndex = 14;
            this.txtTabelaFipe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTabelaFipe_KeyPress);
            this.txtTabelaFipe.Leave += new System.EventHandler(this.txtTabelaFipe_Leave);
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(328, 162);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(74, 15);
            this.lblObs.TabIndex = 13;
            this.lblObs.Text = "Observações";
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(328, 116);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(68, 15);
            this.lblValorVenda.TabIndex = 12;
            this.lblValorVenda.Text = "Valor Venda";
            this.lblValorVenda.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTabelaFipe
            // 
            this.lblTabelaFipe.AutoSize = true;
            this.lblTabelaFipe.Location = new System.Drawing.Point(328, 67);
            this.lblTabelaFipe.Name = "lblTabelaFipe";
            this.lblTabelaFipe.Size = new System.Drawing.Size(94, 15);
            this.lblTabelaFipe.TabIndex = 11;
            this.lblTabelaFipe.Text = "Valor Tabela Fipe";
            // 
            // txtmodeloano
            // 
            this.txtmodeloano.Location = new System.Drawing.Point(328, 228);
            this.txtmodeloano.MaxLength = 15;
            this.txtmodeloano.Name = "txtmodeloano";
            this.txtmodeloano.Size = new System.Drawing.Size(239, 23);
            this.txtmodeloano.TabIndex = 22;
            // 
            // txtfabricacaoano
            // 
            this.txtfabricacaoano.Location = new System.Drawing.Point(35, 228);
            this.txtfabricacaoano.MaxLength = 15;
            this.txtfabricacaoano.Name = "txtfabricacaoano";
            this.txtfabricacaoano.Size = new System.Drawing.Size(239, 23);
            this.txtfabricacaoano.TabIndex = 21;
            // 
            // lblAnoModelo
            // 
            this.lblAnoModelo.AutoSize = true;
            this.lblAnoModelo.Location = new System.Drawing.Point(328, 210);
            this.lblAnoModelo.Name = "lblAnoModelo";
            this.lblAnoModelo.Size = new System.Drawing.Size(73, 15);
            this.lblAnoModelo.TabIndex = 20;
            this.lblAnoModelo.Text = "Ano Modelo";
            this.lblAnoModelo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblAnoFabricacao
            // 
            this.lblAnoFabricacao.AutoSize = true;
            this.lblAnoFabricacao.Location = new System.Drawing.Point(35, 210);
            this.lblAnoFabricacao.Name = "lblAnoFabricacao";
            this.lblAnoFabricacao.Size = new System.Drawing.Size(89, 15);
            this.lblAnoFabricacao.TabIndex = 19;
            this.lblAnoFabricacao.Text = "Ano Fabricação";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtID.Location = new System.Drawing.Point(35, 41);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(239, 23);
            this.txtID.TabIndex = 24;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(35, 23);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 15);
            this.lblid.TabIndex = 23;
            this.lblid.Text = "ID";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(393, 268);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(175, 23);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(212, 268);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(175, 23);
            this.btnNovo.TabIndex = 26;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cb_marca
            // 
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(35, 134);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(239, 23);
            this.cb_marca.TabIndex = 27;
            this.cb_marca.SelectedIndexChanged += new System.EventHandler(this.cb_marca_SelectedIndexChanged);
            this.cb_marca.DataSourceChanged += new System.EventHandler(this.cb_marca_DataSourceChanged);
            // 
            // cb_modelo
            // 
            this.cb_modelo.FormattingEnabled = true;
            this.cb_modelo.Location = new System.Drawing.Point(35, 184);
            this.cb_modelo.Name = "cb_modelo";
            this.cb_modelo.Size = new System.Drawing.Size(239, 23);
            this.cb_modelo.TabIndex = 28;
            this.cb_modelo.SelectedIndexChanged += new System.EventHandler(this.cb_modelo_SelectedIndexChanged);
            // 
            // CadastroCarroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 327);
            this.Controls.Add(this.cb_modelo);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtmodeloano);
            this.Controls.Add(this.txtfabricacaoano);
            this.Controls.Add(this.lblAnoModelo);
            this.Controls.Add(this.lblAnoFabricacao);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.txtTabelaFipe);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.lblValorVenda);
            this.Controls.Add(this.lblTabelaFipe);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtChassi);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblChassi);
            this.Controls.Add(this.lblPlaca);
            this.Name = "CadastroCarroView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Activated += new System.EventHandler(this.CadastroCarroView_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChassi;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtTabelaFipe;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblTabelaFipe;
        private System.Windows.Forms.TextBox txtmodeloano;
        private System.Windows.Forms.TextBox txtfabricacaoano;
        private System.Windows.Forms.Label lblAnoModelo;
        private System.Windows.Forms.Label lblAnoFabricacao;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.ComboBox cb_modelo;
    }
}

