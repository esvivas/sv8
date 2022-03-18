using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica30
{
    public partial class Form1 : Form
    {
        Estudiante estudiante;
        public Form1()
        {
            InitializeComponent();
            estudiante = new Estudiante();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            estudiante.Nombre = txt_nombre.Text;
            estudiante.setEdad(txt_edad.Text);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Clear();
            txt_edad.Clear();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            txt_nombre.Text = estudiante.Nombre;
            txt_edad.Text = estudiante.getEdad().ToString();
        }
    }

    class Estudiante
    {
        private string nombre;
        private int edad;

        //Por propiedad

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        //Método set
        public void setEdad(String n)
        {
            int numero = Convert.ToInt32(n);
            edad = numero;
        }

        //Método get
        public int getEdad()
        {
            return edad;
        }

    }
}
