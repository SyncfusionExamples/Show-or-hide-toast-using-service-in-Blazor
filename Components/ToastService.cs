namespace ShowOrHideToast.Components
{
    //public class ToastOption
    //{
    //    public string Title { get; set; }
    //    public string Content { get; set; }
    //}
    public class ToastService
    {
        public event Action<ToastOption> ShowToastTrigger;
        public void ShowToast(ToastOption options)
        {
            //Invoke ToastComponent to update and show the toast with messages  
            this.ShowToastTrigger.Invoke(options);
        }
    }
}
