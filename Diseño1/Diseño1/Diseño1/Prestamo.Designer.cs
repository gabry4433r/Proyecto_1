namespace Diseño1
{
    partial class frmResgirtar
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
            lblBuscarLibro = new Label();
            txtCampodeescritura = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            btnSeleccionar = new Button();
            groupBox2 = new GroupBox();
            txtEscrituraUsuario = new TextBox();
            txtEscrituraNombre = new TextBox();
            lblIDdeusuario = new Label();
            lblNombredelusuario = new Label();
            groupBox3 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            lblFechalimitededevolucion = new Label();
            lblFechadeprestamo = new Label();
            lblRegistrarprestamodelibro = new Label();
            btnPrestamorealizado = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblBuscarLibro
            // 
            lblBuscarLibro.BackColor = SystemColors.ActiveCaption;
            lblBuscarLibro.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscarLibro.Location = new Point(35, 28);
            lblBuscarLibro.Margin = new Padding(2, 0, 2, 0);
            lblBuscarLibro.Name = "lblBuscarLibro";
            lblBuscarLibro.Size = new Size(105, 21);
            lblBuscarLibro.TabIndex = 0;
            lblBuscarLibro.Text = "Buscar Libro:";
            // 
            // txtCampodeescritura
            // 
            txtCampodeescritura.Location = new Point(144, 28);
            txtCampodeescritura.Margin = new Padding(2);
            txtCampodeescritura.Name = "txtCampodeescritura";
            txtCampodeescritura.Size = new Size(209, 27);
            txtCampodeescritura.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 19;
            btnBuscar.Location = new Point(357, 30);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(24, 25);
            btnBuscar.TabIndex = 6;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += iconButton2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(btnSeleccionar);
            groupBox1.Controls.Add(txtCampodeescritura);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(lblBuscarLibro);
            groupBox1.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(197, 90);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(551, 111);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Libro Seleccionado:";

            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = SystemColors.ActiveCaption;
            btnSeleccionar.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeleccionar.Location = new Point(421, 54);
            btnSeleccionar.Margin = new Padding(2);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(117, 29);
            btnSeleccionar.TabIndex = 7;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(txtEscrituraUsuario);
            groupBox2.Controls.Add(txtEscrituraNombre);
            groupBox2.Controls.Add(lblIDdeusuario);
            groupBox2.Controls.Add(lblNombredelusuario);
            groupBox2.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(197, 245);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(551, 112);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Prestario:";
            // 
            // txtEscrituraUsuario
            // 
            txtEscrituraUsuario.Location = new Point(179, 63);
            txtEscrituraUsuario.Margin = new Padding(2);
            txtEscrituraUsuario.Name = "txtEscrituraUsuario";
            txtEscrituraUsuario.Size = new Size(174, 27);
            txtEscrituraUsuario.TabIndex = 3;
            // 
            // txtEscrituraNombre
            // 
            txtEscrituraNombre.Location = new Point(179, 28);
            txtEscrituraNombre.Margin = new Padding(2);
            txtEscrituraNombre.Name = "txtEscrituraNombre";
            txtEscrituraNombre.Size = new Size(174, 27);
            txtEscrituraNombre.TabIndex = 2;
            // 
            // lblIDdeusuario
            // 
            lblIDdeusuario.AutoSize = true;
            lblIDdeusuario.BackColor = SystemColors.ActiveCaption;
            lblIDdeusuario.Location = new Point(18, 63);
            lblIDdeusuario.Margin = new Padding(2, 0, 2, 0);
            lblIDdeusuario.Name = "lblIDdeusuario";
            lblIDdeusuario.Size = new Size(99, 19);
            lblIDdeusuario.TabIndex = 1;
            lblIDdeusuario.Text = "ID de Usuario:";
            // 
            // lblNombredelusuario
            // 
            lblNombredelusuario.AutoSize = true;
            lblNombredelusuario.BackColor = SystemColors.ActiveCaption;
            lblNombredelusuario.Location = new Point(18, 28);
            lblNombredelusuario.Margin = new Padding(2, 0, 2, 0);
            lblNombredelusuario.Name = "lblNombredelusuario";
            lblNombredelusuario.Size = new Size(136, 19);
            lblNombredelusuario.TabIndex = 0;
            lblNombredelusuario.Text = "Nombre del Usuario:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientInactiveCaption;
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(lblFechalimitededevolucion);
            groupBox3.Controls.Add(lblFechadeprestamo);
            groupBox3.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(197, 403);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(551, 122);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fechas:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(201, 69);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(211, 22);
            dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(201, 30);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 22);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged_1;
            // 
            // lblFechalimitededevolucion
            // 
            lblFechalimitededevolucion.AutoSize = true;
            lblFechalimitededevolucion.BackColor = SystemColors.ActiveCaption;
            lblFechalimitededevolucion.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechalimitededevolucion.Location = new Point(18, 69);
            lblFechalimitededevolucion.Margin = new Padding(2, 0, 2, 0);
            lblFechalimitededevolucion.Name = "lblFechalimitededevolucion";
            lblFechalimitededevolucion.Size = new Size(179, 19);
            lblFechalimitededevolucion.TabIndex = 1;
            lblFechalimitededevolucion.Text = "Fecha Límite de devolución:";
            lblFechalimitededevolucion.Click += label6_Click;
            // 
            // lblFechadeprestamo
            // 
            lblFechadeprestamo.AutoSize = true;
            lblFechadeprestamo.BackColor = SystemColors.ActiveCaption;
            lblFechadeprestamo.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechadeprestamo.Location = new Point(22, 30);
            lblFechadeprestamo.Margin = new Padding(2, 0, 2, 0);
            lblFechadeprestamo.Name = "lblFechadeprestamo";
            lblFechadeprestamo.Size = new Size(132, 19);
            lblFechadeprestamo.TabIndex = 0;
            lblFechadeprestamo.Text = "Fecha del prestamo:";
            // 
            // lblRegistrarprestamodelibro
            // 
            lblRegistrarprestamodelibro.AutoSize = true;
            lblRegistrarprestamodelibro.BackColor = SystemColors.ActiveCaption;
            lblRegistrarprestamodelibro.Font = new Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrarprestamodelibro.Location = new Point(314, 9);
            lblRegistrarprestamodelibro.Margin = new Padding(2, 0, 2, 0);
            lblRegistrarprestamodelibro.Name = "lblRegistrarprestamodelibro";
            lblRegistrarprestamodelibro.Size = new Size(330, 35);
            lblRegistrarprestamodelibro.TabIndex = 10;
            lblRegistrarprestamodelibro.Text = "Registrar Prestamo de Libro";
            lblRegistrarprestamodelibro.Click += label4_Click;
            // 
            // btnPrestamorealizado
            // 
            btnPrestamorealizado.BackColor = SystemColors.ActiveCaption;
            btnPrestamorealizado.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrestamorealizado.Location = new Point(380, 575);
            btnPrestamorealizado.Name = "btnPrestamorealizado";
            btnPrestamorealizado.Size = new Size(198, 34);
            btnPrestamorealizado.TabIndex = 11;
            btnPrestamorealizado.Text = "Prestamo Realizado";
            btnPrestamorealizado.UseVisualStyleBackColor = false;
            // 
            // frmResgirtar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.pngtree_an_old_bookcase_in_a_library_image_2642908;
            ClientSize = new Size(939, 621);
            ControlBox = false;
            Controls.Add(btnPrestamorealizado);
            Controls.Add(lblRegistrarprestamodelibro);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "frmResgirtar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCampodeescritura;
        private Label lblBuscarLibro;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnSeleccionar;
        private Label lblIDdeusuario;
        private Label lblNombredelusuario;
        private TextBox txtEscrituraUsuario;
        private TextBox txtEscrituraNombre;
        private Label lblFechalimitededevolucion;
        private Label lblFechadeprestamo;
        private Label lblRegistrarprestamodelibro;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button btnPrestamorealizado;
    }
}