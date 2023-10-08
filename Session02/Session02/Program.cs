// See https://aka.ms/new-console-template for more information
Console.WriteLine("Mang, tap hop");

#region Mảng - Array
//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//for (int i = 0; i < array.Length; i++)
//{
//    // in ra phần tử ở vị trí thứ i
//    // để truy xuất đến phần tử ở vị trí thứ i array[i]
//    Console.WriteLine(array[i]);
//}

// để truy xuất đến phần tử ở vị trí (index) thứ 3 của "array" thì mình làm như sau:
//Console.WriteLine(array[2]);

//string[] array2 = { "DatDT", "HuyenPT", "AnhNP" };

//for (int i = 0;i < array2.Length; i++)
//{
//    Console.WriteLine(i + " " + array2[i]);
//}

#endregion

#region Tập hợp - Collection
List<int> listInt = new List<int>();
listInt.Add(1);
listInt.Add(2);
listInt.Add(3);
listInt.Add(4);
listInt.Add(5);
listInt.Add(6);
listInt.Add(7);
listInt.Add(8);
listInt.Add(9);
listInt.Add(10);

//listInt.RemoveAll(x => x == 4);
var listInt2 = listInt.Where(x => x % 2 == 0).ToList();

//for (int i = 0; i < listInt.Count; i++)
//{
//    // in ra phần tử ở vị trí thứ i
//    // để truy xuất đến phần tử ở vị trí thứ i array[i]
//    //Console.WriteLine(listInt[i]);

//    // In ra các phần tử chẵn
//    if (listInt[i] == 7)
//    {
//        Console.WriteLine($"Vi tri cua phan tu co gia tri la 7: {i} gia tri la {listInt[i]}");
//        //listInt2.Add(listInt[i]);
//    }
//}
//Console.WriteLine(listInt.Average());
//Console.WriteLine(listInt.Sum());

//for (int i = 0; i < listInt2.Count; i++)
//{
//    Console.WriteLine(listInt2[i]);
//}

// Giải thích vòng lặp foreach
// Cấu trúc
// foreach (<kiểu dữ liệu> <tên biến sẽ sử dụng> in <collection>)
// {
//     câu lệnh cần sử dụng
// }
foreach (int item in listInt2)
{
    Console.WriteLine(item);
}

#endregion
Console.ReadKey();
