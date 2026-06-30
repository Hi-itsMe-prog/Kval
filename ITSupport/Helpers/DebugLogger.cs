using System;

namespace ITSupport.Helpers
{
    /// <summary>
    /// Простой класс для вывода отладочных сообщений в консоль
    /// </summary>
    public static class DebugLogger
    {
        /// <summary>
        /// Вывод информационного сообщения
        /// </summary>
        public static void Log(string message)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            Console.WriteLine($"[{timestamp}] [INFO] {message}");
        }

        /// <summary>
        /// Вывод сообщения об ошибке
        /// </summary>
        public static void LogError(string message)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{timestamp}] [ERROR] {message}");
            Console.ResetColor();
        }

        /// <summary>
        /// Вывод сообщения об ошибке с исключением
        /// </summary>
        public static void LogError(Exception ex, string message = null)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            Console.ForegroundColor = ConsoleColor.Red;
            if (!string.IsNullOrEmpty(message))
                Console.WriteLine($"[{timestamp}] [ERROR] {message}");
            Console.WriteLine($"[{timestamp}] [ERROR] {ex.GetType().Name}: {ex.Message}");
            if (ex.StackTrace != null)
                Console.WriteLine($"[{timestamp}] [ERROR] {ex.StackTrace}");
            Console.ResetColor();
        }

        /// <summary>
        /// Вывод предупреждения
        /// </summary>
        public static void LogWarning(string message)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[{timestamp}] [WARN] {message}");
            Console.ResetColor();
        }

        /// <summary>
        /// Вывод отладочного сообщения
        /// </summary>
        public static void LogDebug(string message)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"[{timestamp}] [DEBUG] {message}");
            Console.ResetColor();
        }

        /// <summary>
        /// Вывод сообщения об успешной операции
        /// </summary>
        public static void LogSuccess(string message)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss.fff");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[{timestamp}] [SUCCESS] {message}");
            Console.ResetColor();
        }

        /// <summary>
        /// Вывод разделителя
        /// </summary>
        public static void LogSeparator()
        {
            Console.WriteLine(new string('=', 80));
        }

        /// <summary>
        /// Вывод заголовка
        /// </summary>
        public static void LogHeader(string title)
        {
            LogSeparator();
            Console.WriteLine($"  {title}");
            LogSeparator();
        }
    }
}
