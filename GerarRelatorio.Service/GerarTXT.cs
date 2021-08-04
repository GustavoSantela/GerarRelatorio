using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace GerarRelatorio.Service
{
    public class GerarTXT
    {
        DateTime agora = DateTime.Now;
        string ArquivoContaTXT;
        public void Escrever(string _conta)
        {
            ArquivoContaTXT = ConfigurationManager.AppSettings["Origem_KEY"] + "Calc" + agora.ToString("yyyy-MM-dd'_'HH-mm-ss") + ".txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(ArquivoContaTXT, true))
                {
                    writer.Write("Calculos dia {0}\n\n"  + DateTime.Now);
                    writer.Write("Contas:\n\n {0}", _conta);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("erro gerar txt \n exception:" + e.Message);
                throw;
            }
                       
        }
        public string GetNomeArq()
        {
            return ArquivoContaTXT;
        }
    }
}
