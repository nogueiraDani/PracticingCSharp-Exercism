using System;
using System.Linq;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (id == null)
        {
            if (string.IsNullOrEmpty(department))
            {
                return $"{name} - OWNER";
            }
            else
            {
                return $"{name} - {department.ToUpper()}";
            }
        }
        else if (string.IsNullOrEmpty(department))
        {
            return $"[{id}] - {name} - OWNER";
        }
        else
        {
            return $"[{id}] - {name} - {department.ToUpper()}";
        }
    }
}
