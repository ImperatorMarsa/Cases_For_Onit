using System;
using System.Collections.Generic;
using System.Linq;

namespace Pony{
    class Program{
        public static void Main(){
            Dictionary<string, List<string>> someData = new Dictionary<string, List<string>>();
            someData["Петр Иванович"] = new List<string>();
            someData["Петр Иванович"].Add("Анна Ивановна");
            someData["Петр Иванович"].Add("Максим Иванович");
            someData["Максим Иванович"] = new List<string>();
            someData["Максим Иванович"].Add("Коля");
            someData["Максим Иванович"].Add("Миша");
            someData["Максим Иванович"].Add("Николай Максимович");
            someData["Анна Ивановна"] = new List<string>();
            someData["Анна Ивановна"].Add("Артем");
            someData["Николай Максимович"] = new List<string>();
            someData["Николай Максимович"].Add("Катя");
            someData["Николай Максимович"].Add("Маша");
            someData["Анна Ивановна"].Add("Саша");
            
            List<string> lastChilds = new List<string>();
            Console.WriteLine("\nStaraya rrekursivnaya funkciya");
            RecursFillLastChilds("Петр Иванович", someData, lastChilds);
            foreach (var child in lastChilds){
                Console.WriteLine(child);
            }

            List<string> lastChilds_2 = new List<string>();
            Console.WriteLine("\nNovaya funkciya");
            NewFun("Петр Иванович", someData, lastChilds_2);
            foreach (var child in lastChilds_2){
                Console.WriteLine(child);
            }
        }
        private static void RecursFillLastChilds(string parentName, Dictionary<string, List<string>> someData, List<string> lastChilds){
            if (!someData.ContainsKey(parentName)){
                lastChilds.Add(parentName);
                return;
            }
            foreach (string child in someData[parentName]){
                RecursFillLastChilds(child, someData, lastChilds);
            }
        }
        private static void NewFun(string parentName, Dictionary<string, List<string>> someData, List<string> lastChilds){
            List<string> rodaki=new List<string>() {parentName};

            while(rodaki.Count>0){
                foreach (string ditya in someData[rodaki[0]]){
                    if (!someData.ContainsKey(ditya)){
                        lastChilds.Add(ditya);
                    } else {
                        rodaki.Add(ditya);
                    }
                }
                rodaki.RemoveAt(0);
            }
            return;
        }
    }
}
