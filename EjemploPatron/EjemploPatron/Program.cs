using System;

class Program
{
    static void Main(string[] args)
    {
        IPagina pagina = new Base();
        pagina = new ArialDecorator(pagina);
        pagina = new BlueDecorator(pagina);
        pagina = new CirculoDecorator(pagina);

        String computedColor = pagina.Color();
        String computedTipo = pagina.Tipografia();
        String computedFigura = pagina.Figura();

        Console.WriteLine($"Paleta de color: {computedColor}");
        Console.WriteLine($"Tipografia: {computedTipo}");
        Console.WriteLine($"Figura: {computedFigura}");
    }
}
