namespace Session05
{
    /// <summary>
    /// Định nghĩa ra class Animal
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Tên của animal
        /// </summary>
        public string Ten { get; set; }

        /// <summary>
        /// Tuổi của animal
        /// </summary>
        protected int Tuoi { get; set; }

        /// <summary>
        /// Phương thức gọi
        /// </summary>
        private void Goi()
        {
            Console.WriteLine(Ten + " oiiiiii!");
        }

        /// <summary>
        /// Phương thức chạy
        /// Hiển thị tên của Animal đang chạy
        /// </summary>
        public void Chay()
        {
            // Gọi đến phương thức Goi();
            Goi();
            Console.WriteLine(Ten + " dang chay");
        }

        /// <summary>
        /// Phương thức ăn
        /// </summary>
        /// <param name="food">Tham số thức ăn</param>
        public void Eat(string food)
        {
            Console.WriteLine(Ten + " dang an " + food);
        }

        /// <summary>
        /// Phương thức ăn
        /// </summary>
        /// <param name="food">Tham số thức ăn</param>
        /// <param name="amount">Số lượng thức ăn</param>
        public void Eat(string food, int amount)
        {
            Console.WriteLine(Ten + " dang an " + amount + " " + food);
        }
    }
}
