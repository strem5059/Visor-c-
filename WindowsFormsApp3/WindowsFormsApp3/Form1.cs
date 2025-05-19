using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEscuchar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtpuerto.Text, out int puerto))
            {
                MessageBox.Show("Puerto inválido.");
                return;
            }
            new visor(puerto).Show();
            btEscuchar.Enabled = false;
        }
    }
}