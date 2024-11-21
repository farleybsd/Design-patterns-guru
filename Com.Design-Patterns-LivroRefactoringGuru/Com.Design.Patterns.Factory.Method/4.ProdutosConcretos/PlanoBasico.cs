using Com.Design.Patterns.Factory.Method._1.InterfacePadrao;

namespace Com.Design.Patterns.Factory.Method._4.ProdutosConcretos;

public class PlanoBasico : IAssinaturas
{
    public string TipoDePlano()
    {
        return "{Voce acabou de Assinar o Plano Basico para o Nosso Servico de Streaming }";
    }
}