namespace Atan
{
    partial class Atan
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Time_Button = new System.Windows.Forms.Button();
            this.Button_LogicThread = new System.Windows.Forms.RadioButton();
            this.Button_Logic = new System.Windows.Forms.RadioButton();
            this.TheardWrite = new System.Windows.Forms.TextBox();
            this.TheardMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите N число для произведения цикла";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(0, 244);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(501, 61);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цикл вычислений";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(501, 39);
            this.textBox2.TabIndex = 3;
            // 
            // Time_Button
            // 
            this.Time_Button.AutoSize = true;
            this.Time_Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Time_Button.Location = new System.Drawing.Point(0, 63);
            this.Time_Button.Name = "Time_Button";
            this.Time_Button.Size = new System.Drawing.Size(501, 54);
            this.Time_Button.TabIndex = 5;
            this.Time_Button.Text = "Time";
            this.Time_Button.UseVisualStyleBackColor = true;
            this.Time_Button.Click += new System.EventHandler(this.Time_Button_Click);
            // 
            // Button_LogicThread
            // 
            this.Button_LogicThread.AutoSize = true;
            this.Button_LogicThread.Checked = true;
            this.Button_LogicThread.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button_LogicThread.Location = new System.Drawing.Point(0, 190);
            this.Button_LogicThread.Name = "Button_LogicThread";
            this.Button_LogicThread.Size = new System.Drawing.Size(501, 17);
            this.Button_LogicThread.TabIndex = 6;
            this.Button_LogicThread.TabStop = true;
            this.Button_LogicThread.Text = "Многопоточность";
            this.Button_LogicThread.UseVisualStyleBackColor = true;
            this.Button_LogicThread.CheckedChanged += new System.EventHandler(this.Button_LogicThread_CheckedChanged);
            // 
            // Button_Logic
            // 
            this.Button_Logic.AutoSize = true;
            this.Button_Logic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button_Logic.Location = new System.Drawing.Point(0, 173);
            this.Button_Logic.Name = "Button_Logic";
            this.Button_Logic.Size = new System.Drawing.Size(501, 17);
            this.Button_Logic.TabIndex = 7;
            this.Button_Logic.Text = "Однопоточность";
            this.Button_Logic.UseVisualStyleBackColor = true;
            // 
            // TheardWrite
            // 
            this.TheardWrite.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TheardWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TheardWrite.Location = new System.Drawing.Point(0, 135);
            this.TheardWrite.Multiline = true;
            this.TheardWrite.Name = "TheardWrite";
            this.TheardWrite.Size = new System.Drawing.Size(501, 38);
            this.TheardWrite.TabIndex = 8;
            // 
            // TheardMessage
            // 
            this.TheardMessage.AutoSize = true;
            this.TheardMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TheardMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TheardMessage.Location = new System.Drawing.Point(0, 117);
            this.TheardMessage.Name = "TheardMessage";
            this.TheardMessage.Size = new System.Drawing.Size(368, 18);
            this.TheardMessage.TabIndex = 9;
            this.TheardMessage.Text = "Укажите количество ядер/логических процессеров";
            // 
            // Atan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 305);
            this.Controls.Add(this.TheardMessage);
            this.Controls.Add(this.TheardWrite);
            this.Controls.Add(this.Button_Logic);
            this.Controls.Add(this.Button_LogicThread);
            this.Controls.Add(this.Time_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Atan";
            this.Text = "Многопоточность/Однопоточность";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Time_Button;
        private System.Windows.Forms.RadioButton Button_LogicThread;
        private System.Windows.Forms.RadioButton Button_Logic;
        private System.Windows.Forms.TextBox TheardWrite;
        private System.Windows.Forms.Label TheardMessage;
        private System.Windows.Forms.Label label2;
    }
}

