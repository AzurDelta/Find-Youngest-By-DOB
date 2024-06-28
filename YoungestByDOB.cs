using System.Globalization;

namespace Find_Youngest_By_DOB;

public class YoungestByDOB
{
    public static string[] getYoungestDOB(string[] datesMassive)
    {
        var datetimeMasssive = new List<DateTimeOffset>();
        
        datesMassive.ToList().ForEach(d =>
        {
            datetimeMasssive.Add(DateTimeOffset.Parse(d));
        });
        
        DateTimeOffset youngest = datetimeMasssive[0];
        DateTimeOffset secondYoungest = datetimeMasssive[1];
        
        
        foreach (var date in datetimeMasssive)
        {
            if (date > youngest)
            {
                secondYoungest = youngest;
                youngest = date;
            }
        }

        if (youngest < secondYoungest)
        {
            var buffer = youngest;
            youngest = secondYoungest;
            secondYoungest = buffer;
        }
        
        var youngestOut = youngest.ToString("yyyy-MM-ddThh:mm:ss.fffZ");
        var secondYoungestOut = secondYoungest.ToString("yyyy-MM-ddThh:mm:ss.fffZ");
        return new string[] { secondYoungestOut, youngestOut };
    }
}