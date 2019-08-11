using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3.modelo
{
    class Zona
    {
        String municipio;
        String puntoUbicacion;
        String direccion;
        double coordenada1;
        double coordenada2;
        

        
        public String getMunicipio()
        {
            return this.municipio;
        }

        public String getPuntoUbicacion()
        {
            return this.puntoUbicacion;
        }

        public String getDireccion()
        {
            return this.direccion;
        }

        public double getCoordenada1()
        {
            return this.coordenada1;
        }

        public double getCoordenada2()
        {
            return this.coordenada2;
        }

        public void setMunicipio( String m )
        {
            this.municipio = m;
        }

        public void setPuntoUbicacion(String p)
        {
            this.puntoUbicacion = p;
        }

        public void setDireccion(String dir)
        {
            this.direccion = dir;
        }
        public void setCoordenada1(double c1)
        {
            this.coordenada1 = c1 ;
        }

        public void setCoordenada2(double c2)
        {
            this.coordenada2 = c2;
        }

        public void organizeInformation(int num, String[][] oI)
        {
            for(int i = 0; i<oI[num].Length; i++)
            {
                if (oI[num][i] != null && oI[num][i].Length > 2)
                {
                    if (i == 0)
                    {
                        string auxiliar = oI[num][i];
                        auxiliar = auxiliar.Replace("\"", "");
                        municipio = auxiliar;
                    }
                    if (i == 1)
                    {
                        string auxiliar = oI[num][i];
                        auxiliar = auxiliar.Replace("\"", "");
                        puntoUbicacion = auxiliar;
                    }
                    if (i == 2)
                    {
                        string auxiliar = oI[num][i];
                        auxiliar = auxiliar.Replace("\"", "");
                        direccion = auxiliar;
                    }
                    if (i == 3)
                    {

                        string auxiliar = oI[num][i];
                        auxiliar = auxiliar.Replace("\"", "");
                        StringBuilder sb = new StringBuilder(auxiliar);
                        sb.Remove(0, 1);
                        auxiliar = sb.ToString();
                        string auxiliar2 = auxiliar.Replace('.', ',');
                        coordenada1 = Double.Parse(auxiliar2); 
                    }
                    if (i == 4)
                    {
                        string auxiliar = oI[num][i];
                        auxiliar = auxiliar.Replace("\"", "");
                        auxiliar = auxiliar.Replace(")", "");
                        StringBuilder sb = new StringBuilder(auxiliar);
                        sb.Remove(auxiliar.Length - 1, 1);
                        string auxiliar2 = auxiliar.Replace('.', ',');
                        coordenada2 = Double.Parse(auxiliar2);
                    }
                }
            }
        }
    }
}
