using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gourmet_s_Choice.Image;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gourmet_s_Choice.Image.Tests
{
    [TestClass()]
    public class ImageHandlerTests
    {
        [TestMethod()]
        public void ResizeTest()
        {
            Bitmap bitmap = (Bitmap) Bitmap.FromFile("C:\\Users\\KCCI\\Desktop\\6.The.Avengers.jpg");

            Bitmap newBitmap = bitmap.Resize(600, 900, 1080, "C:\\Users\\KCCI\\Desktop\\6.The.Avengers2.jpg");

        }
    }
}