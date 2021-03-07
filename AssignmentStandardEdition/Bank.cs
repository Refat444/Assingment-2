using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentStandardEdition
{
        class Bank
        {
            private string bankName;
            public Account[] accounts;

            public Bank(string bankName, int size)
            {
                this.bankName = bankName;
                this.accounts = new Account[5];
            }

            public void Addaccount(Account ac)
            {
                for (int i = 0; i < accounts.Length; i++)
                {
                    if (accounts[i] == null)
                    {
                        accounts[i] = ac;
                        break;
                    }
                }

            }


            public void DeleteAccount(Account ac)
            {

                for (int i = 0; i < accounts.Length; i++)
                {
                    if (accounts[i] == ac)
                    {
                        accounts[i] = null;

                        break;
                    }
                }

            }
        }
    }

