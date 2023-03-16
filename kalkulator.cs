



class Calulator
{
	static void Main(string[] args){
		
		Console.Title = "aplikasi kalkulator";

            Console.WriteLine("inputkan angka");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("hasil penjumlahan " + a + " + " + b + " = " + penjumlahan(a, b));
            Console.WriteLine("hasil pengurangan " + a + " - " + b + " = " + pengurangan(a, b));
            Console.WriteLine("hasil perkalian " + a + " * " + b + " = " + perkalian(a, b));
            Console.WriteLine("hasil pembagian " + a + " / " + b + " = " + pembagian(a, b));

            Console.WriteLine("\n tekan sembarang tombol untuk keluar");
            Console.ReadKey();
		
	}
	
	 static int penjumlahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
}