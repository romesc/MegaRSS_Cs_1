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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tvLista = new System.Windows.Forms.TreeView();
            this.btnCarregar = new System.Windows.Forms.Button();
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
            this.menuStrip1.SuspendLayout();
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
            this.dgvItens.Location = new System.Drawing.Point(206, 71);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.Size = new System.Drawing.Size(852, 501);
            this.dgvItens.TabIndex = 0;
            this.dgvItens.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItens_CellMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.feedsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoToolStripMenuItem});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // feedsToolStripMenuItem
            // 
            this.feedsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoToolStripMenuItem1});
            this.feedsToolStripMenuItem.Name = "feedsToolStripMenuItem";
            this.feedsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.feedsToolStripMenuItem.Text = "Feeds";
            // 
            // manutençãoToolStripMenuItem1
            // 
            this.manutençãoToolStripMenuItem1.Name = "manutençãoToolStripMenuItem1";
            this.manutençãoToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.manutençãoToolStripMenuItem1.Text = "Manutenção";
            // 
            // tvLista
            // 
            this.tvLista.HideSelection = false;
            this.tvLista.Location = new System.Drawing.Point(12, 71);
            this.tvLista.Name = "tvLista";
            this.tvLista.Size = new System.Drawing.Size(188, 501);
            this.tvLista.TabIndex = 3;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(12, 27);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(99, 38);
            this.btnCarregar.TabIndex = 4;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
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
            this.itemTituloDataGridViewTextBoxColumn.HeaderText = "Título";
            this.itemTituloDataGridViewTextBoxColumn.Name = "itemTituloDataGridViewTextBoxColumn";
            this.itemTituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemTituloDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.itemDatahoraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemDatahoraDataGridViewTextBoxColumn.DataPropertyName = "ItemDatahora";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.itemDatahoraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.itemDatahoraDataGridViewTextBoxColumn.HeaderText = "Publicação";
            this.itemDatahoraDataGridViewTextBoxColumn.Name = "itemDatahoraDataGridViewTextBoxColumn";
            this.itemDatahoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemDatahoraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.itemDatahoraDataGridViewTextBoxColumn.Width = 78;
            // 
            // itemLidoDataGridViewCheckBoxColumn
            // 
            this.itemLidoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemLidoDataGridViewCheckBoxColumn.DataPropertyName = "ItemLido";
            this.itemLidoDataGridViewCheckBoxColumn.HeaderText = "Lido?";
            this.itemLidoDataGridViewCheckBoxColumn.Name = "itemLidoDataGridViewCheckBoxColumn";
            this.itemLidoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.itemLidoDataGridViewCheckBoxColumn.Width = 45;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(MegaRSS_1.Item);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1070, 584);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.tvLista);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem1;
        private System.Windows.Forms.TreeView tvLista;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemResumoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDatahoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn itemLidoDataGridViewCheckBoxColumn;
    }
}

