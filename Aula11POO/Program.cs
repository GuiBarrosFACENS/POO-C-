using System;

//metodos que retornam objetos
    class Program
    {
        static void Main(string[] args){ 

            Galinha g1 = new Galinha("Gertrudes");  
            Galinha g2 = new Galinha("Popo");   
            Galinha g3 = new Galinha("Duda");      

            g1.botar(); 
            g1.botar();

            g2.botar();
            g2.botar();

            g3.botar();      

        }

        class Galinha{
            
            private string nomeGalinha;
            private int numOvo;

            public Galinha(string nomeGalinha){

                this.nomeGalinha=nomeGalinha;
                numOvo=0;

            }

            public Ovo botar(){ // METODO QUE RETORNA OBJETO OVO!

                numOvo++;
                return new Ovo(numOvo,nomeGalinha); //metodo retornou objeto!!!

            }
        }

        class Ovo{
            private int numOvo;
            private string minhaGalinha;
            public Ovo(int numOvo,string minhaGalinha){

                this.minhaGalinha=minhaGalinha;
                this.numOvo=numOvo;
                Console.WriteLine("Ovo: {0} da Galinha: {1}",this.numOvo,this.minhaGalinha);
                
            }


        }

    }

