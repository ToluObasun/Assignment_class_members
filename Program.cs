using System;

class Phone
{
    // Class members
    private string brand;
    private string model;
    private double screenSize;
    private int batteryCapacity;

    // Constructor
    public Phone(string brand, string model, double screenSize, int batteryCapacity)
    {
        this.brand = brand;
        this.model = model;
        this.screenSize = screenSize;
        this.batteryCapacity = batteryCapacity;
    }

    // Property for Brand
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    // Property for Model
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    // Property for ScreenSize
    public double ScreenSize
    {
        get { return screenSize; }
        set { screenSize = value; }
    }

    // Property for BatteryCapacity
    public int BatteryCapacity
    {
        get { return batteryCapacity; }
        set { batteryCapacity = value; }
    }

    // Method to make a phone call
    public void MakeCall(string phoneNumber)
    {
        Console.WriteLine($"Calling {phoneNumber}...");
    }

    // Method to send a text message
    public void SendText(string phoneNumber, string message)
    {
        Console.WriteLine($"Sending text to {phoneNumber}: {message}");
    }

    // Method to display phone information
    public void DisplayPhoneInfo()
    {
        Console.WriteLine($"Phone Information:");
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Model: {model}");
        Console.WriteLine($"Screen Size: {screenSize} inches");
        Console.WriteLine($"Battery Capacity: {batteryCapacity} mAh");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Phone class
        Phone myPhone = new Phone("Samsung", "Galaxy S21", 6.2, 4000);

        // Use the properties and methods of the Phone class
        myPhone.DisplayPhoneInfo();
        myPhone.MakeCall("123-456-7890");
        myPhone.SendText("123-456-7890", "Hello there!");

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
