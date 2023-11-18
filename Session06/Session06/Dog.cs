namespace Session06
{
    public class Dog : Animal
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="food"></param>
        /// <param name="age"></param>
        public Dog(string name, string food, int age) : base(name, food, age)
        {

        }

        public void DisplayDogInformation()
        {
            Console.WriteLine("This is " + Name);
            Console.WriteLine(Name + " is " + Age);
            Console.WriteLine(Name + "'s favorite food is: " + Food);
        }
    }
}
