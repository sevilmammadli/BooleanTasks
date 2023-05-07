#region Practice  
#region Constructor

//Car bmwCar  = new ("BMW", "F10", 30000 );
////bmwCar.modelName = "BMW";  // Eger biz deyishenlerimizi private ederikse onlari burada chagira bilmerik
////bmwCar.modelType = "F10";
////bmwCar.price = 30000;

//Console.WriteLine(bmwCar.RentACar(3));


//class Car
//{
//    private string _modelName;
//    private string _modelType;
//    private int _price;


//    public Car(string modelName,string modelType, int price) 
//    {
//        _modelName = modelName;
//        _modelType = modelType;
//        _price = price;
//        //Console.WriteLine("There is constructor method"); // Constructor metod oldugu ucun sinfi cagiran kimi ilk ise dusur ve chalishir
//    }
//    public double RentACar (int hour)
//    {
//        return HoursPrice() * hour;
//    }

//    public double HoursPrice ()
//    {
//        return _price * 0.02;
//    }
//} 
#endregion

#region Getter and Setter

//using Project8_Encapsulation_.Classes;

//Student student = new();

//student.SetId(3);
//Console.WriteLine(student.GetId());

//student.SetAge(6);
//Console.WriteLine(student.GetAge());

//student.Name = "";
//Console.WriteLine(student.Name); 
#endregion

//using Project8_Encapsulation_.Classes;

//Food food = new ();


//food.FoodName = "Burger";
//food.GetFoodInformation(); 
#endregion

using Project8_Encapsulation_.Classes;

Hotel hotel = new Hotel();

hotel.HotelName = "Astoria";
hotel.Address = "Babek Prospekti";
hotel.RoomCount = 123;
hotel.RoomPrice = 100;
hotel.GetHotelInfo();
Console.WriteLine("Total price that you should pay:" + hotel.GetPriceRoom(3));

//student.Name = "";
//Console.WriteLine(student.Name); 