using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuChef
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string contrasena;
        private void Button1_Click(object sender, EventArgs e)
        {
            string user=boxUser.Text;
            string password=Boxpassword.Text;
            string direccion = "C:\\Users\\kakit\\Documents\\Usuarios" + user + ".txt";
            if (File.Exists(direccion))
            {
                contrasena=File.ReadAllText(direccion);
                if(password.Equals(contrasena))
                {
                    MessageBox.Show("Acceso correcto");
                }
                else
                {
                    MessageBox.Show("La contraseña o usuario no son correctos");
                }

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string user = boxUser.Text;
            string password = Boxpassword.Text;
            string direccion= "C:\\Users\\kakit\\Documents\\Usuarios" + user + ".txt";
            if (File.Exists(direccion))
            {
                MessageBox.Show("Este usuario ya esta registrado");
            }
            else
            {
                File.WriteAllText(direccion, password);
                MessageBox.Show("Registro Exitoso");
                boxUser.Text = "";
                Boxpassword.Text = "";
            }
        }
    }
}
