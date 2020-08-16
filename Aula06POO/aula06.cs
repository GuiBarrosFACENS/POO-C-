using System;
    class aula06{
        static void Main(string[] args){

            Derivada2 d2 = new Derivada2();

        }

    }
     class Base{
            public Base(){
                Console.WriteLine("Classe Base");
            }
        }// pai

        class Derivada:Base{
            public Derivada(){
                Console.WriteLine("Classe Derivada");
            }
        }// filho
         class Derivada2:Derivada{
            public Derivada2(){
                Console.WriteLine("Classe Derivada2");
            }
        }// neto

