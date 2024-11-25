using Com.Design.Patterns.Abstract.Factory._1.FabricaDeMetodos;
using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface;
using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.ProdutosFamiliaA;
using Com.Design.Patterns.Abstract.Factory.Dominio.Desenvolvimento;

namespace Com.Design.Patterns.Abstract.Factory._2.CriarProdutosAbstratos;

public class DesenvolvimentoFactory : IEstacoesDetrabalhoDesenvolvimento
{
    public IPerifericosDesenvolvimento CreateEstacaoDetrabalhoDesenvolvimento()
    {
        return new EstacaoPerifericosDesenvolvimento();
    }
}