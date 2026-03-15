class Program
{
    static void Main(string[] args)
    {
        KodePos kp = new KodePos();
        DoorMachine pintu = new DoorMachine();


        Console.Write("Masukkan kelurahan: ");
        string kelurahan = Console.ReadLine();

        Console.WriteLine("Kode Pos: " + kp.getKodePos(kelurahan));


        pintu.BukaPintu();
        pintu.KunciPintu();
        pintu.BukaPintu();
    }
}