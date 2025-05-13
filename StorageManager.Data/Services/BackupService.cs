using System;
using System.IO;
using System.Text.Json;
using System.Linq;
using StorageManager.Data.Entities;
using StorageManager.Data.Repositories;

namespace StorageManager.Data.Services
{
    public class BackupService
    {
        private readonly UsersRepository _usersRepository;
        private readonly CategoriesRepository _categoriesRepository;
        private readonly ReferencesRepository _referencesRepository;
        private readonly LoggingService _loggingService;
        private readonly AlertService _alertService;

        public BackupService(
            UsersRepository usersRepository,
            CategoriesRepository categoriesRepository,
            ReferencesRepository referencesRepository,
            LoggingService loggingService,
            AlertService alertService)
        {
            _usersRepository = usersRepository;
            _categoriesRepository = categoriesRepository;
            _referencesRepository = referencesRepository;
            _loggingService = loggingService;
            _alertService = alertService;
        }

        public void CreateBackup(string backupDirectory = "Backups")
        {
            try
            {
                Directory.CreateDirectory(backupDirectory);
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                string backupFilePath = Path.Combine(backupDirectory, $"backup_{timestamp}.json");

                var backupData = new
                {
                    Users = _usersRepository.GetAll().ToList(),
                    Categories = _categoriesRepository.GetAll().ToList(),
                    References = _referencesRepository.GetAll().ToList()
                };

                string json = JsonSerializer.Serialize(backupData, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(backupFilePath, json);

                _loggingService.Log($"Backup created: {backupFilePath}", LoggingService.LogLevel.Info);
                _alertService.ShowNotification(AlertService.BackupSuccessId);
            }
            catch (Exception ex)
            {
                _loggingService.Log($"Backup failed. Error: {ex.Message}", LoggingService.LogLevel.Error);
                throw; // Re-throw to allow handling by the caller if needed.
            }
        }
    }
}