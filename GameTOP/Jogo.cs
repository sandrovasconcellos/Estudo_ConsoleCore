namespace GameTOP
{
    public class Jogo
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;

        // construtor
        public Jogo(IJogador jA, IJogador jB)
        {
            _jogadorA = jA;
            _jogadorB = jB;
        }

        public void JogoSinistro()
        {
            System.Console.Write(_jogadorA.Corre());
            System.Console.Write(_jogadorA.Chuta());
            System.Console.Write(_jogadorA.Passe());

            System.Console.Write("PROXIMO JOGADOR \n");
            
            System.Console.Write(_jogadorB.Corre());
            System.Console.Write(_jogadorB.Chuta());
            System.Console.Write(_jogadorB.Passe());
        }
    }
   
}