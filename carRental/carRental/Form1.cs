using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace carRental
{
    /// <summary>
    /// Главная форма приложения. Отображает список автомобилей в DataGridView
    /// с кастомной отрисовкой уровня топлива и автоматической нумерацией строк.
    /// </summary>
    public partial class MyForm : Form
    {
        private readonly BindingSource source;
        private List<Car> cars;
        private const int cellOffset = 2;
        const float MaxFuelReserve = 100;

        /// <summary>
        /// Инициализирует форму, заполняет тестовый список автомобилей
        /// и настраивает отображение DataGridView.
        /// </summary>
        public MyForm()
        {
            cars = new List<Car>
            {
                new Car (
                    brand: "Хёндай Крета",
                    stateNumber: "в777ор",
                    mileageInKm: 15000,
                    avgFuelConsumptionPerHourInLiter: 8.5,
                    currentFuelVolumeInLiters: 30,
                    costOfRentPerMinuteInRuble: 40,
                    fuelReserve: Math.Round(30 / 8.5),
                    rentalAmount: Math.Round((30 / 8.5) * 40)
                         ),
                new Car (
                    brand: "Лада Веста",
                    stateNumber: "у361ек",
                    mileageInKm: 500,
                    avgFuelConsumptionPerHourInLiter: 7.2,
                    currentFuelVolumeInLiters: 3,
                    costOfRentPerMinuteInRuble: 25,
                    fuelReserve: Math.Round(3 / 7.2),
                    rentalAmount:Math.Round((3 / 7.2) * 25)
                        ),
                new Car (
                    brand: "Митсубиси Аутлендер",
                    stateNumber: "к789ек",
                    mileageInKm: 45000,
                    avgFuelConsumptionPerHourInLiter: 10.0,
                    currentFuelVolumeInLiters: 35,
                    costOfRentPerMinuteInRuble: 45,
                    fuelReserve: Math.Round(35 / 10.0),
                    rentalAmount: Math.Round((35 / 10.0) * 45)
                       )
            };
            InitializeComponent();
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            source = new BindingSource();
            source.DataSource = cars;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int drawingLinePlacement = 1, doubleValue = 2;
            if (e is { ColumnIndex: >= 0, RowIndex: >= 0 } &&
                dataGridView1.Columns[e.ColumnIndex].Name == "CurrentFuelVolumeInLiters")
            {
                if (dataGridView1.Rows[e.RowIndex].DataBoundItem is Car car)
                {
                    e.Handled = true;
                    e.PaintBackground(e.ClipBounds, false);
                    e.Graphics.DrawRectangle(Pens.Teal, new Rectangle(e.CellBounds.X + cellOffset,
                        e.CellBounds.Y + cellOffset,
                        e.CellBounds.Width - cellOffset * doubleValue - drawingLinePlacement,
                        e.CellBounds.Height - cellOffset * doubleValue - drawingLinePlacement));
                    var x = (int)(car.CurrentFuelVolumeInLiters * (e.CellBounds.Width - cellOffset * doubleValue - drawingLinePlacement) / MaxFuelReserve);
                    e.Graphics.FillRectangle(Brushes.Aquamarine, new Rectangle(e.CellBounds.X + cellOffset,
                        e.CellBounds.Y + cellOffset,
                        x,
                        e.CellBounds.Height - cellOffset * doubleValue - drawingLinePlacement));

                    string text = car.CurrentFuelVolumeInLiters.ToString("0.0");

                    Font font = e.CellStyle.Font ?? dataGridView1.Font;

                    Brush textBrush = Brushes.Black;

                    TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
                    TextRenderer.DrawText(e.Graphics, text, font, e.CellBounds, Color.Black, flags);
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "CarNumbers" && e is { ColumnIndex: >= 0, RowIndex: >= 0 })
            {
                e.Value = e.RowIndex + 1.ToString();
                e.FormattingApplied = true;
            }
        }
    }
}