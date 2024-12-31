namespace Library.Models;
public class Gender
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public List<Book> Books { get; set; } = new List<Book>();
}