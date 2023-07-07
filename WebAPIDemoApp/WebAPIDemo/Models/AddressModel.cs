
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


// Configure the HTTP request pipeline.








public class AddressModel
{
    public string Street { get; set; }
    public string Number { get; set; }
    public string ZipCode { get; set; }
    public string City { get; set; }
    public string State { get; set; }
}