using Proyecto.Clases;
using Proyecto.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Vistas
{
    public partial class FrmAtletas : Form
    {
        public List<Atleta> listaAtletas;
        public List<Atleta> listaOrdenadaFotos = new List<Atleta>();
        List<Atleta> listaUsuariosFiltrada = new List<Atleta>();
        public FrmAtletas()
        {
            InitializeComponent();
        }


        private void tabPageMasculino_Click(object sender, EventArgs e)
        {

        }

        private void FrmAtletas_Load(object sender, EventArgs e)
        {



            listaUsuariosFiltrada = Controladores.ControladorAtleta.recuperarAtletas();
            dgvAtletasMasculino.DataSource = listaUsuariosFiltrada.FindAll((sexo) => sexo.Sexo == "Masculino");

            dgvAtletasFemeninas.DataSource = listaUsuariosFiltrada.FindAll((sexo) => sexo.Sexo == "Femenino");

            listBoxAtletas.DataSource = Controladores.ControladorAtleta.recuperarAtletas();
            listaAtletas = Controladores.ControladorAtleta.recuperarAtletas();
            //ver que se vea solo un proyecto, decir que campo ver

            listaAtletas.Sort((a, b) => (a.NombreCompleto).CompareTo(b.NombreCompleto));
            listBoxAtletas.DataSource = listaAtletas;
            listBoxAtletas.DisplayMember = "NombreCompleto";


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPageFotos_Click(object sender, EventArgs e)
        {

        }

        private void listBoxAtletas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            string fullPath = Path.Combine(Application.StartupPath, "../../");


            pictureBox1.Image = Image.FromFile(fullPath + "/Resources/fotosAtletas/" + listBoxAtletas.Text + ".png");
            pictureBox2.Image = Image.FromFile(fullPath + "/Resources/Banderas/" + listBoxAtletas.Text + ".png");


        }
    }
}
