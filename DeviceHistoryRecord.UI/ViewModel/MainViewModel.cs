using DeviceHistoryRecord.Model;
using DeviceHistoryRecord.Service.Interface;
using System.Collections.ObjectModel;

namespace DeviceHistoryRecord.UI.ViewModel
{
    public class MainViewModel: ViewModelBase
    {
        private IWorkItemDataService _workItemDataService;
        public ObservableCollection<WorkItem> WorkItems { get; set; }

        public string WorkItemtoScan;

        public MainViewModel( IWorkItemDataService workItemDataService)
        {
            WorkItems = new ObservableCollection<WorkItem>();
            _workItemDataService = workItemDataService;
        }
   
        /// <summary>
        /// Load work items
        /// </summary>
        public void Load()
        {
            var workItems = _workItemDataService.GetAll();
            WorkItem workItemtoScan = _workItemDataService.GetNextItemToScan("35B12334");

            WorkItems.Clear();

            foreach (var workItem in workItems)
            {
                WorkItems.Add(workItem);
            }

            WorkItemtoScan = workItemtoScan.ComponentName;

        }
    

    }
}
