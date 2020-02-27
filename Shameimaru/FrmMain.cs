using System;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Shameimaru
{
    public partial class FrmMain : Form
    {
        private Timer timer = new Timer();

        public FrmMain()
        {
            InitializeComponent();

            // initialize ui component values
            var primScreen = Screen.PrimaryScreen;
            left.Value = primScreen.Bounds.Left;
            top.Value = primScreen.Bounds.Top;
            right.Value = primScreen.Bounds.Right;
            bottom.Value = primScreen.Bounds.Bottom;

            saveDirPath.Text = Path.GetDirectoryName(Application.ExecutablePath);

            // timer tick event
            timer.Tick += CaptureNow;
        }

        private void BtnSelectDir_Click(object sender, EventArgs e)
        {
            using (var dlg = new FolderBrowserDialog())
            {
                dlg.Description = "캡쳐파일 저장 폴더 선택:";
                dlg.SelectedPath = saveDirPath.Text;

                if( dlg.ShowDialog() == DialogResult.OK )
                {
                    saveDirPath.Text = dlg.SelectedPath;
                }
            }
        }

        private void BtnStartTimer_Click(object sender, EventArgs e)
        {
            Control[] uiControls = new Control[] {
                saveDirPath, btnSelectDir,
                btnCaptureNow, rbFullScreen, rbSelectedArea,
                left, right, top, bottom, seconds};

            if(timer.Enabled)
            {
                timer.Stop();
                Array.ForEach(uiControls, c => c.Enabled = true);
                btnStartTimer.Text = "시작";
            }
            else
            {
                timer.Interval = (int)seconds.Value * 1000;
                Array.ForEach(uiControls, c => c.Enabled = false);
                timer.Start();                
                btnStartTimer.Text = "중지";
            }
        }

        private void CaptureNow(object sender, EventArgs e)
        {
            CaptureAndSave();
        }

        private void CaptureAndSave()
        {
            var filename = string.Format("cap{0}.png", DateTime.Now.ToString("HHmmss"));
            var savePath = Path.Combine(saveDirPath.Text, filename);

            using (var bitmap = ScreenCapture.GetScreen())
            {
                if (rbSelectedArea.Checked)
                {
                    using (var clipped = ScreenCapture.Crop(bitmap,
                        (int)top.Value, (int)left.Value,
                        (int)bottom.Value, (int)right.Value))
                    {
                        clipped.Save(savePath, ImageFormat.Png);
                    }
                }
                else
                {
                    bitmap.Save(savePath, ImageFormat.Png);
                }
            }
        }
    }
}
