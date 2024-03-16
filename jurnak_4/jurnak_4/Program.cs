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
    public string getKodeBuah(string buah)
    {
        if (kodePosBuah.ContainsKey(buah))
        {
            return kodePosBuah[buah];
        }
        else
        {
            return "kode tidak ditemukan";
        }
    }

}

public class posisiKarakterGame
{
    public enum State { Berdiri, jongkok, tengkurap, terbang}
    public enum Triger { w, s, x}
    public class perubahanPosisi
    {
        public State sebelum;
        public State setelah;

        public Triger tombol;

        public perubahanPosisi(State sebelum, State setelah, Triger tombol)
        {
            this.sebelum = sebelum;
            this.setelah = setelah;
            this.tombol = tombol;
        }
        perubahanPosisi[] list =
        {
           new perubahanPosisi(State.Berdiri, State.jongkok, Triger.s),
           new perubahanPosisi(State.jongkok, State.Berdiri, Triger.w),
        };
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodeBuah kodeBuah = new KodeBuah();

        Console.WriteLine("Kode Buah dari buah apel: " + kodeBuah.getKodeBuah("Apel"));
        Console.WriteLine("Kode Buah dari buah aprikot: " + kodeBuah.getKodeBuah("aprikot"));
        Console.WriteLine("Kode Buah dari buah alpukat: " + kodeBuah.getKodeBuah("alpukat"));
        Console.WriteLine("Kode Buah dari buah pisang: " + kodeBuah.getKodeBuah("pisang"));
        Console.WriteLine("Kode Buah dari buah paprika: " + kodeBuah.getKodeBuah("paprika"));
        Console.WriteLine("Kode Buah dari buah blackberry: " + kodeBuah.getKodeBuah("blackberry"));
        Console.WriteLine("Kode Buah dari buah ceri: " + kodeBuah.getKodeBuah("ceri"));
        Console.WriteLine("Kode Buah dari buah kelapa: " + kodeBuah.getKodeBuah("kelapa"));
        Console.WriteLine("Kode Buah dari buah jagung: " + kodeBuah.getKodeBuah("jagung"));
        Console.WriteLine("Kode Buah dari buah kurma: " + kodeBuah.getKodeBuah("kurma"));
        Console.WriteLine("Kode Buah dari buah durian: " + kodeBuah.getKodeBuah("durian"));
        Console.WriteLine("Kode Buah dari buah anggur: " + kodeBuah.getKodeBuah("anggur"));
        Console.WriteLine("Kode Buah dari buah melon: " + kodeBuah.getKodeBuah("melon"));
        Console.WriteLine("Kode Buah dari buah semangka: " + kodeBuah.getKodeBuah("semangka"));
    }
}

