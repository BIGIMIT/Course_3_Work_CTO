namespace CTO_Forms;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
        

        
    }

    public static void FileRead_Customer(string path)
    {
        Service sv = Service.GetService();
        StreamReader f1 = new StreamReader(path, System.Text.Encoding.UTF8);
        string str;
        while ((str = f1.ReadLine()) != null)
        {
            string[] ms = str.Split(';');
            sv.AddCustomer(Convert.ToInt32(ms[0]), ms[1], ms[2], ms[3], Convert.ToDateTime(ms[4]));
        }
        f1.Close();
    }
    public static void FileWrite_Customer(string path)
    {
        Service sv = Service.GetService();
        StreamWriter f1 = new StreamWriter(path, false, System.Text.Encoding.UTF8);
        
        foreach (Customer c in sv.ListCustomer)
        {
            
            f1.WriteLine(c.IdCustomer.ToString() + ';' + c.FullNameOfCustomer + ';' + c.IdPassport + ';' + c.Address +
                                                   ';' + c.DateOfBirth.ToString("d"));
        }
        f1.Close();
    }

    public static void FileRead_Car(string path)
    {
        Service sv = Service.GetService();
        StreamReader f1 = new StreamReader(path, System.Text.Encoding.UTF8);
        
        string str;
        while ((str = f1.ReadLine()) != null)
        {
            string[] ms = str.Split(';');
            sv.AddCar(ms[0], ms[1], ms[2], Convert.ToInt32(ms[3]),Convert.ToInt32(ms[4]),Convert.ToInt32(ms[5]));
        }
        f1.Close();
    }
    public static void FileWrite_Car(string path)
    {
        Service sv = Service.GetService();
        StreamWriter f1 = new StreamWriter(path, false, System.Text.Encoding.UTF8);
        
        foreach (Car p in sv.ListCar)
        {
            
            f1.WriteLine(p.Brand.ToString() + ';' + p.Color + ';' + p.Number.ToString() + ';' + p.IdCar.ToString() + 
                                              ';'+ p.IdCustomer.ToString() + ';' + p.DateOfRelease.ToString()) ;
        }
        f1.Close();
    }

    public static void FileRead_Worker(string path)
    {
        Service sv = Service.GetService();
        StreamReader f1 = new StreamReader(path, System.Text.Encoding.UTF8);
        string str;
        while ((str = f1.ReadLine()) != null)
        {
            string[] ms = str.Split(';');

            sv.AddWorker(ms[0], ms[1], Convert.ToInt32(ms[2]), Convert.ToInt32(ms[3]));
        }
        f1.Close();
    }
    public static void FileWrite_Worker(string path)
    {
        Service sv = Service.GetService();
        StreamWriter f1 = new StreamWriter(path, false, System.Text.Encoding.UTF8);
        foreach (Worker c in sv.ListWorker)
        {

            f1.WriteLine(c.FullNameOfWorker + ';' + c.Specialization + ';' + c.Rank.ToString() + ';' + c.IdWorker.ToString());
        }
        f1.Close();
    }

    public static void FileRead_Work(string path)
    {
        Service sv = Service.GetService();
        StreamReader f1 = new StreamReader(path, System.Text.Encoding.UTF8);
        string str;
        while ((str = f1.ReadLine()) != null)
        {
            string[] ms = str.Split(';');
            sv.AddWork(Convert.ToInt32(ms[0]), Convert.ToInt32(ms[1]), Convert.ToDateTime(ms[2]), ms[3], 
                    Convert.ToDecimal(ms[4]), Convert.ToDecimal(ms[5]));
        }
        f1.Close();
    }
    public static void FileWrite_Work(string path)
    {
        Service sv = Service.GetService();
        StreamWriter f1 = new StreamWriter(path, false, System.Text.Encoding.UTF8);
        foreach (Work c in sv.ListWork)
        {
            
            f1.WriteLine(c.IdWorker.ToString() + ';' + c.IdCar.ToString() + ';' + c.DateOfWork.ToString() + 
                                                 ';' + c.Deffects + ';' + c.Price.ToString() + ';' + c.PriceOfDetails.ToString());
        }
        f1.Close();
    }


}
class Service
{
    private string _serviceName;
    private string _serviceAddress;

    public string serviceName { get { return _serviceName; } }
    public string ServiceAddress { get { return _serviceAddress; } }


    public static Service? service;
    private Service(string name, string address)
    {
        _LCustomer = new List<Customer>();
        _LCar = new List<Car>();
        _LWorker = new List<Worker>();
        _LWork = new List<Work>();

        _serviceName = name;
        _serviceAddress = address;
    }
    public static Service GetService()
    {
        if (service == null) service = new Service("PRO-Service", "×åðí³ã³âñüêà îáëàñòü, ì³ñòî ×åðí³ã³â, ïðîñï. Âîëîäèìèðñüêà, 37");
        return service;
    }

