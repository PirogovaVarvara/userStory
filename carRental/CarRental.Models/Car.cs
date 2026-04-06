namespace carRental
{
    public class Car
    {
        /// <summary>
        /// Марка автомобиля.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Государственный регистрационный номер.
        /// </summary>
        public string StateNumber { get; set; }

        /// <summary>
        /// Пробег в километрах.
        /// </summary>
        public double MileageInKm { get; set; }

        /// <summary>
        /// Средний расход топлива за час работы (литров в час).
        /// </summary>
        public double AvgFuelConsumptionPerHourInLiter { get; set; }

        /// <summary>
        /// Текущий объём топлива в баке (литры).
        /// </summary>
        public double CurrentFuelVolumeInLiters { get; set; }

        /// <summary>
        /// Стоимость аренды за минуту (рубли).
        /// </summary>
        public double CostOfRentPerMinuteInRuble { get; set; }

        /// <summary>
        /// Расчётный резерв хода (часы работы на остатке топлива).
        /// </summary>
        public double FuelReserve { get; set; }

        /// <summary>
        /// Расчётная сумма аренды (рубли), исходя из резерва хода и стоимости минуты.
        /// </summary>
        public double RentalAmount { get; set; }

        /// <summary>
        /// Пересчитывает поля <see cref="FuelReserve"/> и <see cref="RentalAmount"/> 
        /// на основе текущего расхода топлива, объёма топлива и стоимости аренды.
        /// </summary>
        public void UpdateCalculatedFields()
        {
            if (AvgFuelConsumptionPerHourInLiter > 0)
            {
                FuelReserve = Math.Round(CurrentFuelVolumeInLiters / AvgFuelConsumptionPerHourInLiter, 2);
                RentalAmount = Math.Round(FuelReserve * CostOfRentPerMinuteInRuble * 60, 2);
            }
            else
            {
                FuelReserve = 0;
                RentalAmount = 0;
            }
        }

        /// <summary>
        /// Конструктор класса <see cref="Car"/>.
        /// </summary>
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