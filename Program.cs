using System;

namespace QA_Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("Please enter the needed values for rectangle");

            string lengthString,heightString,widthString;
            int lengthInt,heightInt,widthInt;
            do
            {
                Console.WriteLine("Enter length of rectangle");
                lengthString = Console.ReadLine();

            } while (!int.TryParse(lengthString, out lengthInt) || lengthInt < 0);

            do
            {
                Console.WriteLine("Enter width of rectangle");
                widthString = Console.ReadLine();

            } while (!int.TryParse(widthString, out widthInt) || widthInt < 0);

            do
            {
                Console.WriteLine("Enter height of rectangle");
                heightString = Console.ReadLine();

            } while (!int.TryParse(heightString, out heightInt) || heightInt < 0);

            Rectangle obj = new Rectangle(lengthInt,heightInt,widthInt);

            string menuString;
            int menuInt;

            Program prog = new Program();
            do
            {
                Console.WriteLine("1. Get Rectangle Length \n  2.Change Rectangle Length \n 3.Get Rectangle Width \n 4.Change Rectangle Width  \n 5.Get Rectangle Height \n 6.Change Rectangle Height \n 7.Get Rectangle Volume \n 8.Exit");
                menuString = Console.ReadLine();

                if(int.TryParse(menuString, out menuInt))
                {
                    switch (menuInt)
                    {
                        case 1:
                            Console.WriteLine(obj.GetLength());
                            break;
                        case 2:
                            int tempLen = prog.setValue("length");
                            obj.SetLength(tempLen);
                            Console.WriteLine("length changed successufully to " + tempLen);
                            break;
                        case 3:
                            Console.WriteLine(obj.GetWidth());
                            break;
                        case 4:
                            int tempwid = prog.setValue("width");
                            obj.SetWidth(tempwid);
                            Console.WriteLine("width changed successufully to " + tempwid);
                            break;
                        case 5:
                            Console.WriteLine(obj.GetHeight());
                            break;
                        case 6:
                            int temph = prog.setValue("height");
                            obj.SetHeight(temph);
                            Console.WriteLine("height changed successufully to " + temph);
                            break;
                        case 7:
                            Console.WriteLine("Volume is " + obj.GetVolume());
                            break;
                        case 8:
                            Console.Write("Thank you");
                            break;
                        default:
                            Console.WriteLine("Invalid number, please try agian");
                            break;
                    }
                    Console.Read();
                }
            } while ( menuInt != 8);
        }

        public int setValue(string type)
        {
            string valueStr;
            int value;
            do
            {
                Console.WriteLine("Enter "+ type +" of rectangle");
                valueStr = Console.ReadLine();

            } while (!int.TryParse(valueStr, out value) || value < 0);
            return value;
        }
    }
}
