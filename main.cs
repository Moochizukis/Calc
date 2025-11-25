using System;

class simpleClac
{
    static void Main(string[] args)
    {

        float a, b, hasil = 0;
        string op;

        Console.WriteLine("Kalkulator Sederhana");

        //input

        Console.Write("Masukan operator: ");
        op = Console.ReadLine();

        Console.Write("Masuka Nilai A: ");
        a = float.Parse(Console.ReadLine());

        Console.Write("Masukan Nilai B: ");
        b = float.Parse(Console.ReadLine());


        //operator
        
        

        switch (op)
        {
            case "+":
            hasil = a + b;
            break;

            case "-":
            hasil = a-b;
            break;

            case "*":
            hasil = a*b;
            break;

            case "/":
            hasil = a/b;
            break;
        }

        Console.Write($"Jawabanya adalah: {hasil}");

            

       

    }
    

}