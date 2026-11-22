using System;
using System.Linq;

namespace Students
{
    public class Program
    {
        private static bool Create = true;
        private static List<Students> listStudent = new List<Students>();
        private static int option;

        public static void Main()
        {
            while (Create)
            {
                Console.WriteLine(@"
                    1. Create new Student
                    2. Upload Students
                    3. Reed Students
                    4. Exit
                ");

                Console.Write("Option: ");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case (1):
                            Console.Write("Name: ");
                            string? name = Console.ReadLine();
                            Console.Write("Carnet:");
                            int carnet = Convert.ToInt32(Console.ReadLine());

                            CreateStudent(name, carnet);
                            Console.WriteLine("Estudiante creado correctamente");
                            break;

                        case (2):
                            Console.Write("Carnet: ");
                            int searchCarnet = Convert.ToInt32(Console.ReadLine());
                            UpdateStudent(searchCarnet);
                            break;

                        case (3):
                            ReadStudent();
                            break;

                        case (4):
                            Create = false;
                            break;

                        default:
                            Console.WriteLine("Opcion no válida");
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private static void CreateStudent(string _name, int _carnet)
        {
            var newStudent = new Students(_name, _carnet);

            while (true)
            {
                Console.Write("Nota ha ingresar: ");
                decimal nota = Convert.ToDecimal(Console.ReadLine());

                int a = newStudent.SetNota(nota);

                if (a == 1)
                {
                    listStudent.Add(newStudent);
                    break;
                }
            }
        }

        private static void ReadStudent()
        {
            if (!listStudent.Any())
            {
                Console.WriteLine("Aún no hay ningún Estudiante");
                return;
            }

            foreach (var item in listStudent)
            {
                Console.WriteLine($"{item.Nombre} | {item.Carnet} | {item.GetNota()}");
            }
        }

        private static void UpdateStudent(decimal _carnet)
        {
            var newStudent = listStudent
            .Where(p => p.Carnet == _carnet );

            Console.Write("Name: ");
            string? _name = Console.ReadLine();
            Console.Write("Calificacion: ");
            int _nota = Convert.ToInt32(Console.ReadLine());

            foreach(var item in newStudent)
            {

                item.Nombre = _name;
                item.SetNota(_nota);
            }
        }
    }
}