using System;
using System.IO;

namespace MaturitaGDISloupovyGraf
{
    public class TextFile
    {
        public string PrvniRadek(string cestaKSouboru)
        {
            try
            {
                using (StreamReader reader = new StreamReader(cestaKSouboru))
                {
                    return reader.ReadLine();
                }
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public void ZapisRadek(string cestaKSouboru, string upraveneNoveCislaGrafu)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(cestaKSouboru))
                {
                    writer.WriteLine(upraveneNoveCislaGrafu);
                }
            }
            catch (Exception e)
            {
               return;
            }
        }
    }
}
