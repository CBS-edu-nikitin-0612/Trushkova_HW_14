﻿namespace Task4
{
    internal class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ  открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование  документа  доступно  в  версии  Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение  документа  доступно  в  версии Про");
        }

        public void Show()
        {
            this.OpenDocument();
            this.EditDocument();
            this.SaveDocument();
        }
    }
}
