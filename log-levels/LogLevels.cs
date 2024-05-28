using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        string[] subs = logLine.Split(": ");
        return subs[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] subs = logLine.Split(": ");
        return subs[0].Replace("[", "").Replace("]", "").ToLower();
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";

}
