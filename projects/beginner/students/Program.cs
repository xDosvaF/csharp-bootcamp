using System;

namespace Students
{
    public class Program
    {
        private static bool Create = true;
        private static List<Students> listStudent = new List<Students>();

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
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case(1):
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Carnet:");
                        int carnet = Convert.ToInt32(Console.ReadLine());

                        CreateStudent(name, carnet);
                        Console.WriteLine("Estudiante creado correctamente");
                        break;
                    
                    case(3):
                        ReadStudent();
                        break;

                    case(4):
                        Create = false;
                        break;

                    default:
                        Console.WriteLine("Opcion no válida");
                        break;
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
                
                if(a == 1)
                {
                    break;
                }

                listStudent.Add(newStudent);
            }
        }

        private static void ReadStudent()
        {
            if (!listStudent.Any())
            {
                Console.WriteLine("Aún no hay ningún Estudiante");
                return;
            }

            foreach(var item in listStudent)
            {
                Console.WriteLine($"name: {item.Nombre}");
            }
        }
    }
}