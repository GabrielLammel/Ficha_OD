using System;

GeradorAtributos gerador = new GeradorAtributos();

Atributos atributos = gerador.GerarHeroico();

ClasseRPG guerreiro = new ClasseRPG(
    "Guerreiro",
    "Especialista em combate físico",
    10
);

ClasseRPG mago = new ClasseRPG(
    "Mago",
    "Usuário de magias arcanas",
    4
);

ClasseRPG ladrao = new ClasseRPG(
    "Ladrão",
    "Especialista em furtividade",
    6
);

ClasseRPG clerigo = new ClasseRPG(
    "Clerigo",
    "Capaz de lancar magias divinas",
    8
);


Personagem personagem = new Personagem();

personagem.Nome = "Arthas";

personagem.Atributos = atributos;

personagem.Classe = guerreiro;


personagem.CalcularPV();


Console.WriteLine("=== PERSONAGEM ===");

Console.WriteLine("Nome: " + personagem.Nome);

Console.WriteLine("Classe: " + personagem.Classe.Nome);

Console.WriteLine("Descrição: " + personagem.Classe.Descricao);

Console.WriteLine("PV: " + personagem.PontosVida);

Console.WriteLine();

Console.WriteLine("FOR: " + atributos.Forca);
Console.WriteLine("DES: " + atributos.Destreza);
Console.WriteLine("CON: " + atributos.Constituicao);
Console.WriteLine("INT: " + atributos.Inteligencia);
Console.WriteLine("SAB: " + atributos.Sabedoria);
Console.WriteLine("CAR: " + atributos.Carisma);

Console.WriteLine();

Console.WriteLine("MOD FOR: " +
    atributos.CalcularModificador(atributos.Forca));

Console.WriteLine("MOD CON: " +
    atributos.CalcularModificador(atributos.Constituicao));