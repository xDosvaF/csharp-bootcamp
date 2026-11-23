using System;

namespace funcional
{
    public class UtilDay
    {
        // Función NO pura
        public static double DayToTomorrow(DateTime from) => (DateTime.Now - from).TotalMinutes;
    }
}