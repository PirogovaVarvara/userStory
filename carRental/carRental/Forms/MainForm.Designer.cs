using System.Runtime.CompilerServices;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm));
            dataGridView1 = new DataGridView();
            Brand = new DataGridViewTextBoxColumn();
            StateNumber = new DataGridViewTextBoxColumn();
            MileageInKm = new DataGridViewTextBoxColumn();
            AvgFuelConsumptionPerHourInLiter = new DataGridViewTextBoxColumn();
            CurrentFuelVolumeInLiters = new DataGridViewTextBoxColumn();
            CostOfRentPerMinuteInRuble = new DataGridViewTextBoxColumn();
            FuelReserve = new DataGridViewTextBoxColumn();
            RentalAmount = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Brand, StateNumber, MileageInKm, AvgFuelConsumptionPerHourInLiter, CurrentFuelVolumeInLiters, CostOfRentPerMinuteInRuble, FuelReserve, RentalAmount });
            dataGridView1.Location = new Point(39, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(843, 145);
            dataGridView1.TabIndex = 0;
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1154, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // MyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 450);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Name = "MyForm";
            Text = "MyForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;

        //this.SaveButton.Location = new System.Drawing.Point(13, 320)
    }
}
