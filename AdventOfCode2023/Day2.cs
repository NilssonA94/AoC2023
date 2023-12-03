namespace AdventOfCode2023;
public class Day2 : Day
{
    public override long Expected1 { get; set; } = 8;
    public override long Expected2 { get; set; } = 2286;
    public override void Run()
    {
        Result1 = 0;
        Result2 = 0;

        int matchValue = 0;
        bool error = false;
        int reds = 1;
        int greens = 1;
        int blues = 1;
        int power = 0;

        foreach (var line in Input)
        {
            string[] game = line.Split(':', ';');
            foreach (var match in game)
            {
                string[] set = match.Split(',');
                foreach (var pair in set)
                {
                    string[] combo = pair.Trim().Split(' ');
                    if (combo[0] == "Game")
                    {
                        error = false;
                        reds = 1;
                        greens = 1;
                        blues = 1;
                        matchValue = int.Parse(combo[1]);
                        Result1 += matchValue;
                    }
                    else
                    {
                        int number = int.Parse(combo[0]);
                        string colour = combo[1];
                        if ((number > 12 && colour == "red") ||
                            (number > 13 && colour == "green") ||
                            (number > 14 && colour == "blue"))
                        {
                            error = true;
                        }

                        if (number > reds && colour == "red") { reds = number; }
                        if (number > greens && colour == "green") { greens = number; }
                        if (number > blues && colour == "blue") { blues = number; }

                        Console.WriteLine("reds: " + reds + " greens: " + greens + " blues: " + blues);

                        power = reds * greens * blues;
                    }
                }
            }
            if (error)
            {
                Result1 -= matchValue;
            }
            Result2 += power;
        }
    }
}