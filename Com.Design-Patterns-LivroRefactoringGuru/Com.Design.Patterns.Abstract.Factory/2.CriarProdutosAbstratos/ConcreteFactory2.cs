using Com.Design.Patterns.Abstract.Factory._1.FabricaDeMetodos;
using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface;
using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.ProdutosFamiliaA;
using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.ProdutosFamiliaB;

namespace Com.Design.Patterns.Abstract.Factory._2.CriarProdutosAbstratos;

//Fábricas Concretas sao  definida por uma Fábrica Abstratade criar objetos concretos que pertencem a uma única 
//variante ou família específica de produtos relacionados, seguindo o contrato definido pela fábrica abstrata.
// Resumindo vai criar os produtos que encapsula as variacoes da famila de objetos 

public class ConcreteFactory2 : IAbstractFactory
{
    public IAbstractProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public IAbstractProductB CreateProductB()
    {
        return new ConcreteProductB2();
    }
}