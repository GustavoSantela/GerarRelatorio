using System;
using System.Collections.Generic;
using System.Text;

namespace GerarRelatorio.Service
{
    public class Calculadora
    {
        private int[] numeros;
        float resultado;
        string conta;
        int contador;
        public void EntradaNumerosCalculo()
        {
            string operador;
            numeros = new int[2];
            bool vai = true;
            string resposta = "-";

            while (vai)
            {
                Console.WriteLine("Digite um número para x: ");
                numeros[0] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite um número para y: ");
                numeros[1] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o operador: ");
                operador = (Console.ReadLine());

                // int result = Calc(numeros[0], numeros[1]);

                CalcularB(numeros[0], numeros[1], operador);


                while (resposta != "nao")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Deseja Parar?/n Digite Sim/Nao");
                    Console.ForegroundColor = ConsoleColor.White;
                    resposta = Console.ReadLine();

                    if(resposta == "sim")
                        vai = false;
                    resposta = "nao";
                    
                }

                if (resposta == "nao")
                    resposta = "-";
                //           Console.WriteLine("\n\n Resolução: {0} + {1} = {2}", numeros[0], numeros[1]);

            }


        }
  /*     int Calc(int x, int y)
           {
             int result = x + y;
             return result;
           }
  */
         
        void CalcularB(float x, float y, string operador)
        {
            
          switch (operador)
            {
                case "+":
                    resultado = x + y;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case "-":
                    resultado = x - y;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case "*":
                    resultado = x * y;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
                case "/":
                    resultado = x / y;
                    Console.WriteLine("Resultado: " + resultado);
                    break;
            }

            contador++;

            conta += "\n\nConta" + contador + ":"+ " " + x.ToString() + " " + operador + " " + y + "=" + resultado + "\n\n-----";
            
                        
        }

        public string GetConta()
        {
            return conta;
        }
        
        public int GetNum()
        {
            int levaNum = numeros[0];

            return levaNum;
        }

        public void SetNum(int setaValorX)
        {
            numeros[0] = setaValorX;
        }

    }
}
