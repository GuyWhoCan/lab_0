
namespace lab_0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Speed = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.button_calculation = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.Length = new System.Windows.Forms.Label();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.BackColor = System.Drawing.Color.Yellow;
            this.Speed.Location = new System.Drawing.Point(498, 56);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(69, 17);
            this.Speed.TabIndex = 0;
            this.Speed.Text = "Скорость";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(484, 96);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.ReadOnly = true;
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 22);
            this.textBoxSpeed.TabIndex = 1;
            // 
            // button_calculation
            // 
            this.button_calculation.BackColor = System.Drawing.Color.Cyan;
            this.button_calculation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_calculation.Location = new System.Drawing.Point(246, 256);
            this.button_calculation.Name = "button_calculation";
            this.button_calculation.Size = new System.Drawing.Size(127, 43);
            this.button_calculation.TabIndex = 2;
            this.button_calculation.Text = "Расчет";
            this.button_calculation.UseVisualStyleBackColor = false;
            this.button_calculation.Click += new System.EventHandler(this.button_calculation_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.BackColor = System.Drawing.Color.Wheat;
            this.Time.Location = new System.Drawing.Point(285, 56);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(50, 17);
            this.Time.TabIndex = 3;
            this.Time.Text = "Время";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(272, 96);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(100, 22);
            this.textBoxTime.TabIndex = 4;
            this.textBoxTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTime_KeyPress);
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.BackColor = System.Drawing.Color.BurlyWood;
            this.Length.Location = new System.Drawing.Point(94, 56);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(51, 17);
            this.Length.TabIndex = 5;
            this.Length.Text = "Длина";
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(81, 96);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 22);
            this.textBoxLength.TabIndex = 6;
            this.textBoxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLength_KeyPress);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.Crimson;
            this.button_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_clear.Location = new System.Drawing.Point(246, 333);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(127, 43);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "Очистить";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.button_calculation);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.Speed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Button button_calculation;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Button button_clear;
    }
}

