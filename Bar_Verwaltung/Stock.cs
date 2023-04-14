using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Verwaltung
{
    internal class Stock
    {
        #region variables
        private bool _drink, _alc;
        private string _item, _ingredians;
        private int _Id, _quantaty, _fsk;
        private double _price, _percentage;
        #endregion

        #region Getter/Setter
        public bool Drink
        {
            get 
            { 
                return _drink; 
            }
            set
            {
                _drink = value;
            }
        }
        public bool alc
        {
            get
            {
                return _alc;
            }
            set
            {
                _alc = value;
            }
        }
        public string Item
        {
            get 
            {
                return _item; 
            }
            set 
            { 
                _item = value; 
            }
        }
        public string ingredians
        {
            get 
            { 
                return _ingredians; 
            }
            set
            {
                _ingredians = value;
            }
        }
        public int quantaty
        {
            get 
            { 
                return _quantaty; 
            }
            set 
            { 
                _quantaty = value; 
            }
        }
        public int fsk
        {
            get 
            { 
                return _fsk; 
            }
            set
            {
                _fsk = value;
            }
        }
        public int ID
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }
        public double price
        {
            get 
            { 
                return _price; 
            }
            set 
            { 
                _price = value; 
            }
        }
        public double percentage
        {
            get
            {
                return _percentage;
            }
            set
            {
                _percentage = value;
            }
        }
        #endregion

        #region constructor
/// <summary>
/// food 
/// </summary>
/// <param name="drink"></param>
/// <param name="item"></param>
/// <param name="ingredians"></param>
/// <param name="quantaty"></param>
/// <param name="price"></param>

        public Stock(bool drink, string item, string ingredians, int quantaty, double price)
        {
            this.Drink = drink;
            this.Item = item;
            this.ingredians = ingredians;
            this.quantaty = quantaty;
            this.price = price;
        }

        public Stock(int Id, string item, double price)
        {
            this.ID = Id;
            this.Item = item;
            this.price = price;
        }

/// <summary>
/// drink
/// </summary>
/// <param name="drink"></param>
/// <param name="alc"></param>
/// <param name="item"></param>
/// <param name="ingredians"></param>
/// <param name="quantaty"></param>
/// <param name="fsk"></param>
/// <param name="price"></param>
/// <param name="percentage"></param>

        public Stock(bool drink, bool alc, string item, string ingredians, int quantaty, int fsk, double price, double percentage)
        {
            this.Drink = drink;
            this.alc = alc;
            this.Item = item;
            this.ingredians = ingredians;
            this.quantaty = quantaty;
            this.fsk = fsk;
            this.price = price;
            this.percentage = percentage;
        }
        #endregion

        #region Methods
        public static List<Stock> getItems()
        {
            DataTable dt = new DataTable();
            dt = SqlCom.DataGrid("TStock");

            List<Stock> list = new List<Stock> { };
            foreach (DataRow row in dt.Rows)
            {
                int Id = Convert.ToInt32(row["ID"]);
                string name = row["Item"].ToString();
                double price = Convert.ToDouble(row["Price"]);
                Stock s = new Stock(Id, name, price);
                list.Add(s);
            }
            return list;
        }
        #endregion
    }
}
