namespace Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HienThiTen("Phuong Anh");
            //int tong = TinhToan.TinhTong(5, 3);
            //Console.WriteLine(tong);
            //string name = HienThiTenDayDu("Nghiem", "Phuong Anh");
            //HienThiTen(name);
            //int namhientai = CurrentYear();
            //Console.WriteLine(namhientai);
            var listInt = new List<int>()
            {
                12,3,5,7,9
            };

            HienThiSoChanDauTien(listInt);
            Console.ReadKey();
        }

        static void HienThiSoChanDauTien(List<int> list)
        {
            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("There is no Odd number");
        }

        static void HienThiTen(string ten)
        {
            Console.WriteLine(ten);
        }

        static string HienThiTenDayDu(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }

        static int CurrentYear()
        {
            int year = DateTime.Now.Year;
            return year;
        }
    }
}