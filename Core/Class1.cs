// 4. Core Katmanı (Genel Kullanım Yapıları)
namespace Core
{
    public static class Validator
    {
        public static bool IsValidString(string input) => !string.IsNullOrWhiteSpace(input);
    }
}