using Com.Design.Patterns.Abstract.Factory._1.FabricaDeMetodos.Softwares;
using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface.Softwares;
using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Softwares;

namespace Com.Design.Patterns.Abstract.Factory._2.CriarProdutosAbstratos.Software;

public class SoftwareDesingFactory : IEstacaoSoftwaresDesing
{
    public ISoftwaresDesign createSoftwaresDesign()
    {
        return new SoftwaresDesing();
    }
}