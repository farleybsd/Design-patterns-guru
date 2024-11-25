using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface;

namespace Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.ProdutosFamiliaA;

// Os produtos de concreto são criados pelas fábricas de concreto correspondentes.
public class ConcreteProductA1 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "The result of the product A1.";
    }
}