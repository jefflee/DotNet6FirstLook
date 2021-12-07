namespace SampleMinimalWebApi.Model
{
    public interface IToDoItemRepository
    {
        ToDoItem GetById(int id);
        List<ToDoItem> GetAll();
        void CreateNewToDoItem(ToDoItem item);
    }
}
