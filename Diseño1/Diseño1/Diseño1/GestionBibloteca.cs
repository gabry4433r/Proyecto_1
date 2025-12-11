namespace Diseño1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void AbrirFormulario(Form formulario)
        {
            if (contenedor.Controls.Count > 0)
            {
                contenedor.Controls.RemoveAt(0);
            }
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void Usuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmVentanaUsuario());
        }

        private void iconMenuItem7_Click(object sender, EventArgs e)
        {
           AbrirFormulario(new frmVentanaLibros());
        }

        private void iconMenuItem9_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmResgirtar());
        }

        private void iconMenuItem10_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDevolucion());
        }
    }


}
