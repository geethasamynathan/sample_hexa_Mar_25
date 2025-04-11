# Jagged Array Real-World Example in C#

### 🔷 Scenario:
Suppose you're building a simple app for a **school**, where each class can have a **different number of students**. You want to store the names of students in each class. Since each class can have a different number of students, a **jagged array** is a perfect fit.


```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of classes: ");
        int numClasses = int.Parse(Console.ReadLine());

        // Declare the jagged array
        string[][] school = new string[numClasses][];

        for (int i = 0; i < numClasses; i++)
        {
            Console.Write($"Enter number of students in class {i + 1}: ");
            int numStudents = int.Parse(Console.ReadLine());

            school[i] = new string[numStudents]; // Initialize sub-array

            for (int j = 0; j < numStudents; j++)
            {
                Console.Write($"Enter name of student {j + 1} in class {i + 1}: ");
                school[i][j] = Console.ReadLine();
            }
        }

        Console.WriteLine("\n--- Student List ---");
        for (int i = 0; i < school.Length; i++)
        {
            Console.WriteLine($"Class {i + 1}:");
            for (int j = 0; j < school[i].Length; j++)
            {
                Console.WriteLine($"- {school[i][j]}");
            }
        }
    }
}
```


### 🧠 Explanation:
- `string[][] school` is a jagged array where:
  - Each element is an array of student names.
  - Different classes can have different numbers of students.

- User provides:
  - The number of classes.
  - The number of students in each class.
  - Names of each student.

- The outer array length is fixed (based on number of classes), but each inner array length varies based on how many students are in that class.


### 🏁 Output Sample:
```
Enter number of classes: 2
Enter number of students in class 1: 2
Enter name of student 1 in class 1: Alice
Enter name of student 2 in class 1: Bob
Enter number of students in class 2: 3
Enter name of student 1 in class 2: John
Enter name of student 2 in class 2: Sara
Enter name of student 3 in class 2: Mike

--- Student List ---
Class 1:
- Alice
- Bob
Class 2:
- John
- Sara
- Mike
```
