using TransportPlan;

Random random = new Random();
int transportTypesCount = Enum.GetNames(typeof(TransportEnum)).Length;

TransportEnum[][] transport = new TransportEnum[12][];

for (int month = 1; month < 13; month++)
{
    int daysCount = DateTime.DaysInMonth(
        DateTime.Now.Year, month);
    transport[month - 1] = new TransportEnum[daysCount];
    for (int day = 1; day <= daysCount; day++)
    {
        int randomType = random.Next(transportTypesCount);
        transport[month - 1][day - 1] = (TransportEnum)randomType;
    }

}

