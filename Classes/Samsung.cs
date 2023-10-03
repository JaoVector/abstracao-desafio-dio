using System.Text.Json;

namespace Abstracao_Celulares.Classes
{
    public class Samsung : Celular, ICelular<Samsung>
    {
        private List<Samsung> samsungs;
        private string os;
        private int qtdCam;
        private string model;

        public Samsung(string os, int qtdCam, string model)
        {
            samsungs = new List<Samsung>();
            this.os = os;
            this.qtdCam = qtdCam;
            this.model = model;

        }

        public override string OS => os;
        public override int QtdCameras => qtdCam;
        public override string Modelo => model;

        public override void GeraArquivoListaDeItems()
        {
            var option = new JsonSerializerOptions { WriteIndented = true };
            string jsonArquivo = JsonSerializer.Serialize(samsungs, option);
            File.WriteAllText("Samsung.json", jsonArquivo);
        }

        public void InsereCelulares(Samsung samsung) => samsungs.Add(samsung);
        public List<Samsung> ListaCelulares() => samsungs;

    }
}