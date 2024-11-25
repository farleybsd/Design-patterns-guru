namespace Com.Design.Patterns.Abstract.Factory.Dominio.Administracao;

public class TecladoAdministracao
{
    public string Modelo { get; private set; }

    public TecladoAdministracao(string modelo)
    {
        Modelo = modelo;
    }
}