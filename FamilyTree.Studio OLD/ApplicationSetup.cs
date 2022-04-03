using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Studio
{
    internal class ApplicationSetup
    {
        internal static void Setup()
        {
            CreateApplicationFolder();
            CreateDatabaseFile();
        }

        private static void CreateApplicationFolder()
        {
            var localFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var applicationName = nameof(FamilyTree);
            var applicationFolder = Path.Combine(localFolder, applicationName);

            try
            {
                ApplicationContext.ApplicationInfo.Folder = Directory.CreateDirectory(applicationFolder);
            }
            catch (Exception e)
            {
                var msg = $"Failed to create the application folder.{Environment.NewLine}{e.Message}";
                ApplicationContext.ApplicationInfo.FolderStatus = (true, msg);
                return;
            }

            if (!ApplicationContext.ApplicationInfo.Folder.Exists)
            {
                var msg = $"The application folder is missing.{Environment.NewLine}({applicationFolder})";
                ApplicationContext.ApplicationInfo.FolderStatus = (true, msg);
            }
        }

        private static void CreateDatabaseFile()
        {
            var applicationFolderPath = ApplicationContext.ApplicationInfo.Folder.FullName;
            var databaseFileName = "FamilyTreeDB.db";
            var dataBaseFilePath = Path.Combine(applicationFolderPath, databaseFileName);
            ApplicationContext.ApplicationInfo.DataBaseFile = new FileInfo(dataBaseFilePath);

            if (ApplicationContext.ApplicationInfo.DataBaseFile.Exists)
            {
                return;
            }

            try
            {
                var bytes = ApplicationResources.DefaultDatebase;
                File.WriteAllBytes(dataBaseFilePath, bytes);
                //File.Create(dataBaseFilePath).Close();
            }
            catch (Exception e)
            {
                var msg = $"Failed to create the database file.{Environment.NewLine}{e.Message}";
                ApplicationContext.ApplicationInfo.DatabaseStatus = (true, msg);
                return;
            }

            ApplicationContext.ApplicationInfo.DataBaseFile.Refresh();

            if (!ApplicationContext.ApplicationInfo.DataBaseFile.Exists)
            {
                var msg = $"The application folder is missing.{Environment.NewLine}({dataBaseFilePath})";
                ApplicationContext.ApplicationInfo.DatabaseStatus = (true, msg);

            }
        }
    }
}
