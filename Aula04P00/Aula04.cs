using System;

namespace Aula04P00{
    class Aula04{
        static void Main(string[] args){
            Jogador j1 = new Jogador("gui");
            j1.setEnergia(-30);
            
            Console.WriteLine("Nome...: {0}",j1.getNome());
            Console.WriteLine("Energia: {0}",j1.getEnergia());

        }
        class Jogador{
            private int energia;
            private string nome;
            
            public Jogador(string nome){
                this.nome=nome;
                energia=100;
            }
            public int getEnergia(){ // obtendo a energia
                return energia;
            }

            public string getNome(){
                return nome;
            }

            public void setEnergia(int e){ // setando energia
                if(e<0){

                    if(energia+ e<0){
                        energia=0; 
                    }else{
                        energia+=e;
                    }

                }else if(e>0){

                    if(energia+e > 100){
                        energia=100;
                    }else{
                        energia+=e;
                    }

                }
            }


        }

    }
}
