using System;
using Microsoft.AspNetCore.Components;

namespace Net6Server.Components
{
    public class ToastService
    {
        public event Action<ToastOptions> ToastInstance;

        public void Open(ToastOptions options)
        {
            // Invoke ToastComponent to update and show the toast with messages
            this.ToastInstance.Invoke(options);
        }
    }
}