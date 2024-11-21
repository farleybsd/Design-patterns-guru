using Com.Design.Patterns.Factory.Method._1.InterfacePadrao;

namespace Com.Design.Patterns.Factory.Method._2.Criadores;

// Fabrica que emcapsula as variacoes das subclasses
public abstract  class FabricaDePlanos
{
    public abstract IAssinaturas FactoryMethod();
}