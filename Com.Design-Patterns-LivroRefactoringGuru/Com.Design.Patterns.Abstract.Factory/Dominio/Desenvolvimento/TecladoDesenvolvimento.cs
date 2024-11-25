namespace Com.Design.Patterns.Abstract.Factory.Dominio.Desenvolvimento;

public class TecladoDesenvolvimento
{
    public string Modelo { get; private set; }

    public TecladoDesenvolvimento(string modelo)
    {
        Modelo = modelo;
    }
}