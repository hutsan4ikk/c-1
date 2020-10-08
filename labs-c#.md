 static void Main(string[] args)
        {
            string R1, R2;
            int R;
            Console.WriteLine("Введите напряжение");
            R1 = Console.ReadLine();

            Console.WriteLine("Введите силу тока");
            R2 = Console.ReadLine();

            R = Convert.ToInt32(R1)* Convert.ToInt32(R2) / Convert.ToInt32(R1) + Convert.ToInt32(R2);

            Console.WriteLine("Cопротивление = " + R);

            Console.ReadKey();
        }
        
