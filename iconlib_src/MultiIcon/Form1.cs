using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.IconLib;
using System.Drawing.IconLib.ColorProcessing;

namespace MultiIconTester
{
    public partial class FormIconBrowser : Form
    {
        #region Variables Declaration
        private string      mFolder     = string.Empty;
        private MultiIcon   mMultiIcon  = new MultiIcon();
        #endregion

        #region Constructors
        public FormIconBrowser()
        {
            InitializeComponent();
            dlgSave.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
        }
        #endregion

        #region Events
        private void FormIconBrowser_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateFiles(Path.GetDirectoryName(Application.ExecutablePath));
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            dlgBrowse.SelectedPath = mFolder;
            dlgBrowse.ShowNewFolderButton = false;
            dlgBrowse.ShowDialog(this);

            if (dlgBrowse.SelectedPath == null || dlgBrowse.SelectedPath == string.Empty)
                return;

            PopulateFiles(dlgBrowse.SelectedPath);
        }

        private void lbxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbxFiles.SelectedIndex == -1)
                    return;

                lbxIcons.Items.Clear();
                lbxImages.Items.Clear();
                pbxXORImage.Image       = null;
                pbxANDImage.Image       = null;
                pbxIcon.Image           = null;
                lblWidthValue.Text      = null;
                lblHeightValue.Text     = null;
                lblColorDepthValue.Text = null;
                lblCompressionValue.Text= null;
                mMultiIcon.SelectedIndex= -1;
                mMultiIcon.Load(Path.Combine(mFolder, (string) lbxFiles.SelectedItem));

                foreach(SingleIcon singleIcon in mMultiIcon)
                    lbxIcons.Items.Add(singleIcon.Name);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbxIcons_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbxIcons.SelectedIndex == -1)
                    return;

                lbxImages.Items.Clear();
                pbxXORImage.Image       = null;
                pbxANDImage.Image       = null;
                pbxIcon.Image           = null;
                lblWidthValue.Text      = null;
                lblHeightValue.Text     = null;
                lblColorDepthValue.Text = null;
                lblCompressionValue.Text= null;
                mMultiIcon.SelectedIndex= lbxIcons.SelectedIndex;
                foreach(IconImage iconImage in mMultiIcon[lbxIcons.SelectedIndex])
                {
                    lbxImages.Items.Add(iconImage.Size.Width + "x" + iconImage.Size.Height + " " + GetFriendlyBitDepth(iconImage.PixelFormat));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lbxImages.SelectedIndex == -1)
                    return;

                IconImage iconImage     = mMultiIcon[lbxIcons.SelectedIndex][lbxImages.SelectedIndex];
                pbxXORImage.Image       = iconImage.Image;
                pbxANDImage.Image       = iconImage.Mask;
                pbxIcon.Image           = iconImage.Icon.ToBitmap();
                lblWidthValue.Text      = iconImage.Size.Width.ToString();
                lblHeightValue.Text     = iconImage.Size.Height.ToString();
                lblColorDepthValue.Text = iconImage.PixelFormat.ToString();
                lblCompressionValue.Text= iconImage.IconImageFormat.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            dlgSave.DefaultExt = "icl";
            dlgSave.Filter = "Windows Icon File (*.ico)|*.ico|Icon Library File (*.icl)|*.icl|DLL Library File " +
                "(*.dll)|*.dll|PNG Image File (*.png)|*.png|BMP Windows File (*.bmp)|*.bmp";
            if (dlgSave.ShowDialog(this) == DialogResult.OK)
            {
                if (dlgSave.FileName.ToLower().EndsWith(".ico") && mMultiIcon.SelectedIndex != -1)
                    mMultiIcon.Save(dlgSave.FileName, MultiIconFormat.ICO);
                else if (dlgSave.FileName.ToLower().EndsWith(".png") && mMultiIcon.SelectedIndex != -1 && lbxImages.SelectedIndex != -1)
                    mMultiIcon[mMultiIcon.SelectedIndex][lbxImages.SelectedIndex].Transparent.Save(dlgSave.FileName, ImageFormat.Png);
                else if (dlgSave.FileName.ToLower().EndsWith(".bmp") && mMultiIcon.SelectedIndex != -1 && lbxImages.SelectedIndex != -1)
                    mMultiIcon[mMultiIcon.SelectedIndex][lbxImages.SelectedIndex].Transparent.Save(dlgSave.FileName, ImageFormat.Bmp);
                else if (dlgSave.FileName.ToLower().EndsWith(".icl"))
                    mMultiIcon.Save(dlgSave.FileName, MultiIconFormat.ICL);
                else if (dlgSave.FileName.ToLower().EndsWith(".dll"))
                    mMultiIcon.Save(dlgSave.FileName, MultiIconFormat.DLL);
            }
        }

        private void btnExportAND_Click(object sender, EventArgs e)
        {
            dlgSave.DefaultExt = "bmp";
            dlgSave.Filter = "Windows Bitmap File (*.bmp)|*.bmp";
            if (mMultiIcon.SelectedIndex == -1 || lbxImages.SelectedIndex == -1)
                return;

            if (dlgSave.ShowDialog(this) == DialogResult.OK)
                mMultiIcon[mMultiIcon.SelectedIndex][lbxImages.SelectedIndex].Mask.Save(dlgSave.FileName, ImageFormat.Bmp);
        }

        private void btnExportBMP_Click(object sender, EventArgs e)
        {
            dlgSave.DefaultExt = "bmp";
            dlgSave.Filter = "Windows Bitmap File (*.bmp)|*.bmp";
            if (mMultiIcon.SelectedIndex == -1 || lbxImages.SelectedIndex == -1)
                return;

            if (dlgSave.ShowDialog(this) == DialogResult.OK)
                mMultiIcon[mMultiIcon.SelectedIndex][lbxImages.SelectedIndex].Image.Save(dlgSave.FileName, ImageFormat.Bmp);
        }
        #endregion

        #region Methods
        private void PopulateFiles(string folder)
        {
            List<string> validFiles = new List<string>();
            mFolder = folder;

//            string[] files = Directory.GetFiles(folder, "*.ico, *.icl, *.dll, *.exe, *.ocx, *.cpl, *.src");
            string[] files = Directory.GetFiles(folder);

            foreach(string file in files)
            {
                switch(Path.GetExtension(file).ToLower())
                {
                    case ".ico":
                    case ".icl":
                    case ".dll":
                    case ".exe":
                    case ".ocx":
                    case ".cpl":
                    case ".src":
                        validFiles.Add(Path.GetFileName(file));
                        break;
                }
            }
            lbxFiles.Items.Clear();
            lbxFiles.Items.AddRange(validFiles.ToArray());
        }

        private string GetFriendlyBitDepth(PixelFormat pixelFormat)
        {
            switch(pixelFormat)
            {
                case PixelFormat.Format1bppIndexed:
                    return "1-bit B/W";
                case PixelFormat.Format24bppRgb:
                    return "24-bit True Colors";
                case PixelFormat.Format32bppArgb:
                case PixelFormat.Format32bppRgb:
                    return "32-bit Alpha Channel";
                case PixelFormat.Format8bppIndexed:
                    return "8-bit 256 Colors";
                case PixelFormat.Format4bppIndexed:
                    return "4-bit 16 Colors";
            }
            return "Unknown";
        }
        #endregion

        #region Override
        protected override void OnClosing(CancelEventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog(this);
            base.OnClosing(e);
        }
        #endregion

        #region Test methods
        private void btnCreate_Click(object sender, EventArgs e)
        {
            MultiIcon multiIcon = new MultiIcon();
            multiIcon.Add("Icon 1").Load(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Icon1.ico"));
            multiIcon.Add("Icon 2").Load(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Icon2.ico"));
            multiIcon.Add("Icon 3").Load(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Icon3.ico"));
            multiIcon.Add("Icon 4").Load(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Icon4.ico"));
            multiIcon.Add("Icon 5").Load(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Icon5.ico"));
            multiIcon.Add("Icon 6").Load(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Icon6.ico"));
            multiIcon.Add("Icon 7").Load(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Icon7.ico"));
            multiIcon.Save(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),"library.icl"), MultiIconFormat.ICL);
        }
        #endregion

        #region Internal Testing
        private void button1_Click(object sender, EventArgs e)
        {
            //MultiIcon mIcon = new MultiIcon();
            //SingleIcon sIcon = mIcon.Add("Icon1");
            //sIcon.CreateFrom("c:\\Pampero.png", IconOutputFormat.FromWin95);
            //sIcon.CreateFrom("C:\\z3.png", IconOutputFormat.FromWin31);
            //sIcon[0].Transparent.Save("c:\\zzzz1.png", ImageFormat.Png);
            //sIcon[1].Transparent.Save("c:\\zzzz2.png", ImageFormat.Png);
            //sIcon[2].Transparent.Save("c:\\zzzz3.png", ImageFormat.Png);
            //sIcon[3].Transparent.Save("c:\\zzzz4.png", ImageFormat.Png);
            //sIcon[4].Transparent.Save("c:\\zzzz5.png", ImageFormat.Png);

            //sIcon.Save("c:\\zzzz1.ico");
            //Bitmap bmp1 = (Bitmap) Bitmap.FromFile("C:\\test3.png");
            //bmp1.Save("c:\\test31.png", ImageFormat.Png);
            //Bitmap bmp2 = new Bitmap(bmp1, 128, 138);
            //bmp2.Save("c:\\test32.png", ImageFormat.Png);

            //IColorQuantizer colorReduction = new EuclideanQuantizer(new OctreeQuantizer(), new FloydSteinbergDithering());
            ////Bitmap bmp = (Bitmap) pbxIcon.Image;
            //Bitmap bmp = (Bitmap) Bitmap.FromFile("c:\\MyKids.png");
            ////DateTime dt1 = DateTime.Now;
            //Bitmap newBmp = colorReduction.Convert(bmp, PixelFormat.Format8bppIndexed);
            //newBmp.Save("c:\\MyKids8.png", ImageFormat.Png);

            //newBmp = colorReduction.Convert(bmp, PixelFormat.Format4bppIndexed);
            //newBmp.Save("c:\\MyKids4.png", ImageFormat.Png);

            //newBmp = colorReduction.Convert(bmp, PixelFormat.Format1bppIndexed);
            //newBmp.Save("c:\\MyKids1.png", ImageFormat.Png);

            ////newBmp = fs.Convert(bmp);
            ////newBmp = fs.Convert(bmp);
            //DateTime dt2 = DateTime.Now;
            //Console.WriteLine("Convert:" + ((TimeSpan) dt2.Subtract(dt1)).TotalMilliseconds);
            //pbxIcon.Image = newBmp;
            //newBmp.Save("c:\\zzz.bmp", ImageFormat.Bmp);
        }
        #endregion
    }
}