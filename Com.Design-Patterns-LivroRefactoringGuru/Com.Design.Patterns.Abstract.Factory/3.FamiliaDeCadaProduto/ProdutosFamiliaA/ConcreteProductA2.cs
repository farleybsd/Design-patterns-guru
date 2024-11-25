using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface;
// Os produtos de concreto são criados pelas fábricas de concreto correspondentes.
namespace Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.ProdutosFamiliaA;

public class ConcreteProductA2 : IAbstractProductA
{
    public string UsefulFunctionA()
    {
        return "The result of the product A2.";
    }
}