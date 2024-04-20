public class CirculoDecorator: PaginaDecorator 
{
    public CirculoDecorator(IPagina pagina) : base(pagina) { }

    public override string Figura()
    {
        return "Circulo";
    }
}
