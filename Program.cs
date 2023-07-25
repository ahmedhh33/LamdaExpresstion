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

            //Person person1 = list.First(x=>x.Address=="sohar");

            //Console.WriteLine(person1.Name);

            //Person person2 = list.FirstOrDefault(x => x.Address == "sinaw");
            //Console.WriteLine(person2?.Name??"this city is not here");



            /* Create a program that stores records of students in a list. 
             * Each student record should contain the following information:
             * Name, Age, Gender, and GPA. Implement the following tasks using LINQ:
             */
            List<Students> Studentlist = new List<Students>() {
            new Students("salim", 22, "Male", 2.3),
            new Students("salim", 23, "Male", 2.9),
            new Students("salim", 25, "Male", 1.9),
            new Students("ali", 20, "Male", 3),
            new Students("shagufta", 25, "Female", 3.4),
            new Students("Aliya", 19, "Female", 3.2),
            new Students("Fariha", 30, "Female", 2.7),
            new Students("Farzana", 35, "Female", 2.8),
            new Students("Muqeet", 20, "Male", 3.8),
            new Students("Sehar", 18, "Female", 3.5)};

            Console.WriteLine("Display the list of all students.");
            PrintList(Studentlist);
            Console.WriteLine("Filter and display male students with a GPA greater than 3.5.");
            List<Students> list1 = Studentlist.Where(r=> r.GPA>3.5 && r.Gender == "Male").ToList();
            PrintList(list1);
            Console.WriteLine("Find the average GPA of all female students.");
            //List<Students> list2 = Studentlist.Where(t=>t.Gender=="Femal").OrderBy(r=>r.GPA).ToList();
            Double FemalGPAaverage = Studentlist.Where(t => t.Gender == "Female").Average(t=>t.GPA);
            Console.WriteLine($"The average of Female GPA: {FemalGPAaverage}");

            Console.WriteLine("Display the names of the top three students with the highest GPA.");
            List<string> Top3Students = Studentlist.OrderByDescending(x => x.GPA).Take(3).Select(x => x.Name).ToList();
            foreach(string student in Top3Students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Update the GPA of a specific student.");
            string specificStudentName = "Aliya";
            Double newGPAforSpicificStudents = 3.5;
            Students SpecificStudent = Studentlist.Find(r =>  r.Name == specificStudentName);
            SpecificStudent.GPA = newGPAforSpicificStudents;

            Console.WriteLine("New list after updating Aliya GPA from 3.2 to 3.5");
            PrintList(Studentlist);

            Console.WriteLine("Remove a student from the list based on their name.");

            string removeStudent = "Sehar"; // To remove this name
            bool removed = Studentlist.Remove(Studentlist.Find(s => s.Name == removeStudent));
            if (removed)
            {
                Console.WriteLine("Removed {0} from the list", removeStudent);
                Console.WriteLine("Updated list of students:");
                PrintList(Studentlist);
            }
            else
            {
                Console.WriteLine($"No student with the name {0} found", removeStudent);
            }
        }

        public delegate int MathOperation(int a,int b);
        static int add(int a, int b) => a + b;
        static int multiply(int a, int b) => a * b;
        public static void PrintList(List<Students> students)
        {
            foreach(Students student in students)
            {
                Console.WriteLine($"Name: {student.Name} Age: {student.Age} Gender: {student.Gender} GPA: {student.GPA}");
            }
        }
        //public static double Avrage(List<Students> GPAList)
        //{
        //    double SumGPA = 0;
        //    foreach(Students student in GPAList)
        //    {
        //        SumGPA += student.GPA;
        //    }
        //    return SumGPA/ GPAList.Count;
        //}
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
    internal class Students
    {

        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double GPA { get; set; }

        // Constructor
        public Students(string name, int age, string gender, double GPA )
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.GPA = GPA;
        }
    }
}