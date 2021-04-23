using System;

namespace MyLibrary
{
    public class MessageBuilder
    {
        public static string GetText()
        {
            var dateNow = DateTime.Now.Month;
            return dateNow switch
            {
                1 or 2 or 12 => "Сейчас зима!",
                3 or 4 or 5 => "Сейчас весна!",
                6 or 7 or 8 => "Сейчас лето!",
                9 or 10 or 11 => "Сейчас осень!",
                _ => throw new ArgumentException("Я не знаю, что сейчас за время года!)")
            };
        }
    }
}
