namespace Session06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lập trình hướng đối tượng:
            // Object Oriented Programming
            // 4 tính chất:
            // 1. Tính kế thừa: extends (ClassA : ClassB)
            // 2. Tính đóng gói (private, protected, internal, public - access modifier)
            // 3. Tính đa hình (overload - nạp chồng, override - ghi đè)
            // 4. Tính trừu tượng (abstract - interface, abstract class)
            // Hàm khởi tạo (Constructor) - method (<> function)

            #region Example 1
            var dog = new Animal();
            dog.Name = "Milu";
            var str = dog.Eat("meat", 5, "table");
            Console.WriteLine(str);
            dog.Eat("xuc xich", 5);
            dog.Eat("xuc xich");
            #endregion

            Console.WriteLine("==========================================");

            #region Example 2
            var cho = new Dog("Milu", "xuc xich", 3);
            cho.DisplayDogInformation();
            #endregion

            Console.WriteLine("==========================================");

            #region Example 3
            var calc = new Calculator();
            var sum = calc.Cong(4, 6);
            Console.WriteLine(sum);
            #endregion

            Console.WriteLine("==========================================");

            #region Example 4
            var dat = new Vietnamese("DatDT", "Ha Noi", 30, "JQC");
            dat.DisplayName();
            dat.DisplayInformation();
            #endregion

            Console.ReadKey();
        }
    }
}