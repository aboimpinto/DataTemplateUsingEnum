using ReactiveUI;

namespace DataTemplateUsingEnum.Models
{
    public class ProcessItem : ReactiveObject
    {
        private State _state;
        private string _name;

        public State State
        {
            get => this._state;
            set => this.RaiseAndSetIfChanged(ref this._state, value);
        }

        public string Name 
        { 
            get => this._name; 
            set => this.RaiseAndSetIfChanged(ref this._name, value); 
        }
    }
}
