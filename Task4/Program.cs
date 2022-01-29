// See https://aka.ms/new-console-template for more information
using Task4;

Console.WriteLine("Hello, Teacher!");
//Пароль для версии ProDocumentWorker
const string passwordProDocument = "qwertyPro";
//Пароль для версии ExpertDocmentWorker
const string passwordExpertDocument = "qwertyExp";

while (true)
{
    Console.WriteLine("\nВведите ключ доступа. В конце ключа через пробел укажите версию программы: pro - ProDocumentWorker, exp - ExpertDocumentWorker");

    string? password = Console.ReadLine();

   // Проверка на введение пароля от версии или пустой строки
    if (!String.IsNullOrEmpty(password))
    {
        string[] passwordSpaceArray = password.Split(' ');
        if (passwordSpaceArray.Length != 2)
        {
            Console.WriteLine("Вы ввели не в правильном формате: ключ версия (через пробел)");
            continue;
        }
        else
        {
            switch (passwordSpaceArray[1])
            {
                // Если попытались ввести пароль для версии ProDocument (в конце указали pro)
                case "pro":
                    bool passwordCheckPro = passwordSpaceArray[0] == passwordProDocument;
                    if (passwordCheckPro)
                    {
                        Console.WriteLine("Вы ввели ключ от версии ProDocumentWorker");
                        DocumentWorker proDocWorker = new ProDocumentWorker();
                        proDocWorker.Show();
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неправильный ключ от версии ProDocument");
                    }
                    break;
                // Если попытались ввести пароль для версии ExpertDocument (в конце указали exp)
                case "exp":
                    bool passwordCheckExp = passwordSpaceArray[0] == passwordExpertDocument;
                    if (passwordCheckExp)
                    {
                        Console.WriteLine("Вы ввели ключ от версии ExpertDocumentWorker");
                        DocumentWorker expDocWorker = new ExpertDocumentWorker();
                        expDocWorker.Show();
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неправильный ключ от версии ExpertDocument");
                    }
                    break;
                default:
                    Console.WriteLine("Неизвестная версия программы");
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("Вы ничего не ввели. Можете использовать только бесплантную версию");
        DocumentWorker docWorker = new DocumentWorker();
        docWorker.Show();
    }
}
