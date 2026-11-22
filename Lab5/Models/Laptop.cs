
namespace Lab5.Models
{
    public class Laptop
    {
        public string CPU { get; set; } = "";
        public string GPU { get; set; } = "";
        public string RAM { get; set; } = "";
        public string Storage { get; set; } = "";
        public string Battery { get; set; } = "";

        public string ShowInfo()
        {
            return
                "ХАРАКТЕРИСТИКИ НОУТБУКА\n\n" +
                "Процесор: " + CPU + "\n" +
                "Відеокарта: " + GPU + "\n" +
                "Оперативна пам'ять: " + RAM + "\n" +
                "Накопичувач: " + Storage + "\n" +
                "Акумулятор: " + Battery;
        }
    }
}
