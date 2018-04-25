using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gourmet_s_Choice.Helper;
using ImageConverter = System.Drawing.ImageConverter;

namespace Gourmet_s_Choice.FoodUploadForm
{
    public partial class ImageUploader : Form
    {
        public ImageUploader()
        {
            InitializeComponent();
        }

        List<string> files = new List<string>();

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (fbdFolder.ShowDialog() != DialogResult.OK)
                return;

            //API로 "파일"을 가져오는 라이브러리가 제공된다
            files =
                Directory
                    .EnumerateFiles(fbdFolder.SelectedPath)
                    .Where(x => x.EndsWith(".png") || x.EndsWith(".jpg"))
                    .ToList(); //folder dialog 파일의 전체 경로를 stirng으로 반환

            //Form property
            Cursor = Cursors.WaitCursor;

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //            bgwWorker.RunWorkerAsync(files);

//            List<string> files = (List<string>)e.Argument;

            float insertedCount = 0;
            foreach (var file in files)
            {
                string fileName = Path.GetFileName(file);

                string strBlock = ".jpg";
                fileName = strBlock.Replace(fileName, "");

                //file read in Bitmap
                Bitmap image = new Bitmap(file);

                string thumbPath = $"C:\\Users\\KCCI\\Desktop\\foodImage\\thumbnail\\thumbnail_{fileName}.jpg";
                Bitmap thumnailImage = image.Resize(400, 300, 1080, thumbPath);

                //file convert into binary
                Byte[] imageBytes = File.ReadAllBytes(file);
                Byte[] thumbnailBytes = File.ReadAllBytes(thumbPath);

                //DB접근
                DataRepository.FoodImage.InsertWithImage(txtFoodName.Text,
                    imageBytes, thumbnailBytes);


                //progress bar update UI접근
                insertedCount += 1;
                //prbProgress.Value = (int)(insertedCount / files.Count * 100);
                //                bgwWorker.ReportProgress((int)(insertedCount / files.Count * 100));
            }
        }
    }
}
