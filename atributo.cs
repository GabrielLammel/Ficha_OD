public class Atributos
{
    public int Forca;
    public int Destreza;
    public int Constituicao;
    public int Inteligencia;
    public int Sabedoria;
    public int Carisma;

    public int CalcularModificador(int valor)
    {
        if (valor <= 3)
            return -3;

        if (valor <= 5)
            return -2;

        if (valor <= 8)
            return -1;

        if (valor <= 12)
            return 0;

        if (valor <= 14)
            return 1;

        if (valor <= 16)
            return 2;

        return 3;
    }
}