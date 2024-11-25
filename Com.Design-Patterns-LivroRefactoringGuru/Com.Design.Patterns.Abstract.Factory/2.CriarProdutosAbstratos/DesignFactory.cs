using Com.Design.Patterns.Abstract.Factory._1.FabricaDeMetodos;
using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface;
using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.ProdutosFamiliaA;

namespace Com.Design.Patterns.Abstract.Factory._2.CriarProdutosAbstratos;

public class DesignFactory:IEstacoesDetrabalhoDesinger
{
    public IPerifericosDesinger CreateEstacaoDetrabalhoDesign()
    {
        return new EstacaoPerifericosDesinger();
    }
}