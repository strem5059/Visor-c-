using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class visor : Form
    {
        private readonly int puerto;
        private TcpListener server;
        private TcpClient cliente;
        private NetworkStream mainStream;

        private Thread hiloEscuchar;
        private Thread hiloRecibir;
        private bool enEjecucion = true;

        public visor(int Puerto)
        {
            puerto = Puerto;
            InitializeComponent();
        }

        private void EmpezarEscuchar()
        {
            try
            {
                server = new TcpListener(IPAddress.Any, puerto);
                server.Start();

                cliente = server.AcceptTcpClient();

                hiloRecibir = new Thread(Recibir) { IsBackground = true };
                hiloRecibir.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar escucha: " + ex.Message);
            }
        }

        private void DetenerEscucha()
        {
            enEjecucion = false;
            try
            {
                server.Stop();
                cliente?.Close();
            }
            catch { }
        }

        private void Recibir()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            while (enEjecucion && cliente.Connected)
            {
                try
                {
                    mainStream = cliente.GetStream();
                    Image img = (Image)binFormatter.Deserialize(mainStream);
                    pictureBox1.Invoke(new Action(() => pictureBox1.Image = img));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error recibiendo imagen: " + ex.Message);
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            hiloEscuchar = new Thread(EmpezarEscuchar) { IsBackground = true };
            hiloEscuchar.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            DetenerEscucha();
        }

    }
}
