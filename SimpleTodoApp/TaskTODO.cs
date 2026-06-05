using System;

namespace SimpleTodoApp
{
    public class TaskTODO
    {
        public static string RecordSeperator = "#//#";
        public static string TasksSeperator = "[TASK]";

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsChecked { get; set; }

        public TaskTODO(string title, string description, bool isChecked)
        {
            Title = title;
            Description = description;
            IsChecked = isChecked;
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
        }

        public override string ToString()
        {
            return Title;
        }
    
        public string ConvertToRecord()
        {
            return string.Join(RecordSeperator, Title, Description, IsChecked.ToString());
        }
    }
}
