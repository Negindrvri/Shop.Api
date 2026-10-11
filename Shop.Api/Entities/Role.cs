namespace Shop.Api.Entities;

public class Role:BaseEntity
{
    public string Name { get; set; } = null!;
    public string DisPlayName { get; set; } = null!;
    public List<UserRole> UserRole { get; set; } = null!;
}
