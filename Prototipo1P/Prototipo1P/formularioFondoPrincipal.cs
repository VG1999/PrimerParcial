/*
 Formulario Principal de programa, direcciona a otros formularios
 */
using Prototipo1P;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaDeVideos
{
    public partial class formularioFondoPrincipal : Form
    {
        private string rol;
        public formularioFondoPrincipal()
        {
            InitializeComponent();

                   }

       
        //Salir con validacion
        private void picSalir_Click(object sender, EventArgs e)
        {
            DialogResult drResultadoMensaje;
            drResultadoMensaje= MessageBox.Show("¿Realmente desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (drResultadoMensaje == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //Minimizar
        private void picMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //ir a categoria
        private void categoriaVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //ir a videos
        private void videosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Productos video = new Productos ();
            video.Show();
        }
        //ir a cargos
        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //ir a empleados
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }
        //ir a membresia
        private void membresiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        //ir a clientes
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //ir a proveedores
        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
        }
        //ir a usaurios
        private void controlUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //ir a informe clientes
        private void informeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        //ir a bitacora
        private void informeBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //ir a estado video
        private void estadoVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //ir a facturas 
        private void ingresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //ir a facturas mantenimiento
        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        //ir a compras
        private void ingresoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
        //ir a compras mantenimiento
        private void mantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
