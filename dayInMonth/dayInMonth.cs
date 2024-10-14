internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap thang ma ban muon dem ngay");
        int month = int.Parse(Console.ReadLine());
        string dayInMonth;
        switch (month)
        {
            case 2:
            dayInMonth = "28 hoac 29";
            break;

            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
            dayInMonth = "31";
            break;

            case 4:
            case 6:
            case 9:
            case 11:
            dayInMonth = "30";
            break;

            default:
            dayInMonth = "";
            break;
        }

            if (dayInMonth != "")
            {
                System.Console.WriteLine($"Thang {month} co {dayInMonth} ngay");
            }
            else
            {
                System.Console.WriteLine("Ban nhap sai gia tri");
            }
    }
}