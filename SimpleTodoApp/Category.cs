using System;
using System.Collections.Generic;
using System.IO;
using static SimpleTodoApp.TaskTODO;

namespace SimpleTodoApp
{
    public class Category
    {
        private static string _CategoriesSeperator = "#//#";

        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }

        private string ConvertToRecord()
        {
            return Name;
        }

        public static void SaveCategoriesToFile(string FilePath, List<Category> lCategories)
        {
            // TODO handle the file permissions better
            List<string> lRecords = new List<string>();

            foreach (Category category in lCategories)
            {
                lRecords.Add(category.ConvertToRecord());
            }

            string CategoriesTextToSave = string.Join(_CategoriesSeperator, lRecords);

            File.WriteAllText(FilePath, CategoriesTextToSave);
        }

        public static List<Category> LoadCategoriesFromFile(string FilePath)
        {
            if (!File.Exists(FilePath)) return null;

            string Records = File.ReadAllText(FilePath);

            if (string.IsNullOrEmpty(Records)) return null;

            string[] ArrRecords = Records.Split(new[] { _CategoriesSeperator }, StringSplitOptions.None);

            List<Category> CategoriesList = new List<Category>();

            foreach (var Record in ArrRecords)
            {
                CategoriesList.Add(new Category(Record));
            }

            return CategoriesList;
        }

        public override bool Equals(object obj)
        {
            return obj is Category category &&
                   Name == category.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
    
        public static List<TaskTODO> FilterTasks(List<TaskTODO> lTasks, Category FilterCategory)
        {
            if (FilterCategory.Name == "كل المهام")
                return lTasks;

            List<TaskTODO> lTasksFiltered = new List<TaskTODO>();

            foreach (var task in lTasks)
            {
                if (task.IsUnderCategory(FilterCategory))
                    lTasksFiltered.Add(task);
            }

            return lTasksFiltered;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
