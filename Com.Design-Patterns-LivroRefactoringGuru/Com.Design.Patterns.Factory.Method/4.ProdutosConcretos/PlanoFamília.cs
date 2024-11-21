using Com.Design.Patterns.Factory.Method._1.InterfacePadrao;

namespace Com.Design.Patterns.Factory.Method._4.ProdutosConcretos;

public class PlanoFamília :IAssinaturas
{
    public string TipoDePlano()
    {
        return "{Voce acabou de Assinar o Plano Familia para o Nosso Servico de Streaming }";
    }
}