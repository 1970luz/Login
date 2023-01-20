using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUnisurl
{
    public partial class buttonEntrar : System.Windows.Forms.Form
    {
        int contador = 0;
        int intentosmaximos = 3;
        string user ="luci";
        string contrasena = "12345";


        public buttonEntrar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonEntrar_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == user & textBoxContrasena.Text == contrasena)
            {
                MessageBox.Show("Bienvenido");
                    pictureBoxLogin.Image = Properties.Resources.candadoabuerto;
                labelSaludo.Text = "Bienvenido al sistema";
            }
            else
            {
                contador = contador + 1;
                if (contador>=3)
                {
                    MessageBox.Show("Has superado el maximo de intentos " + intentosmaximos);
                    pictureBoxLogin.Image = Properties.Resources.candadocerrado;
                    buttonLogin.Enabled = false;

                }
                else

                {
                    MessageBox.Show("Usuario o contraseña incorrecta,te quedan  " +( intentosmaximos- contador)+ " intentos.");
                }
            }

                
        }
    }
}
