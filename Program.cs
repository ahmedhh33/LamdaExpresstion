using System.ComponentModel;

namespace LamdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread thread = new Thread(new ThreadStart(
            //    delegate { 

            //    }));

            //Func<int,int> square = (x) => x * x;
            //int result = square(5);

            //Console.WriteLine(result);

            //Func<int,int> square = (x) => {
            //    Console.WriteLine(x);
            //    return x * x;
            //    };

            //MathOperation mathOperation = add;
            //int result = mathOperation(5, 2);
            //Console.WriteLine(result);
            //MathOperation mathOperation2 = multiply;
            //int result2 = mathOperation2(5, 2);
            //Console.WriteLine(result2);
            //something something = new something(add);

            List<Person> list = new List<Person>() {
            new Person("salim", 22, "Male", "sohar"),
            new Person("salim", 23, "Male", "sohar"),
            new Person("salim", 25, "Male", "sohar"),
            new Person("ali", 20, "Male", "muscat"),
            new Person("shagufta", 25, "Female", "muscat"),
            new Person("Aliya", 19, "Female", "sohar"),
            new Person("Fariha", 30, "Female", "muscat"),
            new Person("Farzana", 35, "Female", "salalah"),
            new Person("Muqeet", 20, "Male", "sohar"),
            new Person("Sehar", 18, "Female", "muscat")};

            //List<Person> persons =  list.Where(x => x.Age<=25).OrderBy(x => x.Name).ToList();
            //foreach (Person person in persons)
            //{
            //    Console.WriteLine(person.Name);
            //}
            //List<string> persons = list.Where(x => x.Age <= 25).OrderBy(x => x.Name).Select(x=>x.Name).ToList();
            //foreach (string person in persons)
            //{
            //    Console.WriteLine(person);
            //}

            Person person1 = list.First(x=>x.Address=="sohar");
            
            Console.WriteLine(person1.Name);

            Person person2 = list.FirstOrDefault(x => x.Address == "sinaw");
            Console.WriteLine(person2?.Name??"this city is not here");

        }

        public delegate int MathOperation(int a,int b);
        static int add(int a, int b) => a + b;
        static int multiply(int a, int b) => a * b;

    }
    internal class Person
    {

        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        // Constructor
        public Person(string name, int age, string gender, string address)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Address = address;
        }


    }
}