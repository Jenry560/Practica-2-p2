using static System.Runtime.InteropServices.JavaScript.JSType;

class Libro
{
    public string? Titulo { get; set; }
    public string? Autor { get; set; }
    public int Paginas { get; set; }

    public void mostrarInformacion()
    {
        Console.WriteLine($"Informacion del libro es titulo:{Titulo} autor: {Autor} paginas {Paginas}");
    }
}
class Persona 
{
    public string? Nombre { get; set; }
    public int edad { get; set; }
}

class Estudiante: Persona
{
    public int grado { get; set; }

    public void MostrarInformacionEstudiante()
    {
        Console.WriteLine($"Nombre: {Nombre}, edad: {edad}, grado {grado}");
    }
}
class InstrumentoMusical
{
    public virtual void  Tocar()
    {
        Console.WriteLine("tocando intrumento");
    }
}
class Guitarra: InstrumentoMusical
{
    public override void Tocar()
    {
        Console.WriteLine("tocando guitarra");
    }
}
class Piano: InstrumentoMusical
{
    public override void Tocar()
    {
        Console.WriteLine("tocando piano");
    }
}

class Program
{
    static void Main()
    {
        Libro libro = new Libro
        {
            Titulo = "Cien Años de Soledad",
            Autor = "Gabriel García Márquez",
            Paginas = 417
        };
        Estudiante estudiante = new Estudiante
        {
            Nombre = "jenry",
            edad = 15,
            grado = 8
        };
        List<InstrumentoMusical> instrumentos = new List<InstrumentoMusical>
        {
            new Guitarra(),
            new Piano()
        };

        foreach(var intrumento in instrumentos)
        {
            intrumento.Tocar();
        }

        libro.mostrarInformacion();
        estudiante.MostrarInformacionEstudiante();
    }
}
