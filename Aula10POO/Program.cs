using System;
    class Program{
        static void Main(string[] args){
            
            int i;
            string m,c;
            
            Carro[] carros = new Carro[3];
            

            for(i=0;i<carros.Length;i++){

               Console.WriteLine("Modelo:");
               m=Console.ReadLine();
               Console.WriteLine("Cor:");    
               c=Console.ReadLine();

               carros[i].modelo=m;
               carros[i].cor=c;

            }

            Console.WriteLine("\n");

            for(i=0;i<carros.Length;i++){
                carros[i].info();
            }

        }
        
        struct Carro{

        public string modelo;
        public string cor;

         public void info(){        
          
            Console.WriteLine("Modelo: {0}",this.modelo);
            Console.WriteLine("Cor...: {0}",this.cor);
            Console.WriteLine("------------------------");

        }
     }
  }




