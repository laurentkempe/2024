namespace Communication
{
    public class SantaCommunicator(ChristmasRestPlan christmasRestPlan)
    {
        public string ComposeMessage(ReindeerTravelInfo reindeerTravelInfo)
        {
            var daysBeforeReturn = DaysBeforeReturn(reindeerTravelInfo.NumbersOfDaysForComingBack);
            return
                $"Dear {reindeerTravelInfo.ReindeerName}, please return from {reindeerTravelInfo.CurrentLocation} in {daysBeforeReturn} day(s) to be ready and rest before Christmas.";
        }

        public bool IsOverdue(ReindeerTravelInfo reindeerTravelInfo, ILogger logger)
        {
            if (DaysBeforeReturn(reindeerTravelInfo.NumbersOfDaysForComingBack) <= 0)
            {
                logger.Log($"Overdue for {reindeerTravelInfo.ReindeerName} located {reindeerTravelInfo.CurrentLocation}.");
                return true;
            }

            return false;
        }

        private int DaysBeforeReturn(int numbersOfDaysForComingBack) =>
            christmasRestPlan.NumberOfDaysBeforeChristmas - numbersOfDaysForComingBack - christmasRestPlan.NumberOfDaysToRest;
    }
}