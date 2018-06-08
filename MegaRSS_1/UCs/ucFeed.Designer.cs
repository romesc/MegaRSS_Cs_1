namespace MegaRSS_1.UCs
{
    partial class ucFeed
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.tvFeeds = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.feedCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemResumoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDatahoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemLidoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.tvFeeds);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 4, 10);
            this.panel1.Size = new System.Drawing.Size(303, 619);
            this.panel1.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.DimGray;
            this.btnAtualizar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(10, 570);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(289, 39);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // tvFeeds
            // 
            this.tvFeeds.BackColor = System.Drawing.Color.DarkGray;
            this.tvFeeds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvFeeds.FullRowSelect = true;
            this.tvFeeds.HideSelection = false;
            this.tvFeeds.Location = new System.Drawing.Point(10, 10);
            this.tvFeeds.Name = "tvFeeds";
            this.tvFeeds.Size = new System.Drawing.Size(289, 599);
            this.tvFeeds.TabIndex = 0;
            this.tvFeeds.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFeeds_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvItens);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(303, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4, 10, 10, 10);
            this.panel2.Size = new System.Drawing.Size(719, 619);
            this.panel2.TabIndex = 1;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItens.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.EnableHeadersVisualStyles = false;
            this.dgvItens.Location = new System.Drawing.Point(4, 10);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.ShowCellToolTips = false;
            this.dgvItens.ShowEditingIcon = false;
            this.dgvItens.Size = new System.Drawing.Size(705, 599);
            this.dgvItens.TabIndex = 1;
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
            dataGridViewCellStyle3.Format = "g";
            dataGridViewCellStyle3.NullValue = null;
            this.itemDatahoraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.itemDatahoraDataGridViewTextBoxColumn.HeaderText = "Publicação";
            this.itemDatahoraDataGridViewTextBoxColumn.Name = "itemDatahoraDataGridViewTextBoxColumn";
            this.itemDatahoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemDatahoraDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.itemDatahoraDataGridViewTextBoxColumn.Width = 89;
            // 
            // itemLidoDataGridViewCheckBoxColumn
            // 
            this.itemLidoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.itemLidoDataGridViewCheckBoxColumn.DataPropertyName = "ItemLido";
            this.itemLidoDataGridViewCheckBoxColumn.HeaderText = "Lido?";
            this.itemLidoDataGridViewCheckBoxColumn.Name = "itemLidoDataGridViewCheckBoxColumn";
            this.itemLidoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.itemLidoDataGridViewCheckBoxColumn.Width = 50;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(MegaRSS_1.Item);
            // 
            // ucFeed
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.Name = "ucFeed";
            this.Size = new System.Drawing.Size(1022, 619);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvFeeds;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridView dgvItens;
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
