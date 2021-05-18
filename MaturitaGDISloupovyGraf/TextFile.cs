using System.IO;

namespace MaturitaGDISloupovyGraf
{
    public class TextFile
    {
        public string PrvniRadek(string cestaKSouboru)
        {
            StreamReader reader = new StreamReader(cestaKSouboru);
            return reader.ReadLine();
        }

        public void ZapisRadek(string cestaKSouboru, string upraveneNoveCislaGrafu)
        {
            StreamWriter writer = new StreamWriter(cestaKSouboru);
            writer.WriteLine(upraveneNoveCislaGrafu);
        }
    }
}
