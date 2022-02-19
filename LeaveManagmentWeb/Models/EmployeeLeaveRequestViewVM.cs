namespace LeaveManagmentWeb.Models
{
    public class EmployeeLeaveRequestViewVM 
    {
        public EmployeeLeaveRequestViewVM(List<LeaveAllocationVM> leaveAllocations, List<LeaveRequestVM> requests)
        {
            LeaveAllocations = leaveAllocations;
            LeaveRequests = requests;
        }
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
        public List<LeaveRequestVM> LeaveRequests { get; set; }

    }
}
