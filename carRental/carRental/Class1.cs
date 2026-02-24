namespace carRental
{
    internal class Car
    {
        /// <summary> Марка автомобиля. </summary>
        public string Brand { get; set; }

        /// <summary> Государственный номер автомобиля. </summary>
        public string StateNumber { get; set; }

        /// <summary> Пробег автомобиля в километрах. </summary>
        public double MileageInKm { get; set; }

        /// <summary> Средний расход топлива в литрах за час. </summary>
        public double AvgFuelConsumptionPerHourInLiter { get; set; }

        /// <summary> Текущий объём топлива в баке в литрах. </summary>
        public double CurrentFuelVolumeInLiters { get; set; }

        /// <summary> Стоимость аренды за минуту в рублях. </summary>
        public double CostOfRentPerMinuteInRuble { get; set; }

        /// <summary> Запас хода топлива </summary>
        public double FuelReserve { get; set; }

        /// <summary> Сумма аренды. </summary>
        public double RentalAmount { get; set; }

        /// <summary>
        /// Инициализируем новый экземпляр автомобиля с заданными характеристиками.
        /// </summary>
        public Car(string brand, string stateNumber, double mileageInKm, double avgFuelConsumptionPerHourInLiter, double currentFuelVolumeInLiters, double costOfRentPerMinuteInRuble, double fuelReserve, double rentalAmount)
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
