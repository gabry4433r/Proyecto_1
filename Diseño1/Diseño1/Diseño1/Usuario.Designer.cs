namespace Diseño1
{
    partial class frmVentanaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaUsuario));
            gridTablausuario = new DataGridView();
            IDUsuario = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            NúmeroIdenticación = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            lblUsuario = new Label();
            lblBuscar = new Label();
            txtCampodetexto = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)gridTablausuario).BeginInit();
            SuspendLayout();
            // 
            // gridTablausuario
            // 
            gridTablausuario.BackgroundColor = SystemColors.GradientInactiveCaption;
            gridTablausuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTablausuario.Columns.AddRange(new DataGridViewColumn[] { IDUsuario, Nombre, Apellido, NúmeroIdenticación, Editar, Eliminar });
            gridTablausuario.Location = new Point(143, 241);
            gridTablausuario.Margin = new Padding(2);
            gridTablausuario.Name = "gridTablausuario";
            gridTablausuario.RowHeadersWidth = 62;
            gridTablausuario.Size = new Size(775, 163);
            gridTablausuario.TabIndex = 0;
            gridTablausuario.CellContentClick += dataGridView1_CellContentClick;
            // 
            // IDUsuario
            // 
            IDUsuario.HeaderText = "IDUsuario";
            IDUsuario.MinimumWidth = 8;
            IDUsuario.Name = "IDUsuario";
            IDUsuario.Width = 150;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 8;
            Apellido.Name = "Apellido";
            Apellido.Width = 150;
            // 
            // NúmeroIdenticación
            // 
            NúmeroIdenticación.HeaderText = "NúmeroIdenticación";
            NúmeroIdenticación.MinimumWidth = 8;
            NúmeroIdenticación.Name = "NúmeroIdenticación";
            NúmeroIdenticación.Width = 190;
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
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ActiveCaption;
            btnRegistrar.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRegistrar.IconColor = Color.Black;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.Location = new Point(434, 445);
            btnRegistrar.Margin = new Padding(2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(199, 37);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar Usuario";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = SystemColors.ActiveCaption;
            lblUsuario.Font = new Font("Sylfaen", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(410, 9);
            lblUsuario.Margin = new Padding(2, 0, 2, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(206, 54);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            lblUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = SystemColors.ActiveCaption;
            lblBuscar.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(337, 171);
            lblBuscar.Margin = new Padding(2, 0, 2, 0);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(54, 19);
            lblBuscar.TabIndex = 3;
            lblBuscar.Text = "Buscar:";
            lblBuscar.Click += label2_Click;
            // 
            // txtCampodetexto
            // 
            txtCampodetexto.Location = new Point(410, 167);
            txtCampodetexto.Margin = new Padding(2);
            txtCampodetexto.Name = "txtCampodetexto";
            txtCampodetexto.Size = new Size(199, 23);
            txtCampodetexto.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 19;
            btnBuscar.Location = new Point(624, 162);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(26, 28);
            btnBuscar.TabIndex = 5;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // frmVentanaUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1057, 622);
            ControlBox = false;
            Controls.Add(btnBuscar);
            Controls.Add(txtCampodetexto);
            Controls.Add(lblBuscar);
            Controls.Add(lblUsuario);
            Controls.Add(btnRegistrar);
            Controls.Add(gridTablausuario);
            Margin = new Padding(2);
            Name = "frmVentanaUsuario";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)gridTablausuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridTablausuario;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private Label lblUsuario;
        private Label lblBuscar;
        private TextBox txtCampodetexto;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private DataGridViewTextBoxColumn IDUsuario;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn NúmeroIdenticación;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
    }
}