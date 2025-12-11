namespace Diseño1
{
    partial class frmDevolucion
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
            lbldevoluciondelibro = new Label();
            lblIdusuario = new Label();
            txtCampoidusuario = new TextBox();
            btnicnodebusqueda = new FontAwesome.Sharp.IconButton();
            gridTabladevolucion = new DataGridView();
            Título = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            FechaDePrestamo = new DataGridViewTextBoxColumn();
            FechaLimiteDevolución = new DataGridViewTextBoxColumn();
            btndevolverlibro = new Button();
            ((System.ComponentModel.ISupportInitialize)gridTabladevolucion).BeginInit();
            SuspendLayout();
            // 
            // lbldevoluciondelibro
            // 
            lbldevoluciondelibro.AutoSize = true;
            lbldevoluciondelibro.BackColor = SystemColors.ActiveCaption;
            lbldevoluciondelibro.Font = new Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbldevoluciondelibro.ForeColor = SystemColors.ControlText;
            lbldevoluciondelibro.Location = new Point(339, 9);
            lbldevoluciondelibro.Margin = new Padding(2, 0, 2, 0);
            lbldevoluciondelibro.Name = "lbldevoluciondelibro";
            lbldevoluciondelibro.Size = new Size(246, 35);
            lbldevoluciondelibro.TabIndex = 0;
            lbldevoluciondelibro.Text = "Devolución de Libro";
            lbldevoluciondelibro.Click += lbldevoluciondelibro_Click;
            // 
            // lblIdusuario
            // 
            lblIdusuario.AutoSize = true;
            lblIdusuario.BackColor = SystemColors.ActiveCaption;
            lblIdusuario.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdusuario.Location = new Point(307, 121);
            lblIdusuario.Margin = new Padding(2, 0, 2, 0);
            lblIdusuario.Name = "lblIdusuario";
            lblIdusuario.Size = new Size(76, 19);
            lblIdusuario.TabIndex = 1;
            lblIdusuario.Text = "ID Usuario";
            lblIdusuario.Click += label2_Click;
            // 
            // txtCampoidusuario
            // 
            txtCampoidusuario.Location = new Point(387, 117);
            txtCampoidusuario.Margin = new Padding(2);
            txtCampoidusuario.Name = "txtCampoidusuario";
            txtCampoidusuario.Size = new Size(148, 23);
            txtCampoidusuario.TabIndex = 2;
            // 
            // btnicnodebusqueda
            // 
            btnicnodebusqueda.BackColor = SystemColors.ActiveCaption;
            btnicnodebusqueda.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnicnodebusqueda.IconColor = Color.Black;
            btnicnodebusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnicnodebusqueda.IconSize = 19;
            btnicnodebusqueda.Location = new Point(539, 112);
            btnicnodebusqueda.Margin = new Padding(2);
            btnicnodebusqueda.Name = "btnicnodebusqueda";
            btnicnodebusqueda.Size = new Size(31, 28);
            btnicnodebusqueda.TabIndex = 7;
            btnicnodebusqueda.UseVisualStyleBackColor = false;
            // 
            // gridTabladevolucion
            // 
            gridTabladevolucion.BackgroundColor = SystemColors.GradientInactiveCaption;
            gridTabladevolucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTabladevolucion.Columns.AddRange(new DataGridViewColumn[] { Título, Cantidad, FechaDePrestamo, FechaLimiteDevolución });
            gridTabladevolucion.Location = new Point(113, 223);
            gridTabladevolucion.Margin = new Padding(2);
            gridTabladevolucion.Name = "gridTabladevolucion";
            gridTabladevolucion.RowHeadersWidth = 62;
            gridTabladevolucion.Size = new Size(709, 135);
            gridTabladevolucion.TabIndex = 8;
            // 
            // Título
            // 
            Título.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Título.HeaderText = "Título";
            Título.MinimumWidth = 8;
            Título.Name = "Título";
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cantidad.HeaderText = "Cantidad ";
            Cantidad.MinimumWidth = 8;
            Cantidad.Name = "Cantidad";
            // 
            // FechaDePrestamo
            // 
            FechaDePrestamo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaDePrestamo.HeaderText = "Fecha de prestamo";
            FechaDePrestamo.MinimumWidth = 8;
            FechaDePrestamo.Name = "FechaDePrestamo";
            // 
            // FechaLimiteDevolución
            // 
            FechaLimiteDevolución.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FechaLimiteDevolución.HeaderText = "Fecha Limite de devolución ";
            FechaLimiteDevolución.MinimumWidth = 8;
            FechaLimiteDevolución.Name = "FechaLimiteDevolución";
            // 
            // btndevolverlibro
            // 
            btndevolverlibro.BackColor = SystemColors.ActiveCaption;
            btndevolverlibro.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndevolverlibro.Location = new Point(368, 421);
            btndevolverlibro.Margin = new Padding(2);
            btndevolverlibro.Name = "btndevolverlibro";
            btndevolverlibro.Size = new Size(217, 54);
            btndevolverlibro.TabIndex = 9;
            btndevolverlibro.Text = "Devolver Libro";
            btndevolverlibro.UseVisualStyleBackColor = false;
            // 
            // frmDevolucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.pngtree_an_old_bookcase_in_a_library_image_2642908;
            ClientSize = new Size(915, 525);
            ControlBox = false;
            Controls.Add(btndevolverlibro);
            Controls.Add(gridTabladevolucion);
            Controls.Add(btnicnodebusqueda);
            Controls.Add(txtCampoidusuario);
            Controls.Add(lblIdusuario);
            Controls.Add(lbldevoluciondelibro);
            Margin = new Padding(2);
            Name = "frmDevolucion";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)gridTabladevolucion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbldevoluciondelibro;
        private Label lblIdusuario;
        private TextBox txtCampoidusuario;
        private FontAwesome.Sharp.IconButton btnicnodebusqueda;
        private DataGridView gridTabladevolucion;
        private Button btndevolverlibro;
        private DataGridViewTextBoxColumn Título;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn FechaDePrestamo;
        private DataGridViewTextBoxColumn FechaLimiteDevolución;
    }
}