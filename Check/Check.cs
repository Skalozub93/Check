using Check;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StructCheck
{
    internal struct Check
    {
        private string name;
        private string message;
        private string adress;
        private int year;
        private int month;
        private int day;
        private int hour;
        private int minute;
        private double cost;
        private ArrayList product;
        

        
        public Check(string Name = "Сильпо", string Message = "Хорошего вам дня", string Adress = "Королёва 24", int Year = 2022, int Month = 10, int Day = 22, int Hour = 16, int Minute = 26, double Cost = 4.5, ArrayList prod = null)
        {
            this.name = Name;
            this.message = Message;
            this.adress = Adress;
            this.year = Year;
            this.month = Month;
            this.day = Day;
            this.hour = Hour;
            this.minute = Minute;
            this.cost = Cost;
            this.product = prod;
        }


        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }


        public void SetMessage(string message)
        {
            this.message = message;
        }
        public string GetMessage()
        {
            return this.message;
        }


        public void SetAdress(string adress)
        {
            this.adress = adress;
        }
        public string GetAdress()
        {
            return this.adress;
        }


        public void SetYear(int year)
        {
            this.year = year;
        }
        public int GetYear()
        {
            return this.year;
        }


        public void SetMonth(int month)
        {
            this.month = month;
        }
        public int GetMonth()
        {
            return this.month;
        }


        public void SetDay(int day)
        {
            this.day = day;
        }
        public int GetDay()
        {
            return this.day;
        }


        public void SetHour(int hour)
        {
            this.hour = hour;
        }
        public int GetHour()
        {
            return this.hour;
        }


        public void SetMinute(int minute)
        {
            this.minute = minute;
        }
        public int GetMinute()
        {
            return this.minute;
        }


        public void SetCost(double cost)
        {
            this.cost = cost;
        }
        public double GetCost()
        {
            return this.cost;
        }


        public void SetProduct(ArrayList prod)
        {
            this.product = prod;
        }
        public ArrayList GetProduct()
        {
            return this.product;
        }


        public void AddProduct(Choice ch)
        {
           
            this.product.Add(ch);
        }



        public void PrintCheck()
        {
            ArrayList product = new ArrayList();
            
            Console.WriteLine("\n\tПожалуйста, возьмите ваш чек!\n");
            Console.WriteLine("\t\t" + name);
            Console.WriteLine("\t" + message);   
            Console.WriteLine("\t\t" + adress);
            Console.WriteLine("\n");
            
            foreach(Choice ch in product)
            {
                Console.WriteLine(ch.ToString());
            }

            Console.WriteLine("\tСумма:\t" + cost + "грн");
            Console.WriteLine("\n\t\t\t Дата :" + year + "." + month + "." + day + "." + hour + "." + minute);
            Console.WriteLine("\t\t*Фискальный чек*\n\n");

        }
    }

}
