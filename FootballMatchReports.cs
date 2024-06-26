using System;
using System.Reflection.Metadata.Ecma335;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
            case 2:
                return "left back";
            case 3:
            case 4:
                return "center back";
            case 5:
                return "right back";
            case 6:
            case 7:
            case 8:
                return "midfielder";
            case 9:
                return "left wing";
            case 10:
                return "striker";
            case 11:
                return "right wing";
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case int:
                return $"There are {report} supporters at the match.";
            case string:
                return $"{report}";
            case Foul:
                return ((Foul)report).GetDescription();
            case Injury:
                return "Oh no! " + ((Injury)report).GetDescription() + " Medics are on the field.";
            case Incident:
                return ((Incident)report).GetDescription();
            case Manager when ((Manager)report).Club == null:
                return ((Manager)report).Name;
            case Manager:
                return ((Manager)report).Name + $" ({((Manager)report).Club})";
            default:
                throw new ArgumentException();
        }
    }
}
