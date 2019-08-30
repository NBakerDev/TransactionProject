using System;
using System.Collections.Generic;
namespace TransactionProject {
    class Program {
        static void Main(string[] args) {
            
           
                Console.Write("Press Enter to Start Entering Transactions, type 'quit' to exit:  ");
            string startup = Console.ReadLine();
            while (startup != "quit") {

                Console.Write("Enter First Name: ");
                var response1 = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                var response2 = Console.ReadLine();

                Console.Write("Enter Sale Amount: ");
                var response3 = Console.ReadLine();

                var decresponse3 = decimal.Parse(response3);

                Console.Write("Enter Card Number: ");
                var response4 = Console.ReadLine();

                var intresponse4 = double.Parse(response4);

                var newTransaction = new Transaction(response1, response2, decresponse3, intresponse4);






                var Transactions = new List<Transaction>();

                Transactions.Add(newTransaction);
            }
              
                
            }
        }
            
        }
    

