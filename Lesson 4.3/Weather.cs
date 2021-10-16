using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4._3
{
    public class Weather
    {


        public Region WeatherRegion { get; set; }
        public DateTime Date { get; set; }
        public int Temperature { get; set; }
        public string Precipitation { get; set; }


        public Weather()
        {

        }

        public Weather(Region weather_region, DateTime date, int temperature, string precipitation)
        {
            WeatherRegion = weather_region;
            Date = date;
            Temperature = temperature;
            Precipitation = precipitation;

        }


        public override string ToString()
        {
            return ($"\n ______Погода______ \n Регион: {WeatherRegion.Name}\nДата : {Date.ToLongDateString()}\nТемпература : {Temperature} градусов\nОсадки : {Precipitation}");
        }
        //Значения осадков для создания погоды
        private string[] precipitation = new string[5] { "Снег", "Дождь", "Туман", "Солнечно", "Облачно" };
        //Создание погода за последние семь дней
        private void WeatherLastSevenDays(Weather array)
        {
            Random rand = new Random();
            array.Date = array.Date.AddDays(-1);
            array.Temperature = rand.Next(-10, 10);
            array.Precipitation = precipitation[rand.Next(0, 4)];

        }

        //Сведения о погоде в заданном регионе  
        public void WeatherInPresentRegion(Weather[] array)
        {
            Console.Write("Введите заданый регион : ");
            string present_region = Console.ReadLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].WeatherRegion.Name == present_region)
                {
                    Console.WriteLine(array[i].ToString());//Вывод погоды
                }
            }
        }
        //Вывести даты, когда в заданном регионе шел снег и температура была ниже заданной отрицательной.
        public void WeatherRegionDate(Weather[] array)
        {
            Console.Write("Введите регион : ");
            string present_region = Console.ReadLine();
            Console.Write("Введите температуру : ");
            int present_temperature = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].WeatherRegion.Name == present_region && String.Compare(array[i].Precipitation, "Снег") == 0 && array[i].Temperature < present_temperature)
                {
                    Console.Write($" {array[i].Date.ToLongDateString()} - шел снег и тепература была ниже заданой ");

                }
            }

        }
        //Вывести информацию о погоде за прошедшую неделю в регионах, жители которых общаются на заданном языке.
        public void WeatherInRegionLanguage(Weather[] array)
        {
            Console.Write("Введите язык : ");
            string present_language = Console.ReadLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].WeatherRegion.inregion.Language == present_language)
                {

                    Console.WriteLine(array[i].ToString());
                    for (int j = 0; j < 6; j++)
                    {
                        WeatherLastSevenDays(array[i]);//Генерируем значения погоды для 6 дней
                        Console.WriteLine(array[i].ToString());//Выводим каждый день
                    }


                }
            }

        }
        //Вывести среднюю температуру за прошедшую неделю в регионах с площадью больше заданной.
        public void WeatherInRegionArea(Weather[] array)
        {
            Console.Write("Введите площадь : ");
            int area = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].WeatherRegion.area > area)//Сравниваем площадь
                {
                    int temperature = 0;

                    temperature += array[i].Temperature;
                    for (int j = 0; j < 6; j++)
                    {
                        WeatherLastSevenDays(array[i]);
                        temperature += array[i].Temperature;
                    }
                        Console.WriteLine($"Средняя температура за прошедшую неделю {temperature / 7} в регионе {array[i].WeatherRegion.Name}");
                }

            }
        }

    }
}
