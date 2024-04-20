public class TrianguloDecorator: PaginaDecorator 
{
    public TrianguloDecorator(IPagina pagina) : base(pagina) { }

    public override string Figura()
    {
        return "Triangulo";
    }
}
