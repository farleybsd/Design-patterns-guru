namespace Com.Design.Patterns.Abstract.Factory.Dominio.Softwares;

public class Photoshop
{
    public string Nome { get; private set; }

    public Photoshop(string nome)
    {
        Nome = nome;
    }
}