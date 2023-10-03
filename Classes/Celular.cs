namespace Abstracao_Celulares.Classes
{
    public abstract class Celular
    {
        public abstract string OS { get; }
        public abstract int QtdCameras { get; }
        public abstract string Modelo { get; }

        public abstract void GeraArquivoListaDeItems();
    }
}