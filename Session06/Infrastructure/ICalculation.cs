namespace Infrastructure
{
    /// <summary>
    /// Define interface ICalculation
    /// </summary>
    public interface ICalculation
    {
        /// <summary>
        /// Cong: sum a + b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Cong(int a, int b);

        /// <summary>
        /// Tru: a - b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Tru(int a, int b);

        /// <summary>
        /// Nhan: a * b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Nhan(int a, int b);

        /// <summary>
        /// Chia: a / b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Chia(int a, int b);
    }
}
