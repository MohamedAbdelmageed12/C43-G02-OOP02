using System;

namespace Assignment02OOP
{
    class Program
    {
        struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public double DistanceTo(Point other)
            {
                return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
            }
        }

        struct Rectangle
        {
            private double width;
            private double height;

            public double Width
            {
                get { return width; }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Error: Width cannot be negative.");
                    }
                    else
                    {
                        width = value;
                    }
                }
            }

            public double Height
            {
                get { return height; }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Error: Height cannot be negative.");
                    }
                    else
                    {
                        height = value;
                    }
                }
            }

            public double Area => width * height;

            public void DisplayInfo()
            {
                Console.WriteLine($"Rectangle: Width = {width}, Height = {height}, Area = {Area}");
            }
        }

        static void Main(string[] args)
        {
            #region Q1. Define a struct "Person" and display the details of three persons.
            Person[] persons = new Person[3];

            persons[0] = new Person { Name = "Mohamed", Age = 25 };
            persons[1] = new Person { Name = "Ahmed", Age = 30 };
            persons[2] = new Person { Name = "Zeyad", Age = 35 };

            Console.WriteLine("Details of persons:");
            foreach (var person in persons)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            #endregion

            #region Q2. Define a struct "Point" and calculate the distance between two points.
            Console.Write("Enter the coordinates of the first point (X Y): ");
            string[] firstPointInput = Console.ReadLine().Split(' ');
            Point point1 = new Point { X = double.Parse(firstPointInput[0]), Y = double.Parse(firstPointInput[1]) };

            Console.Write("Enter the coordinates of the second point (X Y): ");
            string[] secondPointInput = Console.ReadLine().Split(' ');
            Point point2 = new Point { X = double.Parse(secondPointInput[0]), Y = double.Parse(secondPointInput[1]) };

            Console.WriteLine($"Distance between points: {point1.DistanceTo(point2):F2}");
            #endregion

            #region Q3. Find the oldest person among three.
            Person[] personsInput = new Person[3];

            for (int i = 0; i < personsInput.Length; i++)
            {
                Console.Write($"Enter the name of person {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Enter the age of person {i + 1}: ");
                int age = int.Parse(Console.ReadLine());

                personsInput[i] = new Person { Name = name, Age = age };
            }

            Person oldest = personsInput[0];
            foreach (var person in personsInput)
            {
                if (person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }

            Console.WriteLine($"The oldest person is {oldest.Name} with {oldest.Age} years.");
            #endregion

            #region Q4. Define a struct "Rectangle" with encapsulated fields and properties.
            Rectangle rect = new Rectangle();
            Console.Write("Enter width of the rectangle: ");
            rect.Width = double.Parse(Console.ReadLine());
            Console.Write("Enter height of the rectangle: ");
            rect.Height = double.Parse(Console.ReadLine());

            rect.DisplayInfo();
            #endregion
        }
    }
}
