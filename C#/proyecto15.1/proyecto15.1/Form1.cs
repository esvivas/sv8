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

namespace proyecto15._1
{
    
    public partial class Form1 : Form
    {
        ArrayList list_voluntarios = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombre.Text;
            list_voluntarios.Add(nombre);
            MessageBox.Show(nombre + " Agregado: Soldado Voluntario");
            txt_nombre.Clear();
            
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            area.Text = "Primera Línea de Locos\n";
            foreach(string soldado in list_voluntarios)
            {
                area.AppendText("\n Nombre " + soldado);
            }
        }
    }
}
