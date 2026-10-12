namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double pupilWeight = double.Parse(Console.ReadLine());
                if (pupilWeight < norma)
                {
                    milk += glass;
                }
            }
            milk /= 1000;
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if ((x > 0) && (y > 0))
                {
                    first++;
                }
                else if ((x < 0) && (y > 0))
                {
                    second++;
                }
                else if ((x < 0) && (y < 0))
                {
                    third++;
                }
                else if ((x > 0) && (y < 0))
                {
                    fourth++;
                }
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                int firstMark = int.Parse(Console.ReadLine());
                int secondtMark = int.Parse(Console.ReadLine());
                int thirdMark = int.Parse(Console.ReadLine());
                int fourthMark = int.Parse(Console.ReadLine());
                if ((firstMark > 3) && (secondtMark > 3) && (thirdMark > 3) && (fourthMark > 3))
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            int taskTime = 10; serias = 0;
            while (time < 1440)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else
                {
                    int seriasTime = int.Parse(Console.ReadLine());
                    time += seriasTime;
                    serias++;
                }
            }
            // end

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here
            switch (number)
            {
                case 1:
                    power += 10;
                    intellect -= 5;
                    if (intellect < 0)
                    {
                        intellect = 0;
                    }
                    break;
                case 2:
                    agility += 5;
                    power -= 5;
                    intellect -= 5;
                    if (power < 0)
                    {
                        power = 0;
                    }
                    if (intellect < 0)
                    {
                        intellect = 0;
                    }
                    break;
                case 3:
                    power += 10;
                    intellect -= 5;
                    if (intellect < 0)
                    {
                        intellect = 0;
                    }
                    break;
                case 4:
                    agility += 15;
                    power -= 10;
                    intellect -= 10;
                    if (intellect < 0)
                    {
                        intellect = 0;
                    }
                    if (power < 0)
                    {
                        power = 0;
                    }
                    break;
                case 5:
                    intellect += 7;
                    power -= 5;
                    if (power < 0)
                    {
                        power = 0;
                    }
                    break;
            }
            // end

            return (power, agility, intellect);
        }
    }
}