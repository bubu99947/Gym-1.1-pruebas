using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.IO;

namespace Gym_1_1_pruebas.Util
{
    class Imagen
    {
        int alto, ancho;
        Bitmap editable;
        Size tamano;
        Rectangle area;

        public Imagen(Size tamano) {
            this.tamano = tamano;

            area = new Rectangle((tamano.Width / 4), 0, (tamano.Width / 2), (tamano.Height - 1));
        }

        public Imagen()
        {
            
        }

        public Bitmap format(Bitmap foto) {
            
            return foto.Clone(area, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);

        }

        public Image toImage(byte[] byteImage)
        {
            MemoryStream ms = new MemoryStream(byteImage);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        public byte[] toByteArray(Bitmap foto) {
            MemoryStream ms = new MemoryStream();
            foto.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();

        }



    }
}
