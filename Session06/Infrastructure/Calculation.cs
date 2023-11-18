namespace Infrastructure
{
    /// <summary>
    /// Define class Calculation implement interface ICalculation
    /// </summary>
    public class Calculation : ICalculation
    {
        /// <summary>
        /// Override method Chia of interface ICalculation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>result of a / b</returns>
        public int Chia(int a, int b)
        {
            return a / b;
        }

        /// <summary>
        /// Override method Cong of interface ICalculation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>result of a + b</returns>
        public int Cong(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Override method Nhan of interface ICalculation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>result of a * b</returns>
        public int Nhan(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Override method Tru of interface ICalculation
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>result of a - b</returns>
        public int Tru(int a, int b)
        {
            return a - b;
        }
    }
}
