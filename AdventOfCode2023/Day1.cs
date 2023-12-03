namespace AdventOfCode2023;
public class Day1 : Day
{
    public override long Expected1 { get; set; } = 209;
    public override long Expected2 { get; set; } = 281;
    public override void Run()
    {
        Result1 = 0;
        Result2 = 0;

        foreach (var line in Input)
        {
            string tempLine = "";
            foreach (var n in line)
            {
                if (Char.IsDigit(n))
                {
                    tempLine += n;
                }
            }
            if (tempLine.Length >= 1)
            {
                tempLine = tempLine[0].ToString() + tempLine[^1].ToString();
                Result1 += Int32.Parse(tempLine);
            }
        }

        foreach (var line in Input)
        {
            string replacedLine = line.Replace("one", "o1e")
                .Replace("two", "t2o")
                .Replace("three", "t3ree")
                .Replace("four", "f4ur")
                .Replace("five", "f5ve")
                .Replace("six", "s6x")
                .Replace("seven", "s7ven")
                .Replace("eight", "e8ght")
                .Replace("nine", "n9ne");
            string tempLine = "";
            foreach (var n in replacedLine)
            {
                if (Char.IsDigit(n))
                {
                    tempLine += n;
                }
            }
            if (tempLine.Length >= 1)
            {
                tempLine = tempLine[0].ToString() + tempLine[^1].ToString();
                Result2 += Int32.Parse(tempLine);
            }
        }
    }
}