using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int c;
        do
        {
            Console.WriteLine("Chon bai tap: ");
            Console.WriteLine("0. Tao mang so nguyen va tinh tong:");
            Console.WriteLine("1. Dem so luog ki tu trog chuoi");
            Console.WriteLine("2. Tim phan tu lon nhat trong mang");
            Console.WriteLine("3. Dao nguoc chuoi");
            Console.WriteLine("4. Kiem tra mang doi xung");
            Console.WriteLine("5. Dem so lan xuat hien cua 1 ki tu trong chuoi");
            Console.WriteLine("6. Thoat");
            Console.WriteLine("Lua chon: ");
            c = int.Parse(Console.ReadLine());

            switch (c)
            {
                case 0:
                    Bai1();
                    break;
                case 1:
                    Bai2();
                    break;
                case 2:
                    Bai3();
                    break;
                case 3:
                    Bai4();
                    break;
                case 4:
                    Bai5();
                    break;
                case 5:
                    Bai6();
                    break;
                case 6:
                    Console.WriteLine("thoat chuog trinh");
                    break;
                default:
                    break;
            }
            Console.WriteLine();
        } while (c != 6);
    }
    static void Bai1()
    {
        Console.Write("nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"nhap phan tu {i}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        int sum = array.Sum();
        Console.WriteLine($"tong cac phan tu trong mang la: {sum}");
    }

    static void Bai2()
    {
        Console.Write("nhap 1 chuoi: ");
        string input = Console.ReadLine();
        int dem = input.Count(c => !char.IsWhiteSpace(c) && !char.IsPunctuation(c));
        Console.WriteLine($"so luong ki tu trong chuoi la: {dem}");

    }

    static void Bai3()
    {
        Console.Write("nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"nhap phan tu thu {i}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        int max = array.Max();
        Console.WriteLine($"phan tu lon nhat trong mang la: {max}");
    }

    static void Bai4()
    {
        Console.Write("nhap 1 chuoi: ");
        string input = Console.ReadLine();
        char[] charArr = input.ToCharArray();
        Array.Reverse(charArr);
        string reStri = new string(charArr);
        Console.WriteLine($"chuoi dao nguoc la: {reStri}");
    }
    static void Bai5()
    {
        Console.Write("nahp so luong phan tu cua mnag: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"nahp phan tu thu {i}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        bool kt = true;
        for (int i = 0; i < n / 2; i++)
        {
            if (array[i] != array[n - 1 - i])
            {
                kt = false;
                break;
            }
        }
        if (kt) { Console.WriteLine("mang doi xung"); }
        else { Console.WriteLine("mang khong doi xung"); }
    }
    static void Bai6()
    {
        Console.Write("nhap 1 chuoi: ");
        string input = Console.ReadLine();

        Console.Write("nhap ki tu can dem: ");
        char x = char.Parse(Console.ReadLine());

        int dem = input.Count(c => c == x);
        Console.WriteLine($"so lan xuat hine cua '{x}' trong chuoi la: {dem}");
    }
}