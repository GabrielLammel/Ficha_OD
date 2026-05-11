public class GeradorAtributos
{
    Random random = new Random();

    private int RolarDado()
    {
        return random.Next(1, 7);
    }

    public Atributos GerarClassico()
    {
        Atributos atributos = new Atributos();

        atributos.Forca = Rolar3d6();
        atributos.Destreza = Rolar3d6();
        atributos.Constituicao = Rolar3d6();
        atributos.Inteligencia = Rolar3d6();
        atributos.Sabedoria = Rolar3d6();
        atributos.Carisma = Rolar3d6();

        return atributos;
    }

    public Atributos GerarAventureiro()
    {
        int[] valores = new int[6];

        for (int i = 0; i < 6; i++)
        {
            valores[i] = Rolar3d6();
        }

        Array.Sort(valores);
        Array.Reverse(valores);

        Atributos atributos = new Atributos();

        atributos.Forca = valores[0];
        atributos.Destreza = valores[1];
        atributos.Constituicao = valores[2];
        atributos.Inteligencia = valores[3];
        atributos.Sabedoria = valores[4];
        atributos.Carisma = valores[5];

        return atributos;
    }

    public Atributos GerarHeroico()
    {
        Atributos atributos = new Atributos();

        atributos.Forca = Rolar4d6();
        atributos.Destreza = Rolar4d6();
        atributos.Constituicao = Rolar4d6();
        atributos.Inteligencia = Rolar4d6();
        atributos.Sabedoria = Rolar4d6();
        atributos.Carisma = Rolar4d6();

        return atributos;
    }

    private int Rolar3d6()
    {
        return RolarDado() + RolarDado() + RolarDado();
    }
    private int Rolar4d6()
    {
        int[] dados = new int[4];

        for (int i = 0; i < 4; i++)
        {
            dados[i] = RolarDado();
        }

        Array.Sort(dados);

        return dados[1] + dados[2] + dados[3];
    }
}