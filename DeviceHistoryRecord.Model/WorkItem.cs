

namespace DeviceHistoryRecord.Model
{
    public class WorkItem
    {
        public string WorkItemID { get; set; }

        public int ComponentID { get; set; }

        public int StageID { get; set; }

        public string ComponentName { get; set; }

        public string StageName { get; set; }

        public string ComponentScanCode { get; set; }

        public int StatusTypeID { get; set; }
        public int ComponentSequence { get; set; }

        public int StageSequence { get; set; }

    }
}
