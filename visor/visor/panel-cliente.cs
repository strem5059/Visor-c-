using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.IO;


namespace visor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btConect_Click(object sender, EventArgs e)
        {
            conexiones conexion = new conexiones();
            conexion.Show();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}
