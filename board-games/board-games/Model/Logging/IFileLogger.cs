using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.Logging
{
    /// <summary>
    /// Interface for a simple logger. Method "shutDown" should always be called when the logger will no longer be used.
    /// Otherwise, log messages might be lost
    /// </summary>
    public interface IFileLogger
    {
        /// <summary>
        /// Logs a message. If the message is an info message, it is buffered and it might be lost
        /// if the logger is not shutdown properly.
        /// </summary>
        /// <param name="message">the message</param>
        /// <param name="logLevel">the importance of the message</param>
        void Log(string message, LogLevel logLevel);

        /// <summary>
        /// Shuts the logger down. Must be called when the logger isn't used anymore, otherwise info messages could be lost.
        /// </summary>
        void Shutdown();

        /// <summary>
        /// Returns the path of the file in which the logger writes its messages. 
        /// </summary>
        /// <returns>the name of the file in which the logger writes its messages</returns>
        string GetFileName();

        /// <summary>
        /// Changes the name of the file in which the logger writes its messages.
        /// </summary>
        /// <param name="newFileName">the new name of the file</param>
        void ChangeFileName(string newFileName);
    }
}
