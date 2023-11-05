using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestor_Centro_Educativo
{
    public partial class docente : Form
    {
        public docente()
        {
            InitializeComponent();
        }

        private void docente_Load(object sender, EventArgs e)
        {
            
        }

        private void verificar_id_Click(object sender, EventArgs e)
        {
         foreach (persona u in persona.variables_globales.usuarios)
            {

            }   
        }

      

        private void volver_btn_Click(object sender, EventArgs e)
        {
            Form form = new tittleBar2();
            this.Hide();
            form.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            listView.Items.Clear();
            materia_buscar.Text = "";
            foreach (persona u in persona.variables_globales.usuarios)
            {
                if (u.type == "ESTUDIANTE")
                {
                    ListViewItem lista = new ListViewItem(u.user);
                    listView.Items.Add(lista);
                }
            }  
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form form = new tittleBar2();
            this.Hide();
            form.ShowDialog();
        }
        // salir
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Minimizar
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_enter(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "NOMBRE DE ESTUDIANTE")
            {
                txt_nombre.Text = "";
            }
        }

        private void nombre_leave(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                txt_nombre.Text = "NOMBRE DE ESTUDIANTE";
            }
        }

        private void primer_enter(object sender, EventArgs e)
        {
            if (primera.Text == "30%")
            {
                primera.Text = "";
            }
        }

        private void primer_leave(object sender, EventArgs e)
        {
            if (primera.Text == "")
            {
                primera.Text = "30%";
            }
        }

        private void segundo_enter(object sender, EventArgs e)
        {
            if (segunda.Text == "30%")
            {
                segunda.Text = "";
            }
        }

        private void segundo_leave(object sender, EventArgs e)
        {
            if (segunda.Text == "")
            {
                segunda.Text = "30%";
            }
        }

        private void tercera_enter(object sender, EventArgs e)
        {
            if (tercera.Text == "40%")
            {
                tercera.Text = "";
            }
        }

        private void tercera_leave(object sender, EventArgs e)
        {
            if (tercera.Text == "")
            {
                tercera.Text = "40%";
            }
        }

        private void verificar_id_Click_1(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "" || Materia.Text == "" || primera.Text == "" || segunda.Text == "" || tercera.Text == "")
            {
                MessageBox.Show("Error: Los campos estan vacios", "Gestor Centro Educativo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (persona u in persona.variables_globales.usuarios)
                {
                    if (u.user == txt_nombre.Text)
                    {
                        if (Materia.Text == "Matemáticas")
                        {
                            materia.variables_globales.estudiante_matematicas.Add(new materia.matematicas(txt_nombre.Text, primera.Text, segunda.Text, tercera.Text));
                        }else if (Materia.Text == "Ciencias")
                        {
                            materia.variables_globales.estudiante_ciencias.Add(new materia.ciencias(txt_nombre.Text, primera.Text, segunda.Text, tercera.Text));
                        }
                        else if (Materia.Text == "Español")
                        {
                            materia.variables_globales.estudiante_español.Add(new materia.español(txt_nombre.Text, primera.Text, segunda.Text, tercera.Text));
                        }
                        MessageBox.Show("Agregado correctamente", "Gestor Centro Educativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        // buscar
        private void button2_Click(object sender, EventArgs e)
        {
            if (materia_buscar.Text == "Matemáticas")
            {
                listView.Items.Clear();
                foreach (materia.matematicas u in materia.variables_globales.estudiante_matematicas)
                {
                    ListViewItem lista = new ListViewItem(u.estudiante);
                    lista.SubItems.Add(u.primernota);
                    lista.SubItems.Add(u.segundanota);
                    lista.SubItems.Add(u.tercernota);
                    double primera = (double.Parse(u.primernota) * 0.30);
                    double segunda = (double.Parse(u.segundanota) * 0.30);
                    double tercera = (double.Parse(u.tercernota) * 0.40);
                    double total = primera + segunda + tercera;
                    total = Math.Round(total, 1);
                    lista.SubItems.Add(Convert.ToString(total));
                    listView.Items.Add(lista);
                } 
            }
            else if (materia_buscar.Text == "Ciencias")
            {
                listView.Items.Clear();
                foreach (materia.ciencias u in materia.variables_globales.estudiante_ciencias)
                {
                    ListViewItem lista = new ListViewItem(u.estudiante);
                    lista.SubItems.Add(u.primernota);
                    lista.SubItems.Add(u.segundanota);
                    lista.SubItems.Add(u.tercernota);
                    double primera = (double.Parse(u.primernota) * 0.30);
                    double segunda = (double.Parse(u.segundanota) * 0.30);
                    double tercera = (double.Parse(u.tercernota) * 0.40);
                    double total = primera + segunda + tercera;
                    total = Math.Round(total, 1);
                    lista.SubItems.Add(Convert.ToString(total));
                    listView.Items.Add(lista);
                }
            }
            else if (materia_buscar.Text == "Español")
            {
                listView.Items.Clear();
                foreach (materia.español u in materia.variables_globales.estudiante_español)
                {
                    ListViewItem lista = new ListViewItem(u.estudiante);
                    lista.SubItems.Add(u.primernota);
                    lista.SubItems.Add(u.segundanota);
                    lista.SubItems.Add(u.tercernota);
                    double primera = (double.Parse(u.primernota) * 0.30);
                    double segunda = (double.Parse(u.segundanota) * 0.30);
                    double tercera = (double.Parse(u.tercernota) * 0.40);
                    double total = primera + segunda + tercera;
                    total = Math.Round(total, 1);
                    lista.SubItems.Add(Convert.ToString(total));
                    listView.Items.Add(lista);
                }
            }
        }
    }
}
