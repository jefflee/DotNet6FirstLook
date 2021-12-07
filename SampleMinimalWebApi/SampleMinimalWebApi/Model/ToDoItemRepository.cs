namespace SampleMinimalWebApi.Model
{
    public class ToDoItemRepository : IToDoItemRepository
    {
        private List<ToDoItem> _toDoItems;  
        public ToDoItemRepository()
        {
            _toDoItems = new List<ToDoItem>()
            {
                new ToDoItem(){Id = 1, Title = "Get milk", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", DateCreated= DateTime.Now},
                new ToDoItem(){Id = 2, Title = "Learn Blazor", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", DateCreated= DateTime.Now},
                new ToDoItem(){Id = 3, Title = "Create an app with Blazor", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", DateCreated= DateTime.Now},
                new ToDoItem(){Id = 4, Title = "Follow C# course", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit.", DateCreated= DateTime.Now}
            };
        }

        public void CreateNewToDoItem(ToDoItem item)
        {
            int nextId = _toDoItems.Max(i => i.Id);
            item.Id = nextId +1 ;
            _toDoItems.Add(item);
        }

        public List<ToDoItem> GetAll()
        {
            return _toDoItems;
        }

        public ToDoItem GetById(int id)
        {
            return _toDoItems.FirstOrDefault(i => i.Id == id);
        }
    }
}
