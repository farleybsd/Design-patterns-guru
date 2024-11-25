using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface;
using Com.Design.Patterns.Abstract.Factory.Dominio.Administracao;

namespace Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.ProdutosFamiliaA;

public class EstacaoPerifericosAdministracao:IPerifericosAdministracao
{
    public TecladoAdministracao teclado()
    {
        return new TecladoAdministracao("Teclado simples");
    }

    public MouseAdministracao mouse()
    {
       return new MouseAdministracao("mouse básico");
    }

    public MonitorAdministracao monitor()
    {
        return new MonitorAdministracao("monitor HD");
    }
}