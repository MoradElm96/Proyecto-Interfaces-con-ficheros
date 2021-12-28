using Proyecto.Clases;
using Proyecto.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Proyecto.Vistas
{


    public partial class FrmGestionDeAtletas : Form
    {
        public List<Atleta> listaAtletas;

        public FrmGestionDeAtletas()
        {
            InitializeComponent();


        }


        private void FrmGestionDeAtletas_Load(object sender, EventArgs e)
        {
            cargarDatos();


        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnContratar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nacionalidad = txtNacionalidad.Text;
            string sexo = SelecionaSexo();
            string edad = txtEdad.Text;
            string peso = txtPeso.Text;
            string salario = txtSalario.Text;
            string categoria = comboBoxCategoria.Text;
            string cif = mtxCIF.Text;
            string telefono = mtxTelefono.Text;
            string correo = txtCorreo.Text;

            if (validarCampos())
            {
                if (Controladores.ControladorAtleta.addAtleta(nombre, apellido, nacionalidad, sexo, edad, peso, salario, categoria, cif, telefono, correo))
                {
                    MessageBox.Show("El atleta se ha contratado");
                    cargarDatos();

                }
                else
                {
                    MessageBox.Show("El atleta no cumple los requisitos para su contratacion");
                }
            }
            else
            {
                MessageBox.Show("Corrija los campos erroneos");
            }
        }

        private bool validarCampos()
        {

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string nacionalidad = txtNacionalidad.Text.Trim();
            string sexo = SelecionaSexo();
            string edad = txtEdad.Text.Trim();
            string peso = txtPeso.Text.Trim();
            string salario = txtSalario.Text.Trim();
            string categoria = comboBoxCategoria.Text.Trim(); 
            string cif = mtxCIF.Text.Trim();
            string telefono = mtxTelefono.Text.Trim();
            string correo = txtCorreo.Text.Trim();


            bool respuesta = true;
            string listadoErrores = "";


            // validar que el  nombre de cliente no es vacío
            // validar que el nombre no está repetido
            if (nombre == "" || Controladores.ControladorAtleta.comprobarNombreAtleta(nombre))
            {
                lblErrorNombre.Visible = true;
                listadoErrores += " Error en el nombre";
                respuesta = false;
            }

            Regex rxCorreo = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!rxCorreo.IsMatch(correo) || Controladores.ControladorAtleta.comprobarCorreoRepetido(correo))
            {
                lblErrorCorreo.Visible = true;

                listadoErrores += " Error en el correo o Correo repetido";
                respuesta = false;
            }

          
                




           return respuesta;

          //no he conseguido hacerlo funcionar
        /*
           if( comboBoxCategoria.SelectedIndex.Equals(-1))
            {
                label20ErrorCombo.Visible = true;
                listadoErrores += " error en selecion de categoria, asegurese de seleccionar una categoria";
                respuesta = false;
            }

            Regex rxCIF = new Regex("^(([A-Z]\\d{8})|(\\d{8}[A-Z]))$");

           if (! rxCIF.IsMatch(cif) )
                {
                lblCifError.Visible = true;
                listadoErrores += "inserte cif correcto";
                  respuesta = false;
                }
            */
            


        }


        //en funcion del radio button seleccionado escribe un valor u otro
        private string SelecionaSexo()
        {
            string seleccionGenero = " ";

            if (radioBMasculino.Checked == true)
            {
                seleccionGenero = radioBMasculino.Text;
            }

            if (radioBFemenino.Checked == true)
            {
                seleccionGenero = radioBFemenino.Text;
            }
            return seleccionGenero;

        }





        private void btnDespedir_Click(object sender, EventArgs e)



        {
            int contadorBorrados = 0;
            foreach (DataGridViewRow fila in dgvGestionAtletas.SelectedRows)
            {
                if (ControladorAtleta.eliminarAtletas(fila.Cells[0].Value.ToString()))
                {
                    contadorBorrados++;
                }
            }
            MessageBox.Show("Se han eliminado " + contadorBorrados.ToString() + " atletas");
            cargarDatos();



        }

        private void cargarDatos()
        {
            listaAtletas = Controladores.ControladorAtleta.recuperarAtletas();
            dgvGestionAtletas.Refresh();
            dgvGestionAtletas.DataSource = listaAtletas;

            comboBoxBuscar.DataSource = listaAtletas;
            comboBoxBuscar.DisplayMember = "NombreCompleto";
            comboBoxBuscar.ValueMember = "IdAtleta";
            dgvGestionAtletas.DataSource = listaAtletas;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            cargarDatos();


        }




        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Atleta> listaFiltrada = listaAtletas.FindAll(atleta => atleta.Nombre.StartsWith(comboBoxBuscar.Text));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //  listaAtletas.Order(listaAtletas => listaAtletas.IdAtleta);

            listaAtletas.Sort((a, b) => (Convert.ToInt32(a.IdAtleta) - Convert.ToInt32(b.IdAtleta))/*a.Nombre).CompareTo(b.Nombre)*/);
            dgvGestionAtletas.Refresh();

            dgvGestionAtletas.DataSource = listaAtletas;




        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;  
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }




        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void mtxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}




