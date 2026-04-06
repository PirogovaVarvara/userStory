using System;
using System.ComponentModel;
using System.Windows.Forms;
using carRental.BL;
using carRental.DAL;
using CarRental.Forms;

namespace carRental
{
    public partial class MyForm : Form
    {
        private readonly BindingSource source;
        private CarRepository repository;
        private CarService service;

        // Поле для статусной строки
        private ToolStripStatusLabel toolStripStatusLabel1;

        private const int cellOffset = 2;
        const float MaxFuelReserve = 100;

        public MyForm()
        {
            InitializeComponent();

            // Инициализация слоёв
            repository = new CarRepository();
            repository.LoadTestData();   // загружаем тестовые данные
            service = new CarService(repository);

            // Настройка DataGridView
            source = new BindingSource();
            source.DataSource = service.GetAllCars();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = source;

            // Подписка на события
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;

            // Создаём StatusStrip программно
            InitializeStatusStrip();

            UpdateStatistic();  // обновляем статистику при старте
        }

        private void InitializeStatusStrip()
        {
            StatusStrip statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Text = "Всего авто: 0 | Критический запас (<7л): 0";
            statusStrip.Items.Add(toolStripStatusLabel1);
            statusStrip.Dock = DockStyle.Bottom;
            this.Controls.Add(statusStrip);
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
                        e.CellBounds.Width - cellOffset * 2 - 1,
                        e.CellBounds.Height - cellOffset * 2 - 1));
                    var x = (int)(car.CurrentFuelVolumeInLiters * (e.CellBounds.Width - cellOffset * 2 - 1) / MaxFuelReserve);
                    e.Graphics.FillRectangle(Brushes.Aquamarine, new Rectangle(e.CellBounds.X + cellOffset,
                        e.CellBounds.Y + cellOffset,
                        x,
                        e.CellBounds.Height - cellOffset * 2 - 1));

                    string text = car.CurrentFuelVolumeInLiters.ToString("0.0");
                    Font font = e.CellStyle.Font ?? dataGridView1.Font;
                    TextRenderer.DrawText(e.Graphics, text, font, e.CellBounds, Color.Black,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Убедитесь, что у вас есть колонка с именем "CarNumbers" (или создайте её в дизайнере)
            if (dataGridView1.Columns[e.ColumnIndex].Name == "CarNumbers" && e.RowIndex >= 0)
            {
                e.Value = (e.RowIndex + 1).ToString();
                e.FormattingApplied = true;
            }
        }

        // Обновление статистики в статусной строке
        private void UpdateStatistic()
        {
            if (service != null && toolStripStatusLabel1 != null)
            {
                var (total, lowFuel) = service.GetStatistics();
                toolStripStatusLabel1.Text = $"Всего авто: {total} | С низким топливом (<7л): {lowFuel}";
            }
        }

        // Кнопка "Добавить"
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var form = new AddUpdateCarForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                service.AddCar(form.ResultCar);
                source.ResetBindings(false);
                UpdateStatistic();
            }
        }

        // Кнопка "Изменить"
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Car selectedCar)
            {
                var form = new AddUpdateCarForm(selectedCar);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    service.UpdateCar(selectedCar, form.ResultCar);
                    source.ResetBindings(false);
                    UpdateStatistic();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования");
            }
        }

        // Кнопка "Удалить"
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Car selectedCar)
            {
                if (MessageBox.Show($"Удалить {selectedCar.Brand} {selectedCar.StateNumber}?", "Подтверждение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    service.DeleteCar(selectedCar);
                    source.ResetBindings(false);
                    UpdateStatistic();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }
    }
}