using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar_Verwaltung
{
    internal class Finance
    {
        private int _HMS, _PID;
        private DateTime _Date;

        #region GetterSetter
        public int HMS
        {
            get
            {
                return _HMS;
            }
            set
            {
                _HMS = value;
            }
        }
        public int PID
        {
            get
            {
                return _PID;
            }
            set
            {
                _PID = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                _Date = value;
            }
        }
        #endregion;

        public Finance(int HMS, int PID, DateTime Date)
        {
            this.HMS = HMS;
            this.PID = PID;
            this.Date = Date;
        }

        public static int[] getSortedArray(List<int> list)
        {
            int max = 0;
            foreach (int i in list)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            int[] sortedArray = new int[max];

            for (int i = 0; i < sortedArray.Length; i++)
            {
                sortedArray[i] += 1;
            }
            return sortedArray;
        }
    }
}
