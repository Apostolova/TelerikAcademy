using System;


class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Enter Company Name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter adress of your company:");
        string adress = Console.ReadLine();
        Console.WriteLine("Enter phone number:");
        ulong phoneNumber = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Enter fax number:");
        ulong faxNumber = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Enter web site company:");
        string webSite = Console.ReadLine();
        Console.WriteLine("Enter information about your manager");
        Console.WriteLine("First name manager:");
        string fName = Console.ReadLine();
        Console.WriteLine("Last name manager:");
        string lName = Console.ReadLine();
        Console.WriteLine("Age manager:");
        sbyte age = sbyte.Parse(Console.ReadLine());
        Console.WriteLine("Manager phone number:");
        ulong phoneManager = ulong.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Company Name:  {0}", companyName);
                   Console.WriteLine("adress: {0}", adress);       
                        Console.WriteLine("Phone number: {0}", phoneNumber );
                        Console.WriteLine("Fax number: {0}", faxNumber);     
                         Console.WriteLine( "Web site: {0}", webSite);
                         Console.WriteLine();
                          Console.WriteLine("Information about Manager:");
                          Console.WriteLine("First Name: {0}", fName); 
                          Console.WriteLine("Last Name: {0}", lName);  
                           Console.WriteLine("Age: {0}", age);    
                           Console.WriteLine("Phone number: {0}", phoneManager);  
             
    }
}

