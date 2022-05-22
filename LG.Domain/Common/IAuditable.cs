namespace LG.Domain.Common
{
    public interface IAuditable
    {
        string UpdatedBy { get; set; }
        DateTime UpdatedAt { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedAt { get; set; }
    }
}
