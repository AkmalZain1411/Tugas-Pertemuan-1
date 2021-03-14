class Calculator
{
	 class Program
    {
        static void Main(string[] args)
        {
            
            Console.Title = "Aplikasi Calculator";
            //int a = 10;  declarasi variabel a, dengan nilai awal 10
            //int b = 6;  declarasi variabel b, dengan nilai awal 6

            Console.WriteLine("Pilih Menu Calculator : ");
            Console.WriteLine("1. Penambahan ");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine("Input nomor menu [1..4]: ");
            int pilihan = int.Parse(Console.ReadLine());
                        

            Console.WriteLine("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); //proses casting

            Console.WriteLine("Iinput nilai b = ");
            int b = int.Parse(Console.ReadLine());

            

            if ( pilihan == 1 )
            {
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (pilihan == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}  ", a, b, Pengurangan(a, b));
            }
            else if (pilihan == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} x {1} = {2} ", a, b, Perkalian(a, b));
            }
            else if (pilihan == 4)
            {
                Console.WriteLine("Hasil Pembagian {0} : {1} = {2} ", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia ");
            }

            Console.WriteLine(); // tambahkan baris
            

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;

        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    
    

    }
}
