using System;

//STRUCT "UM TIPO ESPECIAL, ARMAZENA DADOS DE TIPOS DIFERENTE"
//STRUT ACESSA DIRETAMENTE, NAO POR INSTRUMENTOS
//NÃO É CLASSE N HERDA NEM É HERDADA, MAS PODE INICIAR CONSTRUTORES
//STRUCT NÃO É CLASSE!!!
    class Program{
        static void Main(string[] args){
            
            Carro c1 = new Carro("Ford","Fiesta","Branco");

            c1.info();

            /*  DAR CERTO TAMBÉM !!!
            Carro c1;
            c1.marca="Ford";
            c1.modelo="Fiesta";
            c1.cor="Branco";
            */
        }

        
        struct Carro{
         public string marca;
        public string modelo;
        public string cor;
        public Carro(string marca,string modelo,string cor){
            this.marca=marca;
            this.modelo=modelo;
            this.cor=cor;
        }

         public void info(){
        
            Console.WriteLine("Marca.: {0}",this.marca);
            Console.WriteLine("Modelo: {0}",this.modelo);
            Console.WriteLine("Cor...: {0}",this.cor);

        }
     }
  }




