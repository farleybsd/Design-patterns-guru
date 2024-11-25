using Com.Design.Patterns.Abstract.Factory.Dominio;

namespace Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface;

public interface IPerifericosDesinger
{
    TecladoDesigner teclado();
    MouseDesigner mouse();
    MonitorDesinger monitor();
}