    private List<Customer> _LCustomer;
    private List<Car> _LCar;
    private List<Worker> _LWorker;
    private List<Work> _LWork;

    public List<Customer> ListCustomer { get => _LCustomer; }
    public List<Car> ListCar { get => _LCar; }
    public List<Worker> ListWorker { get => _LWorker; }
    public List<Work> ListWork { get => _LWork; }

    public void AddCustomer(int idCustomer, string fName, string idPassport, string address, DateTime date)
    {
        _LCustomer.Add(new Customer(idCustomer, fName, idPassport, address, date));
    }
    public void AddCar(string brand, string color, string number, int idCar, int idCustomer, int date)
    {
        _LCar.Add(new Car(brand, color, number, idCar, idCustomer, date));
    }
    public void AddWorker(string fullName, string specialization, int rank, int idWorker)
    {
        _LWorker.Add(new Worker(fullName, specialization, rank, idWorker));
    }
    public void AddWork(int idWorker, int idCar, DateTime dateOfWork, string deffects, decimal price, decimal priceOfDetails)
    {
        _LWork.Add(new Work(idWorker, idCar, dateOfWork, deffects, price, priceOfDetails));


    }


}
class Customer
{
    private int _idÑustomer;
    private string _fullName;
    private string _idPassport;
    private string _Address;
    private DateTime _dateOfBirth;
    public static int _id = 1000;

    public Customer(int idÑustomer, string fName, string idPassport, string address, DateTime date)
    {
        _fullName = fName;
        _idPassport = idPassport;
        _Address = address;
        _idÑustomer = idÑustomer;
        _dateOfBirth = date;
        _id++;
    }

    public int IdCustomer { get { return _idÑustomer; } }
    public string FullNameOfCustomer { get { return _fullName; } }
    public string IdPassport { get { return _idPassport; } }
    public string Address { get { return _Address; } }
    public DateTime DateOfBirth { get { return _dateOfBirth; } } 
    public int ID { get { return _id; } }
    

}
class Car
{
    private int _idCar;
    private string _brand;
    private string _color;
    private string _number;
    private int _dateOfRelease;
    private int _idCustomer;
    public static int _id =1000;

    public Car(string brand, string color, string number, int idCar, int idCustomer, int date)
    {
        var service = Service.GetService();
        _brand = brand;
        _color = color;
        _number = number;
        _dateOfRelease = date;
        _idCustomer = idCustomer;
        _idCar = idCar;
        _id++;                
    }

    public int IdCar { get { return _idCar; } }
    public string Brand { get { return _brand; } }
    public string Color { get { return _color; } }
    public string Number { get { return _number; } }
    public int DateOfRelease { get { return _dateOfRelease; } }
    public int IdCustomer { get { return _idCustomer; } }
    

}
class Worker
{
    private int _idWorker;
    private string _fullNameOfWorker;
    private string _specialization;
    private int _rank;
    public static int _id = 1000;

    public Worker(string fullName, string specialization, int rank, int idWorker)
    {
        _fullNameOfWorker = fullName;
        _specialization = specialization;
        _rank = rank;
        _idWorker = idWorker;
        _id++;
    }

    public int IdWorker { get { return _idWorker; } }
    public string FullNameOfWorker { get { return _fullNameOfWorker; } }
    public string Specialization { get { return _specialization; } }
    public int Rank { get { return _rank; } }
    public int ID { get { return _id; } }
    

}
class Work
{
    private int _idWorker;
    private int _idCar;
    private DateTime _dateOfWork;
    private string _deffects;
    private decimal _price;
    private decimal _priceOfDetails;
    public static int _id = 1000;


    public Work(int idWorker, int idCar, DateTime dateOfWork, string deffects, decimal price, decimal priceOfDetails)
    {
        _idWorker = idWorker;
        _idCar = idCar;
        _dateOfWork = dateOfWork;
        _deffects = deffects;
        _price = price;
        _priceOfDetails = priceOfDetails;
        _id++;

        
    }

    public int IdWorker { get { return _idWorker; } }
    public int IdCar { get { return _idCar; } }
    public DateTime DateOfWork { get { return _dateOfWork; } }
    public string Deffects { get { return _deffects; } }
    public decimal Price { get { return _price; } }
    public decimal PriceOfDetails { get { return _priceOfDetails; } }
    public int ID { get { return _id; } }

}




