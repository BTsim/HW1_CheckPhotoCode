using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPhotoCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you have a photo among your documents?");
            string photo_existence=Console.ReadLine();
            int selection = 0;
            if (photo_existence=="yes")
            {
                selection = 1;
            }
            else
            {
                selection = 2;
            }
            switch(selection)
            {
                case 1:
                    Console.WriteLine("Is this photo older than 3 months or used in passport?");
                    string photo_properties = Console.ReadLine();
                    if (photo_properties=="no")
                    {
                        selection = 3;
                        goto case 3;
                    }
                    else
                    {
                        goto case 2;
                    }
                case 2:
                    Console.WriteLine("Go to photoroom");
                    goto case 1;
                case 3:
                    Console.WriteLine("Is this photo sticked in in documents?");
                    string photo_stick=Console.ReadLine();
                    if (photo_stick=="yes")
                   {
                        Console.WriteLine("Go to payment");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Please stick in photo into documents and go to payment");
                        Console.ReadLine();
                    }
                    break;

            }
        }
    }
}
