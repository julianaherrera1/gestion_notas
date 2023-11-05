using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Centro_Educativo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        public static class variables_globales
        {
            public static string nombre_sesion;
            public static string tipo;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

       

        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            btnOcultar.BringToFront();
            passwordbox.PasswordChar = '\0';
        }

        private void btnOcultar_Click_1(object sender, EventArgs e)
        {
            btnMostrar.BringToFront();
            passwordbox.PasswordChar = '*';
        }

        private void BtnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            
            int cont = 0;
            string id_inicio = idBox.Text;
            string password_inicio = passwordbox.Text;
            foreach (persona u in persona.variables_globales.usuarios)
            {
                if (id_inicio == u.user && password_inicio == u.password && variables_globales.tipo == u.type)
                {
                    MessageBox.Show("Inicio de sesión correcto", "Gestor Centro Educativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cont = 0;
                    if (u.type == "ESTUDIANTE")
                    {
                        variables_globales.nombre_sesion = u.user;
                        Form form = new estudiante();
                        this.Hide();
                        form.ShowDialog();

                    }else if (u.type == "DOCENTE")
                    {
                        Form form = new docente();
                        this.Hide();
                        form.ShowDialog();

                    }
                    break;
                }
                else
                {
                    cont++;
                }
            }
            if (cont != 0)
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Gestor Centro Educativo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            idBox.Clear();
            passwordbox.Clear();
    
        }
       
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            
            if(idBox.Text == "" || passwordbox.Text== "")
            {
                MessageBox.Show("Error: Los campos estan vacios", "Gestor Centro Educativo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                persona.variables_globales.usuarios.Add(new persona(idBox.Text, passwordbox.Text, variables_globales.tipo));
                MessageBox.Show("Te has registrado correctamente", "Gestor Centro Educativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                idBox.Clear();
                passwordbox.Clear();
            }

           
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new tittleBar2();
            this.Hide();
            form.ShowDialog();
        }
    }
}
