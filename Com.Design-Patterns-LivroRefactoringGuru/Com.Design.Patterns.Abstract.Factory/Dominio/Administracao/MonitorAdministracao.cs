namespace Com.Design.Patterns.Abstract.Factory.Dominio.Administracao;

public class MonitorAdministracao
{
    public string Modelo { get; private set; }

    public MonitorAdministracao(string modelo)
    {
        Modelo = modelo;
    }
}