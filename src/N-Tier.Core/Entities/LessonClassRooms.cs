using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;
public class LessonClassRooms : BaseEntity , IAuditedEntity
{
    public int LessonId { get; set; }
    public int ClassRoomId { get; set; }
    public string? CreateBy { get; set; }
    public DateTime? CreateOn { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? UpdateOn { get; set; }
}
