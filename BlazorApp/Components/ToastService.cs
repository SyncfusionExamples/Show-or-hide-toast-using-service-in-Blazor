namespace BlazorApp.Components
{
    public class ToastService
    {
        public event Action<ToastOption> ToastInstance;
        public void Open(ToastOption options)
        {
            // Invoke ToastComponent to update and show the toast with messages  
            this.ToastInstance.Invoke(options);
        }
    }
}
