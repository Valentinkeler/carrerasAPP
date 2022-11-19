using CarreasAPP.Http;
using CarrerasBackEnd.entidades;
using Newtonsoft.Json;

namespace CarreasAPP
{
    public partial class Form1 : Form
    {
        private carreras nueva;
        public Form1()
        {
            InitializeComponent();
            limpiar();
            nueva = new carreras();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            
        }

        private async void cargarTitulos()
        {
            string url = "https://localhost:7060/titulo";
            var result  =   await  clientSingelton.getInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<titulo>>(result);

            cboTitulo.DataSource=lst;
            cboTitulo.DisplayMember = "nombre";
            cboTitulo.ValueMember = "id";
        }

        private async void cargarMaterias()
        {
            string url = "https://localhost:7060/materias";

            var result= await clientSingelton.getInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<materias>>(result);

            cboMaterias.DataSource = lst;
            cboMaterias.DisplayMember = "nombre";
            cboMaterias.ValueMember = "id";
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

            //foreach (DataGridViewRow item in dgvMaterias.Rows)
            //{
            //    if (item.Cells["idMateria"].Value.ToString().Equals(cboMaterias.SelectedIndex))
            //    {
            //        MessageBox.Show("materia: " + cboMaterias.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //}

            detalleCarreras Odetalle = new  detalleCarreras();
            Odetalle.añoCursado = txtAÑO.Text;
            int cuatri=0;
            if (rbtPrimerCuatri.Checked)
            {
                Odetalle.cuatrimestre = true;
                cuatri = 1;
            }
            else
            {
                Odetalle.cuatrimestre=false;
                cuatri = 2;
            }
            Odetalle.materias = (materias)cboMaterias.SelectedItem;

            nueva.agregardetalle(Odetalle);

            dgvMaterias.Rows.Add(new object[] {Odetalle.materias.id,Odetalle.materias.nombre,Odetalle.añoCursado,cuatri});

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarMaterias();
            cargarTitulos();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            await guardarcarrera();

        }

        private async Task guardarcarrera()
        {
            nueva.nombre =  txtCarrera.Text;
            nueva.titulos = (titulo)cboTitulo.SelectedItem;
            string  bodyContent=  JsonConvert.SerializeObject(nueva);

            string url = "https://localhost:7060/carrera";
            var result = clientSingelton.getInstance().postAsync(url, bodyContent);

            if (result.Equals("true"))
            {
                MessageBox.Show("carrera registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}