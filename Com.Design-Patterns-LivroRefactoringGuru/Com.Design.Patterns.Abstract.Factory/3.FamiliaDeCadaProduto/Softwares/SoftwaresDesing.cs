using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface.Softwares;
using Com.Design.Patterns.Abstract.Factory.Dominio.Softwares.Desing;

namespace Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Softwares;

public class SoftwaresDesing : ISoftwaresDesign
{
    public Photoshop Photoshop()
    {
        return new Photoshop("Photoshop");
    }

    public Illustrator Illustrator()
    {
        return new Illustrator("Illustrator");
    }
}