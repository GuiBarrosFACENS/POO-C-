using System;

//delegate ref. a um metodo
//ponteiro de em C
    class Program{
        static void Main(string[] args){
            
            int res;

            Op d1 = new Op(Mat.soma);

            res=d1(10,50);

            Console.WriteLine("Soma: {0}",res);

            d1=new Op(Mat.mult);

            res=d1(10,50);
 
            Console.WriteLine("mult: {0}",res);


        }


    delegate int Op(int n1, int n2);    
    class Mat{
        public static int soma(int n1,int n2){
            return n1+n2;
        }

        public static int dobro(int n){
            return n*2;
        }

        public static int mult(int n1,int n2){
            return n1*n2;
        }

    }

    }
