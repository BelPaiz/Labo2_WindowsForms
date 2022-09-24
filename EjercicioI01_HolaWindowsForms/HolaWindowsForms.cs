using Saludo;
namespace EjercicioI01_HolaWindowsForms
{
    public partial class frm_HolaWindowsForms : Form
    {
        public frm_HolaWindowsForms()
        {
            InitializeComponent();
        }

        private void btn_saludar_Click(object sender, EventArgs e)
        {
            string nombre = UpperPrimerCaracter(txb_nombre.Text);
            string apellido = UpperPrimerCaracter(txb_apellido.Text);
            string nombreCompelto = nombre + " " + apellido;
            string favorita = cmb_materiaFavorita.Text;
            if(nombre == null && apellido == null)
            {
                MessageBox.Show("Se deben completar los siguientes campos: \nNombre\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nombre == null)
            {
                MessageBox.Show("Se deben completar los siguientes campos: \nNombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (apellido == null)
            {
                MessageBox.Show("Se deben completar los siguientes campos: \nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!EncontarMateria(favorita))
            {
                MessageBox.Show("No seleciono materia favorita.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frm_saludo frm_salu = new frm_saludo(nombreCompelto, favorita);
                frm_salu.Show();
                this.Hide();
            }
        }

        public static string UpperPrimerCaracter(string texto)
        {
            if(string.IsNullOrWhiteSpace(texto))
            {
                return null;
            }
            return char.ToUpper(texto[0]) + texto.Substring(1);
        }
        private bool EncontarMateria(string materia)
        {

            foreach(string item in cmb_materiaFavorita.Items)
            {
                if(item == materia)
                {
                    return true;
                }
            }
            return false;
        }
    }
}