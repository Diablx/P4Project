namespace MainApp.Forms
{
    partial class CrudForm
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
            this.vin_tb = new System.Windows.Forms.TextBox();
            this.model_tb = new System.Windows.Forms.TextBox();
            this.brand_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.type_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.productionYear_tb = new System.Windows.Forms.DateTimePicker();
            this.engine_tb = new System.Windows.Forms.NumericUpDown();
            this.hp_tb = new System.Windows.Forms.NumericUpDown();
            this.mileage_tb = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.combustion_cb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.color_tb = new System.Windows.Forms.TextBox();
            this.transmission_cb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gps_b = new System.Windows.Forms.CheckBox();
            this.esp_b = new System.Windows.Forms.CheckBox();
            this.AC_b = new System.Windows.Forms.CheckBox();
            this.parkAs_b = new System.Windows.Forms.CheckBox();
            this.paddles_b = new System.Windows.Forms.CheckBox();
            this.condition_cb = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.db_Add = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.engine_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mileage_tb)).BeginInit();
            this.SuspendLayout();
            // 
            // vin_tb
            // 
            this.vin_tb.Location = new System.Drawing.Point(12, 58);
            this.vin_tb.Name = "vin_tb";
            this.vin_tb.Size = new System.Drawing.Size(310, 20);
            this.vin_tb.TabIndex = 0;
            // 
            // model_tb
            // 
            this.model_tb.Location = new System.Drawing.Point(12, 136);
            this.model_tb.Name = "model_tb";
            this.model_tb.Size = new System.Drawing.Size(310, 20);
            this.model_tb.TabIndex = 2;
            // 
            // brand_tb
            // 
            this.brand_tb.AcceptsTab = true;
            this.brand_tb.Location = new System.Drawing.Point(12, 97);
            this.brand_tb.Name = "brand_tb";
            this.brand_tb.Size = new System.Drawing.Size(310, 20);
            this.brand_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type";
            // 
            // type_cb
            // 
            this.type_cb.FormattingEnabled = true;
            this.type_cb.Items.AddRange(new object[] {
            "Sedan",
            "Coupe",
            "Hatchback",
            "Combi",
            "SUV",
            "VAN",
            ""});
            this.type_cb.Location = new System.Drawing.Point(12, 175);
            this.type_cb.Name = "type_cb";
            this.type_cb.Size = new System.Drawing.Size(309, 21);
            this.type_cb.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Engine ( cm3 )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "HP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Production Year";
            // 
            // productionYear_tb
            // 
            this.productionYear_tb.Location = new System.Drawing.Point(12, 292);
            this.productionYear_tb.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.productionYear_tb.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.productionYear_tb.Name = "productionYear_tb";
            this.productionYear_tb.Size = new System.Drawing.Size(309, 20);
            this.productionYear_tb.TabIndex = 8;
            this.productionYear_tb.Value = new System.DateTime(2020, 3, 20, 0, 0, 0, 0);
            // 
            // engine_tb
            // 
            this.engine_tb.Location = new System.Drawing.Point(12, 215);
            this.engine_tb.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.engine_tb.Name = "engine_tb";
            this.engine_tb.Size = new System.Drawing.Size(80, 20);
            this.engine_tb.TabIndex = 4;
            // 
            // hp_tb
            // 
            this.hp_tb.Location = new System.Drawing.Point(127, 215);
            this.hp_tb.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.hp_tb.Name = "hp_tb";
            this.hp_tb.Size = new System.Drawing.Size(80, 20);
            this.hp_tb.TabIndex = 5;
            // 
            // mileage_tb
            // 
            this.mileage_tb.Location = new System.Drawing.Point(241, 215);
            this.mileage_tb.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.mileage_tb.Name = "mileage_tb";
            this.mileage_tb.Size = new System.Drawing.Size(80, 20);
            this.mileage_tb.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Mileage ( km )";
            // 
            // combustion_cb
            // 
            this.combustion_cb.FormattingEnabled = true;
            this.combustion_cb.Items.AddRange(new object[] {
            "Petrol",
            "Petrol + Gas Installation ",
            "Diesel",
            "Hybrid"});
            this.combustion_cb.Location = new System.Drawing.Point(12, 331);
            this.combustion_cb.Name = "combustion_cb";
            this.combustion_cb.Size = new System.Drawing.Size(309, 21);
            this.combustion_cb.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Combustion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Color";
            // 
            // color_tb
            // 
            this.color_tb.Location = new System.Drawing.Point(11, 371);
            this.color_tb.Name = "color_tb";
            this.color_tb.Size = new System.Drawing.Size(310, 20);
            this.color_tb.TabIndex = 10;
            // 
            // transmission_cb
            // 
            this.transmission_cb.FormattingEnabled = true;
            this.transmission_cb.Items.AddRange(new object[] {
            "Automatic",
            "Half Automatic",
            "Manual"});
            this.transmission_cb.Location = new System.Drawing.Point(11, 410);
            this.transmission_cb.Name = "transmission_cb";
            this.transmission_cb.Size = new System.Drawing.Size(309, 21);
            this.transmission_cb.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Transmission";
            // 
            // gps_b
            // 
            this.gps_b.AutoSize = true;
            this.gps_b.Location = new System.Drawing.Point(12, 437);
            this.gps_b.Name = "gps_b";
            this.gps_b.Size = new System.Drawing.Size(48, 17);
            this.gps_b.TabIndex = 12;
            this.gps_b.Text = "GPS";
            this.gps_b.UseVisualStyleBackColor = true;
            // 
            // esp_b
            // 
            this.esp_b.AutoSize = true;
            this.esp_b.Location = new System.Drawing.Point(98, 437);
            this.esp_b.Name = "esp_b";
            this.esp_b.Size = new System.Drawing.Size(47, 17);
            this.esp_b.TabIndex = 13;
            this.esp_b.Text = "ESP";
            this.esp_b.UseVisualStyleBackColor = true;
            // 
            // AC_b
            // 
            this.AC_b.AutoSize = true;
            this.AC_b.Location = new System.Drawing.Point(184, 437);
            this.AC_b.Name = "AC_b";
            this.AC_b.Size = new System.Drawing.Size(40, 17);
            this.AC_b.TabIndex = 14;
            this.AC_b.Text = "AC";
            this.AC_b.UseVisualStyleBackColor = true;
            // 
            // parkAs_b
            // 
            this.parkAs_b.AutoSize = true;
            this.parkAs_b.Location = new System.Drawing.Point(12, 460);
            this.parkAs_b.Name = "parkAs_b";
            this.parkAs_b.Size = new System.Drawing.Size(77, 17);
            this.parkAs_b.TabIndex = 15;
            this.parkAs_b.Text = "Park assist";
            this.parkAs_b.UseVisualStyleBackColor = true;
            // 
            // paddles_b
            // 
            this.paddles_b.AutoSize = true;
            this.paddles_b.Location = new System.Drawing.Point(98, 460);
            this.paddles_b.Name = "paddles_b";
            this.paddles_b.Size = new System.Drawing.Size(87, 17);
            this.paddles_b.TabIndex = 16;
            this.paddles_b.Text = "Shift paddles";
            this.paddles_b.UseVisualStyleBackColor = true;
            // 
            // condition_cb
            // 
            this.condition_cb.FormattingEnabled = true;
            this.condition_cb.Items.AddRange(new object[] {
            "New",
            "Rental",
            "Leased",
            "Used",
            "Broken"});
            this.condition_cb.Location = new System.Drawing.Point(12, 254);
            this.condition_cb.Name = "condition_cb";
            this.condition_cb.Size = new System.Drawing.Size(309, 21);
            this.condition_cb.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Condition";
            // 
            // db_Add
            // 
            this.db_Add.Location = new System.Drawing.Point(12, 505);
            this.db_Add.Name = "db_Add";
            this.db_Add.Size = new System.Drawing.Size(298, 29);
            this.db_Add.TabIndex = 17;
            this.db_Add.Text = "Dodaj samochód";
            this.db_Add.UseVisualStyleBackColor = true;
            this.db_Add.Click += new System.EventHandler(this.db_Add_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(221, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "FORMULARZ DODANIA/EDYCJI POJAZDU";
            // 
            // CrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 544);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.db_Add);
            this.Controls.Add(this.condition_cb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.paddles_b);
            this.Controls.Add(this.parkAs_b);
            this.Controls.Add(this.AC_b);
            this.Controls.Add(this.esp_b);
            this.Controls.Add(this.gps_b);
            this.Controls.Add(this.transmission_cb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.color_tb);
            this.Controls.Add(this.combustion_cb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mileage_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hp_tb);
            this.Controls.Add(this.engine_tb);
            this.Controls.Add(this.productionYear_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.type_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brand_tb);
            this.Controls.Add(this.model_tb);
            this.Controls.Add(this.vin_tb);
            this.Name = "CrudForm";
            this.Text = "CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.engine_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mileage_tb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vin_tb;
        private System.Windows.Forms.TextBox model_tb;
        private System.Windows.Forms.TextBox brand_tb;
        private System.Windows.Forms.ComboBox type_cb;
        private System.Windows.Forms.DateTimePicker productionYear_tb;
        private System.Windows.Forms.NumericUpDown engine_tb;
        private System.Windows.Forms.NumericUpDown hp_tb;
        private System.Windows.Forms.NumericUpDown mileage_tb;
        private System.Windows.Forms.ComboBox combustion_cb;
        private System.Windows.Forms.TextBox color_tb;
        private System.Windows.Forms.ComboBox transmission_cb;
        private System.Windows.Forms.CheckBox gps_b;
        private System.Windows.Forms.CheckBox esp_b;
        private System.Windows.Forms.CheckBox AC_b;
        private System.Windows.Forms.CheckBox parkAs_b;
        private System.Windows.Forms.CheckBox paddles_b;
        private System.Windows.Forms.ComboBox condition_cb;
        private System.Windows.Forms.Button db_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}