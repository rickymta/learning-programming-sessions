using Session05;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ví dụ 1
            var cho = new Animal();
            // Gán giá trị cho thuộc tính "Ten" của instance "cho"
            cho.Ten = "Cun";
            // Gọi phương thức Chay()
            cho.Chay();
            // Gọi phương thức Eat()
            cho.Eat("Xuc xich");
            #endregion

            // *.exe : exe là viết tắt của execute - thực thi
            // *.dll : dll viết tắt của dynamic link library - thư viện liên kết động

            //var chihuahua = new Dog();
            //chihuahua.Ten = "Milu";
            //chihuahua.Chay();
            //chihuahua.Eat("pate");
            //chihuahua.SetTuoi(3);
            //chihuahua.HienThiTuoi();
            Console.ReadKey();
        }
    }
}