using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    public static class AnswerGenerator
    {
        private static string[] answers = new string[]
        {
            "Спроси еще раз.",
            "Не могу сразу сказать.",
            "Без сомнений.",
            "Это действительно так.",
            "Сосредоточся и спроси еще раз.",
            "Нет.",
            "Да, действительно.",
            "Я так не считаю.",
            "Именно так.",
            "Лучше не говори ничего.",
            "Плохая точка зрения.",
            "Вероятно это так.",
            "Очень сомнительно.",
            "Как я вижу, то да.",
            "Мой ответ, нет.",
            "Конечно.",
            "Да.",
            "Можете быть уверены.",
            "Хорошая точка зрения.",
            "Смутный ответ, попробуй снова."
        };


        // Метод случайной генерации ответа.
        public static string GetRandomAnswer()
        {
            return answers[new Random().Next(answers.Length)];
        }
    }
}
