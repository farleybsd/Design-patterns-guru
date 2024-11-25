using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface.Softwares;
using Com.Design.Patterns.Abstract.Factory.Dominio.Softwares.Desenvolvimento;

namespace Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Softwares;

public class SoftwaresDesenvolvimento : ISoftwareDesenvolvimento
{
    public VisualStudio VisualStudio()
    {
        return new VisualStudio("VisualStudio");
    }

    public Git Git()
    {
        return new Git("Git");
    }
}