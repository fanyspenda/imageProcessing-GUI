using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace imgProc1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void BukaFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog bukaFile = new OpenFileDialog();
            bukaFile.Filter = "Image File (*.bmp, *.jpg, *.jpeg)|*.bmp; *.jpg; *.jpeg";
            if (bukaFile.ShowDialog() == DialogResult.OK)
            {
                pbInput.Image = new Bitmap(bukaFile.FileName);
                statusDir.Text = Path.GetDirectoryName(bukaFile.FileName)+"|" ;
                statusSize.Text = pbInput.Image.Width+" x "+ pbInput.Image.Height;
            }
        }

        private void SimpanSebagaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbOutput.Image == null)
            {
                MessageBox.Show("Tidak ada gambar yang disimpan");
            }
            else
            {
                SaveFileDialog simpanFile = new SaveFileDialog();
                simpanFile.Title = "Simpan Gambar";
                simpanFile.Filter = "Image File (*.bmp, *.jpg, *.jpeg)|*.bmp; *.jpg; *.jpeg";
                if (simpanFile.ShowDialog() == DialogResult.OK)
                {
                    pbOutput.Image.Save(simpanFile.FileName);
                }
            }
        }

        private void KeluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.pbInput.Image);
            FrmBrightness fb = new FrmBrightness();
            OlahCitra.keBrightness(copy, fb.getBrightness());
            this.pbOutput.Image = copy;
        }

        private void VersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTentang aboutWindow = new FormTentang();
            aboutWindow.ShowDialog();
        }

        private void BrightnessContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Citra belum ada!");
            }
            else
            {
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                FrmBrightness fb = new FrmBrightness();
                fb.ShowDialog();

                // FYI: koding dibawah dijalankan setelah form Brightness ditutup.
                int nilaiBrightness = Convert.ToInt32(fb.tbBrightness.Text);
                int nilaiContrast = Convert.ToInt32(fb.tbContrast.Text);
                b = OlahCitra.keBrightness(b, nilaiBrightness);
                pbOutput.Image = OlahCitra.keContrast(b, nilaiContrast);
            }
        }

        private void PbInput_Click(object sender, EventArgs e)
        {

        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void InversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap((Bitmap)pbInput.Image);
            pbOutput.Image = OlahCitra.keInvers(b);
        }

        private void LogBrightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogBrightness flb = new FrmLogBrightness();
            flb.ShowDialog();

            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            int nilaiBrightness = Convert.ToInt32(flb.hScrlBrightness.Value.ToString());
            b = OlahCitra.keLogBrightness(b, nilaiBrightness, progressBar1);
            pbOutput.Image = b;
        }

        private void GammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGamma fg = new FrmGamma();
            fg.ShowDialog();

            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            int nilaiGamma = Convert.ToInt32(fg.hScrlGamma.Value.ToString());
            b = OlahCitra.keGammaCorrection(b, nilaiGamma, progressBar1);
            pbOutput.Image = b;
        }

        private void LightnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            b = OlahCitra.grayscaleLightness(b, progressBar1);
            pbOutput.Image = b;
        }

        private void AverageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            b = OlahCitra.grayscaleAverage(b, progressBar1);
            pbOutput.Image = b;
        }

        private void LuminousityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            b = OlahCitra.grayscaleLuminance(b, progressBar1);
            pbOutput.Image = b;
        }

        private void BitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            b = OlahCitra.imageDepth(b, 1, progressBar1);
            pbOutput.Image = b;
        }

        private void BitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            b = OlahCitra.imageDepth(b, 2, progressBar1);
            pbOutput.Image = b;
        }

        private void BitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            b = OlahCitra.imageDepth(b, 3, progressBar1);
            pbOutput.Image = b;
        }

        private void BitToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            b = OlahCitra.imageDepth(b, 4, progressBar1);
            pbOutput.Image = b;
        }

        private void BitToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            b = OlahCitra.imageDepth(b, 5, progressBar1);
            pbOutput.Image = b;
        }

        private void BitToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            b = OlahCitra.imageDepth(b, 6, progressBar1);
            pbOutput.Image = b;
        }

        private void BitToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            b = OlahCitra.imageDepth(b, 7, progressBar1);
            pbOutput.Image = b;
        }

        private void averageDenoisingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
            List<Image> pictureList = new List<Image>();
            foreach (string item in Directory.GetFiles(folderDlg.SelectedPath, "*.jpg", SearchOption.AllDirectories))
            {
                Image _image = Image.FromFile(item);
                pictureList.Add(_image);
            }

            pbInput.Image = pictureList[0];
            pbOutput.Image = OlahCitra.noiseReducer(pictureList, progressBar1);
            
        }

        private void nearest8ColorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int [] baru;
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            this.pbOutput.Image = b;
            progressBar1.Visible = true;
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    baru = OlahCitra.warnaTerdekat(c1.R, c1.G, c1.B);
                    b.SetPixel(i, j, Color.FromArgb(baru[0], baru[1], baru[2]));
                }
                progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
            }
            progressBar1.Visible = false;
            this.pbOutput.Image = b;
        }

        private void floydSteinbergToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] palletteColor = new int[,] {
                { 0, 0, 0 }, { 255,0,0,}, {0, 255, 0}, { 0, 0, 255 },
                {255,255,0}, {0, 255, 255}, {255, 0, 255}, {255,255,255}
            };

            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            int merah, hijau, biru;
            int errorR, errorG, errorB;
            int[] warnaTerdekat;
            int[] errorColor = new int[3];
            progressBar1.Visible = true;
            for (int i = 1; i <= b.Width - 2; i++)
            {
                for (int j = 0; j <= b.Height - 2; j++)
                {
                    merah = b.GetPixel(i, j).R;
                    hijau = b.GetPixel(i, j).G;
                    biru = b.GetPixel(i, j).B;
                    warnaTerdekat = OlahCitra.warnaTerdekat(merah, hijau, biru);
                    errorR = merah - warnaTerdekat[0];
                    errorG = hijau - warnaTerdekat[1];
                    errorB = biru - warnaTerdekat[2];
                    errorColor[0] = OlahCitra.truncate(errorR);
                    errorColor[1] = OlahCitra.truncate(errorG);
                    errorColor[2] = OlahCitra.truncate(errorB);

                    //hitung pixel koordinat i+1, j
                    merah = OlahCitra.truncate(Convert.ToInt32(b.GetPixel(i + 1, j).R + (7.0 / 16.0) * errorColor[0]));
                    hijau = OlahCitra.truncate(Convert.ToInt32(b.GetPixel(i + 1, j).G + (7.0 / 16.0) * errorColor[1]));
                    biru = OlahCitra.truncate(Convert.ToInt32(b.GetPixel(i + 1, j).B + (7.0 / 16.0) * errorColor[2]));
                    b.SetPixel(i + 1, j, Color.FromArgb(merah, hijau, biru));

                    //hitung pixel koordinat i-1, j+1
                    merah = OlahCitra.truncate(Convert.ToInt32(b.GetPixel(i - 1, j+1).R + (3.0 / 16.0) * errorColor[0]));
                    hijau = OlahCitra.truncate(Convert.ToInt32(b.GetPixel(i -1, j+1).G + (3.0 / 16.0) * errorColor[1]));
                    biru = OlahCitra.truncate(Convert.ToInt32(b.GetPixel(i - 1, j+1).B + (3.0 / 16.0) * errorColor[2]));
                    b.SetPixel(i - 1, j+1, Color.FromArgb(merah, hijau, biru));

                    //hitung pixel koordinat i, j+1
                    merah = OlahCitra.truncate(Convert.ToInt32(b.GetPixel(i, j + 1).R + (5.0 / 16.0) * errorColor[0]));
                    hijau = OlahCitra.truncate(Convert.ToInt32(b.GetPixel(i, j + 1).G + (5.0 / 16.0) * errorColor[1]));
                    biru = OlahCitra.truncate(Convert.ToInt32(b.GetPixel(i, j + 1).B + (5.0 / 16.0) * errorColor[2]));
                    b.SetPixel(i, j+1, Color.FromArgb(merah, hijau, biru));

                    //hitung pixel koordinat i+1, j+1
                    merah = OlahCitra.truncate(Convert.ToInt32(b.GetPixel(i+1, j + 1).R + (1.0 / 16.0) * errorColor[0]));
                    hijau = OlahCitra.truncate(Convert.ToInt32(b.GetPixel(i+1, j + 1).G + (1.0 / 16.0) * errorColor[1]));
                    biru = OlahCitra.truncate(Convert.ToInt32(b.GetPixel(i+1, j + 1).B + (1.0 / 16.0) * errorColor[2]));
                    b.SetPixel(i + 1, j+1, Color.FromArgb(merah, hijau, biru));
                }
                progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
            }
            pbOutput.Image = b;
            progressBar1.Visible = false;
        }

        private void inputToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
                MessageBox.Show("Tidak ada citra yang akan diolah");
            else
            {
                Dictionary<int, double> HistoR = new Dictionary<int, double>();
                Dictionary<int, double> HistoG = new Dictionary<int, double>();
                Dictionary<int, double> HistoB = new Dictionary<int, double>();

                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
                GSHistogram frm7 = new GSHistogram();
                CHistogram frm8 = new CHistogram();

                for (int h = 0; h <= 255; h++)
                {
                    HistoR.Add(h, 0);
                    HistoG.Add(h, 0);
                    HistoB.Add(h, 0);
                }
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j); //jika pada baris i kolom j, pixel bernilai n, maka nilai n pada dictionary ditambah 1

                        for (int k = 0; k <= 255; k++)
                        {
                            if (c1.G == k)
                            {
                                HistoG[k] = HistoG[k] + 1;
                            }
                            if (c1.R == k)
                            {
                                HistoR[k] = HistoR[k] + 1;
                            }
                            if (c1.B == k)
                            {
                                HistoB[k] = HistoB[k] + 1;
                            }
                        }
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                frm7.chartGSHistogram.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                frm7.chartGSHistogram.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                frm8.chartR.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                frm8.chartR.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
                frm8.chartG.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                frm8.chartG.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
                frm8.chartB.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                frm8.chartB.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                if (HistoR.Count == HistoG.Count && !HistoR.Except(HistoG).Any())
                {
                    frm7.chartGSHistogram.Series["Series1"].Color = Color.Gray;
                    frm7.chartGSHistogram.Series[0].Points.DataBindXY(HistoR.Keys, HistoR.Values);
                    frm7.ShowDialog();
                }
                else
                {
                    frm8.chartR.Series["Series1"].Color = Color.Red;
                    frm8.chartG.Series["Series1"].Color = Color.Green;
                    frm8.chartB.Series["Series1"].Color = Color.Blue;

                    frm8.chartR.Series[0].Points.DataBindXY(HistoR.Keys, HistoR.Values);
                    frm8.chartG.Series[0].Points.DataBindXY(HistoG.Keys, HistoG.Values);
                    frm8.chartB.Series[0].Points.DataBindXY(HistoB.Keys, HistoB.Values);
                    frm8.ShowDialog();
                }
            }
        }

        private void outputToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pbOutput.Image == null)
                MessageBox.Show("Tidak ada citra yang akan diolah");
            else
            {
                Dictionary<int, double> HistoR = new Dictionary<int, double>();
                Dictionary<int, double> HistoG = new Dictionary<int, double>();
                Dictionary<int, double> HistoB = new Dictionary<int, double>();

                Bitmap b = new Bitmap((Bitmap)this.pbOutput.Image);
                GSHistogram frm7 = new GSHistogram();
                CHistogram frm8 = new CHistogram();

                for (int h = 0; h <= 255; h++)
                {
                    HistoR.Add(h, 0);
                    HistoG.Add(h, 0);
                    HistoB.Add(h, 0);
                }
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color c1 = b.GetPixel(i, j); //jika pada baris i kolom j, pixel bernilai n, maka nilai n pada dictionary ditambah 1

                        for (int k = 0; k <= 255; k++)
                        {
                            if (c1.G == k)
                            {
                                HistoG[k] = HistoG[k] + 1;
                            }
                            if (c1.R == k)
                            {
                                HistoR[k] = HistoR[k] + 1;
                            }
                            if (c1.B == k)
                            {
                                HistoB[k] = HistoB[k] + 1;
                            }
                        }
                    }
                    progressBar1.Value = Convert.ToInt16(100 * (i + 1) / b.Width);
                }
                progressBar1.Visible = false;
                frm7.chartGSHistogram.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                frm7.chartGSHistogram.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                frm8.chartR.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                frm8.chartR.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
                frm8.chartG.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                frm8.chartG.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;
                frm8.chartB.ChartAreas["ChartArea1"].AxisX.LabelStyle.Enabled = false;
                frm8.chartB.ChartAreas["ChartArea1"].AxisY.LabelStyle.Enabled = false;

                if (HistoR.Count == HistoG.Count && !HistoR.Except(HistoG).Any())
                {
                    frm7.chartGSHistogram.Series["Series1"].Color = Color.Gray;
                    frm7.chartGSHistogram.Series[0].Points.DataBindXY(HistoR.Keys, HistoR.Values);
                    frm7.ShowDialog();
                }
                else
                {
                    frm8.chartR.Series["Series1"].Color = Color.Red;
                    frm8.chartG.Series["Series1"].Color = Color.Green;
                    frm8.chartB.Series["Series1"].Color = Color.Blue;

                    frm8.chartR.Series[0].Points.DataBindXY(HistoR.Keys, HistoR.Values);
                    frm8.chartG.Series[0].Points.DataBindXY(HistoG.Keys, HistoG.Values);
                    frm8.chartB.Series[0].Points.DataBindXY(HistoB.Keys, HistoB.Values);
                    frm8.ShowDialog();
                }
            }
        }

        private void equalizationHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbInput.Image == null)
            {
                MessageBox.Show("Error!! Empty Input Image");
            }
            else
            {
                Dictionary<byte, double> histoR = new Dictionary<byte, double>();
                Dictionary<byte, double> histoG = new Dictionary<byte, double>();
                Dictionary<byte, double> histoB = new Dictionary<byte, double>();
                Bitmap image1 = new Bitmap(pbInput.Image);
                pbOutput.Image = image1;
                int baris, kolom;
                CHistogram frm3 = new CHistogram(); //RGB
                GSHistogram frm2 = new GSHistogram(); //Grayscale
                byte c1, c2, c3;
                double[] s1 = new double[256];
                double[] s2 = new double[256];
                double[] s3 = new double[256];
                double jum = 0;
                //Proses inisiasi nilai awal histogram
                for (int counter = 0; counter <= 255; counter++)
                {
                    histoR[(Byte)counter] = 0.0;
                    histoG[(Byte)counter] = 0.0;
                    histoB[(Byte)counter] = 0.0;
                }
                // Proses mendapatkan nilai histogram
                for (baris = 0; baris < image1.Width; baris++)
                {
                    for (kolom = 0; kolom < image1.Height; kolom++)
                    {
                        c1 = image1.GetPixel(baris, kolom).R;
                        c2 = image1.GetPixel(baris, kolom).G;
                        c3 = image1.GetPixel(baris, kolom).B;
                        if (histoR.ContainsKey(c1))
                        {
                            histoR[c1] += 1;
                        }
                        if (histoG.ContainsKey(c2))
                        {
                            histoG[c2] += 1;
                        }
                        if (histoB.ContainsKey(c3))
                        {
                            histoB[c3] += 1; //kerja histogram
                        }
                    }
                }
                
                //Proses menghitung nilai transform function,
                List<byte> kunci1 = histoR.Keys.ToList();
                List<byte> kunci2 = histoG.Keys.ToList();
                List<byte> kunci3 = histoB.Keys.ToList();
                foreach (byte key in kunci1)
                {
                    histoR[key] = histoR[key] / (image1.Width * image1.Height);
                    jum += 255 * histoR[key];
                    s1[key] = jum;
                }
                jum = 0;

                foreach (byte key in kunci2)
                {
                    histoG[key] = histoG[key] / (image1.Width * image1.Height);
                    jum += 255 * histoG[key];
                    s2[key] = jum;
                }
                jum = 0;
                foreach (byte key in kunci3)
                {
                    histoB[key] = histoB[key] / (image1.Width * image1.Height);
                    jum += 255 * histoB[key];
                    s3[key] = jum;
                }
                progressBar1.Show();
                //Proses mengubah nilai pixel ke nilai baru sesuai transform function
                for (baris = 0; baris < image1.Width; baris++)
                {
                    for (kolom = 0; kolom < image1.Height; kolom++)
                    {
                        c1 = image1.GetPixel(baris, kolom).R;
                        c2 = image1.GetPixel(baris, kolom).G;
                        c3 = image1.GetPixel(baris, kolom).B;
                        int s = Convert.ToInt16(s1[c1]);
                        int ss = Convert.ToInt16(s2[c2]);
                        int sss = Convert.ToInt16(s3[c3]);
                        image1.SetPixel(baris, kolom, Color.FromArgb(s, ss, sss));
                    }
                    progressBar1.Value = Convert.ToInt32(Math.Floor((double)(100 * (baris + 1) /
                    image1.Width)));
                }
                progressBar1.Hide();
                pbOutput.Refresh();
            }
        }

        private void aveeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void average3x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] kernel = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            pbOutput.Image = OlahCitra.filter(kernel, b, 9, progressBar1, 1);
        }

        private void average5x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] kernel = { { 1, 1, 1, 1, 1}, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1 } };
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            pbOutput.Image = OlahCitra.filter(kernel, b, 25, progressBar1, 2);
        }

        private void lowPassFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] kernel = { { 1, 1, 1 }, { 1, 4, 1 }, { 1, 1, 1 } };
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            int divider = 12;
            int startFromCoordinate = 1;
            pbOutput.Image = OlahCitra.filter(kernel, b, divider, progressBar1, startFromCoordinate);
        }

        private void highPassFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] kernel = { { -1, 0, 1 }, { -1, 0, 3 }, { -3, 0, 1 } };
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            int divider = 1;
            int startFromCoordinate = 1;
            pbOutput.Image = OlahCitra.filter(kernel, b, divider, progressBar1, startFromCoordinate);
        }

        private void prewittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] kernel = { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            int divider = 1;
            int startFromCoordinate = 1;
            pbOutput.Image = OlahCitra.filter(kernel, b, divider, progressBar1, startFromCoordinate);
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] kernel = { { 0, -1, 0 }, { -1, 5, -1 }, { 0, -1, 0 } };
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            int divider = 1;
            int startFromCoordinate = 1;
            pbOutput.Image = OlahCitra.filter(kernel, b, divider, progressBar1, startFromCoordinate);
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] kernel = { { 1,2,1}, { 2,4,2}, { 1,2,1 } };
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            int divider = 16;
            int startFromCoordinate = 1;
            pbOutput.Image = OlahCitra.filter(kernel, b, divider, progressBar1, startFromCoordinate);
        }

        private void gaussianBlur5x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] kernel = { { 1,4,6,4,1 }, { 4,16,24,16,4 }, { 6,24,36,24,6}, { 4, 16, 24, 16, 4 }, { 1, 4, 6, 4, 1 } };
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            int divider = 256;
            int startFromCoordinate = 2;
            pbOutput.Image = OlahCitra.filter(kernel, b, divider, progressBar1, startFromCoordinate);
        }

        private void unsharpMasking5x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] kernel = { { 1, 4, 6, 4, 1 }, { 4, 16, 24, 16, 4 }, { 6, 24, -476, 24, 6 }, { 4, 16, 24, 16, 4 }, { 1, 4, 6, 4, 1 } };
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            int divider = -256;
            int startFromCoordinate = 2;
            pbOutput.Image = OlahCitra.filter(kernel, b, divider, progressBar1, startFromCoordinate);
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] kernelDilation = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 }};
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            pbOutput.Image = OlahCitra.dilation(kernelDilation, b, progressBar1);
        }

        private void erotionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] kernel = { {1, 1}, {1, 1}};
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            pbOutput.Image = OlahCitra.erotion(kernel, b, progressBar1);
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] kernelDilation = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1} };
            int[,] kernelErotion = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            pbOutput.Image = OlahCitra.closing(kernelDilation, kernelErotion, b, progressBar1);
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[,] kernelDilation = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            int[,] kernelErotion = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
                Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            pbOutput.Image = OlahCitra.opening(kernelDilation, kernelErotion, b, progressBar1);
        }

        private void dilationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[,] kernelDilation = { { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 } };
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            pbOutput.Image = OlahCitra.gsDilation(kernelDilation, b, progressBar1);
        }

        private void erotionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[,] kernel = { { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 } };
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            pbOutput.Image = OlahCitra.gsErotion(kernel, b, progressBar1);
        }

        private void openingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[,] kernel = { { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 }, { 1, 1, 1, 1, 1, 1 } };
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            b = OlahCitra.gsErotion(kernel, b, progressBar1);
            b = OlahCitra.gsErotion(kernel, b, progressBar1);
            b = OlahCitra.gsErotion(kernel, b, progressBar1);
            b = OlahCitra.gsDilation(kernel, b, progressBar1);
            b = OlahCitra.gsDilation(kernel, b, progressBar1);
            pbOutput.Image = OlahCitra.gsDilation(kernel, b, progressBar1);
        }

        private void closingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[,] kernel = { { 1, 1, 1, 1}, { 1, 1, 1, 1}, { 1, 1, 1, 1}, { 1, 1, 1, 1 }};
            Bitmap b = new Bitmap((Bitmap)this.pbInput.Image);
            b = OlahCitra.gsDilation(kernel, b, progressBar1);
            b = OlahCitra.gsDilation(kernel, b, progressBar1);
            b = OlahCitra.gsDilation(kernel, b, progressBar1);
            b = OlahCitra.gsErotion(kernel, b, progressBar1);
            b = OlahCitra.gsErotion(kernel, b, progressBar1);
            pbOutput.Image = OlahCitra.gsErotion(kernel, b, progressBar1);
        }
    }
}
