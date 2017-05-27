using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;


namespace Gym_1_1_pruebas.Views
{
    public partial class FrmTomaFoto : Form
    {

        private FilterInfoCollection dispositivoDeVideo;
        private VideoCaptureDevice fuenteDeVideo = null;
        private Bitmap imagen;
        private Image captura;
        private Util.Imagen formato;
        

        
        public FrmTomaFoto()
        {
            
            InitializeComponent();

            captura = null;

            //try
            {
                dispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                fuenteDeVideo = new VideoCaptureDevice(dispositivoDeVideo[0].MonikerString);
                fuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                fuenteDeVideo.VideoResolution = fuenteDeVideo.VideoCapabilities[fuenteDeVideo.VideoCapabilities.Length-1];
                
                fuenteDeVideo.Start();
             }
            /*catch (VideoException)
            {

                MessageBox.Show("Hubo un error al inicializar el video");
            }*/
            formato = new Util.Imagen(fuenteDeVideo.VideoResolution.FrameSize);
        }

        public void terminarFuenteDeVideo()
        {
            if (!(fuenteDeVideo == null))
                if (fuenteDeVideo.IsRunning)
                {
                    fuenteDeVideo.SignalToStop();
                    fuenteDeVideo = null;
                }

        }

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            


            imagen = formato.format(eventArgs.Frame);

           
            
            ptbCamara.Image = imagen;

      


        }

        private void FrmTomaFoto_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            
            captura = imagen;    
            
            
            this.Close();
        }

        private void FrmTomaFoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            terminarFuenteDeVideo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Image getFoto
        {
            get { return captura;}
        }

    }
}
