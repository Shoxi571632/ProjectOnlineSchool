namespace N_Tier.Core.Entities;
public interface IAuditedEntity
{
    public string? CreateBy { get; set; }
    public DateTime? CreateOn { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? UpdateOn { get; set;}
}
