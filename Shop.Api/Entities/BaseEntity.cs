namespace Shop.Api.Entities;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime DateCreate {  get; set; }= DateTime.Now;
}
