﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace JustLearnForSelf
{
    public class Command
    {
        public void Account(string cardNumber , List<UserAccount> user )
        {
            
            IO io = new IO();
            Bank bank = new Bank();
            string Card4digit = cardNumber.Substring(0, 4);

            string Money;
            switch (Card4digit)
            { 
                case "6104":
                    //
                    user = bank.MelatData();
                    
                    foreach(UserAccount userAccount in user)//
                    {
                        if (userAccount.NumberCard == cardNumber)
                        {
                            Money = userAccount.Money;
                            io.Print($"\n-------\nYour Accounts --> {Money}\n-------\n");
                        }
                    }
                    break;

                case "6393":
                    break;

                case "5892":
                     break;

                default:
                    break;
            
            }
            
        }

        public void GetMoney(string cardNumber , List<UserAccount> user )
        {
            IO io = new IO();
            Bank bank = new Bank();
            string Card4digit = cardNumber.Substring(0, 4);
            switch (Card4digit)
            {
                case "6104":
                    user = bank.MelatData();
                    int MoneyWant;
                    io.PrintAt("Enter How many Hezaar Toman You Need : ");
                    MoneyWant = Convert.ToInt32(io.Get());

                    foreach (UserAccount userAccount in user)
                    {
                        if (userAccount.NumberCard == cardNumber)
                        {
                            int MoneyInt = Convert.ToInt32(userAccount.Money);// money in user account 
                            if( MoneyInt < MoneyWant)
                            {
                                io.Print("Sorry Your Money Is not Enogh!");
                            }
                            else
                            {
                                io.Print("Wait...!");
                                io.Print("Plese Take Your Money");
                                string NewMoney = Convert.ToString(MoneyInt - MoneyWant);

                                string NameUser; 
                                foreach( UserAccount users in user)
                                {
                                    if(userAccount.NumberCard == cardNumber)
                                    {
                                        NameUser = users.Name;
                                        File.WriteAllText($"{NameUser}.txt" , NewMoney);
                                    }
                                }
                                userAccount.Money = NewMoney;
                                io.Print(userAccount.Money);
                            }
                        }
                    }
                    break;

                case "6393":
                    break;

                case "5892":
                    break;

                default:
                    break;

            }

        }
        internal void SendMoney(string cardNumber)
        {
            throw new NotImplementedException();
        }

        internal void GetCharge(string cardNumber)
        {
            throw new NotImplementedException();
        }

        internal void SendCharge(string cardNumber)
        {
            throw new NotImplementedException();
        }
    }

}
