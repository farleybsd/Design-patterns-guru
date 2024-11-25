using Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Interface.Softwares;
using Com.Design.Patterns.Abstract.Factory.Dominio.Softwares.Administracao;

namespace Com.Design.Patterns.Abstract.Factory._3.FamiliaDeCadaProduto.Softwares;

public class SoftwareAdministracao :ISoftwareAdministracao
{
    public MicrosoftOffice MicrosoftOffice()
    {
        return new MicrosoftOffice("MicrosoftOffice");
    }

    public SistemasErp SistemasErp()
    {
        return new SistemasErp("SistemasErp");
    }
}