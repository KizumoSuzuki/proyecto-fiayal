using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Data.SqlClient;
namespace GestionEstudiantes
{
    public partial class principal : Form
    {
      
        public principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ListaEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarEstudiante_Click(object sender, EventArgs e)
        {
            
                ListaEstudiantes.Items.Add(" Nombre: " + Nombre.Text + " /Apellido: " + Apellido.Text + " /Correo: " + Correo.Text + " /Curso: " + Curso.Text + " /Nivel: " + Nivel.Text + " /Telefono: " + NumeroTelefonico.Text + " /Fecha de Nacimiento: " + FechaNacimiento.Text);
         

        }

        private void EliminarEstudiante_Click(object sender, EventArgs e)
        {
            ListaEstudiantes.Items.Remove(ListaEstudiantes.SelectedItem);
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        

    }
}
