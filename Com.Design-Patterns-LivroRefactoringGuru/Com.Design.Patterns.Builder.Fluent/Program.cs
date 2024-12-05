/*
 * O Builder Fluent é um padrão de design que facilita a construção de objetos complexos ao encadear chamadas de
 * métodos de forma fluida. Vou criar um exemplo simples de um objeto Car com várias propriedades.
 */

using Com.Design.Patterns.Builder.Fluent.Dominio;

var car = new Car.Builder()
    .setMake("Toyota")
    .SetModel("Corolla")
    .SetYear(2024)
    .SetColor("Red")
    .Build();

Console.WriteLine(car.ToString());