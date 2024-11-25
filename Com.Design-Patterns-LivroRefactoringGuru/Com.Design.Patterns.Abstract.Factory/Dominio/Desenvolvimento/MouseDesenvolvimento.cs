namespace Com.Design.Patterns.Abstract.Factory.Dominio.Desenvolvimento;

public class MouseDesenvolvimento
{
    public string Modelo { get; private set; }

    public MouseDesenvolvimento(string modelo)
    {
        Modelo = modelo;
    }
}