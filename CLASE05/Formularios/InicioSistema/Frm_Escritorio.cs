using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASE05.Negocios;
using CLASE05.Formularios.Usuarios;
using CLASE05.Formularios.Clientes;
using CLASE05.Formularios.FrmBASE;

namespace CLASE05.Formularios.InicioSistema
{
    public partial class Frm_Escritorio : Form
    {
        string usuario = "";
        string clave = "";
        int id_usuario = 0;
        NE_Usuarios ne_usu = new NE_Usuarios();
        

        public Frm_Escritorio()
        {
            InitializeComponent();
        }

        private void Frm_Escritorio_Load(object sender, EventArgs e)
        {
            this.Plogin();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirDeSistemaConLoginActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Plogin();
        }
        
        private void Plogin()
        {
            this.usuario = "";
            this.clave = "";
            this.id_usuario = 0;

            Frm_Login login = new Frm_Login();
            login.ShowDialog();
            if (login.Pp_usuario == "")
            {
                login.Dispose();
                this.Close();
                return;
            }
            this.usuario = login.Pp_usuario;
            this.clave = login.Pp_clave;
            login.Dispose();
            id_usuario = ne_usu.RecuperarId(this.usuario, this.clave);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Usuario_Entrada frm_usuario = new Frm_ABM_Usuario_Entrada();
            frm_usuario.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Cliente_Entrada frm_usuario = new Frm_ABM_Cliente_Entrada();
            frm_usuario.ShowDialog();

        }
    }
}
