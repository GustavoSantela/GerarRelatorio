using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace GerarRelatorio.Service
{
    public class VerificaDiretorios
    {
        

        public void Verifica()
        {
            Console.WriteLine("\n\nVerificando Diretorios");
            string origemPath = ConfigurationManager.AppSettings["Origem_KEY"];
            string destinoPath = ConfigurationManager.AppSettings["Destino_KEY"];

            if(Directory.Exists(origemPath))
            {
                Console.WriteLine("Pasta: {0} encontrada", origemPath);
            }
            else
            {
                Console.WriteLine("Pasta: {0} não encontra \n Criando ..... \n", origemPath);
                Directory.CreateDirectory(origemPath);
            }
            
            if (Directory.Exists(destinoPath))
            {
                Console.WriteLine("Pasta: {0} encontrada", destinoPath);
            }
            else
            {
                Console.WriteLine("Pasta: {0} não encontra \n Criando ..... \n", destinoPath);
                Directory.CreateDirectory(destinoPath);
            }



        }

        
    }
}
