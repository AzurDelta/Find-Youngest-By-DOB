using Find_Youngest_By_DOB;

var dateMassive = new string[]
{
    "2022-10-31T08:30:45.123Z",
    "2019-10-31T08:20:45.123Z",
    "2021-09-19T08:40:45.123Z",
    "2023-01-15T08:30:45.123Z"
};

YoungestByDOB.getYoungestDOB(dateMassive)
    .ToList()
    .ForEach(r => Console.WriteLine(r));
