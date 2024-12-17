using AspNetUdemy.Models.LeaveTypes;

namespace AspNetUdemy.Services.LeaveTypes;

public interface ILeaveTypesService
{
    Task<List<LeaveTypeReadOnlyVM>> GetAllAsync();
    Task<T?> GetAsync<T>(int id) where T : class;
    Task Remove(int id);
    Task EditAsync(LeaveTypeEditVM model);
    Task CreateAsync(LeaveTypeCreateVM model);
    bool LeaveTypeExists(int id);
    Task<bool> CheckIfLeaveTypeNameExists(string name);
    Task<bool> CheckIfLeaveTypeNameExistsForEdit(LeaveTypeEditVM leaveTypeEdit);
}