using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_2
{
    public class Room
    {
        private int _height;
        private int _length;
        private int _width;

        public int Width
        {
            get { return _width; }
            private set
            {
                if (value > 30 || value < 6)
                {
                    throw new ArgumentException("Invalid Length");
                }
                _width = value;
            }
        }

        public int Length
        {
            get { return _length; }
            private set
            {
                if (value > 30 || value < 6)
                {
                    throw new ArgumentException("Invalid Length");
                }
                _length = value;
            }
        }

        public int Height
        {
            get { return _height; }
            private set
            {
                if (value > 13 || value < 10)
                {
                    throw new ArgumentException("Invalid Height");
                }
                _height = value;
            }
        }

        public Room(int height, int length, int width)
        {
            Height = height;
            Length = length;
            Width = width;
        }

        public int CalculateRoomDimensions()
        {
            return Length * Width;
        }

        public int CalculateSurfaceAreaOfWalls()
        {
            return Height * Width;
        }

        //public int CalculateLateralSurfaceAera()
        //{
        //    return 2 * Length * Height + 2 * Width * Height;
        //}

        public override string ToString()
        {
            return string.Format($"Width: {_width}, height: {_height}, Length: {_length}");
        }
    }
}
