namespace OverrideTask
{
    internal partial class Program
    {
        public class PersonModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string FullName { get; set; }
            public override string ToString()
            {
                FullName = $"{ FirstName.ToUpper() } { LastName.ToUpper() }";
                return FullName;
            }
        }
    }
}
