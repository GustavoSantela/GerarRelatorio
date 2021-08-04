using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace GerarRelatorio.Service
{
    public class MoverRelatorio
    {
        string origemPath = ConfigurationManager.AppSettings["Origem_KEY"];
        string destinoPath = ConfigurationManager.AppSettings["Destino_KEY"];
        string nomeArq;

        public MoverRelatorio(string nomeArq)
        {
            this.nomeArq = nomeArq;

        }

        
        public void MoverTXT()
        {
            string arqOrigem = origemPath + nomeArq;
            string arqDestino = destinoPath + nomeArq;
            
            if(File.Exists(arqOrigem))
            {
                Console.WriteLine("Arquivo: {0} encontrado\n\n Movendo..", origemPath);
                if (File.Exists(arqOrigem))
                {
                    File.Move(arqOrigem, arqDestino);
                }                   
                               
            }
            else
            {
                Console.WriteLine("Arquivo" + arqOrigem + "Nao Encontrado");

            }
        }

    }
}
