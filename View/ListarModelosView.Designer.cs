
namespace CadastroCarros.View
{
    partial class ListarModelosView
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
            this.dgb_Modelo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Modelo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgb_Modelo
            // 
            this.dgb_Modelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgb_Modelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_Modelo.Location = new System.Drawing.Point(33, 29);
            this.dgb_Modelo.Name = "dgb_Modelo";
            this.dgb_Modelo.RowTemplate.Height = 25;
            this.dgb_Modelo.Size = new System.Drawing.Size(683, 277);
            this.dgb_Modelo.TabIndex = 1;
            // 
            // ListarModelosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 384);
            this.Controls.Add(this.dgb_Modelo);
            this.Name = "ListarModelosView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelos";
            ((System.ComponentModel.ISupportInitialize)(this.dgb_Modelo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgb_Modelo;
    }
}