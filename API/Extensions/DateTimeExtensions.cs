namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime date)
        {
            var today = DateTime.Now;
            var age = today.Year - date.Year;
            if (date.Date > today.AddYears(-age)) age--;

            return age;
        }
    }
}