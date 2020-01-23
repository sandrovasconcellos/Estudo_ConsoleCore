using System;
using GameTOP.Lib;

namespace GameTOP.Interface
{
   public class Program
    {
        static void Main(string[] args)
        {    
            Jogador1 j1 = new Jogador1();
            Jogador2 j2 = new Jogador2();
            
            Jogo oJogo = new Jogo(j1, j2);

            // var oJogo = new Jogo(new Jogador1(), new Jogador2());

            oJogo.JogoSinistro();
        }
    }

    
}
