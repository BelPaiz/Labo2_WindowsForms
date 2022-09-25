using ClasesEj2_Registrate;

namespace EjercicioI02_Registrate
{
    public partial class frm_registro : Form
    {
        public frm_registro()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string nombre = UpperPrimerCaracter(txb_nombre.Text);
            string dire = UpperPrimerCaracter(txb_direccion.Text);
            int edad = (int)nud_edad.Value;
            string pais = lstb_paises.Text;
            string sexo = null;
            string[] cursos = new string[2];

            if(rdbtn_masculino.Checked)
            {
                sexo = "Masculino";
            }
            else if(rdbtn_femenino.Checked)
            {
                sexo = "Femenino";
            }
            else
            {
                sexo = "No binario";
            }

            if(ckb_cSharp.Checked)
            {
                AddCurso(cursos, ckb_cSharp.Text);
            }
            if(ckb_cMasMas.Checked)
            {
                AddCurso(cursos, ckb_cMasMas.Text);
            }
            if (ckb_jS.Checked)
            {
                AddCurso(cursos, ckb_jS.Text);
            }
            if(!(string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(dire) || string.IsNullOrWhiteSpace(pais) || string.IsNullOrWhiteSpace(cursos[0])))
            {
                Ingresante nuevo = new Ingresante(nombre, dire, sexo, pais, cursos, edad);
                DialogResult d =  MessageBox.Show(nuevo.Mostrar(), "Ingresante" ,MessageBoxButtons.OK);
                if(d == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Se deben completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public static string UpperPrimerCaracter(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return null;
            }
            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }
        public static void AddCurso(string[] c, string curso)
        {
            for(int i = 0; i < c.Length; i++)
            {
                if (c[i] == null && c[i] != curso)
                {
                    c[i] = curso;
                    break;
                }
            }
        }

    }
}