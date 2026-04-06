using carRental;

namespace CarRental.Forms
{
    /// <summary>
    /// Форма для добавления или обновления информации об автомобиле.
    /// </summary>
    public partial class AddUpdateCarForm : Form
    {
        /// <summary>
        /// Возвращает результат — автомобиль, созданный или отредактированный.
        /// </summary>
        public Car ResultCar { get; private set; }

        private Car car;
        private ErrorProvider errorProvider;

        /// <summary>
        /// Инициализирует новую форму для добавления автомобиля с пустыми полями.
        /// </summary>
        public AddUpdateCarForm()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();

            car = new Car(
                brand: "",
                stateNumber: "",
                mileageInKm: 0,
                avgFuelConsumptionPerHourInLiter: 0,
                currentFuelVolumeInLiters: 0,
                costOfRentPerMinuteInRuble: 0,
                fuelReserve: 0,
                rentalAmount: 0
            );

            BrandTextBox.DataBindings.Add("Text", car, nameof(Car.Brand));
            StateTextBox.DataBindings.Add("Text", car, nameof(Car.StateNumber));
            MileageInKmNumericUpDown.DataBindings.Add("Value", car, nameof(Car.MileageInKm));
            AvgFuelConsumptionPerHourInLiterNumericUpDown.DataBindings.Add("Value", car, nameof(Car.AvgFuelConsumptionPerHourInLiter));
            CurrentFuelVolumeInLitersNumericUpDown.DataBindings.Add("Value", car, nameof(Car.CurrentFuelVolumeInLiters));
            CostOfRentPerMinuteInRubleNumericUpDown.DataBindings.Add("Value", car, nameof(Car.CostOfRentPerMinuteInRuble));
        }

        /// <summary>
        /// Инициализирует форму для редактирования существующего автомобиля.
        /// </summary>
        /// <param name="carToEdit">Автомобиль, данные которого нужно отредактировать.</param>
        public AddUpdateCarForm(Car carToEdit) : this()
        {
            BrandTextBox.Text = carToEdit.Brand;
            StateTextBox.Text = carToEdit.StateNumber;
            MileageInKmNumericUpDown.Value = (decimal)carToEdit.MileageInKm;
            AvgFuelConsumptionPerHourInLiterNumericUpDown.Value = (decimal)carToEdit.AvgFuelConsumptionPerHourInLiter;
            CurrentFuelVolumeInLitersNumericUpDown.Value = (decimal)carToEdit.CurrentFuelVolumeInLiters;
            CostOfRentPerMinuteInRubleNumericUpDown.Value = (decimal)carToEdit.CostOfRentPerMinuteInRuble;
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки подтверждения. Выполняет валидацию введённых данных,
        /// обновляет вычисляемые поля, устанавливает результат и закрывает форму с положительным результатом.
        /// </summary>
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(car.Brand))
            {
                errorProvider.SetError(BrandTextBox, "Введите марку автомобиля");
            }
            if (string.IsNullOrWhiteSpace(car.StateNumber))
            {
                errorProvider.SetError(StateTextBox, "Введите госномер");
            }
            if (car.MileageInKm < 0)
            {
                errorProvider.SetError(MileageInKmNumericUpDown, "Пробег не может быть отрицательным");
            }
            if (car.AvgFuelConsumptionPerHourInLiter <= 0)
            {
                errorProvider.SetError(AvgFuelConsumptionPerHourInLiterNumericUpDown, "Расход должен быть > 0");
            }
            if (car.CurrentFuelVolumeInLiters < 0 || car.CurrentFuelVolumeInLiters > 100)
            {
                errorProvider.SetError(CurrentFuelVolumeInLitersNumericUpDown, "Объём топлива от 0 до 100 л");
            }
            if (car.CostOfRentPerMinuteInRuble <= 0)
            {
                errorProvider.SetError(CostOfRentPerMinuteInRubleNumericUpDown, "Стоимость аренды должна быть > 0");
            }

            car.UpdateCalculatedFields();
            ResultCar = car;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки отмены. Закрывает форму с отрицательным результатом.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}