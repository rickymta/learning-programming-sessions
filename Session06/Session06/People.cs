namespace Session06
{
    public abstract class People
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }

        public string Job { get; set; }

        protected People(string name, string address, int age, string job)
        {
            Name = name;
            Address = address;
            Age = age;
            Job = job;
        }

        public abstract void DisplayInformation();

        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
    }
}
