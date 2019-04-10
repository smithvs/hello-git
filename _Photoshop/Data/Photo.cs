
using System;

namespace MyPhotoshop
{
	public class Photo
	{
		public readonly int width;
		public readonly int height;
        private readonly Pixel[,] data;

        public Pixel this[int x, int y]
        {
            get
            {
                if (!CheckIndex(x,y))
                    throw new IndexOutOfRangeException();
                return data[x, y];
            }
            set
            {
                if (!CheckIndex(x, y))
                    throw new IndexOutOfRangeException();
                data[x, y] = value;
            }
        }

        public Photo(int width, int height)
        {
            this.width = width;
            this.height = height;
            data = new Pixel[width, height];
        }

        bool CheckIndex(int x, int y)
        {
            return (x >= 0 && x < width && y >= 0 && y < height);
        }
    }
}

