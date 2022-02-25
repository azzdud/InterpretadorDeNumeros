//     __  __        __   __  __   __   __   __ 
//  |  __| __| |__| |__  |__    | |__| |__| |  |
//  | |__  __|    |  __| |__|   | |__|  __| |__|


using System;
using System.IO;

namespace LeitorNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string partTopo = "", partMeio = "", partBaixo = "";
            string numeros = @"
     __  __  __  __  __  __  __  __ 
|__||  ||  | __||  ||__||__| __| __|
   ||__||__||__ |__||__| __||__ |__ 

     __  __  __  __  __  __  __  __ 
|__||  ||  | __||  ||__||__| __| __|
   ||__||__||__ |__||__| __||__ |__ 

     __  __  __  __  __  __  __  __ 
|__||  ||  | __||  ||__||__| __| __|
   ||__||__||__ |__||__| __||__ |__ 

     __  __      __  __  __  __  __  __ 
   | __| __||__||__ |__    ||__||__||  |
   ||__  __|   | __||__|   ||__| __||__|

            ";

            //entrada
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t=================");
            Console.WriteLine("\t\t-----ENTRADA-----");
            Console.WriteLine("\t\t=================\n");
            Console.ResetColor();

            StringReader linhas = new StringReader(numeros);
            linhas.ReadLine();

            //processo de desenhar os numeros na tela
            string linha1 = linhas.ReadLine();
            Console.WriteLine(linha1);
            string linha2 = linhas.ReadLine();
            Console.WriteLine(linha2); 
            string linha3 = linhas.ReadLine();
            Console.WriteLine(linha3);
            linhas.ReadLine();

            string linha4 = linhas.ReadLine();
            Console.WriteLine(linha4);
            string linha5 = linhas.ReadLine();
            Console.WriteLine(linha5);
            string linha6 = linhas.ReadLine();
            Console.WriteLine(linha6);
            linhas.ReadLine();

            string linha7 = linhas.ReadLine();
            Console.WriteLine(linha7);
            string linha8 = linhas.ReadLine();
            Console.WriteLine(linha8);
            string linha9 = linhas.ReadLine();
            Console.WriteLine(linha9);
            linhas.ReadLine();

            string linha10 = linhas.ReadLine();
            Console.WriteLine(linha10);
            string linha11 = linhas.ReadLine();
            Console.WriteLine(linha11);
            string linha12 = linhas.ReadLine();
            Console.WriteLine(linha12);
            linhas.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n=================================================================");
            Console.ResetColor();

            char[] priChar = linha1.ToCharArray();
            char[] segChar = linha2.ToCharArray();
            char[] terChar = linha3.ToCharArray();
            char[] quarChar = linha4.ToCharArray();
            char[] quinChar = linha5.ToCharArray();
            char[] sexChar = linha6.ToCharArray();
            char[] setChar = linha7.ToCharArray();
            char[] oitChar = linha8.ToCharArray();
            char[] nonChar = linha9.ToCharArray();
            char[] decChar = linha10.ToCharArray();
            char[] decPriChar = linha11.ToCharArray();
            char[] decSegChar = linha12.ToCharArray();

            //saida
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\t\t ===============");
            Console.WriteLine("\t\t -----SAÍDA-----");
            Console.WriteLine("\t\t ===============");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine();

            //Primeira Linha
            for (int i = 0; i < priChar.Length; i++)
            {
                partTopo = partTopo + priChar[i];
                partMeio = partMeio + segChar[i];
                partBaixo = partBaixo + terChar[i];

                if (partTopo == " __ " && partMeio == "|  |" && partBaixo == "|__|")
                {
                    Console.Write("0");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == "    " && partMeio == "   |" && partBaixo == "   |")
                {
                    Console.Write("1");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == " __|" && partBaixo == "|__ ")
                {
                    Console.Write("2");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == " __|" && partBaixo == " __|")
                {
                    Console.Write("3");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == "    " && partMeio == "|__|" && partBaixo == "   |")
                {
                    Console.Write("4");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__ " && partBaixo == " __|")
                {
                    Console.Write("5");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__ " && partBaixo == "|__|")
                {
                    Console.Write("6");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "   |" && partBaixo == "   |")
                {
                    Console.Write("7");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__|" && partBaixo == "|__|")
                {
                    Console.Write("8");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__|" && partBaixo == " __|")
                {
                    Console.Write("9");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
            }

            Console.WriteLine();            

            //Segunda Linha
            for (int j = 0; j < quarChar.Length; j++)
            {
                partTopo = partTopo + quarChar[j];
                partMeio = partMeio + quinChar[j];
                partBaixo = partBaixo + sexChar[j];

                if (partTopo == " __ " && partMeio == "|  |" && partBaixo == "|__|")
                {
                    Console.Write("0");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == "    " && partMeio == "   |" && partBaixo == "   |")
                {
                    Console.Write("1");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == " __|" && partBaixo == "|__ ")
                {
                    Console.Write("2");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == " __|" && partBaixo == " __|")
                {
                    Console.Write("3");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == "    " && partMeio == "|__|" && partBaixo == "   |")
                {
                    Console.Write("4");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__ " && partBaixo == " __|")
                {
                    Console.Write("5");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__ " && partBaixo == "|__|")
                {
                    Console.Write("6");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "   |" && partBaixo == "   |")
                {
                    Console.Write("7");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__|" && partBaixo == "|__|")
                {
                    Console.Write("8");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__|" && partBaixo == " __|")
                {
                    Console.Write("9");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
            }

            Console.WriteLine();

            //Terceira Linha
            for (int j = 0; j < setChar.Length; j++)
            {
                partTopo = partTopo + setChar[j];
                partMeio = partMeio + oitChar[j];
                partBaixo = partBaixo + nonChar[j];

                if (partTopo == " __ " && partMeio == "|  |" && partBaixo == "|__|")
                {
                    Console.Write("0");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == "    " && partMeio == "   |" && partBaixo == "   |")
                {
                    Console.Write("1");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == " __|" && partBaixo == "|__ ")
                {
                    Console.Write("2");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == " __|" && partBaixo == " __|")
                {
                    Console.Write("3");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == "    " && partMeio == "|__|" && partBaixo == "   |")
                {
                    Console.Write("4");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__ " && partBaixo == " __|")
                {
                    Console.Write("5");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__ " && partBaixo == "|__|")
                {
                    Console.Write("6");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "   |" && partBaixo == "   |")
                {
                    Console.Write("7");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__|" && partBaixo == "|__|")
                {
                    Console.Write("8");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__|" && partBaixo == " __|")
                {
                    Console.Write("9");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
            }

            Console.WriteLine();

            //Quarta e finalmente última linha
            for (int j = 0; j < decChar.Length; j++)
            {
                partTopo = partTopo + decChar[j];
                partMeio = partMeio + decPriChar[j];
                partBaixo = partBaixo + decSegChar[j];

                if (partTopo == " __ " && partMeio == "|  |" && partBaixo == "|__|")
                {
                    Console.Write("0");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == "    " && partMeio == "   |" && partBaixo == "   |")
                {
                    Console.Write("1");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == " __|" && partBaixo == "|__ ")
                {
                    Console.Write("2");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == " __|" && partBaixo == " __|")
                {
                    Console.Write("3");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == "    " && partMeio == "|__|" && partBaixo == "   |")
                {
                    Console.Write("4");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__ " && partBaixo == " __|")
                {
                    Console.Write("5");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__ " && partBaixo == "|__|")
                {
                    Console.Write("6");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "   |" && partBaixo == "   |")
                {
                    Console.Write("7");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__|" && partBaixo == "|__|")
                {
                    Console.Write("8");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
                if (partTopo == " __ " && partMeio == "|__|" && partBaixo == " __|")
                {
                    Console.Write("9");
                    partTopo = "";
                    partMeio = "";
                    partBaixo = "";
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
