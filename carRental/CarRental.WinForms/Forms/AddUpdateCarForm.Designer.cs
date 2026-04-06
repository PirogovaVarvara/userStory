namespace CarRental.Forms
{
    partial class AddUpdateCarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            BrandTextBox = new TextBox();
            MileageInKmNumericUpDown = new NumericUpDown();
            StateTextBox = new TextBox();
            AvgFuelConsumptionPerHourInLiterNumericUpDown = new NumericUpDown();
            CurrentFuelVolumeInLitersNumericUpDown = new NumericUpDown();
            CostOfRentPerMinuteInRubleNumericUpDown = new NumericUpDown();
            FuelReserveNumericUpDown = new NumericUpDown();
            RentalAmountNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)MileageInKmNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AvgFuelConsumptionPerHourInLiterNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CurrentFuelVolumeInLitersNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CostOfRentPerMinuteInRubleNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FuelReserveNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RentalAmountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(176, 23);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(220, 15);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Добавление/Редактирование машины";
            // 
            // BrandTextBox
            // 
            BrandTextBox.Location = new Point(270, 78);
            BrandTextBox.Name = "BrandTextBox";
            BrandTextBox.Size = new Size(299, 23);
            BrandTextBox.TabIndex = 1;
            // 
            // MileageInKmNumericUpDown
            // 
            MileageInKmNumericUpDown.Location = new Point(270, 136);
            MileageInKmNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            MileageInKmNumericUpDown.Name = "MileageInKmNumericUpDown";
            MileageInKmNumericUpDown.Size = new Size(120, 23);
            MileageInKmNumericUpDown.TabIndex = 2;
            // 
            // StateTextBox
            // 
            StateTextBox.Location = new Point(270, 107);
            StateTextBox.Name = "StateTextBox";
            StateTextBox.Size = new Size(299, 23);
            StateTextBox.TabIndex = 3;
            // 
            // AvgFuelConsumptionPerHourInLiterNumericUpDown
            // 
            AvgFuelConsumptionPerHourInLiterNumericUpDown.Location = new Point(270, 165);
            AvgFuelConsumptionPerHourInLiterNumericUpDown.Name = "AvgFuelConsumptionPerHourInLiterNumericUpDown";
            AvgFuelConsumptionPerHourInLiterNumericUpDown.Size = new Size(120, 23);
            AvgFuelConsumptionPerHourInLiterNumericUpDown.TabIndex = 4;
            // 
            // CurrentFuelVolumeInLitersNumericUpDown
            // 
            CurrentFuelVolumeInLitersNumericUpDown.Location = new Point(270, 194);
            CurrentFuelVolumeInLitersNumericUpDown.Name = "CurrentFuelVolumeInLitersNumericUpDown";
            CurrentFuelVolumeInLitersNumericUpDown.Size = new Size(120, 23);
            CurrentFuelVolumeInLitersNumericUpDown.TabIndex = 5;
            // 
            // CostOfRentPerMinuteInRubleNumericUpDown
            // 
            CostOfRentPerMinuteInRubleNumericUpDown.Location = new Point(270, 223);
            CostOfRentPerMinuteInRubleNumericUpDown.Name = "CostOfRentPerMinuteInRubleNumericUpDown";
            CostOfRentPerMinuteInRubleNumericUpDown.Size = new Size(120, 23);
            CostOfRentPerMinuteInRubleNumericUpDown.TabIndex = 6;
            // 
            // FuelReserveNumericUpDown
            // 
            FuelReserveNumericUpDown.DecimalPlaces = 2;
            FuelReserveNumericUpDown.Location = new Point(270, 252);
            FuelReserveNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            FuelReserveNumericUpDown.Name = "FuelReserveNumericUpDown";
            FuelReserveNumericUpDown.Size = new Size(120, 23);
            FuelReserveNumericUpDown.TabIndex = 7;
            // 
            // RentalAmountNumericUpDown
            // 
            RentalAmountNumericUpDown.DecimalPlaces = 2;
            RentalAmountNumericUpDown.Location = new Point(270, 281);
            RentalAmountNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            RentalAmountNumericUpDown.Name = "RentalAmountNumericUpDown";
            RentalAmountNumericUpDown.Size = new Size(120, 23);
            RentalAmountNumericUpDown.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 81);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 9;
            label1.Text = "Марка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 110);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 10;
            label2.Text = "Госномер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 138);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 11;
            label3.Text = "Пробег";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 167);
            label4.Name = "label4";
            label4.Size = new Size(180, 15);
            label4.TabIndex = 12;
            label4.Text = "Средний расход топлива за час";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 196);
            label5.Name = "label5";
            label5.Size = new Size(143, 15);
            label5.TabIndex = 13;
            label5.Text = "Текущий объем топлива";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 225);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 14;
            label6.Text = "Стоимость аренды";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(80, 254);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 15;
            label7.Text = "Запас хода топлива";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(84, 283);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 16;
            label8.Text = "Сумма аренды";
            // 
            // AddUpdateCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 350);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RentalAmountNumericUpDown);
            Controls.Add(FuelReserveNumericUpDown);
            Controls.Add(CostOfRentPerMinuteInRubleNumericUpDown);
            Controls.Add(CurrentFuelVolumeInLitersNumericUpDown);
            Controls.Add(AvgFuelConsumptionPerHourInLiterNumericUpDown);
            Controls.Add(StateTextBox);
            Controls.Add(MileageInKmNumericUpDown);
            Controls.Add(BrandTextBox);
            Controls.Add(titleLabel);
            Name = "AddUpdateCarForm";
            Text = "Добавление/Редактирование машины";
            ((System.ComponentModel.ISupportInitialize)MileageInKmNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AvgFuelConsumptionPerHourInLiterNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CurrentFuelVolumeInLitersNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CostOfRentPerMinuteInRubleNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)FuelReserveNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)RentalAmountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TextBox BrandTextBox;
        private NumericUpDown MileageInKmNumericUpDown;
        private TextBox StateTextBox;
        private NumericUpDown AvgFuelConsumptionPerHourInLiterNumericUpDown;
        private NumericUpDown CurrentFuelVolumeInLitersNumericUpDown;
        private NumericUpDown CostOfRentPerMinuteInRubleNumericUpDown;
        private NumericUpDown FuelReserveNumericUpDown;
        private NumericUpDown RentalAmountNumericUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}