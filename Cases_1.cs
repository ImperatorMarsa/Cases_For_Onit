using System;
using System.Collections.Generic;
using System.Linq;

namespace Pony{
    class Program{
        static void OpredMax(List<List<int>> mass){
            int maximum=0;

            for(int i=0; i<mass.Count; i++){
                for(int j=0; j<mass[i].Count; j++){
                    Console.Write("{0,4}", mass[i][j]);
                    if(mass[i][j]>maximum){maximum=mass[i][j];}
                }
                Console.Write("\n\n");
            }

            List<List<List<int>>> index=new List<List<List<int>>>();
            for(int N=0; N<maximum+1; N++){
                index.Add(new List<List<int>>());
                for(int i=0; i<mass.Count; i++){
                    int buf=mass[i].IndexOf(N);
                    while(buf>0){
                        index[N].Add(new List<int>() {i, buf});
                        buf=mass[i].IndexOf(N, buf+1);
                    }
                }
            }

            List<List<int>> bigNum=new List<List<int>>();
            bigNum.Add(new List<int> {0, 0, 0, 0});
            bigNum.Add(new List<int> {0, 0, 0, 0});
            for(int N=maximum; N>-1; N--){
                for(int i=0; i<index[N].Count; i++){
                    for(int j=0; j<index[N][i].Count; j++){
                    }
                }
            }
        }
        static void Main(string[] args){
            Console.WriteLine("Pognali\n\n");

            // Console.BackgroundColor = ConsoleColor.Blue;
            // Console.ForegroundColor = ConsoleColor.White;
            // Console.WriteLine("White on blue.");
            // Console.WriteLine("Another line.");
            // Console.ResetColor();

            List<List<int>> mass=new List<List<int>>();
            
            { // Eto tak chtob glaza ne mozolelo :-)
                mass.Add(new List<int>() {08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08});
                mass.Add(new List<int>() {49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00});
                mass.Add(new List<int>() {81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65});
                mass.Add(new List<int>() {52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91});
                mass.Add(new List<int>() {22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80});
                mass.Add(new List<int>() {24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50});
                mass.Add(new List<int>() {32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70});
                mass.Add(new List<int>() {67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21});
                mass.Add(new List<int>() {24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72});
                mass.Add(new List<int>() {21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95});
                mass.Add(new List<int>() {78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92});
                mass.Add(new List<int>() {16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57});
                mass.Add(new List<int>() {86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58});
                mass.Add(new List<int>() {19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40});
                mass.Add(new List<int>() {04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66});
                mass.Add(new List<int>() {88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69});
                mass.Add(new List<int>() {04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36});
                mass.Add(new List<int>() {20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16});
                mass.Add(new List<int>() {20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54});
                mass.Add(new List<int>() {01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48});
            }
            
            OpredMax(mass);
        }
    }
}
