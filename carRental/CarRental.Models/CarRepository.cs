using System.ComponentModel;

namespace carRental.DAL
{
    /// <summary>
    /// Репозиторий для хранения и управления списком автомобилей.
    /// </summary>
    public class CarRepository
    {
        /// <summary>
        /// Получает привязанный список автомобилей, хранящихся в репозитории.
        /// </summary>
        public BindingList<Car> Cars { get; private set; }

        /// <summary>
        /// Инициализирует новый экземпляр репозитория с пустым списком автомобилей.
        /// </summary>
        public CarRepository()
        {
            Cars = new BindingList<Car>();
        }

        /// <summary>
        /// Загружает тестовые данные в репозиторий для отладки и демонстрации.
        /// Добавляет несколько предопределённых автомобилей и обновляет их вычисляемые поля.
        /// </summary>
        public void LoadTestData()
        {
            Cars.Add(new Car("Хёндай Крета", "в777ор", 15000, 8.5, 30, 40, 0, 0));
            Cars.Add(new Car("Лада Веста", "у361ек", 500, 7.2, 3, 25, 0, 0));
            Cars.Add(new Car("Митсубиси Аутлендер", "к789ек", 45000, 10.0, 35, 45, 0, 0));

            foreach (var car in Cars)
            {
                car.UpdateCalculatedFields();
            }
        }
    }
}