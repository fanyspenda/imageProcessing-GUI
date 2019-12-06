using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace imgProc1
{
    class OlahCitra
    {
        public static Bitmap keBrightness(Bitmap b, int valueB)
        {
            for(int i = 0; i < b.Width; i++)
            {
                for(int j=0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R + valueB;
                    int g1 = c1.G + valueB;
                    int b1 = c1.B + valueB;
                    r1 = truncate(r1);
                    g1 = truncate(g1);
                    b1 = truncate(b1);
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            // kenapa harus mereturn true?
            return b;
        }

        public static Bitmap keContrast(Bitmap b, int valueC)
        {
            double F = (259 * (valueC + 255)) / (255 * (259 - valueC));
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {

                    Color c1 = b.GetPixel(i, j);
                    int r1 = (int) F * (c1.R - 128) + 128;
                    int g1 = (int)F * (c1.G - 128) + 128;
                    int b1 = (int)F * (c1.B - 128) + 128;
                    r1 = truncate(r1);
                    g1 = truncate(g1);
                    b1 = truncate(b1);
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return b;
        }

        public static int truncate(int x)
        {
            if (x > 255)
            {
                x = 255;
            }
            else if (x < 0)
            {
                x = 0;
            }

            return x;
        }

        public static Bitmap keInvers(Bitmap b)
        {
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {

                    Color c1 = b.GetPixel(i, j);
                    int r1 = 255 - c1.R;
                    int g1 = 255 - c1.G;
                    int b1 = 255 - c1.B;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            // kenapa harus mereturn true?
            return b;
        }

        public static Bitmap keLogBrightness(Bitmap b, int valueC, ProgressBar pb)
        {
            pb.Visible = true;
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = Convert.ToInt32(valueC * Math.Log(1+Math.Abs(c1.R)));
                    int g1 = Convert.ToInt32(valueC * Math.Log(1 + Math.Abs(c1.G)));
                    int b1 = Convert.ToInt32(valueC * Math.Log(1 + Math.Abs(c1.B)));
                    r1 = truncate(r1);
                    g1 = truncate(g1);
                    b1 = truncate(b1);
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
                pb.Value = Convert.ToInt32(100 * (i + 1) / b.Width);
            }
            pb.Visible = false;
            return b;
        }

        public static Bitmap keGammaCorrection(Bitmap b, int nilaiGamma, ProgressBar pb)
        {
            pb.Visible = true;
            Double nilaiGammaDouble = nilaiGamma * 0.01;
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = Convert.ToInt16(255 * Math.Pow(c1.R / 255.0, 1.0 / nilaiGammaDouble));
                    int g1 = Convert.ToInt16(255 * Math.Pow(c1.G / 255.0, 1.0 / nilaiGammaDouble));
                    int b1 = Convert.ToInt16(255 * Math.Pow(c1.B / 255.0, 1.0 / nilaiGammaDouble));
                    r1 = truncate(r1);
                    g1 = truncate(g1);
                    b1 = truncate(b1);
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
                pb.Value = Convert.ToInt32(100 * (i + 1) / b.Width);
            }
            pb.Visible = false;
            return b;
        }

        public static Bitmap grayscaleLightness (Bitmap b, ProgressBar pb)
        {
            pb.Visible = true;
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int max = Math.Max(r1, g1);
                    max = Math.Max(max, b1);
                    r1 = truncate(r1);
                    g1 = truncate(g1);
                    b1 = truncate(b1);
                    b.SetPixel(i, j, Color.FromArgb(max, max, max));
                }
                pb.Value = Convert.ToInt32(100 * (i + 1) / b.Width);
            }
            pb.Visible = false;
            return b;
        }

        public static Bitmap grayscaleAverage(Bitmap b, ProgressBar pb)
        {
            pb.Visible = true;
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int average = Convert.ToInt32((r1+g1+b1)/3);
                    r1 = truncate(r1);
                    g1 = truncate(g1);
                    b1 = truncate(b1);
                    b.SetPixel(i, j, Color.FromArgb(average, average, average));
                }
                pb.Value = Convert.ToInt32(100 * (i + 1) / b.Width);
            }
            pb.Visible = false;
            return b;
        }

        public static Bitmap grayscaleLuminance(Bitmap b, ProgressBar pb)
        {
            pb.Visible = true;
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int luminance = Convert.ToInt32(0.21 * r1 + 0.72 * g1 + 0.07 * b1);
                    r1 = truncate(r1);
                    g1 = truncate(g1);
                    b1 = truncate(b1);
                    b.SetPixel(i, j, Color.FromArgb(luminance, luminance, luminance));
                }
                pb.Value = Convert.ToInt32(100 * (i + 1) / b.Width);
            }
            pb.Visible = false;
            return b;
        }

        public static Bitmap imageDepth(Bitmap b, double bitDepth, ProgressBar pb)
        {
            pb.Visible = true;
            double level = 255.0 / Math.Pow(2, bitDepth-1);
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = Convert.ToInt32( Math.Round(c1.R / level) * level);

                    int g1 = Convert.ToInt32(Math.Round(c1.G / level) * level);

                    int b1 = Convert.ToInt32(Math.Round(c1.B / level) * level);

                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
                pb.Value = Convert.ToInt32(100 * (i + 1) / b.Width);
            }
            pb.Visible = false;
            return b;
        }

        public static Bitmap noiseReducer(List<Image> bList, ProgressBar pb)
        {
            Bitmap b = new Bitmap((Bitmap)bList[0]);
            Bitmap c = new Bitmap((Bitmap)bList[0]);
            pb.Visible = true;
            int R, G, B;
            //nilai 50 berikut menunjukkan jumlah citra, yang diproses adalah 50 citra
            int jumGambar = 100;
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    R = 0;
                    G = 0;
                    B = 0;
                    for (int k = 0; k < jumGambar - 1; k++)
                    {
                        b = (Bitmap)bList[k];
                        Color b1 = b.GetPixel(i, j);
                        R = (int)(b1.R + R) / 2;
                        G = (int)(b1.G + G) / 2;
                        B = (int)(b1.B + B) / 2;
                        R = truncate(R);
                        G = truncate(G);
                        B = truncate(B);
                    }
                    c.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
                pb.Value = Convert.ToInt16(100 * (i + 1) / c.Width);
            }
            pb.Visible = false;
            return c;
        }

        public static int[] warnaTerdekat(int pValueR, int pValueG, int pValueB)
        {
            double minDistance = 255*255+255*255+255*255;
            int palColor, rDiff, gDiff, bDiff;
            int [] pValueR1 = new int[3];
            double distance;
            //set warna pallete: hitam, merah, hijau, kuning, biru, cyan, magenta, putih
            int[,] palletteColor = new int[,] { 
                { 0, 0, 0 }, { 255,0,0,}, {0, 255, 0}, { 0, 0, 255 }, 
                {255,255,0}, {0, 255, 255}, {255, 0, 255}, {255,255,255} 
            };
            for (palColor = 0; palColor <= palletteColor.GetLength(0) - 1; palColor++)
            {
                rDiff = pValueR - palletteColor[palColor, 0];
                gDiff = pValueG - palletteColor[palColor, 1];
                bDiff = pValueB - palletteColor[palColor, 2];
                distance = rDiff*rDiff + gDiff*gDiff+bDiff*bDiff;
                if (distance<minDistance)
                {
                    minDistance = distance;
                    pValueR1[0] = palletteColor[palColor, 0];
                    pValueR1[1] = palletteColor[palColor, 1];
                    pValueR1[2] = palletteColor[palColor, 2];
                }
            }
            return pValueR1;
        }

        public static Bitmap filter(int [,] kernel, Bitmap b, int divider, ProgressBar pb, int start)
        {
            pb.Visible = true;

            for (int i = start; i < b.Width - start; i++)
            {
                for (int j = start; j < b.Height - start; j++)
                {
                    int red = 0;
                    int green = 0;
                    int blue = 0;

                    for (int kernelWidth = 0; kernelWidth < kernel.GetLength(1); kernelWidth++)
                    {
                        for (int kernelHeight = 0; kernelHeight < kernel.GetLength(0); kernelHeight++)
                        {
                            red += kernel[kernelWidth, kernelHeight] * b.GetPixel(i - start + kernelWidth, j - start + kernelHeight).R;
                            green += kernel[kernelWidth, kernelHeight] * b.GetPixel(i - start + kernelWidth, j - start + kernelHeight).G;
                            blue += kernel[kernelWidth, kernelHeight] * b.GetPixel(i - start + kernelWidth, j - start + kernelHeight).B;
                        }
                    }
                    b.SetPixel(i, j, Color.FromArgb(truncate(red/ divider), truncate(green / divider), truncate(blue / divider)));
                }
                pb.Value = Convert.ToInt32(100 * (i + 1) / b.Width);
            }
            pb.Visible = false;
            return b;
        }

        public static Bitmap dilation (int [,] kernel, Bitmap b, ProgressBar pb)
        {
            pb.Visible = true;
            Bitmap newB = new Bitmap(b);

            for (int i = 2; i < b.Width - 2; i++)
            {
                for (int j = 2; j < b.Height - 2; j++)
                {
                    if(b.GetPixel(i, j).R > 250) //jika pixel yang dipilih sekarang adalah putih, maka akan dilakukan dilasi
                    {
                        for (int kernelWidth = 0; kernelWidth < kernel.GetLength(0); kernelWidth++) //getLength(0) bermakna mengambil dimensi pertama (baris)
                        {
                            newB.SetPixel(i - kernelWidth, j, Color.FromArgb(255, 255, 255));
                            newB.SetPixel(i + kernelWidth, j, Color.FromArgb(255, 255, 255));

                            for (int kernelHeight = 0; kernelHeight < kernel.GetLength(1); kernelHeight++) //getLength(0) bermakna mengambil dimensi kedua (kolom)
                            {
                                newB.SetPixel(i - kernelWidth, j - kernelHeight, Color.FromArgb(255, 255, 255));
                                newB.SetPixel(i - kernelWidth, j + kernelHeight, Color.FromArgb(255, 255, 255));
                                newB.SetPixel(i + kernelWidth, j - kernelHeight, Color.FromArgb(255, 255, 255));
                                newB.SetPixel(i + kernelWidth, j + kernelHeight, Color.FromArgb(255, 255, 255));

                            }
                        }
                    }
                }

                pb.Value = Convert.ToInt32(100 * (i + 1) / b.Width);
            }
            pb.Visible = false;
            return newB;
        }

        public static Bitmap erotion(int[,] kernel, Bitmap b, ProgressBar pb)
        {
            pb.Visible = true;
            Bitmap newB = new Bitmap(b);
            for (int i = 2; i < b.Width - 2; i++)
            {
                for (int j = 2; j < b.Height - 2; j++)
                {
                    if (b.GetPixel(i, j).R < 5) //jika pixel yang dipilih sekarang adalah hitam, maka akan dilakukan erosi
                    {
                        for (int kernelWidth = 0; kernelWidth < kernel.GetLength(0); kernelWidth++) //getLength(0) bermakna mengambil dimensi pertama (baris)
                        {
                            newB.SetPixel(i - kernelWidth, j, Color.FromArgb(0,0,0));
                            newB.SetPixel(i + kernelWidth, j, Color.FromArgb(0, 0, 0));

                            for (int kernelHeight = 0; kernelHeight < kernel.GetLength(1); kernelHeight++) //getLength(0) bermakna mengambil dimensi kedua (kolom)
                            {
                                newB.SetPixel(i - kernelWidth, j - kernelHeight, Color.FromArgb(0, 0, 0));
                                newB.SetPixel(i - kernelWidth, j + kernelHeight, Color.FromArgb(0, 0, 0));
                                newB.SetPixel(i + kernelWidth, j - kernelHeight, Color.FromArgb(0, 0, 0));
                                newB.SetPixel(i + kernelWidth, j + kernelHeight, Color.FromArgb(0, 0, 0));
                            }
                        }
                    }
                }
                pb.Value = Convert.ToInt32(100 * (i + 1) / b.Width);
            }
            pb.Visible = false;
            return newB;
        }

        public static Bitmap closing(int [,] kernelDilation, int[,] kernelErotion, Bitmap b, ProgressBar pb)
        {
            for(int i=0; i < 3; i++)
                b = dilation(kernelDilation, b, pb);
            for (int i = 0; i < 4; i++)
                b = erotion(kernelErotion, b, pb);

            return b;
        }

        public static Bitmap opening(int[,] kernelDilation, int[,] kernelErotion, Bitmap b, ProgressBar pb)
        {
            for (int i = 0; i < 2; i++)
                b = erotion(kernelErotion, b, pb);
            for (int i = 0; i < 2; i++)
                b = dilation(kernelDilation, b, pb);

            return b;
        }

        public static Bitmap gsDilation(int[,] kernel, Bitmap b, ProgressBar pb)
{
            pb.Visible = true;
            Bitmap newB = new Bitmap(b);

            for (int i = 6; i < b.Width - 6; i++)
            {
                for (int j = 6; j < b.Height - 6; j++)
                {
                    for (int kernelWidth = 0; kernelWidth < kernel.GetLength(0); kernelWidth++) //getLength(0) bermakna mengambil dimensi pertama (baris)
                    {
                        if(b.GetPixel(i - kernelWidth, j).R > b.GetPixel(i, j).R) //jika lebih putih pixel yang ada disekitar daripada pixel terpilih, maka ubah warna menjadi sama dengan pixel yang dipilih
                        {
                            newB.SetPixel(i - kernelWidth, j, b.GetPixel(i, j));
                        }

                        if (b.GetPixel(i + kernelWidth, j).R > b.GetPixel(i, j).R)
                        {
                            newB.SetPixel(i + kernelWidth, j, b.GetPixel(i, j));
                        }

                        for (int kernelHeight = 0; kernelHeight < kernel.GetLength(1); kernelHeight++) //getLength(0) bermakna mengambil dimensi kedua (kolom)
                        {
                            if (b.GetPixel(i - kernelWidth, j - kernelHeight).R > b.GetPixel(i, j).R)
                            {
                                newB.SetPixel(i - kernelWidth, j - kernelHeight, b.GetPixel(i, j));
                            }

                            if (b.GetPixel(i - kernelWidth, j + kernelHeight).R > b.GetPixel(i, j).R)
                            {
                                newB.SetPixel(i - kernelWidth, j + kernelHeight, b.GetPixel(i, j));
                            }

                            if (b.GetPixel(i + kernelWidth, j - kernelHeight).R > b.GetPixel(i, j).R)
                            {
                                newB.SetPixel(i + kernelWidth, j - kernelHeight, b.GetPixel(i, j));
                            }

                            if (b.GetPixel(i + kernelWidth, j + kernelHeight).R > b.GetPixel(i, j).R)
                            {
                                newB.SetPixel(i + kernelWidth, j + kernelHeight, b.GetPixel(i, j));
                            }
                        }
                    }
                }
                
                pb.Value = Convert.ToInt32(100 * (i + 1) / b.Width);
            }
            
            pb.Visible = false;
            return newB;
        }

        public static Bitmap gsErotion(int[,] kernel, Bitmap b, ProgressBar pb)
        {
            pb.Visible = true;
            Bitmap newB = new Bitmap(b);
            for (int i = 6; i < b.Width - 6; i++)
            {
                for (int j = 6; j < b.Height - 6; j++)
                {
                    
                        for (int kernelWidth = 0; kernelWidth < kernel.GetLength(0); kernelWidth++) //getLength(0) bermakna mengambil dimensi pertama (baris)
                        {
                            if(b.GetPixel(i - kernelWidth, j).R < b.GetPixel(i, j).R)
                            {
                                newB.SetPixel(i - kernelWidth, j, b.GetPixel(i, j));
                            }

                            if (b.GetPixel(i + kernelWidth, j).R < b.GetPixel(i, j).R)
                            {
                                newB.SetPixel(i + kernelWidth, j, b.GetPixel(i, j));
                            }

                            for (int kernelHeight = 0; kernelHeight < kernel.GetLength(1); kernelHeight++) //getLength(0) bermakna mengambil dimensi kedua (kolom)
                            {
                                if (b.GetPixel(i - kernelWidth, j - kernelHeight).R < b.GetPixel(i, j).R)
                                {
                                    newB.SetPixel(i - kernelWidth, j - kernelHeight, b.GetPixel(i, j));
                                }

                                if (b.GetPixel(i - kernelWidth, j + kernelHeight).R < b.GetPixel(i, j).R)
                                {
                                    newB.SetPixel(i - kernelWidth, j + kernelHeight, b.GetPixel(i, j));
                                }

                                if (b.GetPixel(i + kernelWidth, j - kernelHeight).R < b.GetPixel(i, j).R)
                                {
                                    newB.SetPixel(i + kernelWidth, j - kernelHeight, b.GetPixel(i, j));
                                }

                                if (b.GetPixel(i + kernelWidth, j + kernelHeight).R < b.GetPixel(i, j).R)
                                {
                                    newB.SetPixel(i + kernelWidth, j + kernelHeight, b.GetPixel(i, j));
                                }
                            }
                        }
                    
                }
                pb.Value = Convert.ToInt32(100 * (i + 1) / b.Width);
            }
            pb.Visible = false;
            return newB;
        }
    }
}
