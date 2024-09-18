namespace TourAgency
{
    partial class AddHotel
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFoods = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPool = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxCenter = new System.Windows.Forms.CheckBox();
            this.checkBoxSea = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 312);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(260, 77);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(751, 312);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(260, 77);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите страну";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(187, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(610, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Для добавления отеля заполните следующие параметры:";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(5, 101);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(154, 21);
            this.comboBoxCountry.TabIndex = 4;
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.Enabled = false;
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(5, 187);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(154, 21);
            this.comboBoxRegion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите регион";
            // 
            // comboBoxFoods
            // 
            this.comboBoxFoods.FormattingEnabled = true;
            this.comboBoxFoods.Location = new System.Drawing.Point(165, 101);
            this.comboBoxFoods.Name = "comboBoxFoods";
            this.comboBoxFoods.Size = new System.Drawing.Size(155, 21);
            this.comboBoxFoods.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберите тип питания";
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.Location = new System.Drawing.Point(326, 101);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(362, 21);
            this.comboBoxAge.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Выберите возрастную категорию";
            // 
            // comboBoxPool
            // 
            this.comboBoxPool.FormattingEnabled = true;
            this.comboBoxPool.Location = new System.Drawing.Point(326, 187);
            this.comboBoxPool.Name = "comboBoxPool";
            this.comboBoxPool.Size = new System.Drawing.Size(362, 21);
            this.comboBoxPool.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Выберите категорию бассейна";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(734, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Введите имя отеля";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(737, 101);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(858, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Выберите количество звезд";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(861, 98);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 16;
            // 
            // checkBoxCenter
            // 
            this.checkBoxCenter.AutoSize = true;
            this.checkBoxCenter.Location = new System.Drawing.Point(741, 155);
            this.checkBoxCenter.Name = "checkBoxCenter";
            this.checkBoxCenter.Size = new System.Drawing.Size(159, 17);
            this.checkBoxCenter.TabIndex = 17;
            this.checkBoxCenter.Text = "Отель находится в центре";
            this.checkBoxCenter.UseVisualStyleBackColor = true;
            // 
            // checkBoxSea
            // 
            this.checkBoxSea.AutoSize = true;
            this.checkBoxSea.Location = new System.Drawing.Point(741, 204);
            this.checkBoxSea.Name = "checkBoxSea";
            this.checkBoxSea.Size = new System.Drawing.Size(212, 17);
            this.checkBoxSea.TabIndex = 18;
            this.checkBoxSea.Text = "Отель находится на 1 линии от моря";
            this.checkBoxSea.UseVisualStyleBackColor = true;
            // 
            // AddHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 401);
            this.Controls.Add(this.checkBoxSea);
            this.Controls.Add(this.checkBoxCenter);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxPool);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxFoods);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Name = "AddHotel";
            this.Text = "AddHotel";
            this.Load += new System.EventHandler(this.AddHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFoods;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPool;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBoxCenter;
        private System.Windows.Forms.CheckBox checkBoxSea;
    }
}