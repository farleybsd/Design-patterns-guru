using Com.Design.Patterns.Factory.Method._1.InterfacePadrao;

namespace Com.Design.Patterns.Factory.Method._4.ProdutosConcretos;
//  Regra do Plano Familia
public class PlanoFamília :IAssinaturas
{
    public string TipoDePlano()
    {
        return "{Voce acabou de Assinar o Plano Familia - Qualidade Full HD.  }";
    }
}