namespace Calculations
{
    public class NameGenerator
    {
        public static string NickName = null;

        public string MakeFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
