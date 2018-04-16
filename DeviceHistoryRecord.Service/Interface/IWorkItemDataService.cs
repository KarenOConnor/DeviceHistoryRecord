using System.Collections.Generic;
using DeviceHistoryRecord.Model;

namespace DeviceHistoryRecord.Service.Interface
{
    public interface IWorkItemDataService
    {
        IEnumerable<WorkItem> GetAll();
        WorkItem GetNextItemToScan(string SerialNumber);
    }
}