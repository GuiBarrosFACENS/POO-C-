using System;

namespace Aula02POO{
    class aula02POO{
        static void Main(string[] args){

            Jogador.iniciar("Guizao");
            Jogador.info();     

            Inimigo i1 = new Inimigo("Doido");
            Inimigo.alerta=true;  
            i1.fala();

        } // void 
        
        static public class Jogador{  // static n permite construtor... outro metodo 
            static public int energia;
            static public bool vivo;
            static public string nome;

            static public void iniciar(string n ){
                energia = 100;
                vivo=true;
                nome = n;

            } // iniciar

            static public void info(){
                Console.WriteLine("Jogador: {0}",nome);
                Console.WriteLine("Energia: {0}",energia);
                Console.WriteLine("Status:. {0}",vivo);
            } // info

            
        } // jogador

        public class Inimigo{
                static public bool alerta; // muda todos!!!
                public string nome;

                public Inimigo(string n ){
                    alerta = false;
                    nome=n;
                }
                public void fala(){
                    Console.WriteLine(nome);
                    Console.WriteLine(alerta);
                }

            }// inimigo


    } // class

}// namespace