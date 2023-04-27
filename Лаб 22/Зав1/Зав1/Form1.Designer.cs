namespace Зав1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownH = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спаднаЧиЗростаючаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найменшеТаНайбільшеЗначенняФункціїНаПроміжкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вЯкомуКвадрантіБільшеТочокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.середнєЗначенняФункціїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найбільшеВідємнеЗначенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найменшеДодатнеЗначенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownFinal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownInit = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.побудуватиГрафікToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відобразитиСиметричноВідносноОсіОХToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відобразитиСиметричноВідносноОсіОУToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInit)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(349, 154);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(592, 372);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "a";
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(88, 99);
            this.numericUpDownA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(176, 22);
            this.numericUpDownA.TabIndex = 2;
            this.numericUpDownA.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(88, 138);
            this.numericUpDownB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(176, 22);
            this.numericUpDownB.TabIndex = 4;
            this.numericUpDownB.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "b";
            // 
            // numericUpDownH
            // 
            this.numericUpDownH.Location = new System.Drawing.Point(88, 185);
            this.numericUpDownH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownH.Name = "numericUpDownH";
            this.numericUpDownH.Size = new System.Drawing.Size(176, 22);
            this.numericUpDownH.TabIndex = 6;
            this.numericUpDownH.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "h";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операціїToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1003, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операціїToolStripMenuItem
            // 
            this.операціїToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.побудуватиГрафікToolStripMenuItem,
            this.спаднаЧиЗростаючаToolStripMenuItem,
            this.найменшеТаНайбільшеЗначенняФункціїНаПроміжкуToolStripMenuItem,
            this.чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem,
            this.вЯкомуКвадрантіБільшеТочокToolStripMenuItem,
            this.середнєЗначенняФункціїToolStripMenuItem,
            this.найбільшеВідємнеЗначенняToolStripMenuItem,
            this.найменшеДодатнеЗначенняToolStripMenuItem,
            this.наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem,
            this.відобразитиСиметричноВідносноОсіОХToolStripMenuItem,
            this.відобразитиСиметричноВідносноОсіОУToolStripMenuItem});
            this.операціїToolStripMenuItem.Name = "операціїToolStripMenuItem";
            this.операціїToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.операціїToolStripMenuItem.Text = "Операції";
            // 
            // спаднаЧиЗростаючаToolStripMenuItem
            // 
            this.спаднаЧиЗростаючаToolStripMenuItem.Name = "спаднаЧиЗростаючаToolStripMenuItem";
            this.спаднаЧиЗростаючаToolStripMenuItem.Size = new System.Drawing.Size(523, 26);
            this.спаднаЧиЗростаючаToolStripMenuItem.Text = "Спадна чи зростаюча";
            this.спаднаЧиЗростаючаToolStripMenuItem.Click += new System.EventHandler(this.спаднаЧиЗростаючаToolStripMenuItem_Click);
            // 
            // найменшеТаНайбільшеЗначенняФункціїНаПроміжкуToolStripMenuItem
            // 
            this.найменшеТаНайбільшеЗначенняФункціїНаПроміжкуToolStripMenuItem.Name = "найменшеТаНайбільшеЗначенняФункціїНаПроміжкуToolStripMenuItem";
            this.найменшеТаНайбільшеЗначенняФункціїНаПроміжкуToolStripMenuItem.Size = new System.Drawing.Size(523, 26);
            this.найменшеТаНайбільшеЗначенняФункціїНаПроміжкуToolStripMenuItem.Text = "Найменше та найбільше значення функції на проміжку";
            this.найменшеТаНайбільшеЗначенняФункціїНаПроміжкуToolStripMenuItem.Click += new System.EventHandler(this.найменшеТаНайбільшеЗначенняФункціїНаПроміжкуToolStripMenuItem_Click);
            // 
            // чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem
            // 
            this.чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem.Name = "чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem";
            this.чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem.Size = new System.Drawing.Size(523, 26);
            this.чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem.Text = "Чи перетинає графік функції вісь ОХ";
            this.чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem.Click += new System.EventHandler(this.чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem_Click);
            // 
            // вЯкомуКвадрантіБільшеТочокToolStripMenuItem
            // 
            this.вЯкомуКвадрантіБільшеТочокToolStripMenuItem.Name = "вЯкомуКвадрантіБільшеТочокToolStripMenuItem";
            this.вЯкомуКвадрантіБільшеТочокToolStripMenuItem.Size = new System.Drawing.Size(523, 26);
            this.вЯкомуКвадрантіБільшеТочокToolStripMenuItem.Text = "В якому квадранті більше точок";
            this.вЯкомуКвадрантіБільшеТочокToolStripMenuItem.Click += new System.EventHandler(this.вЯкомуКвадрантіБільшеТочокToolStripMenuItem_Click);
            // 
            // середнєЗначенняФункціїToolStripMenuItem
            // 
            this.середнєЗначенняФункціїToolStripMenuItem.Name = "середнєЗначенняФункціїToolStripMenuItem";
            this.середнєЗначенняФункціїToolStripMenuItem.Size = new System.Drawing.Size(523, 26);
            this.середнєЗначенняФункціїToolStripMenuItem.Text = "«Середнє значення» функції";
            this.середнєЗначенняФункціїToolStripMenuItem.Click += new System.EventHandler(this.середнєЗначенняФункціїToolStripMenuItem_Click);
            // 
            // найбільшеВідємнеЗначенняToolStripMenuItem
            // 
            this.найбільшеВідємнеЗначенняToolStripMenuItem.Name = "найбільшеВідємнеЗначенняToolStripMenuItem";
            this.найбільшеВідємнеЗначенняToolStripMenuItem.Size = new System.Drawing.Size(523, 26);
            this.найбільшеВідємнеЗначенняToolStripMenuItem.Text = "Найбільше від\'ємне значення";
            this.найбільшеВідємнеЗначенняToolStripMenuItem.Click += new System.EventHandler(this.найбільшеВідємнеЗначенняToolStripMenuItem_Click);
            // 
            // найменшеДодатнеЗначенняToolStripMenuItem
            // 
            this.найменшеДодатнеЗначенняToolStripMenuItem.Name = "найменшеДодатнеЗначенняToolStripMenuItem";
            this.найменшеДодатнеЗначенняToolStripMenuItem.Size = new System.Drawing.Size(523, 26);
            this.найменшеДодатнеЗначенняToolStripMenuItem.Text = "Найменше додатне значення";
            this.найменшеДодатнеЗначенняToolStripMenuItem.Click += new System.EventHandler(this.найменшеДодатнеЗначенняToolStripMenuItem_Click);
            // 
            // наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem
            // 
            this.наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem.Name = "наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem";
            this.наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem.Size = new System.Drawing.Size(523, 26);
            this.наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem.Text = "Наближено знайти точку перетину графіка функції з віссю ОХ";
            this.наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem.Click += new System.EventHandler(this.наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Проміжок";
            // 
            // numericUpDownFinal
            // 
            this.numericUpDownFinal.Location = new System.Drawing.Point(173, 342);
            this.numericUpDownFinal.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownFinal.Name = "numericUpDownFinal";
            this.numericUpDownFinal.Size = new System.Drawing.Size(91, 22);
            this.numericUpDownFinal.TabIndex = 12;
            this.numericUpDownFinal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Кінцеве значення";
            // 
            // numericUpDownInit
            // 
            this.numericUpDownInit.Location = new System.Drawing.Point(194, 305);
            this.numericUpDownInit.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownInit.Name = "numericUpDownInit";
            this.numericUpDownInit.Size = new System.Drawing.Size(79, 22);
            this.numericUpDownInit.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Початкове значення";
            // 
            // побудуватиГрафікToolStripMenuItem
            // 
            this.побудуватиГрафікToolStripMenuItem.Name = "побудуватиГрафікToolStripMenuItem";
            this.побудуватиГрафікToolStripMenuItem.Size = new System.Drawing.Size(523, 26);
            this.побудуватиГрафікToolStripMenuItem.Text = "Побудувати графік";
            this.побудуватиГрафікToolStripMenuItem.Click += new System.EventHandler(this.побудуватиГрафікToolStripMenuItem_Click);
            // 
            // відобразитиСиметричноВідносноОсіОХToolStripMenuItem
            // 
            this.відобразитиСиметричноВідносноОсіОХToolStripMenuItem.Name = "відобразитиСиметричноВідносноОсіОХToolStripMenuItem";
            this.відобразитиСиметричноВідносноОсіОХToolStripMenuItem.Size = new System.Drawing.Size(523, 26);
            this.відобразитиСиметричноВідносноОсіОХToolStripMenuItem.Text = "Відобразити симетрично відносно осі ОХ";
            this.відобразитиСиметричноВідносноОсіОХToolStripMenuItem.Click += new System.EventHandler(this.відобразитиСиметричноВідносноОсіОХToolStripMenuItem_Click);
            // 
            // відобразитиСиметричноВідносноОсіОУToolStripMenuItem
            // 
            this.відобразитиСиметричноВідносноОсіОУToolStripMenuItem.Name = "відобразитиСиметричноВідносноОсіОУToolStripMenuItem";
            this.відобразитиСиметричноВідносноОсіОУToolStripMenuItem.Size = new System.Drawing.Size(523, 26);
            this.відобразитиСиметричноВідносноОсіОУToolStripMenuItem.Text = "Відобразити симетрично відносно осі ОУ";
            this.відобразитиСиметричноВідносноОсіОУToolStripMenuItem.Click += new System.EventHandler(this.відобразитиСиметричноВідносноОсіОУToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 570);
            this.Controls.Add(this.numericUpDownFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownInit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найбільшеВідємнеЗначенняToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownInit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem чиПеретинаєГрафікФункціїВісьОХToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вЯкомуКвадрантіБільшеТочокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem середнєЗначенняФункціїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найменшеДодатнеЗначенняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наближеноЗнайтиТочкуПеретинуГрафікаФункціїІВіссюОХToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спаднаЧиЗростаючаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найменшеТаНайбільшеЗначенняФункціїНаПроміжкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem побудуватиГрафікToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відобразитиСиметричноВідносноОсіОХToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відобразитиСиметричноВідносноОсіОУToolStripMenuItem;
    }
}

