namespace Example.Core.Services
{
    public interface INameService
    {
        string BuildMessage(string name, string firstname);
    }

    public class NameService : INameService
    {
        public string BuildMessage(string name, string firstname)
        {
            if (string.IsNullOrEmpty(name))
                return "What is your name?";

            if (string.IsNullOrEmpty(firstname))
                return "What is your first name?";

            return $"Hello {firstname} {name}";
        }
    }
}