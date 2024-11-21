 using Com.Design.Patterns.Factory.Method._2.Criadores;
 using Com.Design.Patterns.Factory.Method._3._CriadoresConcretos;

 Console.WriteLine("App: Launched with the ConcreteCreator1.");
 ClientCode(new ConcreteCreator1());
   
 Console.WriteLine("");

 Console.WriteLine("App: Launched with the ConcreteCreator2.");


 Console.WriteLine("App: Uma empresa oferece diferentes tipos de assinaturas de streaming.");
 ClientCode(new ConcreteCreator2());
 
 Console.WriteLine("App: Plano Básico.");
 ClientFabrica(new FabricaPlanoBasico());
 
 Console.WriteLine("App: Plano Premiun.");
 ClientFabrica(new FabricaPlanoPremium());
 
 Console.WriteLine("App: Plano Familia.");
 ClientFabrica(new FabricaPlanoFamília());
 
 void ClientCode(Creator creator)
{
    Console.WriteLine("Client: I'm not aware of the creator's class," +
                      "but it still works.\n" + creator.SomeOperation());
}
 
 void ClientFabrica(FabricaDePlanos fabrica)
 {
     Console.WriteLine("Client: I'm not aware of the creator's class," +
                       "but it still works.\n" + fabrica.FactoryMethod());
 }



