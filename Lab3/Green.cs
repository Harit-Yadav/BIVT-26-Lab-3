namespace Lab3
{
    public class Green
    {
        public double Task1(int a, int b, int r, int n)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());

                double distance = (x - a) * (x - a)
                                + (y - b) * (y - b);

                if (distance <= (double)r * r)
                {
                    count++;
                }
            }

            return count;
        }
        // no olvidar el int
        public (int index, double length) Task2(int n)
        {
            int index = 0;
            double length = 0;
            double minDistance = double.MaxValue;

            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());

                double distance = Math.Sqrt(x * x + y * y); // calcular la distancia desde el origen (0,0) hasta el punto (x,y)

                if (distance < minDistance)
                {
                    minDistance = distance;
                    index = i + 1;
                    length = distance;
                }
            }

            return (index, length);
        }

        public int Task3()
        {
            int count = 0;

            while (true)
            {
                string inputX = Console.ReadLine();

                if (!double.TryParse(inputX, out double x))
                {
                    break;
                }

                string inputY = Console.ReadLine();

                if (!double.TryParse(inputY, out double y))
                {
                    break;
                }

                if (x >= 0 && x <= Math.PI &&
                    y >= 0 && y <= Math.Sin(x))
                {
                    count++;
                }
            }

            return count;
        }

        public int Task4(int labs, int cw)
        {
            int score = 0;

            while (labs > 0 || cw > 0)
            {
                int mark = int.Parse(Console.ReadLine());

                if (labs > 0)
                {
                    score += mark;
                    labs--;
                }
                else
                {
                    score += 4 * mark;
                    cw--;
                }
            }

            return score;
        }

        public double Task5(int a, int b, int type)
        {
            double area = 0;

            switch (type)
            {
                case 1:
                    area = a * b;
                    break;

                case 2:
                    area = Math.PI * Math.Abs(a * a - b * b);
                    break;

                case 3:
                    if (a > 0 && b > 0 && a <= 2 * b)
                    {
                        area = a * Math.Sqrt(
                            b * b - (double)a * a / 4
                        ) / 2;
                    }
                    break;
            }

            return area;
        }
    }
}
