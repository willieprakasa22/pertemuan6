using pertemuan_6;

internal class Program
{
    private static void Main(string[] args)
    {
        Mahasiswa mhs1 = new Mahasiswa();
        mhs1.NamaDepan = "Niken";
        mhs1.NamaBelakang = "Lismiati";
        mhs1.Nim = "22.11.4797";

        Console.WriteLine(mhs1.NamaLengkap);
        Console.WriteLine(mhs1.Nim);
        Console.ReadKey();
    }
}