using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Aplus.LocalDB
{
    public class LocalRepository
    {
        SQLiteConnection database;
        public LocalRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Project>();
        }

        public IEnumerable<Project> GetProjects()
        {
            return database.Table<Project>().ToList();
        }

        public int AddProject(Project project)
        {
            if (project.Id != 0)
            {
                database.Update(project);
                return project.Id;
            }
            else
            {
                return database.Insert(project);
            }
        }

        public int DeleteProject(int id)
        {
            return database.Delete<Project>(id);
        }
    }
}
