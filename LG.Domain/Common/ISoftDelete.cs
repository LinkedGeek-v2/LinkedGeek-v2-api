namespace LG.Domain.Common
{
    public interface ISoftDelete
    {
        string? DeletedBy { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}
