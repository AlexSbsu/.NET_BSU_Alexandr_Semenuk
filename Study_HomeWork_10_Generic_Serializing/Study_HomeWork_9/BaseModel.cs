using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Study_HomeWork_10
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
