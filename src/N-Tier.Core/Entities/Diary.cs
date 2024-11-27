using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;
public class Diary : BaseEntity , IAuditedEntity
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public Student? Student { get; set; }
    public string? Homework { get; set; }
    public bool IsCompleted { get; set; } //uyga vazifani tekshirish
    public string? CreateBy { get; set; }
    public DateTime? CreateOn { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? UpdateOn { get; set; }
}
