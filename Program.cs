namespace Day10AddressBook
{
    class Program
    {

        public string firstname, lastname, mobilenumber, address, city, state, zip, email;
        public static void Main(string[] args)
        {
           // Console.WriteLine("Hello, Welcome to the Adress Book Program: ");
            //ContactManagementUC1.CreateContact();

            ContactManagementUC3 obj = new ContactManagementUC3();
            obj.Usecase3_ContactManagement();

        }

    }
    
    
}
