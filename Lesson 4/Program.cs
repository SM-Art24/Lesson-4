using System;
using System.Text;

namespace Lesson_4
{
    class Program
    {
        /*                                          Вариант А 
            Создать консольное приложение, используя тип string (StringBuilder).
            Программа принимает строку.
            По нажатию произвольной клавиши поочередно выделяет в тексте заданное слово(заданное слово вводится с клавиатуры);
            Ищет в ней глаголы и возвращает в консоль строку без глаголов.
            Для выполнения задания создать массив строк и проинициализировать его несколькими окончаниями, которые есть у глаголов, например, “ать”, “ять” и т.д.Слово из входной строки соответствует глаголу, если оно содержит одно из этих окончаний.
            Найти во входной строке слова с одинаковым основанием (совпадающие части двух и более слов, 3 буквы и более) и разбить эти слова на 3 части
            – префикс, то что стоит до основания слева,
            – основа, то что совпадает с частью другого слова,
            – окончание.
            Обратите внимание, что некоторые из этих 1,3 частей могут отсутствовать*/

       static void FindWord(string text, string word)
        { 
            string [] check_text = text.Split(' ');
           
            for (int i=0;i < check_text.Length;i++)
            {
               
                if (check_text[i].Contains(word))

                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{check_text[i]} ");
                    Console.ResetColor();

                }
                else { Console.Write($"{check_text[i]} "); }
            }
        }

        static void FindVerb(string text)
        {
            StringBuilder result = new StringBuilder ();
            string[] check_text = text.Split(' ');
            string[] check_verb = new string[] { "ать", "ять", "еть" };

            for (int i = 0; i < check_text.Length; i++)
            {
                for (int j = 0; j < check_verb.Length; j++)
                {
                    if (check_text[i].EndsWith(check_verb[j]))
                        break;

                    else if (j == check_verb.Length-1 )
                     result.Append(check_text[i] + ' '); 
                }  
                
            }
            Console.WriteLine($"\n{result}");
        }

        static void Main(string[] args)
        {
            Console.Write("Введите исходный текст : ");
            string text = new string (Console.ReadLine());
            Console.Write("Введите заданное слово : ");
            string word = new string (Console.ReadLine());
            
            
            FindWord(text, word);
            FindVerb(text);
        }
    }
}
