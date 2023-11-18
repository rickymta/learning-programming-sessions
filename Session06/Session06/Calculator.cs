namespace Session06
{
    /// <summary>
    /// Định nghĩa class Calculator implement interface ICalculator
    /// </summary>
    public class Calculator : ICalculator
    {
        /// <summary>
        /// Override method Chia of interface ICalculator
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Chia(int a, int b)
        {
            return a / b;
        }

        /// <summary>
        /// Override method Cong of interface ICalculator
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Cong(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Override method Nhan of interface ICalculator
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Nhan(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Override method Tru of interface ICalculator
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Tru(int a, int b)
        {
            return a - b;
        }
    }
}
