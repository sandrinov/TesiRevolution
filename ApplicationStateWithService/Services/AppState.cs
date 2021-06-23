using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationStateWithService.Services
{
    public class AppState
    {
        public string Message { get; private set; } = "";
        public bool Enabled { get; private set; } = false;
        public int Counter { get; private set; } = 0;

        public void UpdateMessage(ComponentBase Source, string Message)
        {
            this.Message = Message;
            NotifyStateChanged(Source, "Message");
        }
        public void UpdateEnabled(ComponentBase Source, bool Enabled)
        {
            this.Enabled = Enabled;
            NotifyStateChanged(Source, "Enabled");
        }
        public void UpdateCounter(ComponentBase Source, int Counter)
        {
            this.Counter = Counter;
            NotifyStateChanged(Source, "Counter");
        }

        public event Action<ComponentBase, string> StateChanged;

        private void NotifyStateChanged(ComponentBase Source, string Property) => StateChanged?.Invoke(Source, Property);

        //private void NotifyStateChanged(ComponentBase Source, string Property)
        //{
        //    if(StateChanged != null)
        //    {
        //        //StateChanged.Invoke(Source, Property);
        //        Delegate[] delegates = StateChanged.GetInvocationList();
        //        foreach (Delegate d in delegates)
        //        {
        //            Action<ComponentBase, string> sc = (Action<ComponentBase, string>)d;
        //            sc.Invoke(Source, Property);

        //        }
        //    }
        //}
    }
}
