using static System.Net.Mime.MediaTypeNames;

namespace FlippinganImage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] image = [[1, 1, 0], [1, 0, 1], [0, 0, 0]];


            for(int i = 0; i< image.Length; i++)
            {
                int l = 0;

                while (l <= image[i].Length - 1)
                {
                    Console.WriteLine(image[i][l]);
                    l++;
                }
            }


            int[][] result = Program.FlipAndInvertImage(image);

            for (int i = 0; i < image.Length; i++)
            {
                int l = 0;

                while (l <= image[i].Length - 1)
                {
                    Console.WriteLine(image[i][l]);
                    l++;
                }
            }

           Console.ReadLine();
        }

        public static int[][] FlipAndInvertImage(int[][] image)
        {

            for(int i = 0; i < image.Length; i++)
            {
                var l = 0;
                var r = image[i].Length - 1;

                while(l < r)
                {
                    var x = image[i][l];
                    image[i][l] = image[i][r];
                    image[i][r] = x;

                    Program.Invert(i, l, image);
                    Program.Invert(i, r, image);


                    l++;
                    r--;

                }


                if (image[0].Length % 2 > 0)
                {
                    Program.Invert(i, l, image);
                }
            }

            return image;

        }

        public static void Invert(int x, int y, int[][] image) {

            if (image[x][y] == 0)
                image[x][y] = 1;
            else
                image[x][y] = 0;

        }
    }
}
