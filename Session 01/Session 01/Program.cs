// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Start learning programming with QuanDH");
// Megabyte, Gigabyte, Terabyte
// bit: lưu trữ giá trị nhị phân (0, 1)
// 1 byte = 8 bits
// 1 Megabyte (MB) = 1024 * 8 (bits)
// 1 Gigabyte (GB) = 1024 * 1024 * 8 (bits)
// 1 Terabyte (TB) = 1024 * 1024 * 1024 * 8 (bits)
// IDE = Intergrated Development Environment
// Text Editor
// Complier
// Debugger
//string name = "HuyenPT";
//char c = 'x'; // 16 bit (2 byte)
//int age = 28; // 32 bit (-2,147,483,648 ~ 2,147,483,647)
//int max = 2147483647;
//float tienLuong = 5.02f;
//decimal canNang = 60.5M;
//double chieucao = 1.55d;
//bool checkGenderIsFemale = false;
//Console.WriteLine(name);
//Console.WriteLine(age);
//Console.WriteLine(chieucao);
//Console.WriteLine(c);
// operator: toán tử
//int a = 5;
//int b = 2;
//int tong = a + b;
//int hieu = a - b;
//int tich = a * b;
//int thuong = a / b; // phep chia lay phan nguyen 5 / 2 = 2.5 => 2
//int thuong2 = a % b; // phep chia lay phan du 5 / 2 = 2 du 1
//// a++ => a, c (vùng nhớ khác với vùng nhớ của a)
////a += 1;
//a -= 1;
//Console.WriteLine(tong);
//Console.WriteLine(hieu);
//Console.WriteLine(tich);
//Console.WriteLine(thuong);
//Console.WriteLine(thuong2);
//Console.WriteLine(a);

#region nối chuỗi
//string firstName = "Duong Trung";
//string lastName = " Dat";
//string fullName; // khai báo biến str3 có kiểu dữ liệu là string
//fullName = firstName + lastName; // Nối toàn bộ chuỗi str 2 vào sau chuỗi str1 rồi gán giá trị thu được cho biến str3
////Console.WriteLine(count);
//Console.WriteLine(fullName);
#endregion

#region Câu lệnh rẽ nhánh
//int tuoi = 15;
//string gioitinh; // khai báo biến gioitinh
//gioitinh = "Nu1"; // gán giá trị cho biến gioitinh
//Console.WriteLine("Tuoi cua ban la: " + tuoi);
//Console.WriteLine("Gioi tinh cua ban la: " + gioitinh);

#region If else
// Khi kiểm tra 1 condition là true thì chạy vào if, nếu không thì chạy xuống else
//if (tuoi > 20)
//{
//    Console.WriteLine("Ngoai tuoi teen");
//}

//if (gioitinh == "Nam")
//{
//    Console.WriteLine("Dep trai!");
//}
//else if (gioitinh == "Nu")
//{
//    Console.WriteLine("Xinh gai");
//}
//else
//{
//    Console.WriteLine("Be de");
//}

//if (gioitinh.Equals("Nam"))
//{
//    Console.WriteLine("Dep trai!");
//}
//else if (gioitinh.Equals("Nu"))
//{
//    Console.WriteLine("Xinh gai");
//}
//else
//{
//    Console.WriteLine("Be de");
//}

//if (tuoi >= 20)
//{
//    Console.WriteLine("Lap gia dinh duoc roi");
//}
//else if (tuoi <= 16)
//{
//    Console.WriteLine("Di tu day!");
//}

//if (tuoi != 20)
//{
//    Console.WriteLine("Tuoi khong bang 20");
//}
#endregion

#region switch case
//switch (gioitinh)
//{
//    case "Nam":
//        Console.WriteLine("Dep trai!");
//        break;
//    case "Nu":
//        Console.WriteLine("Xinh gai!");
//        break;
//    default:
//        Console.WriteLine("Be de");
//        break;
//}
#endregion
#endregion

#region Vong lap
// Vong lap (loop)
// slash (/)
#region for
// Cấu trúc vòng lặp for:
// for (giá trị khởi tạo; điều kiện (condition); giá trị thay đổi sau mỗi lần lặp)
//int count = 0;
//for (int year = 2000; year <= 2023; year++)
//{
//    Console.WriteLine(year);
//    count++;
//}
#endregion

#region while
// Vòng lặp while
// Cấu trúc vòng lặp while:
// while (điều kiện)
//int year = 2000;
//while (year <= 2023)
//{
//    if (year <= 2010)
//    {
//        year++;
//        continue; // bỏ qua các xử lý bên dưới và tiếp tục vòng lặp
//    }

//    Console.WriteLine(year);
//    year++;

//    if (year >= 2020)
//    {
//        break; // ngắt vòng lặp
//    }
//}
#endregion

#region do while
// Vòng lặp do while
// Cấu trúc
// do
// {
// khối lệnh cần xử lý
// }
// while (điều kiện);
//int year = 2024;
//do
//{
//    if (year <= 2010)
//    {
//        year++;
//        continue; // bỏ qua các xử lý bên dưới và tiếp tục vòng lặp
//    }

//    Console.WriteLine(year);
//    year++;

//    if (year >= 2020)
//    {
//        break; // ngắt vòng lặp
//    }
//}
//while (year <= 2023);
#endregion

#endregion
Console.ReadKey();