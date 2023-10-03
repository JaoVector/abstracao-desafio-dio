using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Abstracao_Celulares.Classes
{
    public class Xiaomi : Celular, ICelular<Xiaomi>
    {
        private List<Xiaomi> mis;
        private string os;
        private int qtdCam;
        private string modelo;

        public Xiaomi(string os, int qtdCam, string modelo)
        {
            mis = new List<Xiaomi>();
            this.os = os;
            this.qtdCam = qtdCam;
            this.modelo = modelo;
        }

        public override string OS => os;
        public override int QtdCameras => qtdCam;
        public override string Modelo => modelo;

        public override void GeraArquivoListaDeItems()
        {
           XmlSerializer serializer = new XmlSerializer(typeof(XElement));

           XElement xiaomi = new XElement("Root");
           foreach (Xiaomi item in mis)
           {
               xiaomi.Add(new XElement("Xiaomi", 
                            new XElement("Modelo", item.Modelo),
                            new XElement("QtdCameras", item.QtdCameras),
                            new XElement("OS", item.OS)
               ));
           }

           TextWriter writer = new StreamWriter("Xiaomi.xml");
           var xmlWriter = XmlWriter.Create(writer, new XmlWriterSettings { Indent = true });
           serializer.Serialize(xmlWriter, xiaomi);        
        }

        public void InsereCelulares(Xiaomi mi) => mis.Add(mi);
        public List<Xiaomi> ListaCelulares() => mis;
    }
}