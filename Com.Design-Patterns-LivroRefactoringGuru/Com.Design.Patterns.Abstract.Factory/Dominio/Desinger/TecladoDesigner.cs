namespace Com.Design.Patterns.Abstract.Factory.Dominio;

public class TecladoDesigner
{
    public string Modelo { get; private set; }

    public TecladoDesigner(string modelo)
    {
        Modelo = modelo;
    }
}