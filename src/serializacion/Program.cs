using System;
using System.Text.Json;

public class Serializacion
{
    public static void Main(string[] args)
    {
        var Pepe = new Libro("Pepe","Esteban");

        string myJson = JsonSerializer.Serialize(Pepe);
        Console.WriteLine(myJson);

        string newPepe = @"{
            ""_Nombre"" : ""kaka"",
            ""_Autor"" : ""Pepito""
        }";

        Libro pepito = JsonSerializer.Deserialize<Libro>(newPepe);
        Console.WriteLine(pepito._Nombre);
    }
}

public class Libro
{
    public string _Nombre {get;set;}
    public string _Autor {get;set;}

    public Libro()
    {
        
    }

    public Libro(string Nombre, string Autor)
    {
        _Nombre = Nombre;
        _Autor = Autor;
    }
}