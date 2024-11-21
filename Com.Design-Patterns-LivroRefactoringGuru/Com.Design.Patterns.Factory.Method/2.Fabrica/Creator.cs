using Com.Design.Patterns.Factory.Method._1.InterfacePadrao;

namespace Com.Design.Patterns.Factory.Method._2.Criadores;

public abstract class Creator
{
    public abstract IProduct FactoryMethod();

    public string SomeOperation()
    {
        var product = FactoryMethod();
        var result = "Criador: O código do mesmo criador acabou de trabalhar com "
                     + product.Operation();

        return result;
    }
}