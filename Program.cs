using System;

class Program
{
    static void Main(string[] args)
    {
        KodePos kp = new KodePos();

        Console.Write("Masukkan kelurahan: ");
        string kelurahan = Console.ReadLine();

        Console.WriteLine("Kode Pos: " + kp.getKodePos(kelurahan));
    }
}