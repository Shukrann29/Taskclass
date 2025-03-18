namespace Taskclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*  Animal animal1 = new Animal();
             animal1.eat();
             Bear bear1 = new Bear { name = "palid", age = 10, Iswild = true };
             bear1.eat();
             Bird bird1 = new Bird { name = "rio", age = 2, canswim = false };
             bird1.eat();
             bird1.fly();
             Dog dog1 = new Dog { name = "dekster", age = 5, HasTail = true };
             dog1.eat();
             dog1.bark();
           */
            string name = "Shukran";
            string surname = "Suleymanli";


            string result = Formattedstring.GetFullName(name, surname);
            Console.WriteLine(result);
        
        }
    }
}
