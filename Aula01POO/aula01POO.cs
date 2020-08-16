using System;

namespace Aula01POO{
    class aula01POO{
        public class Jogador{ // objeto
            public int energia;
            public bool vivo;
            public string nome;
            public Jogador(string n){ // Construtor
                 energia=100;
                 vivo = true;
                 nome=n;
            }
            ~Jogador(){ // destrutor 
                Console.WriteLine("Jogador {0} Destruido",nome);
            }

        }
        static void Main(string[] args){

            string nome1,nome2;
            Console.WriteLine("Digite o nome do jogador 1: ");
            nome1=Console.ReadLine();
            Console.WriteLine("Digite o nome do jogador 1: ");
            nome2=Console.ReadLine();

            Jogador j1=new Jogador(nome1);
            Jogador j2=new Jogador(nome2);

            Console.WriteLine("Jogador 1: {0}",j1.nome);
            Console.WriteLine("Jogador 2: {0}",j2.nome);

        }
 

    }
}
