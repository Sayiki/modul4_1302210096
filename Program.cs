// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;

namespace modul4_1302210096;
class Program
{
    static void Main(string[] args)
    {
        KodeBuah.Buah buah = KodeBuah.Buah.Apel;
        KodeBuah.Buah buah2 = KodeBuah.Buah.Alpukat;
        String kode = KodeBuah.getKodeBuah.GetKodeBuah(buah);
        String kode2 = KodeBuah.getKodeBuah.GetKodeBuah(buah2);
        Console.WriteLine(buah + " " + kode);
        Console.WriteLine(buah2 + " " + kode2);
    }
}
