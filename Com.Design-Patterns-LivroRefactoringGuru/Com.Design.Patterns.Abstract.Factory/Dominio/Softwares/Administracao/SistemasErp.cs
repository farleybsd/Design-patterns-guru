namespace Com.Design.Patterns.Abstract.Factory.Dominio.Softwares.Administracao;

public class SistemasErp
{
    public string Nome { get; private set; }

    public SistemasErp(string nome)
    {
        Nome = nome;
    }
}