using Com.Design.Patterns.Abstract.Factory.Dominio.Desenvolvimento;

namespace Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface;

public interface IPerifericosDesenvolvimento
{
    TecladoDesenvolvimento teclado();
    MouseDesenvolvimento mouse();
    MonitorDesenvolvimento monitor();
}