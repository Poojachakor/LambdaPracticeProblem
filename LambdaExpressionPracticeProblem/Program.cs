namespace LambdaExpressionPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>
        {
            new Student { Id = 1, Name = "Pooja Chakor", PhoneNumber = "7040613418", Address = "Panchvati Nashik", Age = 22 },
            new Student { Id = 2, Name = "Vishesh Date", PhoneNumber = "8806629072", Address = "Gondegaon Niphad", Age = 23 },
            new Student { Id = 3, Name = "Rupesh Kakad", PhoneNumber = "9226548347", Address = "Makhmlabad Nashik", Age = 25 }
        };

            Console.WriteLine("Student Details:");
            studentList.ForEach(student =>
            {
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Phone Number: {student.PhoneNumber}");
                Console.WriteLine($"Address: {student.Address}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine();
            });
        }
    }
    
}