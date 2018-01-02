namespace MegaRSS_1
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
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItens
            // 
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo});
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.Location = new System.Drawing.Point(0, 0);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.Size = new System.Drawing.Size(631, 365);
            this.dgvItens.TabIndex = 0;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "titulo";
            this.titulo.Name = "titulo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 365);
            this.Controls.Add(this.dgvItens);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
    }
}

