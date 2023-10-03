namespace Abstracao_Celulares.Classes
{
    public interface ICelular<T>
    {
        void InsereCelulares(T entry);
        List<T> ListaCelulares();
    }
}