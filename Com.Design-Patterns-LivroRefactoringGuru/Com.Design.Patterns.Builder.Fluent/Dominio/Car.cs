namespace Com.Design.Patterns.Builder.Fluent.Dominio;

public class Car
{
    public string Make { get; private set; }
    
    public string Model { get; private set; }
    
    public int Year { get; set; }
    
    public string Color { get; private set; }
    
    private Car(){}

    public override string ToString()
    {
        return $"Car: {Make} {Model} ({Year}), Color: {Color}";
    }
    public class Builder
    {
        private readonly Car _car;

        public Builder()
        {
            _car = new Car();
        }

        public Builder setMake(string make)
        {
            _car.Make = make;
            return this; 
        }
        
        public Builder SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public Builder SetYear(int year)
        {
            _car.Year = year;
            return this;
        }

        public Builder SetColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
}