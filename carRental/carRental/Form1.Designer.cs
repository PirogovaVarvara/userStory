namespace carRental
{
    partial class MyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            CarNumbers = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            StateNumber = new DataGridViewTextBoxColumn();
            MileageInKm = new DataGridViewTextBoxColumn();
            AvgFuelConsumptionPerHourInLiter = new DataGridViewTextBoxColumn();
            CurrentFuelVolumeInLiters = new DataGridViewTextBoxColumn();
            CostOfRentPerMinuteInRuble = new DataGridViewTextBoxColumn();
            FuelReserve = new DataGridViewTextBoxColumn();
            RentalAmount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CarNumbers, Brand, StateNumber, MileageInKm, AvgFuelConsumptionPerHourInLiter, CurrentFuelVolumeInLiters, CostOfRentPerMinuteInRuble, FuelReserve, RentalAmount });
            dataGridView1.Location = new Point(39, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(943, 145);
            dataGridView1.TabIndex = 0;
            // 
            // CarNumbers
            // 
            CarNumbers.HeaderText = "№ машины";
            CarNumbers.Name = "CarNumbers";
            // 
            // Brand
            // 
            Brand.DataPropertyName = "Brand";
            Brand.HeaderText = "Марка";
            Brand.Name = "Brand";
            // 
            // StateNumber
            // 
            StateNumber.DataPropertyName = "StateNumber";
            StateNumber.HeaderText = "Гос номер";
            StateNumber.Name = "StateNumber";
            // 
            // MileageInKm
            // 
            MileageInKm.DataPropertyName = "MileageInKm";
            MileageInKm.HeaderText = "Пробег";
            MileageInKm.Name = "MileageInKm";
            // 
            // AvgFuelConsumptionPerHourInLiter
            // 
            AvgFuelConsumptionPerHourInLiter.DataPropertyName = "AvgFuelConsumptionPerHourInLiter";
            AvgFuelConsumptionPerHourInLiter.HeaderText = "Средний расход топлива за час";
            AvgFuelConsumptionPerHourInLiter.Name = "AvgFuelConsumptionPerHourInLiter";
            // 
            // CurrentFuelVolumeInLiters
            // 
            CurrentFuelVolumeInLiters.DataPropertyName = "CurrentFuelVolumeInLiters";
            CurrentFuelVolumeInLiters.HeaderText = "Текущий объем топлива";
            CurrentFuelVolumeInLiters.Name = "CurrentFuelVolumeInLiters";
            // 
            // CostOfRentPerMinuteInRuble
            // 
            CostOfRentPerMinuteInRuble.DataPropertyName = "CostOfRentPerMinuteInRuble";
            CostOfRentPerMinuteInRuble.HeaderText = "Стоимость аренды";
            CostOfRentPerMinuteInRuble.Name = "CostOfRentPerMinuteInRuble";
            // 
            // FuelReserve
            // 
            FuelReserve.DataPropertyName = "FuelReserve";
            FuelReserve.HeaderText = "Запас хода топлива";
            FuelReserve.Name = "FuelReserve";
            // 
            // RentalAmount
            // 
            RentalAmount.DataPropertyName = "RentalAmount";
            RentalAmount.HeaderText = "Сумма аренды";
            RentalAmount.Name = "RentalAmount";
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 450);
            Controls.Add(dataGridView1);
            Name = "MyForm";
            Text = "MyForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CarNumbers;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn StateNumber;
        private DataGridViewTextBoxColumn MileageInKm;
        private DataGridViewTextBoxColumn AvgFuelConsumptionPerHourInLiter;
        private DataGridViewTextBoxColumn CurrentFuelVolumeInLiters;
        private DataGridViewTextBoxColumn CostOfRentPerMinuteInRuble;
        private DataGridViewTextBoxColumn FuelReserve;
        private DataGridViewTextBoxColumn RentalAmount;
    }
}
