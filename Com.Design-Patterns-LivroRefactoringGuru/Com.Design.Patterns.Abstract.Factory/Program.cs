// The client code can work with any concrete factory class.

using Com.Design.Patterns.Abstract.Factory._1.FabricaDeMetodos;
using Com.Design.Patterns.Abstract.Factory._1.FabricaDeMetodos.Softwares;
using Com.Design.Patterns.Abstract.Factory._2.CriarProdutosAbstratos;
using Com.Design.Patterns.Abstract.Factory._2.CriarProdutosAbstratos.Software;

Console.WriteLine("Client: Testing client code with the first factory type...");
ClientMethod(new ConcreteFactory1());
Console.WriteLine();

Console.WriteLine("Client: Testing the same client code with the second factory type...");
ClientMethod(new ConcreteFactory2());

Console.WriteLine("____________________________________");
 
 Console.WriteLine("As estações de trabalho: - Design");
 ClientEstacaoDeTrabalhoDesigner(new DesignFactory());
 
 Console.WriteLine("Softwares: - Design");
 ClientSoftwareDesigner(new SoftwareDesingFactory());

 Console.WriteLine("____________________________________");
 
 Console.WriteLine("As estações de trabalho: - Desenvolvimento");
 ClientEstacaoDeTrabalhoDesemvolvimento(new DesenvolvimentoFactory());

Console.WriteLine("Softwares: - Desenvolvimento");
 ClientSoftwareDesenvolvimento(new SoftwareDessenvolvimentoFactory());
 
 Console.WriteLine("____________________________________");
 
 Console.WriteLine("As estações de trabalho: - Administracao");
 ClientEstacaoDeTrabalhoAdministracao(new AdministracaoFactory());
 Console.WriteLine("Softwares: - Administracao");
 ClientEstacaoDeSoftwareAdministracao(new SoftwareAdministracaoFactory());



 void ClientEstacaoDeTrabalhoDesigner(IEstacoesDetrabalhoDesinger factory)
 {
     var estacaodeTrabalhoDesinger = factory.CreateEstacaoDetrabalhoDesign();
     Console.WriteLine($"Montior Modelo:{estacaodeTrabalhoDesinger.monitor().Modelo}");
     Console.WriteLine($"Mouse Modelo:{estacaodeTrabalhoDesinger.mouse().Modelo}");
     Console.WriteLine($"Mouse Modelo:{estacaodeTrabalhoDesinger.teclado().Modelo}");
     
 }
 
 void ClientSoftwareDesigner(IEstacaoSoftwaresDesing factory)
 {
     var estacaodeSoftwareDesinger = factory.createSoftwaresDesign();
     Console.WriteLine($"Softwares:{estacaodeSoftwareDesinger.Photoshop().Nome}");
     Console.WriteLine($"Softwares:{estacaodeSoftwareDesinger.Illustrator().Nome}");
     
 }
 void ClientEstacaoDeTrabalhoDesemvolvimento(IEstacoesDetrabalhoDesenvolvimento factory)
 {
     var estacaodeTrabalhoDesenvolvimento = factory.CreateEstacaoDetrabalhoDesenvolvimento();
     Console.WriteLine($"Montior Modelo:{estacaodeTrabalhoDesenvolvimento.monitor().Modelo}");
     Console.WriteLine($"Mouse Modelo:{estacaodeTrabalhoDesenvolvimento.mouse().Modelo}");
     Console.WriteLine($"Mouse Modelo:{estacaodeTrabalhoDesenvolvimento.teclado().Modelo}");
     
 }
 
 void ClientSoftwareDesenvolvimento(IEstacaoEstacaoSoftwaresDesenvolvimento factory)
 {
     var estacaodeSoftwareDesenvolvimento = factory.createSoftwaresDesenvolvimento();
     Console.WriteLine($"Softwares:{estacaodeSoftwareDesenvolvimento.VisualStudio().Nome}");
     Console.WriteLine($"Softwares:{estacaodeSoftwareDesenvolvimento.Git().Nome}");
     
 }
 
 void ClientEstacaoDeTrabalhoAdministracao(IEstacaoDeTrabalhoAdministracao factory)
 {
     var estacaodeTrabalhoAdministracao = factory.CreateEstacaoDetrabalhoDAdministracao();
     Console.WriteLine($"Montior Modelo:{estacaodeTrabalhoAdministracao.monitor().Modelo}");
     Console.WriteLine($"Mouse Modelo:{estacaodeTrabalhoAdministracao.mouse().Modelo}");
     Console.WriteLine($"Mouse Modelo:{estacaodeTrabalhoAdministracao.teclado().Modelo}");
     
 }
 
 void ClientEstacaoDeSoftwareAdministracao(IEstacaoSoftwaresAdministracao factory)
 {
     var estacaodesoftwareAdministracao = factory.createSoftwareAdministracao();
     Console.WriteLine($"Softwares:{estacaodesoftwareAdministracao.MicrosoftOffice().Nome}");
     Console.WriteLine($"Softwares:{estacaodesoftwareAdministracao.SistemasErp().Nome}");
     
 }
 
 void ClientMethod(IAbstractFactory factory)
 {
     var productA = factory.CreateProductA();
     var productB = factory.CreateProductB();

     Console.WriteLine(productB.UsefulFunctionB());
     Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
 }
 
/*
 Problema: Sistema de Configuração de Estações de Trabalho Personalizadas
Uma empresa de tecnologia precisa de um sistema para configurar estações de trabalho personalizadas para seus funcionários. As estações de trabalho podem ser configuradas para diferentes departamentos (como Design, Desenvolvimento e Administração), e cada departamento exige um conjunto específico de periféricos e softwares.

Requisitos do Problema:
Configuração de Periféricos:

Cada estação de trabalho deve incluir um teclado, mouse e monitor, mas os modelos variam conforme o departamento.
Design: Teclado mecânico, mouse com alta precisão, monitor 4K.
Desenvolvimento: Teclado ergonômico, mouse padrão, monitor ultrawide.
Administração: Teclado simples, mouse básico, monitor HD.
Configuração de Softwares:

Cada estação deve incluir um conjunto de softwares específicos para o departamento:
Design: Ferramentas de edição gráfica (ex.: Photoshop, Illustrator).
Desenvolvimento: IDEs, ferramentas de controle de versão (ex.: Visual Studio, Git).
Administração: Softwares de produtividade (ex.: Microsoft Office, sistemas ERP).
Expansibilidade:

Novos departamentos podem ser adicionados no futuro, cada um com suas próprias configurações de periféricos e softwares.
Consistência:

Cada estação de trabalho deve ser configurada com periféricos e softwares que pertençam ao mesmo departamento, evitando misturas inadequadas (ex.: teclado de Design com softwares de Administração).
Por Que Usar Abstract Factory Aqui?
O padrão Abstract Factory pode ser aplicado para criar uma fábrica para cada departamento (Design, Desenvolvimento, Administração). Cada fábrica concreta será responsável por criar os periféricos e softwares adequados para o seu departamento. Isso garante que as configurações sejam consistentes e facilita a adição de novos departamentos no futuro sem modificar o código existente.

Benefícios do Abstract Factory neste caso:
Consistência: Garante que todos os itens de uma estação de trabalho (teclado, mouse, monitor, software) pertençam ao mesmo departamento.
Flexibilidade: Facilita a inclusão de novos departamentos apenas criando uma nova fábrica concreta.
Organização: Centraliza a lógica de criação de objetos relacionados (periféricos e softwares) em uma única fábrica concreta para cada departamento.
*/