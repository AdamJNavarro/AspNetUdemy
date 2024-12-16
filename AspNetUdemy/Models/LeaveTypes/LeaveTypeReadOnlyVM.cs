using System.ComponentModel.DataAnnotations;
namespace AspNetUdemy.Models.LeaveTypes;

public class LeaveTypeReadOnlyVM : BaseLeaveTypeVM
{
    public string Name { get; set; } = string.Empty;
        
    [Display(Name = "Maximum Allocation of Days")] 
    public int NumOfDays { get; set; }
}