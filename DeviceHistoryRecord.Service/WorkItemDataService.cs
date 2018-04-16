using DeviceHistoryRecord.Model;
using DeviceHistoryRecord.Service.Interface;
using System.Collections.Generic;
using System.Linq;

namespace DeviceHistoryRecord.Service
{
    public class WorkItemDataService : IWorkItemDataService
    {
        public IEnumerable<WorkItem> GetAll()
        {
            yield return new WorkItem
            {
                ComponentID = 1,
                ComponentScanCode = "10054493",
                StageID = 1,
                StageName = "Stage1",
                ComponentName = "Front Panel Assembly PT00084926",
                ComponentSequence = 0,
                StageSequence = 0,
                StatusTypeID = (int)StatusTypes.Incomplete,
                WorkItemID = "35B12334"
            };

            yield return new WorkItem
            {
                ComponentID = 2,
                ComponentScanCode = "10054494",
                StageID = 1,
                StageName = "Stage1",
                ComponentName = "Front Panel Assemply PT00084928",
                ComponentSequence = 1,
                StageSequence = 0,
                StatusTypeID = (int)StatusTypes.Incomplete,
                WorkItemID = "35B12334"
            };

            yield return new WorkItem
            {
                ComponentID = 3,
                ComponentScanCode = "10054495",
                StageID = 1,
                StageName = "Stage1",
                ComponentName = "Front Panel Assemply PT00084929",
                ComponentSequence = 2,
                StageSequence = 0,
                StatusTypeID = (int)StatusTypes.Incomplete,
                WorkItemID = "35B12334"
            };
        }

        public WorkItem GetNextItemToScan(string SerialNumber)
        {
            var wis = GetAll();

            return wis.OrderBy(w => w.ComponentSequence).FirstOrDefault(w => w.StatusTypeID == (int)StatusTypes.Incomplete && w.WorkItemID == SerialNumber);
        }

    }
}
