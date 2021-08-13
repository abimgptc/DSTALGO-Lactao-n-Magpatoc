﻿using System;
using System.Collections;
using System.Collections.Generic;
using DSTALGO_Lactao_n_Magpatoc;


namespace DSTALGO_Lactao_n_Magpatoc
{
    class Program 
    {
        CircularQueue<string> finalQue = new CircularQueue<string>();

        static Dictionary<string, string> headsUpCustomer = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            headsUpCustomer.Add("1000AM", " ");
            headsUpCustomer.Add("1100AM", " ");
            headsUpCustomer.Add("0100PM", " ");
            headsUpCustomer.Add("0200PM", " ");
            headsUpCustomer.Add("0300PM", " ");
            headsUpCustomer.Add("0400PM", " ");
            headsUpCustomer.Add("0500PM", " ");
            headsUpCustomer.Add("0600PM", " ");

            int user = 0;
            user = GoHome(user);
            bool login = false;

            while(true)
            {
                if (user == 1)
                {
                    login = true;
                    while (login)
                    {
                        Console.WriteLine("What are you here for?");

                        while (true)
                        {
                            //Console.WriteLine("\t[1]-Book an appointment" + "\n\t[2]-View appointment schedules" +
                            //"\n\t[3]-Request a specific Salon Staff");
                            Console.WriteLine("\t[1]-Request an appointment" + "\n\t[2]-View appointment schedules" + "\n\t[3]-Logout");

                            Console.Write("\nEnter operation: ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            int choice = Convert.ToInt32(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Gray;

                            if (choice == 1)
                            {
                                Console.WriteLine("Which service would like to book?");
                                Console.WriteLine("\t[1]-Hair Treatment" + "\n\t[2]-Nail Treatment");
                                Console.Write("\nEnter your choice: ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                int service = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Gray;

                                if (service == 1)
                                {
                                    Console.Write("What time do you like? ");

                                    string time = Convert.ToString(Console.ReadLine());
                                    if (headsUpCustomer.ContainsKey(time))
                                    {
                                        Console.Write("Name of customer : ");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        string custName = Convert.ToString(Console.ReadLine());
                                        headsUpCustomer[time] = custName;
                                        Console.ForegroundColor = ConsoleColor.Gray;

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("\nUpdating record...");
                                        Console.WriteLine("\nAppointment has been made! We will contact you once this has been finalized! :)");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nTime selected is not available");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    Console.ReadKey();
                                }
                                if (service == 2)
                                {
                                    Console.Write("What time do you like? ");
                                    string time = Convert.ToString(Console.ReadLine());
                                    if (headsUpCustomer.ContainsKey(time))
                                    {
                                        Console.Write("Name of customer : ");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        string custName = Convert.ToString(Console.ReadLine());
                                        headsUpCustomer[time] = custName;
                                        Console.ForegroundColor = ConsoleColor.Gray;

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("\nUpdating record...");
                                        Console.WriteLine("\nAppointment has been made! We will contact you once this has been finalized! :)");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\nTime selected is not available");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                    Console.ReadKey();
                                }
                            }
                            if (choice == 2)
                            {
                                Console.WriteLine("\nTime       Customer Name");
                                foreach (KeyValuePair<string, string> items in headsUpCustomer)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine(items.Key + " : " + items.Value);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                Console.ReadKey();
                            }
                            if (choice == 3)
                            {
                                user = 0;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Are you sure?");
                                Console.WriteLine("\t[0]-No" + "\n\t[1]-Yes");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Write("\nEnter your choice: ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                int logout = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.ReadKey();

                                if (logout == 0)
                                {
                                    continue;
                                }
                                else if (logout == 1)
                                {
                                    login = false;
                                    user = GoHome(user);
                                    break;
                                }
                            }
                            //if (choice == 4)
                            //{
                            //    Console.ReadKey();
                            //}
                        }

                    }
                }
                else if (user == 2)
                {
                    login = true;
                    while (login)
                    {
                        Console.Write("\nUsername : ");
                        string uname = Convert.ToString(Console.ReadLine());
                        Console.Write("Password : ");
                        string pwd = Convert.ToString(Console.ReadLine());
                        if (uname.Equals("Admin") && pwd.Equals("Admin"))
                        {
                            while (true)
                            {
                                Console.WriteLine("\t[1]-View requested appointments" + "\n\t[2]-Search appointment" + "\n\t[3]-Add confirmed appointment" + "\n\t[4]-Cancel/finish appointment" + "\n\t[5]-Logout");
                                Console.Write("What are you here for? ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                int choice = Convert.ToInt32(Console.ReadLine());
                                Console.ForegroundColor = ConsoleColor.Gray;

                                if (choice == 1)
                                {
                                    Console.WriteLine("\nTime       Customer Name");
                                    foreach (KeyValuePair<string, string> items in headsUpCustomer)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine(items.Key + " : " + items.Value);
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                    }
                                }
                                else if (choice == 2)
                                {
                                    Console.Write("Search customer name : ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    string custName = Convert.ToString(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    string time;
                                    if (headsUpCustomer.TryGetValue(custName, out time))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("One appointment found : " + time);
                                        Console.ForegroundColor = ConsoleColor.Gray;

                                    }
                                    else
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nNo Appointment found");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                else if (choice == 3)
                                {
                                    Console.Write("Enter appointment key : ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    string time = Convert.ToString(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    string custName;
                                    if (headsUpCustomer.TryGetValue(time, out custName))
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write("One appointment found : " + time);
                                        Console.ForegroundColor = ConsoleColor.Gray;

                                    }
                                    else
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nNo Appointment found");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                else if (choice == 4)
                                {

                                }
                                else if (choice == 5)
                                {
                                    user = 0;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Are you sure?");
                                    Console.WriteLine("\t[0]-No" + "\n\t[1]-Yes");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.Write("\nEnter your choice: ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    int logout = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.ReadKey();

                                    if (logout == 0)
                                    {
                                        continue;
                                    }
                                    else if (logout == 1)
                                    {
                                        login = false;
                                        user = GoHome(user);
                                        break;
                                    }
                                }

                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nInvalid Username/Password");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            continue;
                        }
                    }


                }
                else if (user == 3)
                    break;
            }
            
            Console.ReadKey();
        }



        public static int GoHome(int inp)
        {

            Console.WriteLine("----------------------------------");
            Console.WriteLine("            HEADS UP!");
            Console.WriteLine("    A salon appointment program  ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n\t[1]-Customer" + "\n\t[2]-Salon Staff" + "\n\t[3]-Finish");


            Console.Write("\nLogin as : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            inp = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;
            return inp;
        }

    }
   

}
