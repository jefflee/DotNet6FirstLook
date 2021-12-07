namespace SampleMinimalWebApi.Model
{
    public class ToDoItem
    {
        public int Id {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
