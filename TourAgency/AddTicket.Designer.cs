﻿namespace TourAgency
{
    partial class AddTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDownPeople = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownTickets = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownNights = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownPriceAdult = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownPriceChild = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownRoute = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceAdult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(124, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные для добавления билета:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDownPeople
            // 
            this.numericUpDownPeople.Location = new System.Drawing.Point(36, 131);
            this.numericUpDownPeople.Name = "numericUpDownPeople";
            this.numericUpDownPeople.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPeople.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество людей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество билетов";
            // 
            // numericUpDownTickets
            // 
            this.numericUpDownTickets.Location = new System.Drawing.Point(203, 131);
            this.numericUpDownTickets.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTickets.Name = "numericUpDownTickets";
            this.numericUpDownTickets.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownTickets.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество ночей";
            // 
            // numericUpDownNights
            // 
            this.numericUpDownNights.Location = new System.Drawing.Point(364, 131);
            this.numericUpDownNights.Name = "numericUpDownNights";
            this.numericUpDownNights.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNights.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Цена за взрослого";
            // 
            // numericUpDownPriceAdult
            // 
            this.numericUpDownPriceAdult.Location = new System.Drawing.Point(514, 131);
            this.numericUpDownPriceAdult.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDownPriceAdult.Name = "numericUpDownPriceAdult";
            this.numericUpDownPriceAdult.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPriceAdult.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(655, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Цена за ребенка";
            // 
            // numericUpDownPriceChild
            // 
            this.numericUpDownPriceChild.Location = new System.Drawing.Point(655, 131);
            this.numericUpDownPriceChild.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDownPriceChild.Name = "numericUpDownPriceChild";
            this.numericUpDownPriceChild.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPriceChild.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Индекс маршрута";
            // 
            // numericUpDownRoute
            // 
            this.numericUpDownRoute.Location = new System.Drawing.Point(36, 194);
            this.numericUpDownRoute.Maximum = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.numericUpDownRoute.Name = "numericUpDownRoute";
            this.numericUpDownRoute.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRoute.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Время вылета";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Время возращения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 194);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(505, 194);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownRoute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownPriceChild);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownPriceAdult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownNights);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownTickets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownPeople);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "AddTicket";
            this.Text = "AddTicket";
            this.Load += new System.EventHandler(this.AddTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceAdult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDownPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTickets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownNights;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownPriceAdult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownPriceChild;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownRoute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}