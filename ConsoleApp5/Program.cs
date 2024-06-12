namespace ConsoleApp5
{
    using System;
    public class Program
    {
        String cardnum;
        String name;
        double balance;
        int pin;
        public Program(String cardnum, String name, double balance, int pin)
        {

            this.cardnum = cardnum;
            this.name = name;
            this.balance = balance;
            this.pin = pin;


        }
        public String getCard()
        {
            return cardnum;
        }
        public String getName()
        {
            return name;
        }
        public double getBalance()
        {
            return balance;
        }
        public int getPin()
        {
            return pin;
        }
        public void setCard(String newCard)
        {
            cardnum = newCard;
        }
        public void setName(String newName)
        {
            name = newName;
        }
        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }
        public void setPin(int newPin)
        {
            pin = newPin;
        }

        static void Main(string[] args)
        {
            void choices()
            {
                Console.WriteLine("***************WELCOME TO OUR ATM MENIU CUSTOMER*********");
                Console.WriteLine("PLEASE CHOOSE THE OPTIONS BELOW TO ACCESS OUR SERVICES");
                Console.WriteLine("1..Withdraw Cash");
                Console.WriteLine("2.. Deposit Cash");
                Console.WriteLine("3..Check Balance");
                Console.WriteLine("4..Transfer funds");
                Console.WriteLine("5..Change pin");
                
                Console.WriteLine("6..EXIT");
            }


            //deposit function
            void deposit(Program user)
            {
                Console.WriteLine("hi juma"); 
                Console.WriteLine("How much do you want to deposit to your account in ksh");
                double Deposit = double.Parse(Console.ReadLine());
                user.setBalance(user.getBalance() + Deposit);
                Console.WriteLine("YOU HAVE DEPOSITED CASH" + Deposit);
                Console.WriteLine("YOUR NEW ACCOUNT BALANCE IS CASH=ksh" + user.getBalance());

            }
            //withdraw function
            void withdraw(Program user)
            {
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
            //check balance function
            void checkbalance(Program user)
            {
                Console.WriteLine("YOUR CURRENT ACCCOUNT BALANCE =ksh" + user.getBalance());

            }
            //change pin function
            void changepin(Program user){
                Console.WriteLine("Enter the  pervious pin to prove this action");
                int pass= 0;
                pass=int.Parse(Console.ReadLine());
                if (user.getPin()==pass)
                {
                    int passkey = 0;
                    Console.WriteLine("Enter new pin to enhance security");
                    passkey=int.Parse(Console.ReadLine());
                    user.setPin(passkey);
                    Console.WriteLine("Your new Pin is " + user.getPin());
                }
                else
                {
                    Console.WriteLine("You must remember you Pin to change to the new pin");
                    Console.WriteLine("Try again " + user.getName());
                }

            }
            void transfer(Program user)
            {

                List<Program> accounts = new();
                accounts.Add(new Program("67778888", "juma", 70000000, 0001));
                accounts.Add(new Program("889900000", "wekesa", 7000000000, 0000));

                Console.WriteLine("please enter the credit card number too send funds to");
                string cardnumt = "";
               
               
                while (true)
                {
                    try
                    {
                        cardnumt= Console.ReadLine();
                        user = accounts.FirstOrDefault(a => a.cardnum == cardnumt);
                        if (user != null)
                        {
                            Console.WriteLine("Enter amount to transfer");
                            double cash = 0;
                            cash=double.Parse(Console.ReadLine());
                            Console.WriteLine("You transffered cash...:" + cash);
                            user.setBalance(user.getBalance() - cash);
                            Console.WriteLine("Your new balance is"+ user.getBalance());





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
           

      
            List<Program> accounts = new();
            accounts.Add(new Program("67778888", "juma", 70000000, 0001));
            accounts.Add(new Program("889900000", "wekesa", 7000000000, 0000));
            Console.WriteLine("..Welcome to our dickson's banck follow the wizard to access customer services as it is automated...");
            Console.WriteLine("PLEASE INSERT YOUR CARD NUMBER TO THE SYSTEM");
            string Cardno = "";
            Program user;
            while (true)
            {
                try
                {
                    Cardno = Console.ReadLine();
                    user = accounts.FirstOrDefault(a => a.cardnum == Cardno);
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
            Console.WriteLine("welcome our customer" + user.getName());
            int choice = 0;


            choices();



            choice = int.Parse(Console.ReadLine());



            switch (choice)
            {
                case 1:
                    withdraw(user);
                    break;
                case 2:
                    deposit(user);
                    break;
                case 3: checkbalance(user); 
                    break;
                case 4:transfer(user);
                    break;
               case 5:changepin(user);
                    break;
              
                    case 6: break;
            }
     




            Console.WriteLine("hope you enjoyed  our services ");




        }


    }




}
