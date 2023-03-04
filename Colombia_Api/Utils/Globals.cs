using System;

namespace Colombia_Api.Utils
{
    public static class Globals
    {
        public static DateTime GetFechaActual() => DateTime.UtcNow.AddHours(-5);
        public static string GetCreated() => "API";
    }
}
