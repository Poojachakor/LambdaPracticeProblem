namespace LambdaExpressionPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            // Add default values to the list
            students.Add(new Student { Id = 1, Name = "Pooja Chakor", PhoneNumber = "7040613418", Address = "Panchvati Nashik", Age = 15 });
            students.Add(new Student { Id = 2, Name = "Vishesh Date", PhoneNumber = "8806629072", Address = "Gondegaon Niphad", Age = 23 });
            students.Add(new Student { Id = 3, Name = "Rupesh Kakad", PhoneNumber = "5551234567", Address = "Makhmlabad Nashik", Age = 18 });
            students.Add(new Student { Id = 4, Name = "Sakshu Sakhre", PhoneNumber = "8889990000", Address = "saikheda Niphad", Age = 14 });
            students.Add(new Student { Id = 5, Name = "Pallu Aathwale", PhoneNumber = "1112223333", Address = "haraswadi Amravati", Age = 16 });

            // Display all student details
            Console.WriteLine("All Student Details:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
            }

             //Retrieve all records from the list for age between 12 to 18 using LINQ
            var ageFilteredStudents = students.Where(student => student.Age >= 12 && student.Age <= 18);
            Console.WriteLine("\nStudents between the age of 12 and 18:");
            foreach (var student in ageFilteredStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
            }

            // Sort students data in descending order based on TotalMarks (not mentioned in the Student class)
            // Assuming you want to sort by Age in descending order
            var sortedStudents = students.OrderByDescending(student => student.Age);
            Console.WriteLine("\nStudents sorted by age in descending order:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
            }

            // Display all the student records in each address
            var studentsByAddress = students.GroupBy(student => student.Address);
            Console.WriteLine("\nStudents by Address:");
            foreach (var group in studentsByAddress)
            {
                Console.WriteLine($"Address: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Age: {student.Age}");
                }
                Console.WriteLine();
            }


            // Fetch first three students records
            var firstThreeStudents = students.Take(3);
            Console.WriteLine("\nFirst three students:");
            foreach (var student in firstThreeStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age}");
            }

            // Search for a particular student based on name using lambda expression
            var searchName = "Vishesh Date";
            var searchedStudent = students.FirstOrDefault(student => student.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (searchedStudent != null)
            {
                Console.WriteLine($"\nStudent found - Id: {searchedStudent.Id}, Name: {searchedStudent.Name}, Phone Number: {searchedStudent.PhoneNumber}, Address: {searchedStudent.Address}, Age: {searchedStudent.Age}");
            }
            else
            {
                Console.WriteLine($"\nStudent with name '{searchName}' not found.");
            }

        }


    }
}

