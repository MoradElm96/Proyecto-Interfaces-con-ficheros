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
    public static class ControladorAtleta
    {
        
        //este metodo lee de un archivo json
    
        public static List<Atleta> recuperarAtletas() {
            List<Atleta> listaAtletas = new List<Atleta>();
          

            try
            {
                string archivoJson = File.ReadAllText(ConfigurationManager.AppSettings.Get("ficheroAtletas")/*ruta*/);
                listaAtletas = JsonConvert.DeserializeObject<List<Atleta>>(archivoJson);
            }
            catch (Exception) { }

            return listaAtletas;
        }
        //este otro guarda o escribe en un json
        
        public static bool guardarAtletas(List<Atleta> lista)
        {
            try
            {
                    string archivoJson = System.Text.Json.JsonSerializer.Serialize(lista);
                    File.WriteAllText(ConfigurationManager.AppSettings.Get("ficheroAtletas"), archivoJson);
            }
            catch (Exception e) {
                return false;
            }
            return true;
        }

        //elimina las propiedades de un objeto
        public static bool eliminarAtletas(string idAtleta)
        {
            List<Atleta> lista = recuperarAtletas();
            int posicion=lista.FindIndex(atleta => atleta.IdAtleta == idAtleta);
            if (posicion != -1)
            {
                    lista.RemoveAt(posicion);
                    return guardarAtletas(lista);
            } else
            {
                    return false;
            }
        }

        //añade un nuevo atleta
        public static bool addAtleta(string nombre, string apellido, string nacionalidad, string sexo, string edad, string peso, string salario, string categoria, string cif, string telefono, string correo)
        {
            List<Atleta> lista = recuperarAtletas();
            string idAtleta = "0";
            if (lista.Count > 0)
            {
                lista.Sort((a, b) =>
                {
                    return Convert.ToInt32(b.IdAtleta) - Convert.ToInt32(a.IdAtleta);
                });
                idAtleta = "" +(Convert.ToInt32(lista.First().IdAtleta)+ 1);
            }
            Atleta atleta = new Atleta(idAtleta, nombre, apellido,nacionalidad,sexo, edad,peso, salario,categoria, cif, telefono, correo);
            lista.Add(atleta);
            return guardarAtletas(lista);
        }

        //comprueba que el nombre no este repetido
        public static bool comprobarNombreAtleta(string nombre)
        {
            List<Atleta> listaClientes = recuperarAtletas();
            if (listaClientes.FindIndex(x => x.Nombre == nombre) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        // comprueba que correo no este repetido
        public static bool comprobarCorreoRepetido(string correo)
        {
            List<Atleta> listaClientes = recuperarAtletas();
            if (listaClientes.FindIndex(x => x.Correo == correo) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        



    }

    


    }



