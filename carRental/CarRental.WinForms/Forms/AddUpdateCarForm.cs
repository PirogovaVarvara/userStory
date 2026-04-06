using carRental;
using CarRental.WinForms.Extensions;

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

            titleLabel.Text = "Добавление машины";
        }

        /// <summary>
        /// Инициализирует форму для редактирования существующего автомобиля.
        /// </summary>
        /// <param name="carToEdit">Автомобиль, данные которого нужно отредактировать.</param>
        public AddUpdateCarForm(Car carToEdit)
        {
            InitializeComponent();
            this.car = carToEdit;

            InitializeBindings();
            titleLabel.Text = "Редактирование машины";
        }

        private void InitializeBindings()
        {
            BrandTextBox.AddBinding(x => x.Text, car, x => x.Brand, errorProvider);
            StateTextBox.AddBinding(x => x.Text, car, x => x.StateNumber, errorProvider);
            MileageInKmNumericUpDown.AddBinding(x => x.Value, car, x => x.MileageInKm, errorProvider);
            AvgFuelConsumptionPerHourInLiterNumericUpDown.AddBinding(x => x.Value, car, x => x.AvgFuelConsumptionPerHourInLiter, errorProvider);
            CurrentFuelVolumeInLitersNumericUpDown.AddBinding(x => x.Value, car, x => x.CurrentFuelVolumeInLiters, errorProvider);
            CostOfRentPerMinuteInRubleNumericUpDown.AddBinding(x => x.Value, car, x => x.CostOfRentPerMinuteInRuble, errorProvider);
            FuelReserveNumericUpDown.AddBinding(x => x.Value, car, x => x.FuelReserve, errorProvider);
            RentalAmountNumericUpDown.AddBinding(x => x.Value, car, x => x.RentalAmount, errorProvider);
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