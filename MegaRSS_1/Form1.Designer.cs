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
            this.components = new System.ComponentModel.Container();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.wbSite = new System.Windows.Forms.WebBrowser();
            this.feedCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemResumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDatahoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemLidoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feedCodigoDataGridViewTextBoxColumn,
            this.itemCodigoDataGridViewTextBoxColumn,
            this.itemTituloDataGridViewTextBoxColumn,
            this.itemResumoDataGridViewTextBoxColumn,
            this.itemUrlDataGridViewTextBoxColumn,
            this.itemAutorDataGridViewTextBoxColumn,
            this.itemDatahoraDataGridViewTextBoxColumn,
            this.itemLidoDataGridViewCheckBoxColumn});
            this.dgvItens.DataSource = this.itemBindingSource;
            this.dgvItens.Location = new System.Drawing.Point(12, 12);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.Size = new System.Drawing.Size(317, 560);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItens_CellMouseClick);
            // 
            // wbSite
            // 
            this.wbSite.Location = new System.Drawing.Point(335, 12);
            this.wbSite.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbSite.Name = "wbSite";
            this.wbSite.Size = new System.Drawing.Size(723, 560);
            this.wbSite.TabIndex = 1;
            // 
            // feedCodigoDataGridViewTextBoxColumn
            // 
            this.feedCodigoDataGridViewTextBoxColumn.DataPropertyName = "FeedCodigo";
            this.feedCodigoDataGridViewTextBoxColumn.HeaderText = "FeedCodigo";
            this.feedCodigoDataGridViewTextBoxColumn.Name = "feedCodigoDataGridViewTextBoxColumn";
            this.feedCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.feedCodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemCodigoDataGridViewTextBoxColumn
            // 
            this.itemCodigoDataGridViewTextBoxColumn.DataPropertyName = "ItemCodigo";
            this.itemCodigoDataGridViewTextBoxColumn.HeaderText = "ItemCodigo";
            this.itemCodigoDataGridViewTextBoxColumn.Name = "itemCodigoDataGridViewTextBoxColumn";
            this.itemCodigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemCodigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemTituloDataGridViewTextBoxColumn
            // 
            this.itemTituloDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemTituloDataGridViewTextBoxColumn.DataPropertyName = "ItemTitulo";
            this.itemTituloDataGridViewTextBoxColumn.HeaderText = "ItemTitulo";
            this.itemTituloDataGridViewTextBoxColumn.Name = "itemTituloDataGridViewTextBoxColumn";
            this.itemTituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemResumoDataGridViewTextBoxColumn
            // 
            this.itemResumoDataGridViewTextBoxColumn.DataPropertyName = "ItemResumo";
            this.itemResumoDataGridViewTextBoxColumn.HeaderText = "ItemResumo";
            this.itemResumoDataGridViewTextBoxColumn.Name = "itemResumoDataGridViewTextBoxColumn";
            this.itemResumoDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemResumoDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemUrlDataGridViewTextBoxColumn
            // 
            this.itemUrlDataGridViewTextBoxColumn.DataPropertyName = "ItemUrl";
            this.itemUrlDataGridViewTextBoxColumn.HeaderText = "ItemUrl";
            this.itemUrlDataGridViewTextBoxColumn.Name = "itemUrlDataGridViewTextBoxColumn";
            this.itemUrlDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemUrlDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemAutorDataGridViewTextBoxColumn
            // 
            this.itemAutorDataGridViewTextBoxColumn.DataPropertyName = "ItemAutor";
            this.itemAutorDataGridViewTextBoxColumn.HeaderText = "ItemAutor";
            this.itemAutorDataGridViewTextBoxColumn.Name = "itemAutorDataGridViewTextBoxColumn";
            this.itemAutorDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemAutorDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemDatahoraDataGridViewTextBoxColumn
            // 
            this.itemDatahoraDataGridViewTextBoxColumn.DataPropertyName = "ItemDatahora";
            this.itemDatahoraDataGridViewTextBoxColumn.HeaderText = "ItemDatahora";
            this.itemDatahoraDataGridViewTextBoxColumn.Name = "itemDatahoraDataGridViewTextBoxColumn";
            this.itemDatahoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemLidoDataGridViewCheckBoxColumn
            // 
            this.itemLidoDataGridViewCheckBoxColumn.DataPropertyName = "ItemLido";
            this.itemLidoDataGridViewCheckBoxColumn.HeaderText = "ItemLido";
            this.itemLidoDataGridViewCheckBoxColumn.Name = "itemLidoDataGridViewCheckBoxColumn";
            this.itemLidoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(MegaRSS_1.Item);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 584);
            this.Controls.Add(this.wbSite);
            this.Controls.Add(this.dgvItens);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.WebBrowser wbSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemResumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDatahoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemLidoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource itemBindingSource;
    }
}

