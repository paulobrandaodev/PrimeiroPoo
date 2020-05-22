using System;

namespace PrimeiroPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem jogador1 = new Personagem();
            jogador1.nome = "Matheus Barbosa";
            jogador1.idade = 18;

            Console.WriteLine( jogador1.Correr(250.3f) );
            Console.WriteLine( "Força : " + jogador1.Atacar(60f) );
            
            jogador1.pulando = true;
            Console.WriteLine( "Força : " + jogador1.Atacar(60f) );

        }
    }
}
