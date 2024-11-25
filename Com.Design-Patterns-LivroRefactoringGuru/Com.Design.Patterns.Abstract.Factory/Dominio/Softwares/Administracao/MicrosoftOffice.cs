namespace Com.Design.Patterns.Abstract.Factory.Dominio.Softwares.Administracao;

public class MicrosoftOffice
{
    public string Nome { get; private set; }

    public MicrosoftOffice(string nome)
    {
        Nome = nome;
    }
}