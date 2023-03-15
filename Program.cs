// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;

namespace modul4_1302210096;
class Program
{
    static void Main(string[] args)
    {
        KodeBuah codeBuah = new KodeBuah();
        KodeBuah.Buah buah = KodeBuah.Buah.Apel;
        String kode = KodeBuah.getKodeBuah.GetKodeBuah(buah);
        Console.WriteLine(buah + " " + kode);
    }
}
