namespace MegaRSS_1.Forms
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnSites = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnFeed = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.ucFeed = new MegaRSS_1.UCs.ucFeed();
            this.pnlLeft.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnlLeft.Controls.Add(this.btnSites);
            this.pnlLeft.Controls.Add(this.btnCategorias);
            this.pnlLeft.Controls.Add(this.btnFeed);
            this.pnlLeft.Controls.Add(this.pnlControl);
            this.pnlLeft.Controls.Add(this.panel2);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(5, 5);
            this.pnlLeft.MinimumSize = new System.Drawing.Size(140, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(140, 693);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnSites
            // 
            this.btnSites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSites.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSites.FlatAppearance.BorderSize = 0;
            this.btnSites.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSites.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSites.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.btnSites.Location = new System.Drawing.Point(0, 208);
            this.btnSites.Margin = new System.Windows.Forms.Padding(0);
            this.btnSites.MinimumSize = new System.Drawing.Size(140, 0);
            this.btnSites.Name = "btnSites";
            this.btnSites.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSites.Size = new System.Drawing.Size(140, 67);
            this.btnSites.TabIndex = 11;
            this.btnSites.Text = "Sites";
            this.btnSites.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSites.UseVisualStyleBackColor = true;
            this.btnSites.Click += new System.EventHandler(this.btnSites_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.btnCategorias.Location = new System.Drawing.Point(0, 141);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCategorias.Size = new System.Drawing.Size(140, 67);
            this.btnCategorias.TabIndex = 10;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnFeed
            // 
            this.btnFeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFeed.FlatAppearance.BorderSize = 0;
            this.btnFeed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeed.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
            this.btnFeed.Location = new System.Drawing.Point(0, 74);
            this.btnFeed.Margin = new System.Windows.Forms.Padding(0);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFeed.Size = new System.Drawing.Size(140, 67);
            this.btnFeed.TabIndex = 3;
            this.btnFeed.Text = "Feed";
            this.btnFeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pnlControl.Controls.Add(this.btnSair);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 622);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(140, 71);
            this.pnlControl.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(3, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 65);
            this.btnSair.TabIndex = 0;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 74);
            this.panel2.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(145, 5);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1022, 74);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(505, 74);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Feed";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Gray;
            this.pnlContent.Controls.Add(this.ucFeed);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContent.Location = new System.Drawing.Point(145, 79);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1022, 619);
            this.pnlContent.TabIndex = 2;
            // 
            // ucFeed
            // 
            this.ucFeed.BackColor = System.Drawing.Color.Gray;
            this.ucFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFeed.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.ucFeed.ForeColor = System.Drawing.Color.Black;
            this.ucFeed.Location = new System.Drawing.Point(0, 0);
            this.ucFeed.Name = "ucFeed";
            this.ucFeed.Size = new System.Drawing.Size(1022, 619);
            this.ucFeed.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1172, 703);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.Button btnSites;
        private System.Windows.Forms.Button btnCategorias;
        private UCs.ucFeed ucFeed;
    }
}