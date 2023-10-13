namespace Session05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo 1 đối tượng (instance - thể hiện) chó
            //var age = 30;
            //var name = "HuyenPT";
            //var list = new List<string>();
            #region Ví dụ 1
            var cho = new Animal();
            // Gán giá trị cho thuộc tính "Ten" của instance "cho"
            cho.Ten = "Cun";
            // Gọi phương thức Chay()
            cho.Chay();
            // Gọi phương thức Eat()
            cho.Eat("Xuc xich");
            #endregion

            #region Ví dụ 2
            //// Gán giá trị cho thuộc tính "Ten" của instance "cho"
            //Animal.Ten = "Cun";
            //// Gọi phương thức Chay()
            //Animal.Chay();
            //// Gọi phương thức Eat()
            //Animal.Eat("Xuc xich");
            #endregion

            #region Ví dụ 3
            // Tính kế thừa
            //var golden = new Dog();
            //golden.Ten = "Milu";
            //golden.Chay();
            //golden.Eat("pate");
            #endregion

            #region Ví dụ 4
            // Tính đóng gói
            //var chihuahua = new Dog();
            //chihuahua.Ten = "Milu";
            //chihuahua.Chay();
            //chihuahua.Eat("pate");
            //chihuahua.SetTuoi(3);
            //chihuahua.HienThiTuoi();

            // private protected internal public là phạm vi truy cập
            // được gọi chung là "bổ từ truy cập" - Access Modifier
            // phạm vi truy cập:
            // private: chỉ trong chính nó
            // protected: trong chính nó và trong các class kế thừa nó
            // internal: trong phạm vi Assembly của nó
            // public: anywhere
            #endregion

            Console.ReadKey();
        }
    }
}