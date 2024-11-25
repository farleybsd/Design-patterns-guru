using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface;
using Com.Design.Patterns.Abstract.Factory.Dominio.Desenvolvimento;

namespace Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.ProdutosFamiliaA;

public class EstacaoPerifericosDesenvolvimento : IPerifericosDesenvolvimento
{
    public TecladoDesenvolvimento teclado()
    {
        return new TecladoDesenvolvimento("Teclado ergonômico");
    }

    public MouseDesenvolvimento mouse()
    {
        return new MouseDesenvolvimento("mouse padrão");
    }

    public MonitorDesenvolvimento monitor()
    {
        return new MonitorDesenvolvimento("monitor ultrawide");
    }
}