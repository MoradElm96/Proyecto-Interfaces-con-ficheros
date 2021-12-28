using Proyecto.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;
using System.Configuration;
using Newtonsoft.Json;


namespace Proyecto.Controladores
{
   public  class ControladorResultados
    {

        public static List<Resultados> recuperarResultados()
        {
            List<Resultados> listaResultados = new List<Resultados>();
          

            try
            {
                string archivoJsonn = File.ReadAllText(ConfigurationManager.AppSettings.Get("ficheroResultados")/*ruta*/);
                listaResultados = JsonConvert.DeserializeObject<List<Resultados>>(archivoJsonn);
            }
            catch (Exception) { }

            return listaResultados;
        }

     
        public static bool guardarResultados(List<Resultados> lista)
        {
            try
            {
                string archivoJsonn = JsonConvert.SerializeObject(lista);
                File.WriteAllText(ConfigurationManager.AppSettings.Get("ficheroResultados"), archivoJsonn);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        public static bool addResultado(string nombreCompletoPeleador,string nombreCompletoContrincante, string categoria, string resultado, int ronda, string metodo)
        {
            List<Resultados> lista = recuperarResultados();

           /* string idResultado = "0";
            if (lista.Count > 0)
            {
                lista.Sort((a, b) =>
                {
                    return Convert.ToInt32(b.IdResultado) - Convert.ToInt32(a.IdResultado);
                });
                idResultado = "" + (Convert.ToInt32(lista.First().IdResultado) + 1);
            }*/
            Resultados resultadoss = new Resultados(nombreCompletoPeleador,nombreCompletoContrincante, categoria, resultado, ronda, metodo);
            lista.Add(resultadoss);
            return guardarResultados(lista);
        }


    }
}
