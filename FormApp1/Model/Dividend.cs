using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp1.Model
{
    public class Dividend
    {
        private string _symbolCode;
        public string symbolCode
        {
            get { return _symbolCode; } 
            set { _symbolCode = value; }
        }

        private string _paymentDate;
        public string paymentDate { 
            get { return _paymentDate; } 
            set { _paymentDate = value; } 
        }

        private string _recordDate;

        public string recordDate
        {
            get { return _recordDate; }
            set { _recordDate = value; }
        }

        private int _statusId;
        public int statusId { 
            get { return _statusId; }
            set{ _statusId = value; } 
        }

        private int _divId;
        public int divId
        {
            get { return _divId; }
            set { _divId = value; }
        }

        public Dividend() { 
        }

        public Dividend(int divId, string symbolCode, string paymentDate, string recordDate, int statusId)
        {
            this.divId = divId;
            this.symbolCode = symbolCode;
            this.paymentDate = paymentDate;
            this.recordDate = recordDate;
            this._statusId= statusId;
        }
    }
}
