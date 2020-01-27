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

namespace Calzado_Anny
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            CustomDesing();
            Maximizar();
        }

        
        private void Pbexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Arrastrar Formulario
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarra_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void Pbrestablecer_Click(object sender, EventArgs e)
        {
            pbMaximizar.Visible = true;
            pbrestablecer.Visible = false;
            int sw1 = 1154, sh1 = 661;
            int lx1 = 223, ly1 = 99;
            this.Size = new Size(sw1, sh1);
            this.Location = new Point(lx1, ly1);
        }

        private void Pbminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PbMaximizar_Click(object sender, EventArgs e)
        {
            Maximizar();
        }

        private void Maximizar()
        {
            int lx = this.Location.X;
            int ly = this.Location.Y;
            int sw = this.Size.Width;
            int sh = this.Size.Height;
            pbMaximizar.Visible = false;
            pbrestablecer.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        #region Menu

        private void CustomDesing()
        {
            Panel_Producto.Visible = false;
            Panel_Proveedor.Visible = false;
            Panel_compras.Visible = false;
            Panel_Ubicacion.Visible = false;
            Panel_tiendas.Visible = false;
            PanelBodega.Visible = false;
            Panel_Empleados.Visible = false;
            Panel_Mayoristas.Visible = false;
            Panel_Factura.Visible = false;
            Panel_Ventas.Visible = false;
            Panel_Pagos.Visible = false;
            Panel_Extras.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (Panel_Producto.Visible == true)
            {
                Panel_Producto.Visible = false;
            }
            if (Panel_Proveedor.Visible == true)
            {
                Panel_Proveedor.Visible = false;
            }
            if (Panel_Ubicacion.Visible == true)
            {
                Panel_Ubicacion.Visible = false;
            }
            if (Panel_compras.Visible == true)
            {
                Panel_compras.Visible = false;
            }
            if (Panel_tiendas.Visible == true)
            {
                Panel_tiendas.Visible = false;
            }
            if (Panel_tiendas.Visible == true)
            {
                Panel_tiendas.Visible = false;
            }
            if (PanelBodega.Visible == true)
            {
                PanelBodega.Visible = false;
            }
            if (Panel_Mayoristas.Visible == true)
            {
                Panel_Mayoristas.Visible = false;
            }
            if (Panel_Empleados.Visible == true)
            {
                Panel_Empleados.Visible = false;
            }
            if (Panel_Factura.Visible == true)
            {
                Panel_Factura.Visible = false;
            }
            if (Panel_Ventas.Visible == true)
            {
                Panel_Ventas.Visible = false;
            }
            if (Panel_Pagos.Visible == true)
            {
                Panel_Pagos.Visible = false;
            }
            if (Panel_Extras.Visible == true)
            {
                Panel_Extras.Visible = false;
            }





        }

        private void MostarSubMenu(Panel subpanel)
        {
            if (subpanel.Visible == false)
            {
                OcultarSubMenu();
                subpanel.Visible = true;
            }
            else
                subpanel.Visible = false;
        }



        #endregion

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            MostarSubMenu(Panel_Producto);
            BtnUbicacion.Text = "Ubicacion";
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            MostarSubMenu(Panel_compras);
            BtnUbicacion.Text = "Ubicacion";
        }

        private void BtnUbicacion_Click(object sender, EventArgs e)
        {
            MostarSubMenu(Panel_Ubicacion);
            BtnUbicacion.Text = "Ubicacion";
        }

        private void BtnSubTiendas_Click(object sender, EventArgs e)
        {
            MostarSubMenu(Panel_tiendas);
            BtnUbicacion.Text = "Tiendas";
        }

        private void BtnBodegas_Click(object sender, EventArgs e)
        {
            MostarSubMenu(PanelBodega);
            BtnUbicacion.Text = "Bodegas";
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            MostarSubMenu(Panel_Empleados);
            BtnUbicacion.Text = "Ubicacion";
        }

        private void BtnMayoristas_Click(object sender, EventArgs e)
        {
            MostarSubMenu(Panel_Mayoristas);
            BtnUbicacion.Text = "Ubicacion";
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            MostarSubMenu(Panel_Factura);
            BtnUbicacion.Text = "Ubicacion";
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            MostarSubMenu(Panel_Ventas);
            BtnUbicacion.Text = "Ubicacion";
        }

        private void BtnPagos_Click(object sender, EventArgs e)
        {
            MostarSubMenu(Panel_Pagos);
            BtnUbicacion.Text = "Ubicacion";
        }

        private void BtnExtras_Click(object sender, EventArgs e)
        {
            MostarSubMenu(Panel_Extras);
            BtnUbicacion.Text = "Ubicacion";
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            MostarSubMenu(Panel_Proveedor);
            BtnUbicacion.Text = "Ubicacion";
        }



        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        

    }
}
