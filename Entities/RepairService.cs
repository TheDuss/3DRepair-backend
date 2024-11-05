namespace API.Entities
{public class RepairService
{
    public int Id { get; set; }
    public required string ServiceName { get; set; }
    public int Price { get; set; }
    public required string Description { get; set; } 
   
}
}