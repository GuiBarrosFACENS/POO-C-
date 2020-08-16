using System;

    class aula07{
    
    static void Main(string[] args){

            veiculo c = new veiculo();

            c[4]= 200; // posição 4 = 200

            Console.WriteLine("Velocidade: {0}",c[4]);

        }

        class veiculo{

            private int[] velMax = new int[5]{80,120,160,240,300};

            public int this[int i]{ // anexador indice do vetor

                get{
                    return velMax[i];
                }set{
                    if(value < 0){
                        velMax[i] = 0;
                    }else if(value > 280){ // set deixa VOCE SETAR ALGO COLOCAR
                        velMax[i] = 280;
                    }else{
                        value = velMax[i];
                    }
                }
            }


        }
    }
