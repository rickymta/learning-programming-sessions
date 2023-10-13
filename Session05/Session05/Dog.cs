namespace Session05
{
    // 1. Khai báo class Dog extends class Animal
    // extends: Mở rộng
    // Viết lại dòng 1 class Dog "kế thừa" class Animal
    internal class Dog : Animal
    {
        public void SetTuoi(int tuoi)
        {
            Tuoi = tuoi;
        }

        public void HienThiTuoi()
        {
            Console.WriteLine(Ten + " nam nay " +  Tuoi + " tuoi");
        }

        public void AnXucXich()
        {
            string food = "xuc xich";
            int soluong = 5;
            Eat(food, soluong);
        }
    }
}
