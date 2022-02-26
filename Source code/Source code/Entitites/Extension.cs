using System;

namespace Source_code.Entitites
{
    public static class Extension
    {
        public static string ShowDate(this DateTime dateTime)
        {
            return dateTime.ToString("dd MM yyyy");
        }
    }
}
