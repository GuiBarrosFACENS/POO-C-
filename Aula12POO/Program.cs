using System;

//Métodos e Variáveis estáticos (static)
//static pode retornar
    class Program{
        static void Main(string[] args){

            double vpi=Mat.pi;
            int num=10;

            Console.WriteLine(vpi);            

            Console.WriteLine(Mat.dobro(num));            

        }
        class Mat{

            public static double pi=3.14;

            public static int dobro(int n){
                return n * 2 ;
            }

        }


    }

