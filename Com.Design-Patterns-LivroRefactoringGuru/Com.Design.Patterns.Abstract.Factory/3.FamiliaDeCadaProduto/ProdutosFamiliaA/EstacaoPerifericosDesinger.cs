using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface;
using Com.Design.Patterns.Abstract.Factory.Dominio;

namespace Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.ProdutosFamiliaA;

public class EstacaoPerifericosDesinger : IPerifericosDesinger
{
    public TecladoDesigner teclado()
    {
        return new TecladoDesigner("Teclado mecânico");
    }

    public MouseDesigner mouse()
    {
        return new MouseDesigner(" mouse com alta precisão");
    }

    public MonitorDesinger monitor()
    {
        return new MonitorDesinger("monitor 4K");
    }
}