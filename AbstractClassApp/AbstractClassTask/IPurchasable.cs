namespace AbstractClassTask
{
    internal partial class Program
    {
        public interface IPurchasable
        {
            int Quantity { get; set; }
            void Purchase();
        }
    }
}
