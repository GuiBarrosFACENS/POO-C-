using System;
using System.Collections.Generic;

//DICTIONARY UMA COLEÇÃO

namespace Aula14POO
{
    class Program{
        static void Main(string[] args){
            
            Dictionary <int,string> veiculos = new Dictionary <int,string> (); //chave int - valor string CRIAR DICIONARIO

            veiculos.Add(10,"Carro"); // add adiociona chave 10 int carro string carro
            veiculos.Add(5,"Aviao");
            veiculos.Add(0,"Navio"); // adicionando
            veiculos.Add(20,"Moto");
            veiculos.Add(15,"Patinete");

            //metodos

            // veiculos.Clear(); // limpa tudo

            //veiculos.Remove(20); //remove só os 20

            Console.WriteLine("Tamanho do Dictionary: {0}",veiculos.Count); //monstra quantos tem

            Console.WriteLine("-----------------");
            
            int chave =22; // busco p ver se 20 tem na coleção !!!
            
            if(veiculos.ContainsKey(chave)){
                Console.WriteLine("Chave {0} esta coleção",chave);
            }else{
                Console.WriteLine("Chave {0} nao esta coleção",chave);
            }

            //veiculos[15]="Bicicleta"; // na onde tinha patinete agora tem BICICLETA!!

            string valor = "Navio"; // busco p ver se o valor NAVIO tem na coleção !!!
            
            if(veiculos.ContainsValue(valor)){
                Console.WriteLine("valor {0} esta coleção",valor);
            }else{
                Console.WriteLine("valor {0} nao esta coleção",valor);
            }

            Console.WriteLine("-----------------\n");

            foreach(KeyValuePair<int,string> v in veiculos){ 
                Console.WriteLine(v.Value); // imprime os valores... navio, carro etc.
            }

            Console.WriteLine("-----------------");

             foreach(KeyValuePair<int,string> v in veiculos){ 
                Console.WriteLine(v.Key); // imprime as keys... 10,20,30 etc.
            }


        }

    }
}
