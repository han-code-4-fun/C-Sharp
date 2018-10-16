using System;


namespace AS1ProjectTeam01
{
    [Serializable()]
    public class Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public decimal EngineSize { get; set; } 
        public int Price { get; set; } 
        public string Dealer { get; set; } 
        public Car() { }
    }
}
