namespace Diseño1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            menuStrip2 = new MenuStrip();
            Usuario = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem7 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem8 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem9 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem10 = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1 = new MenuStrip();
            iconMenuGestion = new FontAwesome.Sharp.IconMenuItem();
            contenedor = new Panel();
            menuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 793);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 37);
            label2.TabIndex = 4;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = SystemColors.GradientActiveCaption;
            iconButton1.Font = new Font("Segoe UI", 15F);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(769, 447);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(193, 69);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "Siguente";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.BackColor = SystemColors.GradientActiveCaption;
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { Usuario, iconMenuItem7, iconMenuItem8, iconMenuItem9, iconMenuItem10 });
            menuStrip2.Location = new Point(0, 90);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1334, 145);
            menuStrip2.TabIndex = 6;
            menuStrip2.Text = "menuStrip2";
            // 
            // Usuario
            // 
            Usuario.AutoSize = false;
            Usuario.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usuario.IconChar = FontAwesome.Sharp.IconChar.PersonHalfDress;
            Usuario.IconColor = Color.Black;
            Usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(151, 150);
            Usuario.Text = "Usuario";
            Usuario.Click += Usuario_Click;
            // 
            // iconMenuItem7
            // 
            iconMenuItem7.AutoSize = false;
            iconMenuItem7.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem7.IconChar = FontAwesome.Sharp.IconChar.Book;
            iconMenuItem7.IconColor = Color.Black;
            iconMenuItem7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem7.IconSize = 50;
            iconMenuItem7.Name = "iconMenuItem7";
            iconMenuItem7.Size = new Size(131, 150);
            iconMenuItem7.Text = "Libros";
            iconMenuItem7.Click += iconMenuItem7_Click;
            // 
            // iconMenuItem8
            // 
            iconMenuItem8.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem8.IconColor = Color.Black;
            iconMenuItem8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem8.Name = "iconMenuItem8";
            iconMenuItem8.Size = new Size(36, 141);
            // 
            // iconMenuItem9
            // 
            iconMenuItem9.AutoSize = false;
            iconMenuItem9.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem9.IconChar = FontAwesome.Sharp.IconChar.HandHolding;
            iconMenuItem9.IconColor = Color.Black;
            iconMenuItem9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem9.IconSize = 50;
            iconMenuItem9.Name = "iconMenuItem9";
            iconMenuItem9.Size = new Size(173, 150);
            iconMenuItem9.Text = "Prestamo";
            iconMenuItem9.Click += iconMenuItem9_Click;
            // 
            // iconMenuItem10
            // 
            iconMenuItem10.AutoSize = false;
            iconMenuItem10.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuItem10.IconChar = FontAwesome.Sharp.IconChar.HandHoldingHand;
            iconMenuItem10.IconColor = Color.Black;
            iconMenuItem10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem10.IconSize = 50;
            iconMenuItem10.Name = "iconMenuItem10";
            iconMenuItem10.Size = new Size(196, 150);
            iconMenuItem10.Text = "Devolución";
            iconMenuItem10.Click += iconMenuItem10_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuGestion });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(13, 4, 0, 4);
            menuStrip1.Size = new Size(1334, 90);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuGestion
            // 
            iconMenuGestion.BackColor = SystemColors.GradientInactiveCaption;
            iconMenuGestion.Font = new Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconMenuGestion.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuGestion.IconColor = Color.Black;
            iconMenuGestion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuGestion.Name = "iconMenuGestion";
            iconMenuGestion.Size = new Size(290, 82);
            iconMenuGestion.Text = "Gestión de Biblioteca";
            // 
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 235);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1334, 579);
            contenedor.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = Properties.Resources.pngtree_an_old_bookcase_in_a_library_image_2642908;
            ClientSize = new Size(1334, 814);
            ControlBox = false;
            Controls.Add(contenedor);
            Controls.Add(menuStrip2);
            Controls.Add(iconButton1);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form1";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem Usuario;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem7;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem8;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem9;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem10;
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuGestion;
        private Panel contenedor;
    }
}
