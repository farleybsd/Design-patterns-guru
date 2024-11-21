using Com.Design.Patterns.Factory.Method._1.InterfacePadrao;
using Com.Design.Patterns.Factory.Method._2.Criadores;
using Com.Design.Patterns.Factory.Method._4.ProdutosConcretos;

namespace Com.Design.Patterns.Factory.Method._3._CriadoresConcretos;

public class ConcreteCreator2 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct2();
    }
}