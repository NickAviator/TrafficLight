namespace TrafficLight1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.labelInf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.streetA1 = new System.Windows.Forms.Label();
            this.StreetA2 = new System.Windows.Forms.Label();
            this.StreetB2 = new System.Windows.Forms.Label();
            this.StreetB1 = new System.Windows.Forms.Label();
            this.statusA1 = new System.Windows.Forms.Label();
            this.statusA2 = new System.Windows.Forms.Label();
            this.statusB1 = new System.Windows.Forms.Label();
            this.statusB2 = new System.Windows.Forms.Label();
            this.timerA1 = new System.Windows.Forms.Timer(this.components);
            this.timerB1 = new System.Windows.Forms.Timer(this.components);
            this.timerA2 = new System.Windows.Forms.Timer(this.components);
            this.timerB2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelInf
            // 
            this.labelInf.AutoSize = true;
            this.labelInf.Location = new System.Drawing.Point(102, 247);
            this.labelInf.Name = "labelInf";
            this.labelInf.Size = new System.Drawing.Size(41, 13);
            this.labelInf.TabIndex = 1;
            this.labelInf.Text = "labelInf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(126, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "•";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(126, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "•";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(186, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "•";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(186, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 46);
            this.label5.TabIndex = 5;
            this.label5.Text = "•";
            // 
            // streetA1
            // 
            this.streetA1.AutoSize = true;
            this.streetA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.streetA1.Location = new System.Drawing.Point(37, 96);
            this.streetA1.Name = "streetA1";
            this.streetA1.Size = new System.Drawing.Size(83, 20);
            this.streetA1.TabIndex = 6;
            this.streetA1.Text = "Street A ⇄";
            // 
            // StreetA2
            // 
            this.StreetA2.AutoSize = true;
            this.StreetA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetA2.Location = new System.Drawing.Point(222, 96);
            this.StreetA2.Name = "StreetA2";
            this.StreetA2.Size = new System.Drawing.Size(83, 20);
            this.StreetA2.TabIndex = 7;
            this.StreetA2.Text = "⇄ Street A";
            // 
            // StreetB2
            // 
            this.StreetB2.AutoSize = true;
            this.StreetB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetB2.Location = new System.Drawing.Point(141, 162);
            this.StreetB2.Name = "StreetB2";
            this.StreetB2.Size = new System.Drawing.Size(68, 40);
            this.StreetB2.TabIndex = 8;
            this.StreetB2.Text = "    ↓↑\r\nStreet B";
            // 
            // StreetB1
            // 
            this.StreetB1.AutoSize = true;
            this.StreetB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StreetB1.Location = new System.Drawing.Point(141, 17);
            this.StreetB1.Name = "StreetB1";
            this.StreetB1.Size = new System.Drawing.Size(68, 40);
            this.StreetB1.TabIndex = 9;
            this.StreetB1.Text = "Street B\r\n    ↓↑";
            // 
            // statusA1
            // 
            this.statusA1.AutoSize = true;
            this.statusA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusA1.Location = new System.Drawing.Point(38, 128);
            this.statusA1.Name = "statusA1";
            this.statusA1.Size = new System.Drawing.Size(14, 20);
            this.statusA1.TabIndex = 10;
            this.statusA1.Text = "-";
            // 
            // statusA2
            // 
            this.statusA2.AutoSize = true;
            this.statusA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusA2.Location = new System.Drawing.Point(223, 57);
            this.statusA2.Name = "statusA2";
            this.statusA2.Size = new System.Drawing.Size(14, 20);
            this.statusA2.TabIndex = 11;
            this.statusA2.Text = "-";
            // 
            // statusB1
            // 
            this.statusB1.AutoSize = true;
            this.statusB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusB1.Location = new System.Drawing.Point(73, 17);
            this.statusB1.Name = "statusB1";
            this.statusB1.Size = new System.Drawing.Size(14, 20);
            this.statusB1.TabIndex = 12;
            this.statusB1.Text = "-";
            // 
            // statusB2
            // 
            this.statusB2.AutoSize = true;
            this.statusB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusB2.Location = new System.Drawing.Point(215, 182);
            this.statusB2.Name = "statusB2";
            this.statusB2.Size = new System.Drawing.Size(14, 20);
            this.statusB2.TabIndex = 13;
            this.statusB2.Text = "-";
            // 
            // timerA1
            // 
            this.timerA1.Interval = 1000;
            this.timerA1.Tick += new System.EventHandler(this.TimerA1_Tick);
            // 
            // timerB1
            // 
            this.timerB1.Interval = 1000;
            this.timerB1.Tick += new System.EventHandler(this.TimerB1_Tick);
            // 
            // timerA2
            // 
            this.timerA2.Interval = 1000;
            this.timerA2.Tick += new System.EventHandler(this.TimerA2_Tick);
            // 
            // timerB2
            // 
            this.timerB2.Interval = 1000;
            this.timerB2.Tick += new System.EventHandler(this.TimerB2_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 296);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.statusB2);
            this.Controls.Add(this.statusB1);
            this.Controls.Add(this.statusA2);
            this.Controls.Add(this.statusA1);
            this.Controls.Add(this.StreetB1);
            this.Controls.Add(this.StreetB2);
            this.Controls.Add(this.StreetA2);
            this.Controls.Add(this.streetA1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelInf);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelInf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label streetA1;
        private System.Windows.Forms.Label StreetA2;
        private System.Windows.Forms.Label StreetB2;
        private System.Windows.Forms.Label StreetB1;
        private System.Windows.Forms.Label statusA1;
        private System.Windows.Forms.Label statusA2;
        private System.Windows.Forms.Label statusB1;
        private System.Windows.Forms.Label statusB2;
        private System.Windows.Forms.Timer timerA1;
        private System.Windows.Forms.Timer timerB1;
        private System.Windows.Forms.Timer timerA2;
        private System.Windows.Forms.Timer timerB2;
        private System.Windows.Forms.Button button2;
    }
}

