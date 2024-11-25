using Com.Design.Patterns.Abstract.Factory.Dominio.Administracao;

namespace Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface;

public interface IPerifericosAdministracao
{
    TecladoAdministracao teclado();
    MouseAdministracao mouse();
    MonitorAdministracao monitor();
}