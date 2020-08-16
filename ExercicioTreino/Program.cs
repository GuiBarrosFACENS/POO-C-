using System;

namespace ExercicioTreino
{
    class Program
    {
        static void Main(string[] args){
            
            string nome;
            int vel;


            Console.WriteLine("Nome do Carro:");
            nome = Console.ReadLine();

            Console.WriteLine("VelMax: ");
            vel=int.Parse(Console.ReadLine());

            Carro c1 = new Carro(nome,vel);

            c1.ligar();
            c1.status();
        }

        class Veiculo{

            public int velAtual;
            protected int velMax;
            protected bool ligado;

            public Veiculo(int velMax){
                velAtual = 0;
                this.velMax = velMax;
                ligado = false;

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
        
            public int getVelMax(){
                return velMax;
            }

        } // pai 

        class Carro:Veiculo{

            public string nome;

            public Carro(string nome, int vm):base(vm){

                this.nome=nome;

            }

            public void status(){

            Console.WriteLine("Nome..:{0}",this.nome);
            Console.WriteLine("VelMax:{0}",this.getVelMax());
            Console.WriteLine("Ligado:{0}",this.getLigado());

            }


        }//filho

    }
}
