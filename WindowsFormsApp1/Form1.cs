using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        entrada ingresa; // Proviene del form entrada 
                     // ingresa es un nombre con el cual se le pueda llamar, puede tener otro nombre
                     // ejemplo gato, perro, ingresa, login, etc

        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            //Si casilla de usuario y contrasena estan en blanco no permita ingresar hasta que el texto 
            //del usuario y contrasena tengan Admin y pass
            if ((txtUsuario.Text != "") && (txtContrasena.Text !=""))
            {
                // Indica que el usuario es Admin y la contrasena es pass
                if ((txtUsuario.Text == "Admin") && (txtContrasena.Text == "pass")) 
                {
                    ingresa = new entrada(); //Inicia el nuevo form llamado entrada
                    ingresa.Show();          //Para que muestre el form
                    this.Hide();           //Para que lo deje de mostrar el form
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();    //Para salir del form inicio de sesion con el boton salir
        }
    }
}
