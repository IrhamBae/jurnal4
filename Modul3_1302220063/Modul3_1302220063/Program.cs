using System;
public class KodeBuah
{
    private readonly Dictionary<string, string> kodePosBuah;

    public KodeBuah()
    {
        kodePosBuah = new Dictionary<string, string>()
        {
            { "Apel", "A00" },
            { "aprikot", "B00" },
            { "alpukat", "C00" },
            { "pisang", "D00" },
            { "paprika", "E00" },
            { "blackberry", "F00" },
            { "ceri", "H00" },
            { "kelapa", "I00" },
            { "jagung", "J00" },
            { "kurma", "K00" },
            { "durian", "L00" },
            { "anggur", "M00" },
            { "melon", "N00" },
            { "semangka", "O00" },
        };
    }
}

public string getKodeBuah(string buah)
{
    if (KodeBuah.ContainsKey(buah))
    {
        return KodeBuah[buah];
    }
    else
    {
        return "Buah tidak ditermukan"
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodeBuah kodeBuah = new KodeBuah();

        Console.WriteLine("kode pos");
    }
}