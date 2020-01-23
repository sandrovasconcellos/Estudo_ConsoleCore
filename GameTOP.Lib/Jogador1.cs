namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
   {        
        public string nome { get; set; }

        public Jogador1(string n = "Ronaldo")
        {
            nome = n;
        }
       
       public string Chuta()
       {
           return $"{nome} está chutando. \n";
       }
        public string Corre()
       {
           return $"{nome} está correndo. \n";
       }
        public string Passe()
       {
           return $"{nome} está passando. \n";
       }
        
    
    }
}