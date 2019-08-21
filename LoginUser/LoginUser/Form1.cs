using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUser
{
    public partial class Form1 : Form
    {
        string usuario, contrasena;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)//iniciar
        {
            if (usuario == "juancho")
            {
                if (contrasena == "123tamarindo")
                {
                    MessageBox.Show("Bienvenido Usuario " + usuario + " al sistema.");
                }
                else
                {
                    MessageBox.Show("CONTRASEÑA INCORRECTA.");
                }
            }
            else
            {
                MessageBox.Show("USUARIO INCORRECTO.");
            }

        }

        private void Button2_Click(object sender, EventArgs e)//salir
        {
            this.Close();
        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            usuario = user.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Keyyy_TextChanged(object sender, EventArgs e)
        {
            contrasena = key.Text;
        }
    }
}
