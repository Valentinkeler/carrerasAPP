using CarreasAPP.Http;
using CarrerasBackEnd.entidades;
using Newtonsoft.Json;

namespace CarreasAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            limpiar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            cargarMaterias();
            cargarTitulos();
        }

        private void cargarTitulos()
        {
            throw new NotImplementedException();
        }

        private async void cargarMaterias()
        {
            string url = "https://localhost:7060/materias";
            //string url = "https://localhost:7060/titulo";

            var result= await clientSingelton.getInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<materias>>(result);

            cboMaterias.DataSource = lst;
            //cboMaterias.DisplayMember = "descricion";
            //cboMaterias.ValueMember = "id_materias";

        }

        private void limpiar()
        {
            txtCarrera.Text =String.Empty;
            txtAÑO.Text = String.Empty;
            cboMaterias.SelectedIndex = -1;
            cboTitulo.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("quiere cancelar carga de carrera", "Control", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarMaterias();
        }
    }
}