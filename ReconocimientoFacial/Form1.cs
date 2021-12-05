using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;

namespace ReconocimientoFacial
{
    public partial class Form1 : Form
    {
       private Capture videoCaptura = null;
       private Image<Bgr, byte> MarcoActual = null;
       Mat frame = new Mat();
       private bool deteccionRostros = false;
       CascadeClassifier rostroCascadeClasificador = new CascadeClassifier("haarcascade_frontalface_alt.xml");
       Image<Bgr, Byte> rostroResultado = null;
       List<Image<Gray, Byte>> rostrosEntrenados = new List<Image<Gray, byte>>();
       List<int>etiquetasPersonas = new List<int>();
       bool habilitarGuardadoImagenes = false;
       static bool  estaEntrenada = false;
       EigenFaceRecognizer reconocedora;
       List<string> nombresDePersonas = new List<string>();
       public string NombrePersonaActual = "";
        private Boolean ventanaAbierta = false;
        private bool Reconociendo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaptura_Click(object sender, EventArgs e)
        {
            if(videoCaptura != null) videoCaptura.Dispose();

            videoCaptura = new Capture();
            //videoCaptura.ImageGrabbed += ProcessFrame;
            Application.Idle += ProcessFrame;
            //videoCaptura.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if(videoCaptura != null && videoCaptura.Ptr != IntPtr.Zero)
            {
            // Captura de video
            videoCaptura.Retrieve(frame, 0);
            MarcoActual = frame.ToImage<Bgr, byte>().Resize(picCaptura.Width, picCaptura.Height, Inter.Cubic);

            // Detectar el rostro de la persona en el video
            if (deteccionRostros)
            {
                // Convertir de imagen a color a gris
                Mat imagenGris = new Mat(); 
                CvInvoke.CvtColor(MarcoActual, imagenGris, ColorConversion.Bgr2Gray);
                
                // Enhance the image to get better results
                CvInvoke.EqualizeHist(imagenGris, imagenGris);
                Rectangle[] rostros = rostroCascadeClasificador.DetectMultiScale(imagenGris, 1.1, 3, Size.Empty);
                // If faces detected
                if(rostros.Length > 0)
                {
                    int faceId = 0;
                    // Con esto estaremos dibujando un rectangulo en el area en donde se detecten los rostros de las personas
                    foreach(var rostro in rostros)
                    {
                        CvInvoke.Rectangle(MarcoActual, rostro, new Bgr(Color.Red).MCvScalar, 2);
                            
                        //  Registrar a una persona
                        // Asignar el rostro al picture box de captura de rostro
                        Image<Bgr, Byte> imagenResultante = MarcoActual.Convert<Bgr, Byte>();
                        imagenResultante.ROI = rostro;
                        picCapturada.SizeMode = PictureBoxSizeMode.StretchImage;
                        picCapturada.Image = imagenResultante.Bitmap;

                        if (habilitarGuardadoImagenes)
                        {
                            // Crearemos un nuevo directorio en caso de que el mismo no exista
                            string ruta = Directory.GetCurrentDirectory() + @"\Rostros Entrenados";
                            if (!Directory.Exists(ruta))
                                Directory.CreateDirectory(ruta);

                            // Guardaremos 10 imagenes con retraso de 1 segundo por cada imagen
                            // para evitar los hangs de la interfaz grafica realizaremos otra tarea
                            Task.Factory.StartNew(() =>
                            {
                                for (int i = 0; i < 10; i++)
                                {
                                    // Reajustar la imagen y guardarla
                                    imagenResultante.Resize(200, 200, Inter.Cubic).Save(ruta + @"\" + txtNombre.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                    Thread.Sleep(1000);
                                }
                            });
                        }
                        habilitarGuardadoImagenes = false;

                        if (btnRegistrar.InvokeRequired)
                        {
                            btnRegistrar.Invoke(new ThreadStart(delegate
                            {
                                btnRegistrar.Enabled = true;
                            }));
                        }

                        // Paso 5: Reconocer los rostros ya conocidos
                        if (estaEntrenada && Reconociendo)
                        {
                            Image<Gray, Byte> grayFaceResult = imagenResultante.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                            CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                            var resultado = reconocedora.Predict(grayFaceResult);

                            // En caso de que se encuentre un rostro que sea conocido
                            if(resultado.Label != -1 && resultado.Distance < 2000)
                            {
                                CvInvoke.PutText(MarcoActual, nombresDePersonas[resultado.Label], new Point(rostro.X - 2, rostro.Y - 2),
                                    FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                CvInvoke.Rectangle(MarcoActual, rostro, new Bgr(Color.Green).MCvScalar, 2);

                            // En caso de que se detecte un rostro que sea reconocido, se realizará una consulta por el nombre de la persona
                            // y se mostrará la información de la persona en un nuevo form. 
                            // La variable ventanaAbierta representa un booleano que verifica si el form a través del cual se está 
                            // haciendo la consulta no esta abierto. Si esta abierto quiere decir que ya la consulta se realizo
                            // y que se estan mostrando los datos de la persona. Con esta variable booleana nos aseguramos de que
                            // la aplicacion no abra infinitas ventanas, ya que si la ventana esta abierta, pues no tiene porque volver abrirse.
                                 if(ventanaAbierta == false)
                                    {
                                      Reconociendo = false;
                                      SqlDataReader leer= ConexionSQL.BuscarUsuario(nombresDePersonas[resultado.Label]);
                                      VerPersona verPersona = new VerPersona(leer, this);
                                      verPersona.ShowDialog();
                                      ventanaAbierta = true;
                                       videoCaptura = null;
                                    }
                            }
                            //En caso de que no haya encontrado rostros conocidos
                            else
                            {
                                CvInvoke.PutText(MarcoActual, "Desconocido", new Point(rostro.X - 2, rostro.Y - 2),
                                    FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                CvInvoke.Rectangle(MarcoActual, rostro, new Bgr(Color.Green).MCvScalar, 2);
                            }
                        }
                    }
                }
            }
                if(videoCaptura != null)
                {
                // Renderizar la video captura en el picture box que hemos creado
                picCaptura.Image = MarcoActual.Bitmap;
             }
                if(MarcoActual != null)
                    MarcoActual.Dispose();
                }
     }

        private void btnDetectar_Click(object sender, EventArgs e)
        {
            deteccionRostros = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //btnSave.Enabled = true;
            btnRegistrar.Enabled = false;
            habilitarGuardadoImagenes = true;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            Reconociendo = true;
            EntrenarImagenesDesdeDir();
        }

        // Paso 4: Entrenaniento de imagenes
        private bool EntrenarImagenesDesdeDir()
        {
            int imagesCount = 0;
            double threshold = 2000;
            rostrosEntrenados.Clear();
            etiquetasPersonas.Clear();
            nombresDePersonas.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\Rostros Entrenados";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories );

                foreach(var file in files)
                {
                    Image<Gray, Byte>rostroEntrenado = new Image<Gray, Byte>(file).Resize(200,200, Inter.Cubic);
                    CvInvoke.EqualizeHist(rostroEntrenado, rostroEntrenado);
                    rostrosEntrenados.Add(rostroEntrenado);
                    etiquetasPersonas.Add(imagesCount);
                    string nomnbre = file.Split('\\').Last().Split('_')[0];
                    nombresDePersonas.Add(nomnbre);
                    imagesCount++;
                }

                if(rostrosEntrenados.Count > 0)
                {
                    reconocedora = new EigenFaceRecognizer(imagesCount, threshold);
                    reconocedora.Train(rostrosEntrenados.ToArray(), etiquetasPersonas.ToArray());
                    estaEntrenada = true;
                    return true;
                }
                else
                {
                    estaEntrenada = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                estaEntrenada=false;
                MessageBox.Show($"Error al entrenar imagenes: {ex.Message}");
                return false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form formulario = new Agregar(this);
            formulario.ShowDialog();
        }

        public void CambiarNombre(string nombre)
        {
            txtNombre.Text = nombre;
            btnRegistrar.Enabled = true;
        }
    }
}