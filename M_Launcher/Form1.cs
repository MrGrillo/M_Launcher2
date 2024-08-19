using System.Diagnostics;

namespace M_Launcher
{
    public partial class Form1 : Form
    {
        private Form inicioForm;
        private Form instalacionForm;
        private Form form3;
        public Form1()
        {
            InitializeComponent();

            // Create instances of the forms
            inicioForm = new Inicio(this);
            instalacionForm = new Instalacion(this);
            form3 = new Form3();

            // Show the first form by default
            AbrirFormHijo(inicioForm);
        }

        private void AbrirFormHijo(object formHijo)
        {

            // Eliminar controles anteriores si existen
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);

            // Configurar el nuevo form como hijo
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();

        }



        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(inicioForm);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtInicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {

            AbrirFormHijo(instalacionForm);
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(form3);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            // URL a la que deseas redirigir
            string url = "https://discord.gg/UGb9C8Vq";

            // Abre la URL en el navegador predeterminado
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true // Esto asegura que la URL se abra en el navegador predeterminado
            });
        }
    }
}
