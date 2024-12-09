using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BlazorApp1.Components.Pages
{
    public partial class Todo
    {
        List<TodoItems> toDos = new List<TodoItems>();
        string newToDo = string.Empty;
        public class TodoItems
        {
            public string Title { get; set; }
            public bool IsDone { get; set; }
        }
        private void AddToDo(Microsoft.AspNetCore.Components.Web.MouseEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newToDo))
            {
                toDos.Add(new TodoItems { Title = newToDo });
                newToDo = string.Empty;
            }
        }
    }
}