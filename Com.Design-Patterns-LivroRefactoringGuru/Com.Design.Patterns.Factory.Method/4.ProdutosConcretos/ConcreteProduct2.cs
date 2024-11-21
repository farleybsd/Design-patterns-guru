using Com.Design.Patterns.Factory.Method._1.InterfacePadrao;

namespace Com.Design.Patterns.Factory.Method._4.ProdutosConcretos;

public class ConcreteProduct2 : IProduct
{
    public string Operation()
    {
        return "{Result of ConcreteProduct2}";
    }
}