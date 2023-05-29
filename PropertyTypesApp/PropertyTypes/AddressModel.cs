namespace PropertyTypes
{
    public class AddressModel
    {
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string Address
        {
            get { return $"{Street}\n{ZipCode}\n{City}\n{State}"; }
        }

    }
}
