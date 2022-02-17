using System;

namespace InterpretadorDeNumeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "   __  __        __   __  __   __   __   __\n" +
                           "|  __| __| |__| |__  |__    | |__| |__| |  |\n" +
                           "| |__  __|    |  __| |__|   | |__|  __| |__|\n"+
                           "                                              ";


            int tamanhoDoTexto = texto.Length;
            string numerosFormatados = "";
            Console.WriteLine(texto + "" + tamanhoDoTexto);
            System.IO.StringReader leitorTexto = new System.IO.StringReader(texto);
            bool centroCima, superiorEsquerdo, superiorDireito, centroMeio, inferiorEsquerdo, inferiorDireito, centroBaixo;
           
            string primeiraLinha = leitorTexto.ReadLine();
            char[] arrayPrimeiraLinha = primeiraLinha.ToCharArray();
            
            
            string segundaLinha = leitorTexto.ReadLine();
            char[] arraySegundaLinha = segundaLinha.ToCharArray();
            
            
            string terceiraLinha = leitorTexto.ReadLine();
            char [] arrayTerceiraLinha = terceiraLinha.ToCharArray();

            for (int i = 0; i < arrayPrimeiraLinha.Length; i++)
            {
                //Linha 1:
                for (int j = 0; j < arrayPrimeiraLinha.Length; j++)
                {
                    //numero 1:
                    if ((arrayPrimeiraLinha[j] != '|' && arrayPrimeiraLinha[j + 1] != '_') && (segundaLinha[j] == '|' && segundaLinha[j + 1] != '_') && (terceiraLinha[j] == '|' && terceiraLinha[j + 1] != '_'))
                    {
                        numerosFormatados += "1";
                    }
                    //numere 2: 
                    if ((arrayPrimeiraLinha[j] != '|' && arrayPrimeiraLinha[j + 1] == '_') && (segundaLinha[j] != '|' && segundaLinha[j + 1] == '_') && (terceiraLinha[j] == '|' && terceiraLinha[j + 1] == '_'))
                    {
                        numerosFormatados += "2";
                    }
                    //numero 3:
                    if ((arrayPrimeiraLinha[j] != '|' && arrayPrimeiraLinha[j + 1] == '_') && (segundaLinha[j] != '|' && segundaLinha[j + 1] == '_') && (terceiraLinha[j] != '|' && terceiraLinha[j + 1] == '_'))
                    {
                        numerosFormatados += "3";
                    }
                    //numero 4:
                    if ((arrayPrimeiraLinha[j] != '|' && arrayPrimeiraLinha[j + 1] != '_') && (segundaLinha[j] != '|' && segundaLinha[j + 1] == '_') && (terceiraLinha[j] != '|' && terceiraLinha[j + 1] != '_'))
                    {
                        numerosFormatados += "4";
                    }
                    //numero 5:
                    if ((arrayPrimeiraLinha[j] != '|' && arrayPrimeiraLinha[j + 1] == '_') && (segundaLinha[j] == '|' && segundaLinha[j + 1] == '_') && (terceiraLinha[j] != '|' && terceiraLinha[j + 1] != '_'))
                    {
                        numerosFormatados += "5";
                    }
                    //numero 6:
                    if ((arrayPrimeiraLinha[j] != '|' && arrayPrimeiraLinha[j + 1] == '_') && (segundaLinha[j] == '|' && segundaLinha[j + 1] == '_') && (terceiraLinha[j] == '|' && terceiraLinha[j + 1] == '_'))
                    {
                        numerosFormatados += "6";
                    }
                    //numero 7:
                    if ((arrayPrimeiraLinha[j] != '|' && arrayPrimeiraLinha[j + 1] == '_') && (segundaLinha[j] != '|' && segundaLinha[j + 1] != '_') && (terceiraLinha[j] != '|' && terceiraLinha[j + 1] != '_'))
                    {
                        numerosFormatados += "7";
                    }
                    //numero 8:
                    if ((arrayPrimeiraLinha[j] != '|' && arrayPrimeiraLinha[j + 1] == '_') && (segundaLinha[j] == '|' && segundaLinha[j + 1] == '_') && (terceiraLinha[j] == '|' && terceiraLinha[j + 1] == '_'))
                    {
                        numerosFormatados += "8";
                    }
                    //numero 9:
                    if ((arrayPrimeiraLinha[j] != '|' && arrayPrimeiraLinha[j + 1] == '_') && (segundaLinha[j] == '|' && segundaLinha[j + 1] == '_') && (terceiraLinha[j] != '|' && terceiraLinha[j + 1] == '_'))
                    {
                        numerosFormatados += "9";
                    }
                    //numero 0:
                    if ((arrayPrimeiraLinha[j] != '|' && arrayPrimeiraLinha[j + 1] == '_') && (segundaLinha[j] == '|' && segundaLinha[j + 1] != '_') && (terceiraLinha[j] != '|' && terceiraLinha[j + 1] == '_'))
                    {
                        numerosFormatados += "0";
                    }
                }    
                

            }
            Console.WriteLine(numerosFormatados);
            Console.ReadLine();
        }
    }
}
