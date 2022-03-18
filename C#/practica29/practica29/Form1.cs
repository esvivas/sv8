using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace practica29
{
    public partial class Form1 : Form
    {
        int posicionX = 0;
        int posicionY = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            posicionX = esqueleto.Location.X;
            posicionY = esqueleto.Location.Y;
            Thread caminar = new Thread(new ThreadStart(hilo));
            caminar.Start();
        }

        public void hilo()
        {
            CheckForIllegalCrossThreadCalls = false;
            while (true)
            {
                posicionX += 2;
                esqueleto.Location = new Point(posicionX, posicionY);
                Thread.Sleep(10);
            }
        }
    }
}
