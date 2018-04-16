using Autofac;
using DeviceHistoryRecord.Service;
using DeviceHistoryRecord.Service.Interface;
using DeviceHistoryRecord.UI.ViewModel;
using Prism.Events;

namespace DeviceHistoryRecord.UI.Startup
{
    class Bootstrapper
    {
            public IContainer Bootstrap()
            {
                var builder = new ContainerBuilder();
                builder.RegisterType<MainViewModel>().AsSelf();
                builder.RegisterType<MainWindow>().AsSelf();
                builder.RegisterType<WorkItemDataService>().As<IWorkItemDataService>();

                builder.RegisterType<EventAggregator>().As<IEventAggregator>().SingleInstance();

                return builder.Build();
            }
     }
}
