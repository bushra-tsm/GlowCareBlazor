namespace GlowCareWeb.Services
{
    public class NotificationService
    {
        public event Action<string, string, int>? OnShow;
        public void Success(string message, int duration = 3000)
            => OnShow?.Invoke(message, "alert-success", duration);
        public void Error(string message, int duration = 3000)
            => OnShow?.Invoke(message, "alert-danger", duration);
        public void Warning(string message, int duration = 3000)
            => OnShow?.Invoke(message, "alert-warning", duration);
        public void Info(string message, int duration = 3000)
            => OnShow?.Invoke(message, "alert-info", duration);
    }
}