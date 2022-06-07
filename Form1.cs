using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTO_Forms;

public partial class Form1 : Form
{
    readonly Service service;
    public Form1()
    {
        InitializeComponent();
        service = Service.GetService();
        panel_Customer.Visible = false;
        panel_Car.Visible = false;
        panelMaster.Visible = false;
        panelWork.Visible = false;

        var idCarRemuve = new List<int>();


    }

    private void Form1_Load(object sender, EventArgs e)
    {
        String[] args = Environment.GetCommandLineArgs();

    }

    private void Paint_Customer()
    {
        dataGridCustomer.DataSource = service.ListCustomer;
        dataGridCustomer.Columns[0].Visible = false;
        dataGridCustomer.Columns[0].HeaderText = "ID";
        dataGridCustomer.Columns[1].HeaderText = "ПІБ";
        dataGridCustomer.Columns[1].Width = 220;
        dataGridCustomer.Columns[2].HeaderText = "ID паспорта";
        dataGridCustomer.Columns[2].Width = 150;
        dataGridCustomer.Columns[3].HeaderText = "Адрес";
        dataGridCustomer.Columns[3].Width = 250;
        dataGridCustomer.Columns[4].HeaderText = "Дата народження";
        dataGridCustomer.Columns[4].Width = 85;
        dataGridCustomer.Columns[5].Visible = false;
    }
    private void Paint_Car()
    {

        var q2 = from customer in service.ListCustomer
                 join car in service.ListCar on customer.IdCustomer equals car.IdCustomer
                 select new
                 { 
                     Brand = car.Brand,
                     Color = car.Color,
                     Number = car.Number,
                     DataBindings = car.DateOfRelease,
                     Owner = customer.FName,
                     IdCar = car.IdCar
                 };
                     
        dataGridCar.DataSource = q2.ToList();
        dataGridCar.Columns[0].HeaderText = "Марка";
        dataGridCar.Columns[1].HeaderText = "Колір";
        dataGridCar.Columns[2].HeaderText = "Державний номер";
        dataGridCar.Columns[2].Width = 150;
        dataGridCar.Columns[3].HeaderText = "Рік випуску";
        dataGridCar.Columns[4].HeaderText = "Власник";
        dataGridCar.Columns[4].Width = 220;
        dataGridCar.Columns[5].Visible = false;
        
    }
    private void Paint_Work()
    {

        var q = from work in service.ListWork
                join car in service.ListCar on work.IdCar equals car.IdCar
                join worker in service.ListWorker on work.IdWorker equals worker.IdWorker 
                select new
                {
                    WorkerName = worker.FullNameOfWorker,
                    CarName = car.Brand,
                    CarNumber = car.Number,
                    WorkDate = work.DateOfWork,
                    WorkDeffects = work.Deffects,
                    PriceOfWork = work.Price,
                    PriceOfDetails = work.PriceOfDetails,
                };
        dataGridWork.DataSource = q.ToList();
        dataGridWork.Columns[0].HeaderText = "ПІБ мастера";
        dataGridWork.Columns[0].Width = 220;
        dataGridWork.Columns[1].HeaderText = "Назва авто";
        dataGridWork.Columns[1].Width = 150;
        dataGridWork.Columns[2].HeaderText = "Державний номер";
        dataGridWork.Columns[2].Width = 120;
        dataGridWork.Columns[3].HeaderText = "Дата";
        dataGridWork.Columns[3].Width = 100;
        dataGridWork.Columns[4].HeaderText = "Список дефектов";
        dataGridWork.Columns[4].Width = 250;
        dataGridWork.Columns[5].HeaderText = "Цiна роботи";
        dataGridWork.Columns[5].Width = 90;
        dataGridWork.Columns[6].HeaderText = "Цiна запчастин";
        dataGridWork.Columns[6].Width = 100;
    }
    private void Paint_Work_1(string s)
    {

        var q = from work in service.ListWork
                join car in service.ListCar on work.IdCar equals car.IdCar
                join worker in service.ListWorker on work.IdWorker equals worker.IdWorker where work.DateOfWork.ToString() == s
                select new
                {
                    WorkerName = worker.FullNameOfWorker,
                    CarName = car.Brand,
                    CarNumber = car.Number,
                    WorkDate = work.DateOfWork,
                    WorkDeffects = work.Deffects,
                    PriceOfWork = work.Price,
                    PriceOfDetails = work.PriceOfDetails,
                };

        dataGridRequest.DataSource = null;
        dataGridRequest.DataSource = q.ToList();
        dataGridRequest.Columns[0].HeaderText = "ПІБ мастера";
        dataGridRequest.Columns[0].Width = 220;
        dataGridRequest.Columns[1].HeaderText = "Назва авто";
        dataGridRequest.Columns[1].Width = 150;
        dataGridRequest.Columns[2].HeaderText = "Державний номер";
        dataGridRequest.Columns[2].Width = 120;
        dataGridRequest.Columns[3].HeaderText = "Дата";
        dataGridRequest.Columns[3].Width = 100;
        dataGridRequest.Columns[4].HeaderText = "Список дефектов";
        dataGridRequest.Columns[4].Width = 250;
        dataGridRequest.Columns[5].HeaderText = "Цiна роботи";
        dataGridRequest.Columns[5].Width = 90;
        dataGridRequest.Columns[6].HeaderText = "Цiна запчастин";
        dataGridRequest.Columns[6].Width = 100;
    }
    private void Paint_Worker()
    {
        dataGridWorker.DataSource = service.ListWorker;
        dataGridWorker.Columns[0].Visible = false;
        dataGridWorker.Columns[0].HeaderText = "ID";
        dataGridWorker.Columns[1].HeaderText = "ПІБ";
        dataGridWorker.Columns[1].Width = 220;
        dataGridWorker.Columns[2].HeaderText = "Спеціалізація";
        dataGridWorker.Columns[2].Width = 150;
        dataGridWorker.Columns[3].HeaderText = "Ранг";
        dataGridWorker.Columns[4].Visible = false;
    }
  

