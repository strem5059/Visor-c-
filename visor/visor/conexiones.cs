using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace visor
{
    public partial class conexiones : Form
    {
        private readonly TcpClient cliente = new TcpClient();
        private NetworkStream mainStream;
        private int N_Puerto;

        private static Image Capturapantalla()
        {
            Rectangle bound = Screen.PrimaryScreen.Bounds;
            Bitmap Cpantalla = new Bitmap(bound.Width, bound.Height, PixelFormat.Format32bppArgb);
            Graphics grafico = Graphics.FromImage(Cpantalla);
            grafico.CopyFromScreen(bound.X, bound.Y, 0, 0, bound.Size, CopyPixelOperation.SourceCopy);
            
            return Cpantalla;
        }

        private void imagenEscritorio()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            mainStream = cliente.GetStream();
            binFormatter.Serialize(mainStream, Capturapantalla());

        }

        public conexiones()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;

        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtpuerto.Text, out N_Puerto))
            {
                MessageBox.Show("Puerto inválido.");
                return;
            }

            try
            {
                cliente.Connect(txtIp.Text, N_Puerto);
                btConectar.Text = "Conectado exitosamente....";
                MessageBox.Show("Conectado");
                btConectar.Enabled = false;
                btScreen.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al conectar");
                btConectar.Text = "No conectado";
            }
        }

        private void conexiones_Load(object sender, EventArgs e)
        {
            btScreen.Enabled = false;

        }

        private void btScreen_Click(object sender, EventArgs e)
        {
            if (btScreen.Text.StartsWith("Comenzar"))
            {
                timer1.Start();
                btScreen.Text = ".....intercambiando.....";
            }
            else
            {
                timer1.Stop();
                btScreen.Text = "Comenzar";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            imagenEscritorio();
        }

    }
}