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
                string content = File.ReadAllText(path);
                Console.WriteLine("\nСодержимое файла:");
                Console.WriteLine(content);
                break;
            }
            Console.WriteLine("\nПрограмма завершена!");
            Console.ReadKey();
        }
    }
}﻿
