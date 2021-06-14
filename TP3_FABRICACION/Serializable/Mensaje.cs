using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serializable
{
    [Serializable]
    public class Mensaje
    {
        public string Proceso { get; set; }
        public string Material { get; set; }
        public string Origen { get; set; }
        public string Cantidad { get; set; }
        public string Calidad { get; set; }
        public string Color { get; set; }
        /// <summary>
        /// Constructor que permite poder Serializar
        /// </summary>
        public Mensaje()
        {
        }
        /// <summary>
        /// Constructor de Mensaje con todos sus parametros
        /// </summary>
        /// <param name="proceso"></param>
        /// <param name="material"></param>
        /// <param name="origen"></param>
        /// <param name="cantidad"></param>
        /// <param name="calidad"></param>
        /// <param name="color"></param>
        public Mensaje(string proceso, string material, string origen, string cantidad, string calidad, string color)
        {
            Proceso = proceso;
            Material = material;
            Origen = origen;
            Cantidad = cantidad;
            Calidad = calidad;
            Color = color;
        }
        /// <summary>
        /// Sobreescritura de ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarCampos();
        }
        /// <summary>
        /// Retorna el string del mensaje creado
        /// </summary>
        /// <returns></returns>
        public string MostrarCampos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Proceso:{Proceso};");
            sb.Append($"Material:{Material};");
            sb.Append($"Origen:{Origen};");
            sb.Append($"Cantidad:{Cantidad};");
            sb.Append($"Calidad:{Calidad};");
            sb.Append($"Color:{Color};");
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del operador ==
        /// </summary>
        /// <param name="listaMensaje"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static bool operator ==(List<Mensaje> listaMensaje, Mensaje mensaje)
        {
            bool retorno = false;
            foreach (Mensaje item in listaMensaje)
            {
                if (mensaje.Origen.Equals(item.Origen) &&
                    mensaje.Cantidad.Equals(item.Cantidad))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        /// <summary>
        /// Sobrecarga del operador !=
        /// </summary>
        /// <param name="listaMensaje"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static bool operator !=(List<Mensaje> listaMensaje, Mensaje mensaje)
        {
            return !(listaMensaje == mensaje);
        }
        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="misMensajes"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static List<Mensaje> operator +(List<Mensaje> misMensajes, Mensaje mensaje)
        {
            if (misMensajes != mensaje)
            {
                misMensajes.Add(mensaje);
            }
            return misMensajes;
        }
        /// <summary>
        /// Permite guardar el mensaje en formato TXT
        /// </summary>
        /// <returns></returns>
        public bool GuardarTxt()
        {
            StreamWriter streamWriter = new StreamWriter($"{Material}{Origen}.txt");
            streamWriter.WriteLine(MostrarCampos().Replace('\n', ';'));
            streamWriter.Close();
            return File.Exists($"{Material}{Origen}.txt");
        }
        /// <summary>
        /// permite guardar el mensaje en formato XML
        /// </summary>
        public void GuardarXml()
        {
            XmlTextWriter xmlTextWriter = new XmlTextWriter($"{Material}{Origen}.xml", Encoding.UTF8);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Mensaje));
            xmlSerializer.Serialize(xmlTextWriter, this);
            xmlTextWriter.Close();
        }
    }
}
