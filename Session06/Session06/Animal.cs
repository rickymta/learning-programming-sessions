namespace Session06
{
    /// <summary>
    /// Animal
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Food
        /// </summary>
        public string Food { get; set; }

        /// <summary>
        /// Age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Animal()
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="food"></param>
        public Animal(string name, string food)
        {
            Name = name;
            Food = food;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="food"></param>
        /// <param name="age"></param>
        public Animal(string name, string food, int age)
        {
            Name = name;
            Food = food;
            Age = age;
        }

        /// <summary>
        /// Eat
        /// </summary>
        /// <param name="food"></param>
        public void Eat(string food)
        {
            Console.WriteLine(Name + " dang an " + food);
        }

        /// <summary>
        /// Eat
        /// </summary>
        /// <param name="food">food name</param>
        /// <param name="amount">number of food</param>
        public void Eat(string food, int amount)
        {
            Console.WriteLine(Name + " dang an " + " " +  amount + " " + food);
        }

        /// <summary>
        /// Eat
        /// </summary>
        /// <param name="food"></param>
        /// <param name="amount"></param>
        /// <param name="place"></param>
        /// <returns></returns>
        public string Eat(string food, int amount, string place)
        {
            return Name + " 's eating " + amount + " " + food + " on " + place;
        }
    }
}
