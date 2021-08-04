using System;
using System.Configuration;
using GerarRelatorio.Service;

namespace GerarRelatorio.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora com relatório (Estudo)";

            string origemPath = ConfigurationManager.AppSettings["Origem_Key"];
            Console.WriteLine("Iniciando...");

            VerificaDiretorios verificaDiretorios = new VerificaDiretorios();
            verificaDiretorios.Verifica();

            Calculadora calc = new Calculadora();
            calc.EntradaNumerosCalculo();
            calc.SetNum(4);
            int num = calc.GetNum();

            Console.WriteLine("Retorno get num: " + num);

            string conta = calc.GetConta();
            

            GerarTXT gerarTXT = new GerarTXT();
            gerarTXT.Escrever(conta);

            string nameFile = gerarTXT.GetNomeArq();

            MoverRelatorio movRela = new MoverRelatorio(nameFile);
            movRela.MoverTXT();
            
        }
    }
}
