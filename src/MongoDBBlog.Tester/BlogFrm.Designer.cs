namespace MongoDBBlog.Prueba
{
    partial class BlogFrm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPosts = new System.Windows.Forms.Label();
            this.gridPosts = new System.Windows.Forms.DataGridView();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLongitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.gridComentarios = new System.Windows.Forms.DataGridView();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevoPost = new System.Windows.Forms.Button();
            this.btnNuevoComentario = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridComentarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.Controls.Add(this.lblPosts, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridPosts, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblComentarios, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridComentarios, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNuevoPost, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNuevoComentario, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(593, 270);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPosts
            // 
            this.lblPosts.AutoSize = true;
            this.lblPosts.Location = new System.Drawing.Point(3, 0);
            this.lblPosts.Name = "lblPosts";
            this.lblPosts.Size = new System.Drawing.Size(33, 13);
            this.lblPosts.TabIndex = 0;
            this.lblPosts.Text = "Posts";
            // 
            // gridPosts
            // 
            this.gridPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTitulo,
            this.colContPost,
            this.colLongitud});
            this.gridPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPosts.Location = new System.Drawing.Point(3, 23);
            this.gridPosts.MultiSelect = false;
            this.gridPosts.Name = "gridPosts";
            this.gridPosts.ReadOnly = true;
            this.gridPosts.RowHeadersVisible = false;
            this.gridPosts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPosts.Size = new System.Drawing.Size(551, 109);
            this.gridPosts.TabIndex = 2;
            this.gridPosts.SelectionChanged += new System.EventHandler(this.gridPosts_SelectionChanged);
            // 
            // colTitulo
            // 
            this.colTitulo.DataPropertyName = "Titulo";
            this.colTitulo.HeaderText = "Título";
            this.colTitulo.Name = "colTitulo";
            this.colTitulo.ReadOnly = true;
            this.colTitulo.Width = 60;
            // 
            // colContPost
            // 
            this.colContPost.DataPropertyName = "Contenido";
            this.colContPost.HeaderText = "Contenido";
            this.colContPost.Name = "colContPost";
            this.colContPost.ReadOnly = true;
            this.colContPost.Width = 80;
            // 
            // colLongitud
            // 
            this.colLongitud.DataPropertyName = "Longitud";
            this.colLongitud.HeaderText = "Longitud";
            this.colLongitud.Name = "colLongitud";
            this.colLongitud.ReadOnly = true;
            this.colLongitud.Width = 73;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(3, 135);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(65, 13);
            this.lblComentarios.TabIndex = 1;
            this.lblComentarios.Text = "Comentarios";
            // 
            // gridComentarios
            // 
            this.gridComentarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridComentarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmail,
            this.colContenido,
            this.colFecha});
            this.gridComentarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridComentarios.Location = new System.Drawing.Point(3, 158);
            this.gridComentarios.MultiSelect = false;
            this.gridComentarios.Name = "gridComentarios";
            this.gridComentarios.ReadOnly = true;
            this.gridComentarios.RowHeadersVisible = false;
            this.gridComentarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridComentarios.Size = new System.Drawing.Size(551, 109);
            this.gridComentarios.TabIndex = 3;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "E-mail";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 60;
            // 
            // colContenido
            // 
            this.colContenido.DataPropertyName = "Contenido";
            this.colContenido.HeaderText = "Contenido";
            this.colContenido.Name = "colContenido";
            this.colContenido.ReadOnly = true;
            this.colContenido.Width = 80;
            // 
            // colFecha
            // 
            this.colFecha.DataPropertyName = "FechaPosteo";
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Width = 62;
            // 
            // btnNuevoPost
            // 
            this.btnNuevoPost.Location = new System.Drawing.Point(560, 23);
            this.btnNuevoPost.Name = "btnNuevoPost";
            this.btnNuevoPost.Size = new System.Drawing.Size(26, 35);
            this.btnNuevoPost.TabIndex = 4;
            this.btnNuevoPost.Text = "+";
            this.btnNuevoPost.UseVisualStyleBackColor = true;
            this.btnNuevoPost.Click += new System.EventHandler(this.NuevaEntrada);
            // 
            // btnNuevoComentario
            // 
            this.btnNuevoComentario.Location = new System.Drawing.Point(560, 158);
            this.btnNuevoComentario.Name = "btnNuevoComentario";
            this.btnNuevoComentario.Size = new System.Drawing.Size(26, 35);
            this.btnNuevoComentario.TabIndex = 5;
            this.btnNuevoComentario.Text = "+";
            this.btnNuevoComentario.UseVisualStyleBackColor = true;
            this.btnNuevoComentario.Click += new System.EventHandler(this.NuevaEntrada);
            // 
            // BlogFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 295);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BlogFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blog";
            this.Load += new System.EventHandler(this.BlogFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridComentarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView gridComentarios;
        private System.Windows.Forms.Label lblPosts;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.DataGridView gridPosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLongitud;
        private System.Windows.Forms.Button btnNuevoPost;
        private System.Windows.Forms.Button btnNuevoComentario;
    }
}