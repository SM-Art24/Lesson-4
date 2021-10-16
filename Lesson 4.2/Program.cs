using System;

namespace Lesson_4._2
{
     /*                                      ________________ Вариант В ________________
        3. Четырехугольники. В сущностях (типах) хранятся координаты вершин выпуклых четырехугольников на плоскости.
        Вывести координаты вершин параллелограммов.
        Вывести координаты вершин трапеций.
        */

    class Program
    {
        //Вывод вершин заданой фигуры
        static void Output(int[] point_1, int[] point_2, int[] point_3, int[] point_4)
        { Console.Write($"({point_1[0]};{point_1[1]}) ({point_2[0]};{point_2[1]}) ({point_3[0]};{point_3[1]}) ({point_4[0]};{point_4[1]})");
        }
        //Проверка паралельности прямых
        static int FindParallelLines(int[] point_1, int[] point_2,int[] point_3, int[] point_4)
        {
            //Рассчитываем и сравнимаем угловой коэффициент
            if ((point_2[1]-point_1[1])/(point_2[0]-point_1[0]) == (point_4[1] - point_3[1])/(point_4[0] - point_3[0]))
                return 1;
          
            else
                return 0;
        }
        //Определяем тип четырёхугольника 
        static void DefinitionShape(int[] point_1, int[] point_2, int[] point_3, int[] point_4)
        {
            int NumberParallelLines = 0;//Количество паралельных прямых

            //Проверка исключений
            try
            {
                NumberParallelLines += FindParallelLines(point_1, point_2, point_3, point_4);
                NumberParallelLines += FindParallelLines(point_3, point_1, point_4, point_2);
            }
            catch (IndexOutOfRangeException )
            { Console.WriteLine("Возникла ошибка : Выход за границы массива ");
                return;
            }
            catch (DivideByZeroException )
            { Console.WriteLine("Возникла ошибка : Попытка деления на ноль ");
                return;
            }
            catch (Exception )
            { Console.WriteLine("Возникла ошибка");
                return;
            }

            
            if (NumberParallelLines == 2)
            {
                Console.Write( "\nФигура является паралелограмом. Вершины паралелограмма : ");
                Output(point_1, point_2, point_3, point_4);
            }
            else if (NumberParallelLines == 1)
            {
                Console.Write("\nФигура является трапецией. Вершины трапеции : ");
                Output(point_1, point_2, point_3, point_4);
            }
            else
            {
                Console.Write("\nФигура является криволинейным четырёхугольником ");
            }


        }
       
        static void Main(string[] args)
        {   //Задаём точки  четырехугольников 
            (int[] Point_1, int[] Point_2, int[] Point_3, int[] Point_4) shape_1 =
           (new int[] { 5, 5 }, new int[] { 5, 4 }, new int[] { 5, 2 }, new int[] { 8, 2 });
            //       1 вершина          2 вершина           3 вершина             4 вершина
            (int[] Point_1, int[] Point_2, int[] Point_3, int[] Point_4) shape_2 =
            (new int[] { 5, 4 }, new int[] { 10, 4 }, new int[] { 3, 2 }, new int[] { 8, 2 });
            
            (int[] Point_1, int[] Point_2, int[] Point_3, int[] Point_4) shape_3 =
            (new int[] { 4, 3 }, new int[] { 8, 3 }, new int[] { 3,1 }, new int[] { 9, 1 });

            //Вызываем методы для поска типов четырехугольников 
            DefinitionShape(shape_1.Point_1, shape_1.Point_2, shape_1.Point_3, shape_1.Point_4);
            DefinitionShape(shape_2.Point_1, shape_2.Point_2, shape_2.Point_3, shape_2.Point_4);
            DefinitionShape(shape_3.Point_1, shape_3.Point_2, shape_3.Point_3, shape_3.Point_4);
        }
    }
}
