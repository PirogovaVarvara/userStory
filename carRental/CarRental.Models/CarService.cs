using System.ComponentModel;
using carRental.DAL;

namespace carRental.BL
{
    /// <summary>
    /// Предоставляет бизнес-логику для работы с автомобилями: получение, добавление, обновление, удаление и статистика.
    /// </summary>
    public class CarService
    {
        private CarRepository repository;

        /// <summary>
        /// Инициализирует новый экземпляр сервиса с указанным репозиторием.
        /// </summary>
        /// <param name="repo">Репозиторий, содержащий список автомобилей.</param>
        public CarService(CarRepository repo)
        {
            repository = repo;
        }

        /// <summary>
        /// Возвращает список всех автомобилей из репозитория.
        /// </summary>
        /// <returns>Привязанный список автомобилей (<see cref="BindingList{Car}"/>).</returns>
        public BindingList<Car> GetAllCars() => repository.Cars;

        /// <summary>
        /// Добавляет новый автомобиль. Перед добавлением обновляет вычисляемые поля автомобиля.
        /// </summary>
        /// <param name="car">Автомобиль для добавления.</param>
        public void AddCar(Car car)
        {
            car.UpdateCalculatedFields();
            repository.Cars.Add(car);
        }

        /// <summary>
        /// Обновляет существующий автомобиль. Заменяет старый объект новым после обновления вычисляемых полей.
        /// </summary>
        /// <param name="oldCar">Автомобиль, который требуется заменить.</param>
        /// <param name="newCar">Автомобиль с новыми данными.</param>
        public void UpdateCar(Car oldCar, Car newCar)
        {
            var index = repository.Cars.IndexOf(oldCar);
            if (index >= 0)
            {
                newCar.UpdateCalculatedFields();
                repository.Cars[index] = newCar;
            }
        }

        /// <summary>
        /// Удаляет указанный автомобиль из репозитория.
        /// </summary>
        /// <param name="car">Автомобиль для удаления.</param>
        public void DeleteCar(Car car) => repository.Cars.Remove(car);

        /// <summary>
        /// Получает статистику по автомобилям.
        /// </summary>
        /// <returns>Кортеж, содержащий общее количество автомобилей и количество автомобилей с низким уровнем топлива (менее 7 литров).</returns>
        public (int total, int lowFuelCount) GetStatistics()
        {
            var total = repository.Cars.Count;
            var lowFuel = 0;
            foreach (var c in repository.Cars)
                if (c.CurrentFuelVolumeInLiters < 7) lowFuel++;
            return (total, lowFuel);
        }
    }
}