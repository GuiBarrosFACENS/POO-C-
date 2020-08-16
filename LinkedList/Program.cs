using System;
using System.Collections.Generic;

//LinkedList lista 2 vezes encaminhada 
//da para manipular...

namespace LinkedList{
    class Program{
        static void Main(string[] args){

            LinkedList <string> transp = new LinkedList<string>();

            Console.WriteLine("\n");

            transp.AddFirst("Carro"); // adiciona começo da lista INICIO
            transp.AddFirst("Aviao");
            transp.AddFirst("Navio");
            transp.AddFirst("Moto");
            transp.AddLast("Bicicleta"); // adiciona no final da lista FIM

            LinkedListNode<string>no;

            no=transp.FindLast("Navio");
            transp.AddAfter(no,"Patinete"); // adiciona depois de navio APOS

            no=transp.FindLast("Navio"); // adiciona antes de navio ANTES
             
            transp.AddBefore(no,"Patins");

            foreach(string t in transp){
                Console.WriteLine("Transporte: {0}",t);
            }

            Console.WriteLine("--------------");

            if(transp.Find("Carro"==null)){
                Console.WriteLine("Elemento não encontrado");
            }else{
                Console.WriteLine("Elemento Encontrado");
            }

            //transp.Remove("Navio"); // remove navio
            //transp.RemoveFirst(); //remove o primeiro
            //transp.RemoveLast(); //remove o ultimo

            Console.WriteLine("\n");

        }
    }
}
