using System;
using System.IO;
namespace FileReaderWithExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Чтение файла ===");
            while (true)
            {
                Console.Write("\nВведите путь к файлу (или 'exit'): ");
                string? input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Путь не может быть пустым");
                    continue;
                }
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;
                string path = input.Trim('"', ' ');
                try
                {
                    string content = File.ReadAllText(path);
                    Console.WriteLine("\nСодержимое файла:");
                    Console.WriteLine(content);
                    break;
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"ОШИБКА: Файл не найден. Проверьте путь.\n{ex.Message}");
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine($"ОШИБКА: Нет доступа к файлу. Возможно, файл защищён или используется.\n{ex.Message}");
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"ОШИБКА ввода-вывода: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
                }
            }
            Console.WriteLine("\nПрограмма завершена!");
            Console.ReadKey();
        }
    }
}﻿
