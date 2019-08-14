using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3.modelo
{
    class Ubicacion
    {

        int numZonas;
        modelo.Zona[] zonas;
        Dictionary<string, List<Zona>> diccionarioZonas = new Dictionary<string, List<Zona>>();


        public Ubicacion()
        {
           
        }

        public void reconocimientoZonas(int cont, String[][] totalZonas)
        {
           
            this.numZonas = cont;

            zonas = new Zona[numZonas];

            for (int i = 0; i < numZonas; i++)

            {

                zonas[i] = new modelo.Zona();


                zonas[i].organizeInformation(i, totalZonas);

                String auxiliar = zonas[i].getMunicipio();
                if (auxiliar.Length != 0)
                { 


                    if (diccionarioZonas.ContainsKey(auxiliar))
                    {
                        
                        List<Zona> listaAuxiliar = new List<Zona>();
                        diccionarioZonas.TryGetValue(auxiliar, out listaAuxiliar);
                        listaAuxiliar.Add(zonas[i]);
                        diccionarioZonas.Remove(auxiliar);
                        diccionarioZonas.Add(auxiliar, listaAuxiliar);

                    }
                    else
                    {
                        List<Zona> listaAuxiliar = new List<Zona>();
                        listaAuxiliar.Add(zonas[i]);
                        diccionarioZonas.Add(auxiliar, listaAuxiliar);
                    }
            }
            }
            
        }

        public Array clasificacionInformacion()
        {
           return diccionarioZonas.Keys.ToArray();
        }

        public List<Zona> entregaDeInformacion(String a)
        {
            List<Zona> listaAux = new List<Zona>();
            diccionarioZonas.TryGetValue(a, out listaAux);
            return listaAux;
        }

        internal void entregaDeInformacion(object selectedItem)
        {
            throw new NotImplementedException();
        }
    }

}
