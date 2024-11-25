namespace Com.Design.Patterns.Abstract.Factory.Dominio;

public class MouseDesigner 
{
    public string Modelo { get; private set; }

    public MouseDesigner(string modelo)
    {
        Modelo = modelo;
    }
}