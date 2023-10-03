namespace Abstracao_Celulares.Classes
{
    public class Apple : Celular, ICelular<Apple>
    {
        private List<Apple> apples;
        private string os;
        private int qtdCam;
        private string modelo;

        public Apple(string os, int qtdCam, string modelo)
        {
            apples = new List<Apple>();
            this.os = os;
            this.qtdCam = qtdCam;
            this.modelo = modelo;
        }

        public override string OS => os;
        public override int QtdCameras => qtdCam;
        public override string Modelo => modelo;

        public static implicit operator string(Apple apple) => $"{apple.Modelo},{apple.OS},{apple.QtdCameras.ToString()}";

        public override void GeraArquivoListaDeItems()
        {
            File.WriteAllLines("Apple.csv", apples.Select(appl => (string)appl).ToList());
        }

        public void InsereCelulares(Apple apple) => apples.Add(apple);
        public List<Apple> ListaCelulares() => apples;
    }
}