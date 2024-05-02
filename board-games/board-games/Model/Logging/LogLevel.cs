namespace board_games.Model.Logging
{
    /// <summary>
    /// Used to measure the importance of a log message. Info is the least important, while Error is the most important.
    /// </summary>
    public enum LogLevel
    {
        Info,
        Warn,
        Error
    }
}
