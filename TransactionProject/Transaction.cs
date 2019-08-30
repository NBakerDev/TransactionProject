using System;
using System.Collections.Generic;
using System.Text;

namespace TransactionProject {
    class Transaction {
        private static int NextSaleId = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal SaleAmount { get; set; } = 0;
        public double CardNumber { get; set; }
        public int SaleId { get; private set; }

        public Transaction() {
            SaleId = ++NextSaleId;     
        }

        public Transaction(string firstname, string lastname, decimal saleamount, double cardnumber) : this() {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.SaleAmount = saleamount;
            this.CardNumber = cardnumber;


        }

        public override string ToString() {
            return $"{SaleId, -15} {FirstName, -14} {LastName, -13} {SaleAmount,-12} {CardNumber, -11}";
        }

    }
}
