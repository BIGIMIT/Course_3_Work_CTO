namespace CTO_Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ButtonWrite = new System.Windows.Forms.Button();
            this.ButtonRewrite = new System.Windows.Forms.Button();
            this.TabCar = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_Car = new System.Windows.Forms.Panel();
            this.textBoxCar5 = new System.Windows.Forms.TextBox();
            this.textBoxCar4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxCar3 = new System.Windows.Forms.TextBox();
            this.buttonCar_Cancel = new System.Windows.Forms.Button();
            this.buttonCar_Ok = new System.Windows.Forms.Button();
            this.textBoxCar2 = new System.Windows.Forms.TextBox();
            this.textBoxCar1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridCar = new System.Windows.Forms.DataGridView();
            this.TabCustomer = new System.Windows.Forms.TabPage();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.panel_Customer = new System.Windows.Forms.Panel();
            this.textBoxCustomer3 = new System.Windows.Forms.TextBox();
            this.buttonCustomer_Cancel = new System.Windows.Forms.Button();
            this.buttonCustomer_Ok = new System.Windows.Forms.Button();
            this.textBoxCustomer2 = new System.Windows.Forms.TextBox();
            this.textBoxCustomer1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerCustomer = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDelCustomer = new System.Windows.Forms.Button();
            this.dataGridCustomer = new System.Windows.Forms.DataGridView();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabWorker = new System.Windows.Forms.TabPage();
            this.dataGridWorker = new System.Windows.Forms.DataGridView();
            this.TabWork = new System.Windows.Forms.TabPage();
            this.dataGridWork = new System.Windows.Forms.DataGridView();
            this.TabRequest = new System.Windows.Forms.TabPage();
            this.panelWork = new System.Windows.Forms.Panel();
            this.dateTimeDataOfWork = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.panelMaster = new System.Windows.Forms.Panel();
            this.comboBoxMaster = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panelMaintenance = new System.Windows.Forms.Panel();
            this.comboBoxRequest = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridRequest = new System.Windows.Forms.DataGridView();
            this.FileID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TabCar.SuspendLayout();
            this.panel_Car.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCar)).BeginInit();
            this.TabCustomer.SuspendLayout();
            this.panel_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorker)).BeginInit();
            this.TabWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWork)).BeginInit();
            this.TabRequest.SuspendLayout();
            this.panelWork.SuspendLayout();
            this.panelMaster.SuspendLayout();
            this.panelMaintenance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonWrite
            // 
            this.ButtonWrite.Location = new System.Drawing.Point(723, 547);
            this.ButtonWrite.Name = "ButtonWrite";
            this.ButtonWrite.Size = new System.Drawing.Size(170, 23);
            this.ButtonWrite.TabIndex = 3;
            this.ButtonWrite.Text = "Завантажити файли";
            this.ButtonWrite.UseVisualStyleBackColor = true;
            this.ButtonWrite.Click += new System.EventHandler(this.button_ReadFile);
            // 
            // ButtonRewrite
            // 
            this.ButtonRewrite.Location = new System.Drawing.Point(899, 547);
            this.ButtonRewrite.Name = "ButtonRewrite";
            this.ButtonRewrite.Size = new System.Drawing.Size(170, 23);
            this.ButtonRewrite.TabIndex = 4;
            this.ButtonRewrite.Text = "Переписати файли";
            this.ButtonRewrite.UseVisualStyleBackColor = true;
            this.ButtonRewrite.Click += new System.EventHandler(this.button_RewriteFile);
            // 
            // TabCar
            // 
            this.TabCar.Controls.Add(this.button1);
            this.TabCar.Controls.Add(this.button2);
            this.TabCar.Controls.Add(this.panel_Car);
            this.TabCar.Controls.Add(this.dataGridCar);
            this.TabCar.Location = new System.Drawing.Point(4, 24);
            this.TabCar.Name = "TabCar";
            this.TabCar.Padding = new System.Windows.Forms.Padding(3);
            this.TabCar.Size = new System.Drawing.Size(1452, 476);
            this.TabCar.TabIndex = 1;
            this.TabCar.Text = "Автомобилi";
            this.TabCar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Видалити авто";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_DelCar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Додати авто";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_AddCar_Click);
            // 
            // panel_Car
            // 
            this.panel_Car.Controls.Add(this.textBoxCar5);
            this.panel_Car.Controls.Add(this.textBoxCar4);
            this.panel_Car.Controls.Add(this.label12);
            this.panel_Car.Controls.Add(this.textBoxCar3);
            this.panel_Car.Controls.Add(this.buttonCar_Cancel);
            this.panel_Car.Controls.Add(this.buttonCar_Ok);
            this.panel_Car.Controls.Add(this.textBoxCar2);
            this.panel_Car.Controls.Add(this.textBoxCar1);
            this.panel_Car.Controls.Add(this.label2);
            this.panel_Car.Controls.Add(this.label8);
            this.panel_Car.Controls.Add(this.label9);
            this.panel_Car.Controls.Add(this.label10);
            this.panel_Car.Controls.Add(this.label11);
            this.panel_Car.Location = new System.Drawing.Point(848, 6);
            this.panel_Car.Name = "panel_Car";
            this.panel_Car.Size = new System.Drawing.Size(566, 376);
            this.panel_Car.TabIndex = 4;
            // 
            // textBoxCar5
            // 
            this.textBoxCar5.Location = new System.Drawing.Point(222, 240);
            this.textBoxCar5.Name = "textBoxCar5";
            this.textBoxCar5.Size = new System.Drawing.Size(243, 23);
            this.textBoxCar5.TabIndex = 14;
            // 
            // textBoxCar4
            // 
            this.textBoxCar4.Location = new System.Drawing.Point(222, 197);
            this.textBoxCar4.Name = "textBoxCar4";
            this.textBoxCar4.Size = new System.Drawing.Size(243, 23);
            this.textBoxCar4.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(97, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "ID власника";
            // 
            // textBoxCar3
            // 
            this.textBoxCar3.Location = new System.Drawing.Point(222, 157);
            this.textBoxCar3.Name = "textBoxCar3";
            this.textBoxCar3.Size = new System.Drawing.Size(243, 23);
            this.textBoxCar3.TabIndex = 11;
            // 
            // buttonCar_Cancel
            // 
            this.buttonCar_Cancel.Location = new System.Drawing.Point(338, 308);
            this.buttonCar_Cancel.Name = "buttonCar_Cancel";
            this.buttonCar_Cancel.Size = new System.Drawing.Size(200, 24);
            this.buttonCar_Cancel.TabIndex = 10;
            this.buttonCar_Cancel.Text = "Cancel";
            this.buttonCar_Cancel.UseVisualStyleBackColor = true;
            this.buttonCar_Cancel.Click += new System.EventHandler(this.button_CancelCar_Click);
            // 
            // buttonCar_Ok
            // 
            this.buttonCar_Ok.Location = new System.Drawing.Point(25, 308);
            this.buttonCar_Ok.Name = "buttonCar_Ok";
            this.buttonCar_Ok.Size = new System.Drawing.Size(200, 24);
            this.buttonCar_Ok.TabIndex = 5;
            this.buttonCar_Ok.Text = "OK";
            this.buttonCar_Ok.UseVisualStyleBackColor = true;
            this.buttonCar_Ok.Click += new System.EventHandler(this.button_OkCar_Click);
            // 
            // textBoxCar2
            // 
            this.textBoxCar2.Location = new System.Drawing.Point(222, 117);
            this.textBoxCar2.Name = "textBoxCar2";
            this.textBoxCar2.Size = new System.Drawing.Size(243, 23);
            this.textBoxCar2.TabIndex = 8;
            // 
            // textBoxCar1
            // 
            this.textBoxCar1.Location = new System.Drawing.Point(222, 77);
            this.textBoxCar1.Name = "textBoxCar1";
            this.textBoxCar1.Size = new System.Drawing.Size(243, 23);
            this.textBoxCar1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата випуску";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Серійний номер";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Колiр";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Марка";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(187, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Додавання нового Авто";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dataGridCar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridCar.Location = new System.Drawing.Point(6, 6);
            this.dataGridCar.MultiSelect = false;
            this.dataGridCar.Name = "dataGridCar";
            this.dataGridCar.RowTemplate.Height = 25;
            this.dataGridCar.Size = new System.Drawing.Size(757, 376);
            this.dataGridCar.TabIndex = 1;
            // 
            // TabCustomer
            // 
            this.TabCustomer.Controls.Add(this.buttonAddCustomer);
            this.TabCustomer.Controls.Add(this.panel_Customer);
            this.TabCustomer.Controls.Add(this.buttonDelCustomer);
            this.TabCustomer.Controls.Add(this.dataGridCustomer);
            this.TabCustomer.Location = new System.Drawing.Point(4, 24);
            this.TabCustomer.Name = "TabCustomer";
            this.TabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.TabCustomer.Size = new System.Drawing.Size(1452, 476);
            this.TabCustomer.TabIndex = 0;
            this.TabCustomer.Text = "Власники";
            this.TabCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(82, 413);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(200, 24);
            this.buttonAddCustomer.TabIndex = 12;
            this.buttonAddCustomer.Text = "Додати власника";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.button_AddCustomer_Click);
            // 
            // panel_Customer
            // 
            this.panel_Customer.Controls.Add(this.textBoxCustomer3);
            this.panel_Customer.Controls.Add(this.buttonCustomer_Cancel);
            this.panel_Customer.Controls.Add(this.buttonCustomer_Ok);
            this.panel_Customer.Controls.Add(this.textBoxCustomer2);
            this.panel_Customer.Controls.Add(this.textBoxCustomer1);
            this.panel_Customer.Controls.Add(this.dateTimePickerCustomer);
            this.panel_Customer.Controls.Add(this.label7);
            this.panel_Customer.Controls.Add(this.label6);
            this.panel_Customer.Controls.Add(this.label5);
            this.panel_Customer.Controls.Add(this.label4);
            this.panel_Customer.Controls.Add(this.label3);
            this.panel_Customer.Location = new System.Drawing.Point(848, 6);
            this.panel_Customer.Name = "panel_Customer";
            this.panel_Customer.Size = new System.Drawing.Size(566, 376);
            this.panel_Customer.TabIndex = 3;
            // 
            // textBoxCustomer3
            // 
            this.textBoxCustomer3.Location = new System.Drawing.Point(222, 157);
            this.textBoxCustomer3.Name = "textBoxCustomer3";
            this.textBoxCustomer3.Size = new System.Drawing.Size(243, 23);
            this.textBoxCustomer3.TabIndex = 11;
            // 
            // buttonCustomer_Cancel
            // 
            this.buttonCustomer_Cancel.Location = new System.Drawing.Point(338, 308);
            this.buttonCustomer_Cancel.Name = "buttonCustomer_Cancel";
            this.buttonCustomer_Cancel.Size = new System.Drawing.Size(200, 24);
            this.buttonCustomer_Cancel.TabIndex = 10;
            this.buttonCustomer_Cancel.Text = "Cancel";
            this.buttonCustomer_Cancel.UseVisualStyleBackColor = true;
            this.buttonCustomer_Cancel.Click += new System.EventHandler(this.button_CancelCustomer_Click);
            // 
            // buttonCustomer_Ok
            // 
            this.buttonCustomer_Ok.Location = new System.Drawing.Point(25, 308);
            this.buttonCustomer_Ok.Name = "buttonCustomer_Ok";
            this.buttonCustomer_Ok.Size = new System.Drawing.Size(200, 24);
            this.buttonCustomer_Ok.TabIndex = 5;
            this.buttonCustomer_Ok.Text = "OK";
            this.buttonCustomer_Ok.UseVisualStyleBackColor = true;
            this.buttonCustomer_Ok.Click += new System.EventHandler(this.button_OkCustomer_Click);
            // 
            // textBoxCustomer2
            // 
            this.textBoxCustomer2.Location = new System.Drawing.Point(222, 117);
            this.textBoxCustomer2.Name = "textBoxCustomer2";
            this.textBoxCustomer2.Size = new System.Drawing.Size(243, 23);
            this.textBoxCustomer2.TabIndex = 8;
            // 
            // textBoxCustomer1
            // 
            this.textBoxCustomer1.Location = new System.Drawing.Point(222, 77);
            this.textBoxCustomer1.Name = "textBoxCustomer1";
            this.textBoxCustomer1.Size = new System.Drawing.Size(243, 23);
            this.textBoxCustomer1.TabIndex = 7;
            // 
            // dateTimePickerCustomer
            // 
            this.dateTimePickerCustomer.Location = new System.Drawing.Point(222, 196);
            this.dateTimePickerCustomer.Name = "dateTimePickerCustomer";
            this.dateTimePickerCustomer.Size = new System.Drawing.Size(243, 23);
            this.dateTimePickerCustomer.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Дата народження";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "ID Паспорта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Адреса";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "ПIБ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(171, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Додавання нового Власника";
            // 
            // buttonDelCustomer
            // 
            this.buttonDelCustomer.Location = new System.Drawing.Point(462, 413);
            this.buttonDelCustomer.Name = "buttonDelCustomer";
            this.buttonDelCustomer.Size = new System.Drawing.Size(200, 24);
            this.buttonDelCustomer.TabIndex = 2;
            this.buttonDelCustomer.Text = "Видалити власника";
            this.buttonDelCustomer.UseVisualStyleBackColor = true;
            this.buttonDelCustomer.Click += new System.EventHandler(this.button_DelCustomer_Click);
            // 
            // dataGridCustomer
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomer.Location = new System.Drawing.Point(6, 6);
            this.dataGridCustomer.Name = "dataGridCustomer";
            this.dataGridCustomer.RowTemplate.Height = 25;
            this.dataGridCustomer.Size = new System.Drawing.Size(757, 376);
            this.dataGridCustomer.TabIndex = 0;
            this.dataGridCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomer_CellContentClick);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabCustomer);
            this.TabControl.Controls.Add(this.TabCar);
            this.TabControl.Controls.Add(this.TabWorker);
            this.TabControl.Controls.Add(this.TabWork);
            this.TabControl.Controls.Add(this.TabRequest);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1460, 504);
            this.TabControl.TabIndex = 0;
            // 
            // TabWorker
            // 
            this.TabWorker.Controls.Add(this.dataGridWorker);
            this.TabWorker.Location = new System.Drawing.Point(4, 24);
            this.TabWorker.Name = "TabWorker";
            this.TabWorker.Size = new System.Drawing.Size(1452, 476);
            this.TabWorker.TabIndex = 3;
            this.TabWorker.Text = "Працiвник";
            this.TabWorker.UseVisualStyleBackColor = true;
            // 
            // dataGridWorker
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridWorker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWorker.Location = new System.Drawing.Point(6, 6);
            this.dataGridWorker.Name = "dataGridWorker";
            this.dataGridWorker.RowTemplate.Height = 25;
            this.dataGridWorker.Size = new System.Drawing.Size(757, 376);
            this.dataGridWorker.TabIndex = 2;
            this.dataGridWorker.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridWorker_CellContentClick);
            // 
            // TabWork
            // 
            this.TabWork.Controls.Add(this.dataGridWork);
            this.TabWork.Location = new System.Drawing.Point(4, 24);
            this.TabWork.Name = "TabWork";
            this.TabWork.Size = new System.Drawing.Size(1452, 476);
            this.TabWork.TabIndex = 2;
            this.TabWork.Text = "Робота";
            this.TabWork.UseVisualStyleBackColor = true;
            // 
            // dataGridWork
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridWork.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWork.Location = new System.Drawing.Point(6, 6);
            this.dataGridWork.Name = "dataGridWork";
            this.dataGridWork.RowTemplate.Height = 25;
            this.dataGridWork.Size = new System.Drawing.Size(1443, 467);
            this.dataGridWork.TabIndex = 2;
            this.dataGridWork.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridWork_CellContentClick);
            // 
            // TabRequest
            // 
            this.TabRequest.Controls.Add(this.panelWork);
            this.TabRequest.Controls.Add(this.panelMaster);
            this.TabRequest.Controls.Add(this.panelMaintenance);
            this.TabRequest.Controls.Add(this.comboBox);
            this.TabRequest.Controls.Add(this.dataGridRequest);
            this.TabRequest.Location = new System.Drawing.Point(4, 24);
            this.TabRequest.Name = "TabRequest";
            this.TabRequest.Size = new System.Drawing.Size(1452, 476);
            this.TabRequest.TabIndex = 4;
            this.TabRequest.Text = "Запити";
            this.TabRequest.UseVisualStyleBackColor = true;
            // 
            // panelWork
            // 
            this.panelWork.Controls.Add(this.dateTimeDataOfWork);
            this.panelWork.Controls.Add(this.label15);
            this.panelWork.Location = new System.Drawing.Point(1173, 240);
            this.panelWork.Name = "panelWork";
            this.panelWork.Size = new System.Drawing.Size(267, 99);
            this.panelWork.TabIndex = 8;
            // 
            // dateTimeDataOfWork
            // 
            this.dateTimeDataOfWork.Location = new System.Drawing.Point(3, 63);
            this.dateTimeDataOfWork.Name = "dateTimeDataOfWork";
            this.dateTimeDataOfWork.Size = new System.Drawing.Size(261, 23);
            this.dateTimeDataOfWork.TabIndex = 6;
            this.dateTimeDataOfWork.ValueChanged += new System.EventHandler(this.dateTime_DataOfWork_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(70, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 21);
            this.label15.TabIndex = 5;
            this.label15.Text = "Виберіть дату";
            // 
            // panelMaster
            // 
            this.panelMaster.Controls.Add(this.comboBoxMaster);
            this.panelMaster.Controls.Add(this.label14);
            this.panelMaster.Location = new System.Drawing.Point(1173, 124);
            this.panelMaster.Name = "panelMaster";
            this.panelMaster.Size = new System.Drawing.Size(267, 99);
            this.panelMaster.TabIndex = 7;
            // 
            // comboBoxMaster
            // 
            this.comboBoxMaster.FormattingEnabled = true;
            this.comboBoxMaster.Location = new System.Drawing.Point(3, 64);
            this.comboBoxMaster.Name = "comboBoxMaster";
            this.comboBoxMaster.Size = new System.Drawing.Size(261, 23);
            this.comboBoxMaster.TabIndex = 6;
            this.comboBoxMaster.SelectedIndexChanged += new System.EventHandler(this.comboBox_Master_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(42, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 21);
            this.label14.TabIndex = 5;
            this.label14.Text = "Виберіть ПІБ майстра";
            // 
            // panelMaintenance
            // 
            this.panelMaintenance.Controls.Add(this.comboBoxRequest);
            this.panelMaintenance.Controls.Add(this.label13);
            this.panelMaintenance.Location = new System.Drawing.Point(1173, 8);
            this.panelMaintenance.Name = "panelMaintenance";
            this.panelMaintenance.Size = new System.Drawing.Size(267, 99);
            this.panelMaintenance.TabIndex = 6;
            // 
            // comboBoxRequest
            // 
            this.comboBoxRequest.FormattingEnabled = true;
            this.comboBoxRequest.Location = new System.Drawing.Point(3, 64);
            this.comboBoxRequest.Name = "comboBoxRequest";
            this.comboBoxRequest.Size = new System.Drawing.Size(261, 23);
            this.comboBoxRequest.TabIndex = 6;
            this.comboBoxRequest.SelectedIndexChanged += new System.EventHandler(this.comboBox_Customer_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(42, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 21);
            this.label13.TabIndex = 5;
            this.label13.Text = "Виберіть ПІБ власника";
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Автомобiлi заданого власника",
            "Обслугововані автомобілі заданого майстра",
            "Робота за заданим часом"});
            this.comboBox.Location = new System.Drawing.Point(6, 419);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(1152, 29);
            this.comboBox.TabIndex = 5;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_Request_SelectedIndexChanged);
            // 
            // dataGridRequest
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRequest.Location = new System.Drawing.Point(6, 8);
            this.dataGridRequest.Name = "dataGridRequest";
            this.dataGridRequest.RowTemplate.Height = 25;
            this.dataGridRequest.Size = new System.Drawing.Size(1152, 389);
            this.dataGridRequest.TabIndex = 3;
            this.dataGridRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRequest_CellContentClick);
            // 
            // FileID
            // 
            this.FileID.Location = new System.Drawing.Point(137, 547);
            this.FileID.Name = "FileID";
            this.FileID.Size = new System.Drawing.Size(580, 23);
            this.FileID.TabIndex = 5;
            this.FileID.Text = "C:\\\\MyProject\\\\studyes\\\\Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Каталог із файлами";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileID);
            this.Controls.Add(this.ButtonRewrite);
            this.Controls.Add(this.ButtonWrite);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TabCar.ResumeLayout(false);
            this.panel_Car.ResumeLayout(false);
            this.panel_Car.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCar)).EndInit();
            this.TabCustomer.ResumeLayout(false);
            this.panel_Customer.ResumeLayout(false);
            this.panel_Customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomer)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabWorker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorker)).EndInit();
            this.TabWork.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWork)).EndInit();
            this.TabRequest.ResumeLayout(false);
            this.panelWork.ResumeLayout(false);
            this.panelWork.PerformLayout();
            this.panelMaster.ResumeLayout(false);
            this.panelMaster.PerformLayout();
            this.panelMaintenance.ResumeLayout(false);
            this.panelMaintenance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button ButtonWrite;
        private Button ButtonRewrite;
        private TabPage TabCar;
        private TabPage TabCustomer;
        private TabControl TabControl;
        private TextBox FileID;
        private Label label1;
        private Button buttonDelCustomer;
        private DataGridView dataGridCustomer;
        private Panel panel_Customer;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button buttonCustomer_Cancel;
        private Button buttonCustomer_Ok;
        private TextBox textBoxCustomer2;
        private TextBox textBoxCustomer1;
        private DateTimePicker dateTimePickerCustomer;
        private TabPage TabWork;
        private TabPage TabWorker;
        private DataGridView dataGridCar;
        private DataGridView dataGridWorker;
        private DataGridView dataGridWork;
        private TextBox textBoxCustomer3;
        private Panel panel_Car;
        private TextBox textBoxCar3;
        private Button buttonCar_Cancel;
        private Button buttonCar_Ok;
        private TextBox textBoxCar2;
        private TextBox textBoxCar1;
        private Label label2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBoxCar4;
        private Label label12;
        private Button button1;
        private Button button2;
        private Button buttonAddCustomer;
        private TabPage TabRequest;
        private DataGridView dataGridRequest;
        private ComboBox comboBox;
        private Panel panelMaintenance;
        private ComboBox comboBoxRequest;
        private Label label13;
        private TextBox textBoxCar5;
        private Panel panelMaster;
        private ComboBox comboBoxMaster;
        private Label label14;
        private Panel panelWork;
        private DateTimePicker dateTimeDataOfWork;
        private Label label15;
    }
}