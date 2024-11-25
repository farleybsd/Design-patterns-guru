namespace Com.Design.Patterns.Abstract.Factory.Dominio.Desenvolvimento;

public class MonitorDesenvolvimento
{
    public string Modelo { get; private set; }

    public MonitorDesenvolvimento(string modelo)
    {
        Modelo = modelo;
    }
}