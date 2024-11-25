using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface;

namespace Com.Design.Patterns.Abstract.Factory._1.FabricaDeMetodos;

// A interface Abstract Factory declara um conjunto de métodos que retornam
// diferentes produtos abstratos. Esses produtos são chamados de família 
public interface IAbstractFactory
{
    IAbstractProductA CreateProductA();
    IAbstractProductB CreateProductB();
}