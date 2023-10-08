using System.ComponentModel.Design;

namespace Session04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Moi ban nhap vao ho va ten");
            //string? name = Console.ReadLine();
            //Console.WriteLine("Moi ban nhap vao tuoi");
            //int tuoi = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ten ban vua nhap la: " + name);
            //Console.WriteLine("Tuoi cua ban: " + tuoi);
            int tuoi = 0;
            string ten = "";
            string diachi = "";
            MenuCommand: // Label
            Console.WriteLine("================ MENU ================");
            Console.WriteLine("1. Nhap ho ten");
            Console.WriteLine("2. Nhap tuoi");
            Console.WriteLine("3. Nhap dia chi");
            Console.WriteLine("4. Hien thi du lieu");
            Console.WriteLine("======================================");
            Console.Write("Moi ban nhap: ");

            string input = Console.ReadLine();
            int luachon = int.Parse(input);

            switch (luachon)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Moi ban nhap vao ho ten:");
                    ten = Console.ReadLine();
                    goto MenuCommand;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Moi ban nhap tuoi: ");
                    tuoi = int.Parse(Console.ReadLine());
                    goto MenuCommand;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Moi ban nhap dia chi: ");
                    diachi = Console.ReadLine();
                    goto MenuCommand;
                default:
                    Console.Clear();
                    Console.WriteLine("Hien thi du lieu ban vua nhap");
                    Console.WriteLine("Ten cua ban la: " + ten);
                    Console.WriteLine("Tuoi cua ban la: " + tuoi);
                    Console.WriteLine("Dia chi cua ban: " + diachi);
                    break;
            }

            Console.WriteLine("Nhan phim bat ky de ket thuc");
            Console.ReadKey();
        }
    }
}