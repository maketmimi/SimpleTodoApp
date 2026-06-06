using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SimpleTodoApp
{
    public class TaskTODO
    {
        public struct StTODOList
        {
            public uint NumberOfCheckedItems { get; set; }
            public readonly List<TaskTODO> TasksList;

            public StTODOList(uint numberOfCheckedItems, List<TaskTODO> tasksList)
            {
                NumberOfCheckedItems = numberOfCheckedItems;
                TasksList = tasksList;
            }

        }

        public static string RecordSeperator = "#//#";
        public static string TasksSeperator = "[TASK]";

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsChecked { get; set; }
        public Category category { get; set; }

        public TaskTODO(string title, string description, bool isChecked, Category category)
        {
            Title = title;
            Description = description;
            IsChecked = isChecked;
            this.category = category;
        }

        public TaskTODO(string Record)
        {
            string[] ArrTask = Record.Split(new []{"#//#"}, StringSplitOptions.None);            
            
            Title = ArrTask[0];
            Description = ArrTask[1];

            if (Boolean.TryParse(ArrTask[2], out bool result))
                IsChecked = result;
            else
                IsChecked = false;

            this.category = new Category(ArrTask[3]);
        }

        public override string ToString()
        {
            return Title;
        }
    
        private string ConvertToRecord()
        {
            return string.Join(RecordSeperator, Title, Description, IsChecked.ToString(), category.Name);
        }
    
        public static void SaveTasksToFile(string FilePath, List<TaskTODO> TasksList)
        {
            // TODO handle the file permissions better
            List<string> lRecords = new List<string>();
            
            foreach (TaskTODO task in TasksList)
            {
                lRecords.Add(task.ConvertToRecord());
            }

            string TasksTextToSave = string.Join(TaskTODO.TasksSeperator, lRecords);

            File.WriteAllText(FilePath, TasksTextToSave);
        }

        // TODO I think I should improve this 
        public static StTODOList LoadStTODOListFromFile(string FilePath)
        {
            if (!File.Exists(FilePath)) return new StTODOList(0, new List<TaskTODO>());

            string Records = File.ReadAllText(FilePath);

            if (string.IsNullOrEmpty(Records)) return new StTODOList(0, new List<TaskTODO>());

            string[] ArrRecords = Records.Split(new[] { TasksSeperator }, StringSplitOptions.None);

            List<TaskTODO> TasksList = new List<TaskTODO>();
            uint NumberOfCheckedItems = 0;

            foreach (var Record in ArrRecords)
            {
                TaskTODO task = new TaskTODO(Record);
                TasksList.Add(task);
                if (task.IsChecked)
                    NumberOfCheckedItems++;
            }

            return new StTODOList(NumberOfCheckedItems, TasksList);
        }

        public bool IsUnderCategory(Category category)
        {

            return this.category.Equals(category);

        }

    }
}