    //Read File
    private void button1_Click(object sender, EventArgs e)
    {
        dataGridCustomer.DataSource = null;
        dataGridCar.DataSource = null;
        dataGridWorker.DataSource = null;
        dataGridWork.DataSource = null;
        service.ListCustomer.Clear();
        service.ListCar.Clear();
        service.ListWorker.Clear();
        service.ListWork.Clear();

        string filesDir = FileID.Text.Trim();
        if (filesDir.Last() == '\\')
        {
            Program.FileRead_Customer(filesDir + "Customer.txt");
            Program.FileRead_Car(filesDir + "Car.txt");
            Program.FileRead_Worker(filesDir + "Worker.txt");
            Program.FileRead_Work(filesDir + "Work.txt");
        }
        else
        {
            Program.FileRead_Customer(filesDir + "\\Customer.txt");
            Program.FileRead_Car(filesDir + "\\Car.txt");
            Program.FileRead_Worker(filesDir + "\\Worker.txt");
            Program.FileRead_Work(filesDir + "\\Work.txt");
        }

        Paint_Customer();
        Paint_Car();
        Paint_Work();
        Paint_Worker();

        panelMaintenance.Visible = false;
        
    }
    //Rewrite File
    private void button2_Click(object sender, EventArgs e)
    {
        if (ButtonWrite.Text.Trim().Length > 0) ButtonWrite.Enabled = true;
        string filesDir = FileID.Text.Trim();
        if (filesDir.Last() == '\\')
        {
            Program.FileWrite_Customer(filesDir + "Customer.txt");
            Program.FileWrite_Car(filesDir + "Car.txt");
            Program.FileWrite_Work(filesDir + "Work.txt");
            Program.FileWrite_Worker(filesDir + "Worker.txt");
        }
        else
        {
            Program.FileWrite_Customer(filesDir + "\\Customer.txt");
            Program.FileWrite_Car(filesDir + "\\Car.txt");
            Program.FileWrite_Work(filesDir + "\\Work.txt");
            Program.FileWrite_Worker(filesDir + "\\Worker.txt");
        }
    }
    private void buttonDelCustomer_Click(object sender, EventArgs e)
    {
        string surname = "" + Convert.ToString(dataGridCustomer.CurrentRow.Cells[2].Value);
        string name = (string)(dataGridCustomer.CurrentRow.Cells[1].Value);
        int key = (int)(dataGridCustomer.CurrentRow.Cells[0].Value);
        if (MessageBox.Show("Удалить покупателя " + name + " " + surname + "?", "Удаление покупателя",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
            foreach (Customer c in service.ListCustomer)
            {
                if (c.IdCustomer == key)
                { service.ListCustomer.Remove(c); break; }
            }
            foreach (Car c in service.ListCar)
            {
                if (c.IdCar == key)
                { service.ListCar.Remove(c); comboBoxRequest.Items.Remove(Convert.ToString(key)); break; }
            }

            service.ListCustomer.RemoveAll(c => (c.IdCustomer == key));

            dataGridCustomer.DataSource = null;
            Paint_Customer();
            Paint_Car();
            dataGridCustomer.Refresh();

            service.ListCar.RemoveAll(c => (c.IdCustomer == key));

            Paint_Work();
        }
    }
    private void buttonAddCustomer_Click(object sender, EventArgs e)
    {
        textBoxCustomer1.Text = "";
        textBoxCustomer2.Text = "";
        textBoxCustomer3.Text = "";
        panel_Customer.Visible = true;
    }
    private void buttonCustomer_Cancel_Click(object sender, EventArgs e)
    {
        panel_Customer.Visible = false;
    }
    private void buttonCustomer_Ok_Click(object sender, EventArgs e)
    {
        do
        {
            if (textBoxCustomer1.Text == "" || textBoxCustomer2.Text == "" || textBoxCustomer3.Text == "") break;
            string fullName = textBoxCustomer1.Text;
            string address = textBoxCustomer2.Text;
            string idPassport = textBoxCustomer3.Text;
            DateTime birth = dateTimePickerCustomer.Value.Date;
            service.AddCustomer(Convert.ToInt32(Customer._id), fullName, idPassport, address, Convert.ToDateTime(birth));
            dataGridCustomer.Refresh();

            dataGridCustomer.DataSource = null;
            dataGridCustomer.DataSource = service.ListCustomer;
            dataGridCustomer.CurrentCell = dataGridCustomer[1, dataGridCustomer.Rows.Count - 1];
            Paint_Customer();
            dataGridCustomer.Refresh();
            panel_Customer.Visible = true;
            textBoxCustomer1.Text = "";
            textBoxCustomer2.Text = "";
            textBoxCustomer3.Text = "";
        } while (false);
    }
    private void buttonCar_Cancel_Click(object sender, EventArgs e)
    {
        panel_Car.Visible = false;
    }
    private void button2_Click_1(object sender, EventArgs e)
    {
        textBoxCar1.Text = "";
        textBoxCar2.Text = "";
        textBoxCar3.Text = "";
        textBoxCar4.Text = "";
        panel_Car.Visible = true;
    }
    private void buttonCar_Ok_Click(object sender, EventArgs e)
    {
        do
        {
            if (textBoxCar1.Text == "" || textBoxCar2.Text == "" || textBoxCar3.Text == "" || textBoxCar4.Text == "") break;
            string Name = textBoxCar1.Text;
            string Color = textBoxCar2.Text;
            string IdCustomer = textBoxCar4.Text;
            string Number = textBoxCar3.Text;
            int date = Convert.ToInt32(textBoxCar5.Text);
            service.AddCar(Name, Color, Number, Convert.ToInt32(Customer._id), Convert.ToInt32(IdCustomer), date);
            dataGridCar.Refresh();


            dataGridCar.DataSource = null;
            dataGridCar.DataSource = service.ListCar;
            dataGridCar.CurrentCell = dataGridCar[1, dataGridCar.Rows.Count - 1];
            Paint_Car();
            Paint_Customer();
            textBoxCar1.Text = "";
            textBoxCar2.Text = "";
            textBoxCar3.Text = "";
            textBoxCar4.Text = "";
        } while (false);
    }
    //del Car
    private void button1_Click_1(object sender, EventArgs e)
    {
        string idCustomer = "" + Convert.ToString(dataGridCar.CurrentRow.Cells[0].Value);
        string name = "" + Convert.ToString(dataGridCar.CurrentRow.Cells[2].Value);
        int key = (int)(dataGridCar.CurrentRow.Cells[5].Value);
        if (MessageBox.Show("Удалить авто " + name + " Власника = " + idCustomer + "?", "Удаление авто",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
        {
            foreach (Car c in service.ListCar)
            {
                if (c.IdCar == key)
                { service.ListCar.Remove(c); break; }
            }

            service.ListCar.RemoveAll(c => (c.IdCar == key));

            dataGridCar.DataSource = null;
            Paint_Car();
            dataGridCar.Refresh();

            service.ListCar.RemoveAll(c => (c.IdCustomer == key));

            Paint_Work();
        }
    }
    private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = comboBox.SelectedIndex+1;
        List <int> allCars = new List <int>();
        List <int> allJob = new List <int>();
        switch (index)
        {
            case 1:
                panelMaster.Visible = false;
                panelWork.Visible = false;
                comboBoxRequest.Items.Clear();

                comboBoxRequest.Items.Clear();
                panelMaintenance.Visible = true;
                int i = 1000;
                while (Car._id != i)
                {
                    i++;
                    foreach (Car car in service.ListCar)
                    {
                        if (car.IdCar == i)
                        {
                            foreach (Customer customer in service.ListCustomer)
                            {
                                if (car.IdCustomer == customer.IdCustomer)
                                {   if( !allCars.Contains(customer.IdCustomer ) ) { comboBoxRequest.Items.Add(customer.FName); }
                                    allCars.Add(customer.IdCustomer);
                                    break; 
                                }
                            }
                        }
                    }
                    
                }
                break;

            case 2:
                panelMaintenance.Visible = false;
                panelWork.Visible = false;
                comboBoxRequest.Items.Clear();
                panelMaster.Visible = true;
                int j = 1000;
                while (Worker._id != j)
                {
                    j++;
                    foreach (Car car in service.ListCar)
                    {
                        foreach (Work work in service.ListWork)
                        {
                            if (car.IdCar == work.IdCar)
                            {
                                foreach (Worker worker in service.ListWorker)
                                {
                                    if (worker.IdWorker == work.IdWorker)
                                    {
                                        if (!allJob.Contains(work.IdWorker)) { comboBoxMaster.Items.Add(worker.FullNameOfWorker); }
                                        allJob.Add(work.IdWorker);
                                        break;
                                    }
                                }
                            }
                        }
                    }

                }
                break;

            case 3:
                panelMaster.Visible = false;
                comboBoxRequest.Items.Clear();
                panelMaintenance.Visible = false;
                panelWork.Visible = true;
                break;
        }

    }
    // • Кто обслуживал заданного владельца автомобиля.
    private void comboBoxRequest_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = 1001 + Convert.ToInt32(comboBoxRequest.SelectedIndex);
        var request_1 = from worker in service.ListWorker
                        join work in service.ListWork on worker.IdWorker equals work.IdWorker
                        join car in service.ListCar on work.IdCar equals car.IdCar where car.IdCustomer == index
                        select new
                        {
                            FullNameOfMaster = worker.FullNameOfWorker,
                            Specialization = worker.Specialization,
                            Rank = worker.Rank,
                            Defects = work.Deffects,
                            Cost = work.PriceOfDetails,
                            NameCar = car.Brand,
                            CarDate = car.DateOfRelease,
        
                        };
        

        dataGridRequest.DataSource = null;
        dataGridRequest.Refresh();

        dataGridRequest.DataSource = request_1.ToList();
        dataGridRequest.Columns[0].HeaderText = "Iм'я майстра";
        dataGridRequest.Columns[0].Width = 220;
        dataGridRequest.Columns[1].HeaderText = "Спеціалізація";
        dataGridRequest.Columns[2].HeaderText = "Ранг";
        dataGridRequest.Columns[2].Width = 60;
        dataGridRequest.Columns[3].HeaderText = "Дефекти";
        dataGridRequest.Columns[3].Width = 250;
        dataGridRequest.Columns[4].HeaderText = "Вартість";
        dataGridRequest.Columns[5].HeaderText = "Марка авто";
        dataGridRequest.Columns[6].HeaderText = "Дата виготовлення ";
    }
    private void comboBoxMaster_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = 1001 + Convert.ToInt32(comboBoxMaster.SelectedIndex);
        var request_1 = from worker in service.ListWorker
                        join work in service.ListWork on worker.IdWorker equals work.IdWorker
                        join car in service.ListCar on work.IdCar equals car.IdCar
                        where car.IdCustomer == index
                        select new
                        {
                            NameCar = car.Brand,
                            NumberCar = car.Number,
                            Defects = work.Deffects,
                            Cost = work.Price,
                        };


        dataGridRequest.DataSource = null;
        dataGridRequest.Refresh();

        dataGridRequest.DataSource = request_1.ToList();
        dataGridRequest.Columns[0].HeaderText = "Марка авто";
        dataGridRequest.Columns[0].Width = 220;
        dataGridRequest.Columns[1].HeaderText = "Держ. номер";
        dataGridRequest.Columns[1].Width = 120;
        dataGridRequest.Columns[2].HeaderText = "Дефекти";
        dataGridRequest.Columns[2].Width = 250;
        dataGridRequest.Columns[3].HeaderText = "Вартість роботи";
        dataGridRequest.Columns[3].Width = 100;
    }


    private void dataGridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void label11_Click(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label17_Click(object sender, EventArgs e)
    {

    }

    private void dataGridWorker_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
    private void dataGridRequest_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    private void dataGridWork_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

    private void dateTimeDataOfWork_ValueChanged(object sender, EventArgs e)
    {

       
        Paint_Work_1(Convert.ToString(dateTimeDataOfWork.Value.Date));
    }
}

