using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public Item()
    {
      this.Categories = new HashSet<CategoryItem>();
    }

    public int ItemId { get; set; }
    public string Description { get; set; }
    public string DueDate { get; set; }
    public bool Completed { get; set; }

    public ICollection<CategoryItem> Categories { get;}
  }
}