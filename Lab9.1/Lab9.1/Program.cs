using System;

namespace Lab9._1
{
    public class Message : EventArgs
    {
        public string message { set; get; }
        public Message(string message) : base()
        {
            this.message = message;
        }
    }

    public class Publisher
    {
        public delegate void PublisherEventHanler(Message message);
        public delegate void EventHandler(Object sender, EventArgs args);

        public event PublisherEventHanler Changed; // 1. -+= запрет на передачу события как param; передает событие

        public Publisher() { }
        public void EventForPublisher(Message message)
        {
            Console.WriteLine(" Event for all subscribers {0}", message.message);
            Changed(message);
        }
    }
    public class Subscriber 
    {
        int QRC { set; get; }
        public Subscriber(int QRC) { this.QRC = QRC; }
        public void subscribe (Message message)
        {
            Console.WriteLine(" Subscriber {0} {1}", this.QRC, message.message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //создание подписчиков

            Publisher publisher = new Publisher();
            Subscriber subscriber1 = new Subscriber(1);
            Subscriber subscriber2 = new Subscriber(2);
            Subscriber subscriber3 = new Subscriber(3);

            //подписка

            publisher.Changed += subscriber1.subscribe;
            publisher.Changed += subscriber2.subscribe;
            publisher.Changed += subscriber3.subscribe;

            //выполнение события
            publisher.EventForPublisher(new Message("Mumber number 5 are ready"));

        }
    }
}
