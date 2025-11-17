namespace web_api.Models;

public class product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public product()
    {
        Id = Guid.NewGuid();
    }
}
