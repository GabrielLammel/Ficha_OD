public class Personagem
{
    public string Nome;

    public Atributos Atributos;

    public ClasseRPG Classe;

    public int PontosVida;

    public void CalcularPV()
    {
        int modificadorCON =
            Atributos.CalcularModificador(Atributos.Constituicao);

        PontosVida = Classe.DadoVida + modificadorCON;

        if (PontosVida < 1)
        {
            PontosVida = 1;
        }
    }
}