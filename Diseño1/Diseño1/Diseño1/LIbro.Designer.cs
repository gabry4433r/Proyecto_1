namespace Diseño1
{
    partial class frmVentanaLibros
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
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            lblLibros = new Label();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            girdLibro = new DataGridView();
            IDLibro = new DataGridViewTextBoxColumn();
            Título = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Género = new DataGridViewTextBoxColumn();
            Año = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)girdLibro).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 19;
            btnBuscar.Location = new Point(585, 120);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(28, 29);
            btnBuscar.TabIndex = 11;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(382, 124);
            txtBuscar.Margin = new Padding(2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(199, 23);
            txtBuscar.TabIndex = 10;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = SystemColors.ActiveCaption;
            lblBuscar.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(324, 128);
            lblBuscar.Margin = new Padding(2, 0, 2, 0);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(54, 19);
            lblBuscar.TabIndex = 9;
            lblBuscar.Text = "Buscar:";
            // 
            // lblLibros
            // 
            lblLibros.BackColor = SystemColors.ActiveCaption;
            lblLibros.Font = new Font("Sylfaen", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLibros.Location = new Point(382, 9);
            lblLibros.Margin = new Padding(2, 0, 2, 0);
            lblLibros.Name = "lblLibros";
            lblLibros.Size = new Size(172, 52);
            lblLibros.TabIndex = 8;
            lblLibros.Text = "Libros";
            lblLibros.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ActiveCaption;
            btnRegistrar.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRegistrar.IconColor = Color.Black;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.Location = new Point(406, 368);
            btnRegistrar.Margin = new Padding(2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(161, 51);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar Libro";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // girdLibro
            // 
            girdLibro.BackgroundColor = SystemColors.GradientInactiveCaption;
            girdLibro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            girdLibro.Columns.AddRange(new DataGridViewColumn[] { IDLibro, Título, Autor, Género, Año, Cantidad, Estado, Editar, Eliminar });
            girdLibro.Location = new Point(84, 177);
            girdLibro.Margin = new Padding(2);
            girdLibro.Name = "girdLibro";
            girdLibro.RowHeadersWidth = 62;
            girdLibro.Size = new Size(833, 163);
            girdLibro.TabIndex = 6;
            // 
            // IDLibro
            // 
            IDLibro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IDLibro.FillWeight = 87.7068558F;
            IDLibro.HeaderText = "ID Libro";
            IDLibro.MinimumWidth = 8;
            IDLibro.Name = "IDLibro";
            // 
            // Título
            // 
            Título.HeaderText = "Título";
            Título.MinimumWidth = 8;
            Título.Name = "Título";
            Título.Width = 150;
            // 
            // Autor
            // 
            Autor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Autor.FillWeight = 87.7068558F;
            Autor.HeaderText = "Autor";
            Autor.MinimumWidth = 8;
            Autor.Name = "Autor";
            // 
            // Género
            // 
            Género.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Género.FillWeight = 87.7068558F;
            Género.HeaderText = "Género";
            Género.MinimumWidth = 8;
            Género.Name = "Género";
            // 
            // Año
            // 
            Año.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Año.FillWeight = 87.7068558F;
            Año.HeaderText = "Año";
            Año.MinimumWidth = 8;
            Año.Name = "Año";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 150;
            // 
            // Estado
            // 
            Estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Estado.FillWeight = 87.7068558F;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 8;
            Estado.Name = "Estado";
            // 
            // Editar
            // 
            Editar.FillWeight = 173.758865F;
            Editar.HeaderText = "";
            Editar.MinimumWidth = 8;
            Editar.Name = "Editar";
            Editar.Width = 35;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "";
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 35;
            // 
            // frmVentanaLibros
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.pngtree_an_old_bookcase_in_a_library_image_2642908;
            ClientSize = new Size(970, 593);
            ControlBox = false;
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(lblLibros);
            Controls.Add(btnRegistrar);
            Controls.Add(girdLibro);
            Margin = new Padding(2);
            Name = "frmVentanaLibros";
            ((System.ComponentModel.ISupportInitialize)girdLibro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Label lblLibros;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private DataGridView girdLibro;
        private DataGridViewTextBoxColumn IDLibro;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Género;
        private DataGridViewTextBoxColumn Año;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
    }
}