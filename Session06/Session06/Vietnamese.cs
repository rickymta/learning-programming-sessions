namespace Session06
{
    public class Vietnamese : People
    {
        public Vietnamese(string name, string address, int age, string job) : base(name, address, age, job)
        {
        }

        public override void DisplayInformation()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("My name is " + Name);
            Console.WriteLine("I'm " + Age);
            Console.WriteLine("I'm a " + Job);
            Console.WriteLine("I live in " + Address);
            Console.WriteLine("Nice to meet you!");
        }
    }
}
