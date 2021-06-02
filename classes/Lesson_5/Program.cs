using System;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Structs
            Rectangle rectangle = new Rectangle();
            rectangle.shortEdge = 3;
            rectangle.longEdge = 5;
            Console.WriteLine("Class field measurement : {0}" , rectangle.fieldMeasurement());

            RectangleStruct rectangleStruct = new RectangleStruct();
            rectangleStruct.shortEdge = 4;
            rectangleStruct.longEdge =6;
            Console.WriteLine("Struct field measurement : {0}" , rectangleStruct.fieldMeasurement());
        }
    }

    class Rectangle
    {
        public int shortEdge;
        public int longEdge;

        public long fieldMeasurement()
        {
            return this.shortEdge * this.longEdge;
        }
    }

    public struct RectangleStruct
    {
        public int shortEdge;
        public int longEdge;

        public long fieldMeasurement()
        {
            return this.shortEdge * this.longEdge;
        }
    }
    
}
