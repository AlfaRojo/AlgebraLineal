using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PhotoCookie
{
    public partial class Form1 : Form
    {
        string rutaArchivo = string.Empty;
        int wI = 0;
        int hI = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private static readonly ImageConverter _imageConverter = new ImageConverter();
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog busquedaArchivo = new OpenFileDialog())
            {
                busquedaArchivo.InitialDirectory = "c:\\";
                busquedaArchivo.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                busquedaArchivo.FilterIndex = 2;
                busquedaArchivo.RestoreDirectory = true;
                if (busquedaArchivo.ShowDialog() == DialogResult.OK)
                {
                    PBOriginal.InitialImage = null;
                    PBFinal.InitialImage = null;
                    Picture.InitialImage = null;
                    rutaArchivo = busquedaArchivo.FileName;
                    byte[] imgdata = File.ReadAllBytes(rutaArchivo);
                    var Inicial = GetImageFromByteArray(imgdata);
                    wI = Inicial.Width;
                    hI = Inicial.Height;
                    PBOriginal.Image = Inicial;
                }
                else
                {
                    return;
                }
            }
        }
        /// <summary>
        /// Convierte la imagen a escala de grises
        /// </summary>
        /// <param name="bm"></param>
        /// <returns></returns>
        public static Bitmap MedianFiltering(Bitmap bm)
        {
            List<byte> termsList = new List<byte>();
            byte[,] image = new byte[bm.Width, bm.Height];
            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    var c = bm.GetPixel(i, j);
                    byte gray = (byte)(.333 * c.R + .333 * c.G + .333 * c.B);
                    image[i, j] = gray;
                }
            }
            for (int i = 0; i <= bm.Width - 3; i++)
                for (int j = 0; j <= bm.Height - 3; j++)
                {
                    for (int x = i; x <= i + 2; x++)
                        for (int y = j; y <= j + 2; y++)
                        {
                            termsList.Add(image[x, y]);
                        }
                    byte[] terms = termsList.ToArray();
                    termsList.Clear();
                    Array.Sort<byte>(terms);
                    Array.Reverse(terms);
                    byte color = terms[4];
                    bm.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                }
            return bm;
        }
        /// <summary>
        /// Obtiene Bitmap de la imagen
        /// </summary>
        /// <param name="arregloByte"></param>
        /// <returns></returns>
        public static Bitmap GetImageFromByteArray(byte[] arregloByte)
        {
            Bitmap bm = (Bitmap)_imageConverter.ConvertFrom(arregloByte);
            if (bm != null && (bm.HorizontalResolution != (int)bm.HorizontalResolution ||
                               bm.VerticalResolution != (int)bm.VerticalResolution))
            {
                bm.SetResolution((int)(bm.HorizontalResolution + 0.5f),
                                 (int)(bm.VerticalResolution + 0.5f));
            }
            return bm;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (PBOriginal.Image == null)
            {
                MessageBox.Show("No se ha cargado ninguna imagen.", "Algebra Lineal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Bitmap matrizBlancoNegro = new Bitmap(PBOriginal.Image);
            MedianFiltering(matrizBlancoNegro);
            double[,] ValuesDouble = new double[matrizBlancoNegro.Width, matrizBlancoNegro.Height];
            for (int i = 0; i < matrizBlancoNegro.Width - 1; i++)
            {
                for (int j = 0; j < matrizBlancoNegro.Height - 1; j++)
                {
                    ValuesDouble[i, j] = matrizBlancoNegro.GetPixel(i, j).R;
                }
            }
            var bmp = new Bitmap(matrizBlancoNegro);
            PBFinal.Image = matrizBlancoNegro;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double a11 = 0; double a12 = 0; double a13 = 0;
            double a21 = 0; double a22 = 0; double a23 = 0;
            double a31 = 0; double a32 = 0; double a33 = 0;
            if (PBOriginal.Image == null)
            {
                MessageBox.Show("No se ha cargado ninguna imagen.", "Algebra Lineal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            label1.Text = Tipos.Text;

            switch (Tipos.Text)//Establecer valores a Matriz a multiplicar
            {
                case "Difuminado":
                    a11 = 0.0625; a12 = 0.125; a13 = 0.0625;
                    a21 = 0.125; a22 = 0.25; a23 = 0.125;
                    a31 = 0.0625; a32 = 0.125; a33 = 0.0625;
                    break;
                case "Realzar":
                    a11 = -2; a12 = -1; a13 = 0;
                    a21 = -1; a22 = 1; a23 = 1;
                    a31 = 0; a32 = 1; a33 = 2;
                    break;
                case "Sobel Inferior":
                    a11 = -1; a12 = -2; a13 = -1;
                    a21 = 0; a22 = 0; a23 = 0;
                    a31 = 1; a32 = 2; a33 = 1;
                    break;
                case "Sobel Superior":
                    a11 = 1; a12 = 2; a13 = 1;
                    a21 = 0; a22 = 0; a23 = 0;
                    a31 = -1; a32 = -2; a33 = -1;
                    break;
                case "Sobel Izquierdo":
                    a11 = 1; a12 = 0; a13 = -1;
                    a21 = 2; a22 = 0; a23 = -2;
                    a31 = 1; a32 = 0; a33 = -1;
                    break;
                case "Sobel Derecho":
                    a11 = -1; a12 = 0; a13 = 1;
                    a21 = -2; a22 = 0; a23 = 2;
                    a31 = -1; a32 = 0; a33 = 1;
                    break;
                case "Contorno":
                    a11 = -1; a12 = -1; a13 = -1;
                    a21 = -1; a22 = 8; a23 = -1;
                    a31 = -1; a32 = -1; a33 = -1;
                    break;
                case "Afilar":
                    a11 = 0; a12 = -1; a13 = 0;
                    a21 = -1; a22 = 5; a23 = -1;
                    a31 = 0; a32 = -1; a33 = 0;
                    break;
                case "Original":
                    a11 = 0; a12 = 0; a13 = 0;
                    a21 = 0; a22 = 1; a23 = 0;
                    a31 = 0; a32 = 0; a33 = 0;
                    break;
                case "Personalizado":

                    a11 = Convert.ToDouble(textBox1.Text);
                    a11 = int.Parse(textBox1.Text);
                    a12 = Convert.ToDouble(textBox1.Text);
                    a12 = int.Parse(textBox2.Text);
                    a13 = Convert.ToDouble(textBox1.Text);
                    a13 = int.Parse(textBox3.Text);

                    a21 = Convert.ToDouble(textBox1.Text);
                    a21 = int.Parse(textBox4.Text);
                    a22 = Convert.ToDouble(textBox1.Text);
                    a22 = int.Parse(textBox5.Text);
                    a23 = Convert.ToDouble(textBox1.Text);
                    a23 = int.Parse(textBox6.Text);

                    a31 = Convert.ToDouble(textBox1.Text);
                    a31 = int.Parse(textBox7.Text);
                    a32 = Convert.ToDouble(textBox1.Text);
                    a32 = int.Parse(textBox8.Text);
                    a33 = Convert.ToDouble(textBox1.Text);
                    a33 = int.Parse(textBox9.Text);
                    break;
                case "":
                    MessageBox.Show("Porfavor seleccione una opción.");
                    break;
                default:
                    break;
            }

            byte[] imgdata = File.ReadAllBytes(rutaArchivo);
            PBOriginal.Image = GetImageFromByteArray(imgdata);
            Bitmap toBlackWhite = new Bitmap(PBFinal.Image);

            int Ancho = wI;
            int Alto = hI;
            var Filtro = new Bitmap(Ancho, Alto);
            int[,] M = new int[Ancho, Alto];
            int[,] R = new int[Ancho, Alto];
            for (int l = 0; l < Ancho; l++)
            {
                for (int p = 0; p < Alto; p++)
                {
                    M[l, p] = toBlackWhite.GetPixel(l, p).R;
                }
            }
            //Proceso de multiplicación
            for (int i = 0; i < Ancho; i++)
            {
                for (int j = 0; j < Alto; j++)
                {
                    if (i == 0)
                    {
                        if (j == 0 || j == Alto - 1 || ((j > 0) && (j < Alto - 1)))
                        {
                            R[i, j] = M[i, j];
                        }
                    }
                    if (i == Ancho - 1)
                    {
                        if (j == 0 || j == Alto - 1 || ((j > 0) && (j < Alto - 1)))
                        {
                            R[i, j] = M[i, j];
                        }
                    }
                    if (j == 0)
                    {
                        if ((i > 0) && (i < Ancho - 1))
                        {
                            R[i, j] = M[i, j];
                        }
                    }
                    if (j == Alto - 1)
                    {
                        if ((i > 0) && (i < Ancho - 1))
                        {
                            R[i, j] = M[i, j];
                        }
                    }
                    if ((i > 0) && (j > 0) && (i < Ancho - 1) && j < Alto - 1)
                    {
                        R[i, j] = (int)
                             (M[i - 1, j - 1] * a11
                            + M[i - 1, j] * a12
                            + M[i - 1, j + 1] * a13
                            + M[i, j - 1] * a21
                            + M[i, j] * a22
                            + M[i, j + 1] * a23
                            + M[i + 1, j - 1] * a31
                            + M[i + 1, j] * a32
                            + M[i + 1, j + 1] * a33
                            );
                    }
                    //Comprobar limites de los colores
                    if (R[i, j] > 255)
                    {
                        R[i, j] = 255;
                    }
                    if (R[i, j] < 0)
                    {
                        R[i, j] = 0;
                    }
                    int img = R[i, j];
                    var nuevo = Color.FromArgb(img, img, img);
                    Filtro.SetPixel(i, j, nuevo);
                }
            }
            Picture.Image = Filtro;
        }
        private void Tipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tipos.Text == "Personalizado")
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Porfavor ingrese números solamente.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }
    }
}
