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
                    .ToList();//folder dialog 파일의 전체 경로를 stirng으로 반환

            //Form property
            //Cursor = Cursors.WaitCursor;

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            bgwWorker.RunWorkerAsync(files);
        }

        private void bgwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<string> files = (List<string>)e.Argument;

            float insertedCount = 0;
            foreach (var file in files)
            {
                //file read in binary
                //byte[] imageBytes = File.ReadAllBytes(file); //경로를 받아서 이진 파일(image, mp3등등 텍스트가 아닌 경우)로 읽는다 vs text 파일
                Image image = Image.FromFile(file);

                //DB접근
                //DataRepository.Card.InsertWithImage(cbbCategory.Text,
                //    imageBytes); //Card table과 CardImage table에 동시에 넣어야 한다


                //progress bar update UI접근
                insertedCount += 1;
                //prbProgress.Value = (int)(insertedCount / files.Count * 100);
                bgwWorker.ReportProgress((int)(insertedCount / files.Count * 100));
            }
        }

        private void bgwWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Image

        }

        private void bgwWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
