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

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
namespace Taller3
{
    public partial class Form1 : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        private modelo.Ubicacion ubicacion;
        string municipioActual;

        public Form1()
        {
            InitializeComponent();
        }


        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Database files (*.mdb, *.accdb, *.csv)|*.mdb;*.accdb;*.csv";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                txtB_Direccion.Text += selectedFileName;
                //...
            }
        }

        private void Btn_Abrir_Click(object sender, EventArgs e)
        {
            string rutaCompleta = txtB_Direccion.Text;

            string line = "";
            using (StreamReader file = new StreamReader(rutaCompleta))
            {
                string[] gru;

                int a = 150;

                int b = 5;

                string[][] puntos = new String[110][];

                int contador = 0;

                while ((line = file.ReadLine()) != null)                //Leer linea por linea
                {
                    if (contador == 0)
                    {
                        line = file.ReadLine();
                    }
                    gru = line.Split(',');
                

                    for (int i = 0; i < gru.Length; i++)
                    {

                        if (i == 0)
                        {
                            puntos[contador] = new string[gru.Length];
                        }
                        puntos[contador][i] = gru[i];


                    }
                    contador++;


                }

                ubicacion = new modelo.Ubicacion();

                ubicacion.reconocimientoZonas(contador, puntos);

                siguienteEtapa();
                llenarOpciones();


            }
        }

        public void llenarOpciones()
        {
            Array arregloAuxiliar = ubicacion.clasificacionInformacion();
            for (int i = 0; i < arregloAuxiliar.Length; i++)
            {
                Label lblAux = new Label();

                listaEleccion.Items.Add(arregloAuxiliar.GetValue(i));
            }

        }
        public void siguienteEtapa() 
        {
            //primerPanel.Hide();
            primerPanel.Enabled = true;
            gMap.Visible = true;
            gMap.Enabled = true;
            listaEleccion.Visible = true;
            listaEleccion.Enabled = true;
            btn_Seleccionar.Visible = true;
            lbl_ptosWifi.Visible = true;
            listaSeleccion.Visible = true;
            listaSeleccion.Enabled = true;
            btn_Ubicar.Visible = true;
            btn_Ubicar.Enabled = true;
            lbl_municipios.Visible = true;
            lbl_municipios.Enabled = true;
        }
        private void PrimerPanel_Paint(object sender, PaintEventArgs e)
        {


        }

        private void ListaEleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Seleccionar.Enabled = true;
        }

        private void Btn_Seleccionar_Click(object sender, EventArgs e)
        {
            gMap.Zoom = 9;
            String auxCadena = listaEleccion.SelectedItem.ToString();
            listaSeleccion.Items.Clear();
            municipioActual = auxCadena;
            if (markerOverlay != null)
            {
                markerOverlay.Markers.Clear();
            }

            List<modelo.Zona> listaAuxiliar = ubicacion.entregaDeInformacion(auxCadena);
            for (int i = 0; i < listaAuxiliar.Count; i++)
            {
                String auxCad = listaAuxiliar.ElementAt(i).getPuntoUbicacion();
                listaSeleccion.Items.Add(auxCad);
            }


        }

        private void GMap_Load(object sender, EventArgs e)
        {
            gMap.DragButton = MouseButtons.Left;
            gMap.CanDragMap = true;
            gMap.MapProvider = GMapProviders.GoogleMap;
            gMap.Position = new PointLatLng(3.3423, -76.5293);
            gMap.MinZoom = 0;
            gMap.MaxZoom = 24;
            gMap.Zoom = 9;
            markerOverlay = new GMapOverlay("Marcador");

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ubicar_Click(object sender, EventArgs e)
        {

            List<modelo.Zona> listaAuxiliar = ubicacion.entregaDeInformacion(municipioActual);

            markerOverlay.Markers.Clear();
            modelo.Zona zonaAux = listaAuxiliar.ElementAt(listaSeleccion.SelectedIndex);
            marker = new GMarkerGoogle(new PointLatLng(zonaAux.getCoordenada1(), zonaAux.getCoordenada2()), GMarkerGoogleType.red);
            gMap.Position = new PointLatLng(zonaAux.getCoordenada1(), zonaAux.getCoordenada2());
            gMap.Zoom = 16;
            markerOverlay.Markers.Add(marker);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format("Municipio: {0}\nPunto de Ubicacion: {1}\nDireccion: {2}\nLatitud: {3}\nLongitud: {4}", zonaAux.getMunicipio(), zonaAux.getPuntoUbicacion(), zonaAux.getDireccion(), zonaAux.getCoordenada1(), zonaAux.getCoordenada2());
            gMap.Overlays.Add(markerOverlay);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            int parques = 0;
            int museos = 0;
            int corregimiento = 0;
            int vereda = 0;
            int coliseo = 0;
            int barrios = 0;
            

            string rutaCompleta = txtB_Direccion.Text;

            string line = "";
            using (StreamReader file = new StreamReader(rutaCompleta))
            {
                string[] gru;

                int a = 150;

                int b = 5;

                string[][] puntos = new String[150][];
               

                int contador = 0;

                while ((line = file.ReadLine()) != null)                //Leer linea por linea
                {
                    if (contador == 0)
                    {
                        line = file.ReadLine();
                    }
                    gru = line.Split(',');
                    int total = parques + museos + corregimiento + coliseo + vereda + barrios;
                    chart1.Series["Series1"].LegendText = "Cantidad" + "\n" + "zonas" + "\n" + "wifi" + "\n" +
                        "\n"+ "\n" + "Parques: " + parques + "\n" + "Museos: " + museos + "\n" + "corregimientos: " + corregimiento + "\n" + "Coliseo: " + coliseo+ "\n" + "Veredas: " + vereda + "\n" + "Barrios: " + barrios+"\n"+"Total: " + total;


                    for (int i = 0; i < gru.Length; i++)
                    {

                        if (i == 0)
                        {
                            puntos[contador] = new string[gru.Length];
                        
                        puntos[contador][i] = gru[i];

                        if (gru[1].Contains("Parque")&& (!gru[1].Contains("corregimiento")|| !gru[1].Contains("Corregimiento")))
                        {
                            parques++;
                        }
                        else if (gru[1].Contains("Museo")|| gru[1].Contains("museo"))
                        {
                            museos++;
                        }
                        else if (gru[1].Contains("Corregimiento")|| gru[1].Contains("corregimiento"))
                        {
                            corregimiento++;
                        }
                        else if (gru[1].Contains("Vereda")|| gru[1].Contains("vereda"))
                        {
                            vereda++;
                        }else if(gru[1].Contains("Coliseo")|| gru[1].Contains("coliseo"))
                            {
                                coliseo++;
                            }
                        else
                        {
                            barrios++;
                        }
                        }


                    }
                    contador++;


                }
                dic.Add("Parques", parques);
                dic.Add("Museos",museos);
                dic.Add("Corregimientos", corregimiento);
                dic.Add("Veredas", vereda);
                dic.Add("Coliseos", coliseo);
                dic.Add("Barrios", barrios);
                

                foreach (KeyValuePair<string, int> d in dic)
                {
                    chart1.Series["Series1"].Points.AddXY(d.Key, d.Value);
                    
                }
            }
        }   
    }
}