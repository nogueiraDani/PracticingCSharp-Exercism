using System;
using System.Linq;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var newNameDepartment = (department ?? "OWNER").ToUpper();
        return (id != null) ? $"[{id}] - {name} - {newNameDepartment}" : $"{name} - {newNameDepartment}";
    }
}
