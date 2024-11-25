namespace Com.Design.Patterns.Abstract.Factory.Dominio.Administracao;

public class MouseAdministracao
{
    public string Modelo { get; private set; }

    public MouseAdministracao(string modelo)
    {
        Modelo = modelo;
    }
}