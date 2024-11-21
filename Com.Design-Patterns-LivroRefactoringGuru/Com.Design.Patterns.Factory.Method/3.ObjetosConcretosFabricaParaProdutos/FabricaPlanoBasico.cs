using Com.Design.Patterns.Factory.Method._1.InterfacePadrao;
using Com.Design.Patterns.Factory.Method._2.Criadores;
using Com.Design.Patterns.Factory.Method._4.ProdutosConcretos;

namespace Com.Design.Patterns.Factory.Method._3._CriadoresConcretos;

// Fabrica que emcapsula a Regra do Plano Basico
public class FabricaPlanoBasico : FabricaDePlanos
{
    public override IAssinaturas FactoryMethod()
    {
        return new PlanoBasico();
    }
}