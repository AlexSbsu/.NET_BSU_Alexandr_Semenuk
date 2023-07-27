using System;


namespace Study_HomeWork_8
{
    public abstract class BaseModel
    {
        static int randomNumber;

        public long Id { get; private set; }

        private long TimeId()
        {
            TimeSpan timeSpan = DateTime.Now - DateTime.MinValue;
            return timeSpan.Ticks + randomNumber;
        }
        static BaseModel()
        {
            var random = new Random();
            randomNumber = random.Next();
        }
        protected BaseModel()
        {
            Id = TimeId();
        }
    }
}
