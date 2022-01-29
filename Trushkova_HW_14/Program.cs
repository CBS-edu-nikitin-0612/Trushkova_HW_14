// See https://aka.ms/new-console-template for more information
using Trushkova_HW_14;

Console.WriteLine("Hello, teacher!");

//Создание клссса с разными учениками
ClassRoom classRoom = new ClassRoom(new BadPupil(), new GoodPupil(), new ExcelentPupil()); 

//Вывод на кран всей информации о классе
classRoom.Show();
