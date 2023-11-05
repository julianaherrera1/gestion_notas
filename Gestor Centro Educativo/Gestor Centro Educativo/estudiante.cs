using System;
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
    public partial class estudiante : Form
    {
        public estudiante()
        {
            InitializeComponent();
        }

        private void ver_notas_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new tittleBar2();
            this.Hide();
            form.ShowDialog();
        }
    }
}
