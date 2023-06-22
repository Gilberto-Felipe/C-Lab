namespace AbstractClassTask
{
    internal partial class Program
    {
        public class Vehicle : IPurchasable
        {
            public int VIN { get; set; }
            public string Manufacturer { get; set; }
            public string Year { get; set; }
            public string Model { get; set; }
            public int Quantity { get; set; }

            public void Purchase()
            {
                // code goes here
            }
        }
    }
}
