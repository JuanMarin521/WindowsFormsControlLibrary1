using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            //Se invoca el metodo en el constructor justo despues de inicializar componentes
            personalizarDiseño();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelRegistrarSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

       

      

        //Codificacion 23/10/2024

        private void personalizarDiseño()
        {
            //Oculta los paneles del submenu
            panelObjetosSubMenu.Visible=false;
            panelPersonasSubMenu.Visible=false;
        }

        private void ocultarSubMenu()
        {
            //Si el panel objetos se encuentra desplegado lo cerrará
            if (panelObjetosSubMenu.Visible== true)
                panelObjetosSubMenu.Visible = false;
            //Si el panel personas se encuentra desplegado lo cerrará
            if (panelPersonasSubMenu.Visible == true)
                panelPersonasSubMenu.Visible = false;
        }

        //Todos los submenus son paneles, entonces se tomará como parametro de tipo panel1 submenu
        private void mostrarSubMenu(Panel subMenu)
        {
            //Si panel submenu está oculto, se mostrará
            if (subMenu.Visible == false)
            {
                //Se invoca en caso de que haya algun submenu abierto
                ocultarSubMenu();

                //Se muestra el submenu
                subMenu.Visible = true;
            }
            else
            {
                //Si el submenu se encuentra abierto se volverá a ocultar
                subMenu.Visible = false;
            }
        }

        //Codigo alojado de boton personas
        #region Personas
        private void botonPersonas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelPersonasSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Form1());
            //Codigo para registrar personas
            ocultarSubMenu();
        }

        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Form2());
            //Codigo para eliminar personas
            ocultarSubMenu();
        }
        #endregion

        //Codigo alojado de boton objetos
        #region Objetos
        private void button5_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelObjetosSubMenu);
        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Form3());
            //Codigo para registrar objeto
            ocultarSubMenu();
        }

        private void btnRegistrarMaterial_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Form4());
            //Codigo para registrar material
            ocultarSubMenu();
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Form5());
            //Codigo para registrar devolucion de material
            ocultarSubMenu();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Form6());
            //Codigo para registrar objeto
            ocultarSubMenu();
        }
        #endregion

        //Codigo alojado de historial
        #region Historial
        private void botonHistorial_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new Form7());
            //Codigo para historial
            ocultarSubMenu();
        }
        #endregion

        //Cierra el formulario anterior
        private Form formularioActivo = null;

        private void abrirFormulariosHijos(Form formularioHijo)
        {
            //Si existe algun formulario activo
            if(formularioActivo != null)

                //Se cierra el formulario
                formularioActivo.Close();

            //Se guarda el formulario que se abre en la variable formulario activo
            formularioActivo = formularioHijo;

            //Se indica que el formulario hijo no es de nivel superior
            //Se comportará igual que un control
            formularioHijo.TopLevel = false;

            //Se quita el borde del formulario
            formularioHijo.FormBorderStyle = FormBorderStyle.None;

            //Se establece la propiedad para llenar todo el formulario contenedor(principal)
            formularioHijo.Dock = DockStyle.Fill;

            //Agregamos el formulario a la lista de controles del panel contenedor
            panelFormularioHijo.Controls.Add(formularioHijo);

            //Se asocia el formulario con el panel contenedor
            panelFormularioHijo.Tag = formularioHijo;

            //En caso de poner logos en el panel
            formularioHijo.BringToFront();
            //Se muestra el formulario hijo
            formularioHijo.Show();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelFormularioHijo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
