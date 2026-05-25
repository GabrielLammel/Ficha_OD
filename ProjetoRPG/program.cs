using System;
using System.Linq;

using var db = new RpgContext();

GeradorAtributos gerador = new GeradorAtributos();

Atributos atributos = gerador.GerarHeroico();

ClasseRPG classeEscolhida = new ClasseRPG(
    "Guerreiro",
    "Especialista em combate físico",
    10
);

int modificadorCON = atributos.CalcularModificador(atributos.Constituicao);

int pontosVida = classeEscolhida.DadoVida + modificadorCON;

if (pontosVida < 1)
{
    pontosVida = 1;
}

Personagem personagem = new Personagem();

personagem.Nome = "Arthas";
personagem.Forca = atributos.Forca;
personagem.Destreza = atributos.Destreza;
personagem.Constituicao = atributos.Constituicao;
personagem.Inteligencia = atributos.Inteligencia;
personagem.Sabedoria = atributos.Sabedoria;
personagem.Carisma = atributos.Carisma;
personagem.Classe = classeEscolhida.Nome;
personagem.PontosVida = pontosVida;

db.Personagens.Add(personagem);
db.SaveChanges();

Console.WriteLine("Personagem salvo no banco!");
Console.WriteLine();

var personagens = db.Personagens.ToList();

foreach (var p in personagens)
{
    Console.WriteLine("---------------------");
    Console.WriteLine("ID: " + p.PersonagemId);
    Console.WriteLine("Nome: " + p.Nome);
    Console.WriteLine("Classe: " + p.Classe);
    Console.WriteLine("PV: " + p.PontosVida);
    Console.WriteLine("FOR: " + p.Forca);
    Console.WriteLine("DES: " + p.Destreza);
    Console.WriteLine("CON: " + p.Constituicao);
    Console.WriteLine("INT: " + p.Inteligencia);
    Console.WriteLine("SAB: " + p.Sabedoria);
    Console.WriteLine("CAR: " + p.Carisma);
}