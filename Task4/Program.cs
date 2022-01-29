// See https://aka.ms/new-console-template for more information
using Task4;

Console.WriteLine("Hello, Teacher!");

const string keyProDocument = "qwertyPro";
const string keyExpertDocument = "qwertyExp";

while (true)
{
    Console.WriteLine("\nВведите ключ доступа. В конце ключа через пробел укажите версию программы: pro - ProDocumentWorker, exp - ExpertDocumentWorker");

    string? key = Console.ReadLine();

    if (!String.IsNullOrEmpty(key))
    {
        string[] keySpaceArray = key.Split(' ');
        if (keySpaceArray.Length != 2)
        {
            Console.WriteLine("Вы ввели не в правильном формате: ключ версия (через пробел)");
            continue;
        }
        else
        {
            switch (keySpaceArray[1])
            {
                case "pro":
                    bool keyCheckPro = keySpaceArray[0] == keyProDocument;
                    if (keyCheckPro)
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
                case "exp":
                    bool keyCheckExp = keySpaceArray[0] == keyExpertDocument;
                    if (keyCheckExp)
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
