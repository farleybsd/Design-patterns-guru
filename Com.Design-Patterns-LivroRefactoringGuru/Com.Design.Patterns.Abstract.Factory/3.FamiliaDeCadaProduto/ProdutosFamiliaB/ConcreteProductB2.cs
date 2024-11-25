using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface;

namespace Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.ProdutosFamiliaB;
// Os produtos de concreto são criados pelas fábricas de concreto correspondentes.
public class ConcreteProductB2 : IAbstractProductB
{
    public string UsefulFunctionB()
    {
        return "The result of the product B2.";
    }

    public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
    {
        var result = collaborator.UsefulFunctionA();

        return $"The result of the B2 collaborating with the ({result})";
    }
}