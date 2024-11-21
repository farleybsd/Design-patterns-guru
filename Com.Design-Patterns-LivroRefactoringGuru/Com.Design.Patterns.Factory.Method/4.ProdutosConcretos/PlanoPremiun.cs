using Com.Design.Patterns.Factory.Method._1.InterfacePadrao;

namespace Com.Design.Patterns.Factory.Method._4.ProdutosConcretos;
//  Regra do Plano Premium
public class PlanoPremiun : IAssinaturas
{
    public string TipoDePlano()
    {
        return "{Voce acabou de Assinar o Plano Premium - Qualidade 4K}";
    }
}