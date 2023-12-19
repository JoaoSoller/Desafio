
namespace CadastroCarros.View
{
    partial class ListarCarrosView
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
            this.dgv_Carros = new System.Windows.Forms.DataGridView();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Carros
            // 
            this.dgv_Carros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Carros.Location = new System.Drawing.Point(12, 31);
            this.dgv_Carros.Name = "dgv_Carros";
            this.dgv_Carros.RowTemplate.Height = 25;
            this.dgv_Carros.Size = new System.Drawing.Size(475, 332);
            this.dgv_Carros.TabIndex = 0;
            this.dgv_Carros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Carros_CellDoubleClickAsync);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(12, 390);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(218, 28);
            this.btnMarcas.TabIndex = 5;
            this.btnMarcas.Text = "Visualizar Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(246, 390);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(218, 28);
            this.btnCadastro.TabIndex = 6;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // ListarCarrosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 430);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnMarcas);
            this.Controls.Add(this.dgv_Carros);
            this.Name = "ListarCarrosView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarCarros";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Carros;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCadastro;
    }
}