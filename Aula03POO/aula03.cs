using System;
    class aula03{
        static void Main(string[] args){
            int n1,n2;

            Console.WriteLine("Digite 1 valor: ");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Digite 2 vlalor: ");
            n2=int.Parse(Console.ReadLine());

            Calculos c = new Calculos (n1,n2);
             Console.WriteLine("\nSoma: "+ c.Somar());
        }
        class Calculos{
            public int v1;
            public int v2;

            public Calculos(int v1,int v2){
                this.v1=v1;
                this.v2=v2;

            }

            public int Somar(){
                return v1+v2;
            }
        }


    }

