using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;


Console.OutputEncoding = Encoding.UTF8;
#region BaiTap01
/*
Console.WriteLine("****Tính ngày trong tuần****");
Console.WriteLine("Mời bạn nhập số ngày cần tính");
int date = int.Parse(Console.ReadLine());
int week = 7;
string resultWeek = "";
int resultDay = 0; //Lưu giá trị ngày lẻ

if (date != 0)
{

    if (date < week)
    {
        resultDay = date;
        Console.WriteLine($"Số ngày bạn nhập là {resultDay} chưa đạt một tuần");
    }
    else
    {
        if (date < week * 4 + 2)
        {
            if (date >= week && date < week + 7)
            {
                resultWeek = "Một tuần";
                if (week == date)
                {
                    resultDay = resultDay;
                }
                else
                {
                    resultDay = date - week;
                }
                Console.WriteLine($"{resultWeek} {resultDay} ngày");
            }
            else if (date >= week * 2 && date < week * 2 + 7)
            {
                resultWeek = "Hai tuần";
                if (week * 2 == date)
                {
                    resultDay = resultDay;
                }
                else
                {
                    resultDay = date - (week * 2);
                }
                Console.WriteLine($"{resultWeek} {resultDay} ngày");
            }
            else if (date >= week * 3 && date < week * 3 + 7)
            {
                resultWeek = "Ba tuần";
                if (week * 3 == date)
                {
                    resultDay = resultDay;
                }
                else
                {
                    resultDay = date - (week * 3);
                }
                Console.WriteLine($"{resultWeek} {resultDay} ngày");
            }
            else if (date >= week * 4 && date < week * 4 + 2)
            {
                resultWeek = "Bốn tuần";
                if (week * 4 == date)
                {
                    resultDay = resultDay;
                }
                else
                {
                    resultDay = date - (week * 4);
                }
                Console.WriteLine($"{resultWeek} {resultDay} ngày");
            }
        }
        else
        {
            Console.WriteLine("Số ngày bạn nhập đã thành một tháng. Vui lòng nhập lại");
        }
    }
}
else
{
    Console.WriteLine("Vui lòng nhập số ngày cần kiểm tra trong tuần");
}*/
#endregion

#region BaiTap02
// Console.WriteLine("****Tính tổng số tiền sau khi giảm giá****");
// Console.WriteLine("Mời bạn nhập vào giá trị đơn hàng cần tính");
// double price = double.Parse(Console.ReadLine());
// Console.WriteLine("Mời bạn nhập vào phần trăm giảm giá");
// double voucher = double.Parse(Console.ReadLine());
// double result = (voucher * price) / 100;

// Console.WriteLine($"Số tiền bạn được giảm từ đơn hàng ban đầu là: {(voucher * price) / 100}Vnđ \n " +
//     $"Tổng số tiền còn lại bạn phải thanh toán là {price - result}Vnđ");
#endregion

#region BaiTap03
/*Console.WriteLine("****Chuyển đổi thời gian từ giờ sang phút và ngược lại****");

Console.WriteLine("Mời bạn chọn chương trình chuyển đổi: ");
Console.WriteLine("1. Bộ chuyển đổi từ phút sang giờ");
Console.WriteLine("2. Bộ chuyển đổi từ giờ sang phút");

int menu = int.Parse(Console.ReadLine());
int house = 60;
if (menu == 1)
{
    Console.WriteLine("Mời bạn nhập vào thời gian cần chuyển đổi sang giờ:");
    int munite = int.Parse(Console.ReadLine());
    int houses = 1;

    if (munite >= house)
    {
        if (munite == house)
        {
            Console.WriteLine($"Thời gian sau khi chuyển đổi là 1 giờ 00 phút");
        }
        else 
        {
            if(munite > house || munite <= houses * 2)
            {
                int result = munite - house * 2;
                if (result > 60)
                {
                    houses += 1;
                    Console.WriteLine($"Thời gian sau khi chuyển đổi là {houses} giờ {result} phút");
                }else
                {
                    houses = houses;
                    Console.WriteLine($"Thời gian sau khi chuyển đổi là {houses} giờ {result} phút");
                }
            }else if (munite > house || munite <= houses * 3)
            {
                int result = munite - house * 3;
                if (result > 0)
                {
                    houses += 2;
                    Console.WriteLine($"Thời gian sau khi chuyển đổi là {houses} giờ {result} phút");
                }
                else
                {
                    houses = houses;
                    Console.WriteLine($"Thời gian sau khi chuyển đổi là {houses} giờ {result} phút");
                }
            }
            else if (munite > house || munite <= houses * 4)
            {
                int result = munite - house * 4;
                if (result > 0)
                {
                    houses += 2;
                    Console.WriteLine($"Thời gian sau khi chuyển đổi là {houses} giờ {result} phút");
                }
                else
                {
                    houses = houses;
                    Console.WriteLine($"Thời gian sau khi chuyển đổi là {houses} giờ {result} phút");
                }
            }
            else if (munite > house || munite <= houses * 5)
            {
                int result = munite - house * 5;
                if (result > 0)
                {
                    houses += 2;
                    Console.WriteLine($"Thời gian sau khi chuyển đổi là {houses} giờ {result} phút");
                }
                else
                {
                    houses = houses;
                    Console.WriteLine($"Thời gian sau khi chuyển đổi là {houses} giờ {result} phút");
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Giá trị thời gian không hợp lệ");
    }
}

if (menu == 2)
{
    Console.WriteLine("Mời bạn nhập vào giá trị giờ cần chuyển đổi (Nhập giờ . phút => VD: 1.30, 1 giờ 30 phút)");
    double hourInput= double.Parse(Console.ReadLine());

    // Tách phần giờ và phần phút
    int hours = (int)hourInput;  // Lấy phần giờ
    double minutes = (hourInput - hours) * 100;  // Lấy phần phút

    double hour = 60;
    double result = 0;
    if (hourInput > 0)
    {
        result = hours * hour;
        if(result >= hour)
        {
            if(minutes > 60) {
                Console.WriteLine("Giá trị thời gian phút không hợp lệ");
            }
            else
            {
                Console.WriteLine($"{hourInput} giờ đổi sang phút sẽ là : {result + Math.Round(minutes, 2)} phút");
            }
        }
    }else
    {
        Console.WriteLine("Giá trị thời gian không hợp lệ");
    }
}*/

#endregion

#region BaiTap04

/*Console.WriteLine("****Tính tổng số tiền sau khi cộng thuế****");
Console.WriteLine("Mời bạn nhập số tiền gốc cần tính:");
double price = double.Parse(Console.ReadLine());
Console.WriteLine("Mời bạn nhập tỷ lệ thuế:");
double vat = double.Parse(Console.ReadLine());

Console.WriteLine($"Số tiền {price} sau khi đã cộng thuế là {price +  (price * vat / 100)}");*/

#endregion

#region BaiTap05
/*Console.WriteLine("****Chuyển đổi USD sang VNĐ****");
Console.WriteLine("Mời bạn nhập số tiền cần chuyển đổi:");
double usd = double.Parse(Console.ReadLine());
double vnd = 24643;

Console.WriteLine($"Số tiền {usd} sau khi chuyển đổi sang tiền VNĐ: {usd * vnd}đ");*/
#endregion