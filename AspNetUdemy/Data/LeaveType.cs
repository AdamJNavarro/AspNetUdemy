namespace AspNetUdemy.Data;

public class LeaveType : BaseEntity
{
    public string Name { get; set; }
    
    public int NumOfDays { get; set; }
}