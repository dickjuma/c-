namespace ConsoleApp6
{
    // FILE: C:/Users/USER/Documents/ATM/ATM/Juma.cs

    // In this section you can add your own using directives
    // section 127-0-0-1-42338c09:18e2510d2b9:-8000:0000000000000869 begin
    // section 127-0-0-1-42338c09:18e2510d2b9:-8000:0000000000000869 end


    /// <summary>
    ///  A class that represents ...
    /// 
    ///  @see OtherClasses
    ///  @author your_name_here
    /// </summary>
    public class Juma
    {
        // Attributes

        public string cardno;

        public string name;

        public int pin;

        public double balance;
        public Juma(string cardno, string name, int pin, double balance)
        {
            this.cardno = cardno;
            this.name = name;
            this.pin = pin;
            this.balance = balance;
        }
        public string getCardno()
        {
            return cardno;
        }
        public string getName()
        {
            return name;
        }
        public int getPin()
        {
            return pin;
        }
        public double getBalance()
        {
            return balance;
        }
        public void setCardno(string newcardno)
        {
            cardno = newcardno;
        }
        public void setName(string newname)
        {
            name = newname;
        }
        public void setPin(int newpin)
        {

            pin = newpin;
        }

        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }
        // Operations

        /// <summary>
        ///  An operation that does...
        /// 
        ///  @param firstParam a description of this parameter
        /// </summary>
        /// <returns>
        /// </returns>
        ///  static void Main(string[] args)
        static void Main(string[] args)
        {
            void Withdraw(Juma user)
            {
                // section 127-0-0-1--396a82e8:18e2819d37e:-8000:0000000000000A8F begin
                // section 127-0-0-1--396a82e8:18e2819d37e:-8000:0000000000000A8F end
                Console.WriteLine("How much do you want to withdraw from your account in ksh");
                double withdrawal = double.Parse(Console.ReadLine());
                if (user.getBalance() < withdrawal)
                {
                    Console.WriteLine("TRY LOWER AMOUNT , INSUFFICENT BALANCE IN YOUR ACCOUNT!!!!!");
                }
                else
                {

                    user.setBalance(user.getBalance() - withdrawal);
                    Console.WriteLine("YOU HAVE SUCCESSFULLY WITHDRAWN " + withdrawal);
                    Console.WriteLine("YOUR CURRENT BALANCE IS=ksh" + user.getBalance());
                }
            }

            /// <summary>
            ///  An operation that does...
            /// 
            ///  @param firstParam a description of this parameter
            /// </summary>
            /// <returns>
            /// </returns>
            void Deposit(Juma user)
            {

                Console.WriteLine("How much do you want to deposit to your account in ksh");
                double Deposit = double.Parse(Console.ReadLine());
                user.setBalance(user.getBalance() + Deposit);
                Console.WriteLine("YOU HAVE DEPOSITED CASH" + Deposit);
                Console.WriteLine("YOUR NEW ACCOUNT BALANCE IS CASH=ksh" + user.getBalance());
                // section 127-0-0-1--396a82e8:18e2819d37e:-8000:0000000000000A95 begin
                // section 127-0-0-1--396a82e8:18e2819d37e:-8000:0000000000000A95 end

            }

            /// <summary>
            ///  An operation that does...
            /// 
            ///  @param firstParam a description of this parameter
            /// </summary>
            /// <returns>
            /// </returns>
            void Checkbalance(Juma user)
            {
                Console.WriteLine("YOUR CURRENT ACCCOUNT BALANCE =ksh" + user.getBalance());
                // section 127-0-0-1--396a82e8:18e2819d37e:-8000:0000000000000A97 begin
                // section 127-0-0-1--396a82e8:18e2819d37e:-8000:0000000000000A97 end

            }

            /// <summary>
            ///  An operation that does...
            /// 
            ///  @param firstParam a description of this parameter
            /// </summary>
            /// <returns>
            /// </returns>
            void Transfer(Juma user)
            {
                // section 127-0-0-1--396a82e8:18e2819d37e:-8000:0000000000000AAC begin
                // section 127-0-0-1--396a82e8:18e2819d37e:-8000:0000000000000AAC end
                List<Juma> accounts = new();
                accounts.Add(new Juma("67778888", "juma", 7000, 0001));
                accounts.Add(new Juma("889900000", "wekesa", 7000, 0000));
                accounts.Add(new Juma("111111", "dickson", 8888, 8900));
                accounts.Add(new Juma("918919", "wafula juma", 2000, 7800));
                accounts.Add(new Juma("kenya", "George juma", 8900, 7000));

                Console.WriteLine("please enter the credit card number too send funds to");
                string cardnumt = "";


                while (true)
                {
                    try
                    {
                        cardnumt = Console.ReadLine();
                        user = accounts.FirstOrDefault(a => a.cardno == cardnumt);
                        if (user != null)
                        {
                            Console.WriteLine("Enter amount to transfer");
                            double cash = 0;
                            cash = double.Parse(Console.ReadLine());
                            Console.WriteLine("You transffered cash...:" + cash);
                            user.setBalance(user.getBalance() - cash);
                            Console.WriteLine("Your new balance is" + user.getBalance());





                        }

                        else
                        {
                            Console.WriteLine("Card number not recognized");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Card number not recognized");
                    }

                }



            }



            /// <summary>
            ///  An operation that does...
            /// 
            ///  @param firstParam a description of this parameter
            /// </summar
            void Changepin(Juma user)
            {
                Console.WriteLine("Enter the  pervious pin to prove this action");
                int pass = 0;
                pass = int.Parse(Console.ReadLine());
                if (user.getPin() == pass)
                {
                    int passkey = 0;
                    Console.WriteLine("Enter new pin to enhance security");
       
                        passkey = int.Parse(Console.ReadLine());
                        user.setPin(passkey);
                 
                        Console.WriteLine("Your new Pin is " + user.getPin());
                }
                else
                {
                    Console.WriteLine("You must remember you Pin to change to the new pin");
                    Console.WriteLine("Try again " + user.getName());
                }
                // section 127-0-0-1--396a82e8:18e2819d37e:-8000:0000000000000AAE begin
                // section 127-0-0-1--396a82e8:18e2819d37e:-8000:0000000000000AAE end


            }

            /// <summary>
            /// transctions avialable list...
            /// 
            ///  @param firstParam a description of this parameter
            /// </summary>
            /// <returns>
            /// </returns>
            void Choices()
            {
                Console.WriteLine("***************WELCOME TO OUR ATM MENIU CUSTOMER*********");
                Console.WriteLine("PLEASE CHOOSE THE OPTIONS BELOW TO ACCESS OUR SERVICES");
                Console.WriteLine("1..Withdraw Cash");
                Console.WriteLine("2.. Deposit Cash");
                Console.WriteLine("3..Check Balance");
                Console.WriteLine("4..Transfer funds");
                Console.WriteLine("5..Change pin");

                Console.WriteLine("6..EXIT");
                // section 127-0-0-1--425053f5:18e28271d58:-8000:000000000000098C begin
                // section 127-0-0-1--425053f5:18e28271d58:-8000:000000000000098C end

            }



            List<Juma> accounts = new();
            accounts.Add(new Juma("67778888", "juma", 7, 0001));
            accounts.Add(new Juma("889900000", "wekesa", 9000, 0000));
            accounts.Add(new Juma("111111", "dickson", 8888, 8900));
            accounts.Add(new Juma("918919", "wafula juma", 2000, 7800));
            accounts.Add(new Juma("kenya", "George juma", 8900, 7000));
            Console.WriteLine("..Welcome to our dickson's banck follow the wizard to access customer services as it is automated...");
            Console.WriteLine("PLEASE INSERT YOUR CARD NUMBER TO THE SYSTEM");
            string Cardno = "";
            Juma user;
            while (true)
            {
                try
                {
                    Cardno = Console.ReadLine();
                    user = accounts.FirstOrDefault(a => a.cardno == Cardno);
                    if (user != null)
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Card number not recognized");
                    }
                }
                catch
                {
                    Console.WriteLine("Card number not recognized");
                }

            }

            Console.WriteLine("..PLEASE ENTER YOUR PIN....");
            int userpin = 0;

            while (true)
            {
                try
                {
                    userpin = int.Parse(Console.ReadLine());

                    if (user.getPin() == userpin)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("wrong pin please try again");
                    }
                }
                catch
                {
                    Console.WriteLine("wrong pin please try again");
                }
            }
            Console.WriteLine("welcome our customer--:--" + user.getName().ToUpper());
            int choice = 0;

           
                Choices();


               
                
                    choice = int.Parse(Console.ReadLine());



                    switch (choice)
                    {
                        case 1:
                            Withdraw(user);
                            break;
                        case 2:
                            Deposit(user);
                            break;
                        case 3:
                            Checkbalance(user);
                            break;
                        case 4:
                            Transfer(user);
                            break;
                        case 5:
                            Changepin(user);
                            break;

                        case 6: break;
                    }

                


               

            Console.WriteLine("hope you enjoyed  our services ");




        }


    } /* end class Juma */

}

