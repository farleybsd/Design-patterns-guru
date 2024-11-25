namespace Com.Design.Patterns.Abstract.Factory.Dominio;

public class MonitorDesinger 
{
    public string Modelo { get; private set; }

    public MonitorDesinger(string modelo)
    {
        Modelo = modelo;
    }
}