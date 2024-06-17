using System;
using Xunit.Sdk;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
        /*        DateTime appointmentDateTime = Convert.ToDateTime(appointmentDateDescription);

        return new DateTime(appointmentDateTime.Year, appointmentDateTime.Month, appointmentDateTime.Day, appointmentDateTime.Hour, appointmentDateTime.Minute, appointmentDateTime.Second);
        */

    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;

        /*        DateTime today = DateTime.Now;

        if (appointmentDate.Year < today.Year)
        {
            return true;
        }
        else if (appointmentDate.Year == today.Year)
        {
            if (appointmentDate.DayOfYear < today.DayOfYear)
            {
                return true;
            }
            else if (appointmentDate.DayOfYear == today.DayOfYear)
            {
                if (appointmentDate.Hour < today.Hour)
                {
                    return true;
                }
                else if (appointmentDate.Hour == today.Hour)
                {
                    if (appointmentDate.Minute < today.Minute)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
        */
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;


    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate.ToShortDateString()} {appointmentDate.ToLongTimeString()}.";


    public static DateTime AnniversaryDate() => new(DateTime.Now.Year, 9, 15);
    
}
