using System;

namespace Aula05POO{
    class aula05{
        static void Main(string[] args){

            Carro c1=new Carro("Fox","Prata");
            CarroCombate c2=new CarroCombate();

            c1.ligar();
            c1.mostra();

            c2.status();

        }

        class Veiculo{ // clase base PAI
            public int velMax;
            private int rodas;
            public bool ligado;

            public Veiculo(int rodas){
                this.rodas=rodas;
            }

            public void ligar(){
                ligado=true;
            }

            public void desligar(){
                ligado=false;
            }

            public string getLigado(){
                return (ligado?"sim":"não"); // condicional ternario
            }  // true = sim false = não

            public int getRodas(){
                return rodas;
            }
            public void setRodas(int rodas){
                if(rodas<0){
                    this.rodas=0;
                }else if(rodas>10){
                    this.rodas=10;
                }else{
                    this.rodas=rodas;
                }
            }
            
        }// pai

        class Carro:Veiculo{ // filho herança
            public string nome;
            public string cor;
            
            public Carro(string nome,string cor):base(4){
                desligar();
                velMax=120;
                this.nome=nome;
                this.cor=cor;
            }

            public void mostra(){
              Console.WriteLine("Cor....:{0}",this.cor);
              Console.WriteLine("Nome...:{0}",this.nome);     
              Console.WriteLine("Rodas..:{0}",this.getRodas());   
              Console.WriteLine("Vel.Max:{0}",this.velMax);
              Console.WriteLine("Ligado.:{0}",this.getLigado());
              Console.WriteLine("\n---------------------------\n");

            }

        }// filho

        class CarroCombate:Carro{ // filho do filho

            public int municao;

            public CarroCombate():base("Carro de Combate","Verde"){
                municao=100;
                setRodas(6);
            }

              public void status(){
              Console.WriteLine("Cor....:{0}",this.cor);
              Console.WriteLine("Nome...:{0}",this.nome);     
              Console.WriteLine("Rodas..:{0}",this.getRodas());   
              Console.WriteLine("Vel.Max:{0}",this.velMax);
              Console.WriteLine("Ligado.:{0}",this.getLigado());
              Console.WriteLine("Munição:{0}",this.municao);

            }


        }//neto

    }
}
