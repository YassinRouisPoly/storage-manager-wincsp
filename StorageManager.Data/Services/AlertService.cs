using DevExpress.XtraBars.ToastNotifications;
using System;

namespace StorageManager.Data.Services
{
    public class AlertService
    {
        private readonly ToastNotificationsManager _notificationsManager;

        // Predefined notification IDs (use these exact strings)
        public const string BackupSuccessId = "d4660d5c-1779-43cf-bb03-65f0672c85f8";
        public const string LowStorageWarningId = "ac0eb84c-9809-48f9-a9d2-6b2e9c869a5e";
        public const string TransferCompleteId = "5655e934-b32e-44ec-ae0e-9e482804e5df";

        public AlertService(ToastNotificationsManager notificationsManager)
        {
            _notificationsManager = notificationsManager;
        }

        // Show a notification by its ID
        public void ShowNotification(string notificationId)
        {
            _notificationsManager.ShowNotification(notificationId);
        }
    }
}