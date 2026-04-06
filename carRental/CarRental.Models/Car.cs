namespace carRental
{
    public class Car
    {
        public string Brand { get; set; }
        public string StateNumber { get; set; }
        public double MileageInKm { get; set; }
        public double AvgFuelConsumptionPerHourInLiter { get; set; }
        public double CurrentFuelVolumeInLiters { get; set; }
        public double CostOfRentPerMinuteInRuble { get; set; }
        public double FuelReserve { get; set; }
        public double RentalAmount { get; set; }

        // Добавленный метод для пересчёта (будем вызывать перед сохранением)
        public void UpdateCalculatedFields()
        {
            if (AvgFuelConsumptionPerHourInLiter > 0)
            {
                FuelReserve = Math.Round(CurrentFuelVolumeInLiters / AvgFuelConsumptionPerHourInLiter, 2);
                // Сумма аренды = запас хода (часы) * стоимость аренды за минуту * 60 минут
                RentalAmount = Math.Round(FuelReserve * CostOfRentPerMinuteInRuble * 60, 2);
            }
            else
            {
                FuelReserve = 0;
                RentalAmount = 0;
            }
        }

        public Car(string brand, string stateNumber, double mileageInKm,
                   double avgFuelConsumptionPerHourInLiter, double currentFuelVolumeInLiters,
                   double costOfRentPerMinuteInRuble, double fuelReserve, double rentalAmount)
        {
            Brand = brand;
            StateNumber = stateNumber;
            MileageInKm = mileageInKm;
            AvgFuelConsumptionPerHourInLiter = avgFuelConsumptionPerHourInLiter;
            CurrentFuelVolumeInLiters = currentFuelVolumeInLiters;
            CostOfRentPerMinuteInRuble = costOfRentPerMinuteInRuble;
            FuelReserve = fuelReserve;
            RentalAmount = rentalAmount;
        }
    }
}