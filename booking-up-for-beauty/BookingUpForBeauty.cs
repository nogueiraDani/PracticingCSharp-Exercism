using System;
using Xunit.Sdk;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) => return DateTime.Parse(appointmentDateDescription);


    public static bool HasPassed(DateTime appointmentDate) => appointmentDate < DateTime.Now;

    public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;


    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate.ToShortDateString()} {appointmentDate.ToLongTimeString()}.";

    public static DateTime AnniversaryDate() => new(DateTime.Now.Year, 9, 15);
    
}
