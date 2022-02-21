using System.Collections.ObjectModel;

namespace DataTemplateUsingEnum.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Models.ProcessItem> Items { get; }

        public MainWindowViewModel()
        {
            this.Items = new ObservableCollection<Models.ProcessItem>
            {
                new Models.ProcessItem
                {
                    State = Models.State.NotStarted,
                    Name = "NotStarted"
                },
                new Models.ProcessItem
                {
                    State = Models.State.Running,
                    Name = "Running"
                },
                new Models.ProcessItem
                {
                    State = Models.State.Finished,
                    Name = "Finished"
                }
            };
        }
    }
}
