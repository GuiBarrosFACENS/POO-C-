using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string>carros=new List<string>();
            List<string>carros2=new List<string>();

            string[] carros3=new string[6]; // COPY TO SO ACEITA ASSIM

            carros.Add("Golf");
            carros.Add("Hb20");
            carros.Add("Focus");
            carros.Add("Uno");

            carros2.AddRange(carros); // adiciona carros em carros 2 

            carros.CopyTo(carros3,2); // copiar a partir da posição 2

            carros.Insert(1,"Cruze"); // coloca na posição 1 o cruze

            // carros.Reverse(); // REVERTE A LISTA INVERTE
            //carros.Sort(); // ordena alfabetica

            int tamanho = carros.Count; // mostra o tamanho

            carros.Capacity=20; // altera a capacidade
            int cap=carros.Capacity;

            Console.WriteLine("Tamanho: {0}",tamanho);
            Console.WriteLine("Capacidade: {0}",cap);

            Console.WriteLine("---------");

            foreach(string c in carros){

                Console.WriteLine("Carros: {0}",c);

            }

            foreach(string c in carros){

                Console.WriteLine("Carros: {0}",c);

            }
/*
            foreach(string c in carros2){

                Console.WriteLine("Carros 2 : {0}",c); // lista 2 

            }
*/
            Console.WriteLine("---------");

            if(carros.Contains("Golf")){ // busca se contem golf 
                Console.WriteLine("Esta na lista");
            }else{
                Console.WriteLine("Não encontrado");
            }

             Console.WriteLine("---------");

            foreach(string c in carros3){

                Console.WriteLine("Carros: {0}",c);

            }

            // encontrar a posição de um caracter 

            string ca = "Golf";
            int pos=0;
            pos=carros.IndexOf(ca); // acha uma string na lista...
            Console.WriteLine("Carro: {0} esta na posição: {1}",ca,pos);

        }
    }
}
