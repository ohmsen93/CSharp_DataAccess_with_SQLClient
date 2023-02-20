using System.Reflection.Metadata;
using CSharp_DataAccess_with_SQLClient.Models;
using CSharp_DataAccess_with_SQLClient.Repositories;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tests Initializing:");

        ICustomerRepository repository = new CustomerRepository();

        //TestSelectAll(repository);

        //TestSelectById(repository, 1);

        //TestSelectByName(repository, "Kara", "Nielsen");

        //TestGetLimitedCustomersByOffset(repository, 20, 40);

        //TestAddNewCustomer(repository, "TestMand", "Testensen", "TestingCorp", "TestAvenue12", "TestCity", "TestState", "TestCountry", "4100", "20202020", "30303030", "TestEmail", 3);

        //TestUpdateCustomer(repository, 61, "ReplaceTestMand", "ReplaceTestensen", "ReplaceTestingCorp", "ReplaceTestAvenue12", "ReplaceTestCity", "ReplaceTestState", "ReplaceTestCountry", "4200", "21202020", "31303030", "ReplaceTestEmail", 3);

        //TestGetCustomerCountByCountry(repository);

        TestCustomerBySpending(repository);

        //TestFavoriteGenre(repository);
    }

    // Print functionality
    static void PrintCustomers(IEnumerable<Customer> customers)
    {
        foreach (Customer customer in customers)
        {
            PrintCustomer(customer);
        }
    }
    static void PrintCustomer(Customer customer)
    {
        Console.WriteLine($"--- {customer.CustomerId} {customer.FirstName} {customer.LastName} {customer.Company} {customer.City}");
    }
    static void PrintGenres(IEnumerable<CustomerInvoice> customer)
    {
        foreach (CustomerInvoice genre in customer)
        {
            PrintGenre(genre);
        }
    }
    static void PrintGenre(CustomerInvoice genre)
    {
        Console.WriteLine($"--- Name: {genre.FirstName} - Genre: {genre.Genre} - InvoiceAmmount: {genre.InvoiceAmmount}");
    }

    static void PrintCountryCount(CountryCount countryCount)
    {
        Console.WriteLine($"--- Country: {countryCount.Name} - Count: {countryCount.Count}");
    }

    static void PrintCountryCounts(IEnumerable<CountryCount> countryCounts)
    {
        foreach (CountryCount countryCount in countryCounts)
        {
            PrintCountryCount(countryCount);
        }
    }


    // TESTS

    static void TestSelectAll(ICustomerRepository repository)
    {
        PrintCustomers(repository.GetCustomers());
    }
    static void TestSelectById(ICustomerRepository repository, int id)
    {
        PrintCustomer(repository.GetCustomerById(id));
    }
    static void TestSelectByName(ICustomerRepository repository, string firstName, string lastName)
    {
        PrintCustomer(repository.GetCustomerByName(firstName, lastName));
    }
    static void TestCustomerBySpending(ICustomerRepository repository)
    {
        PrintGenres(repository.GetCustomersBySpending());
    }
    static void TestGetLimitedCustomersByOffset(ICustomerRepository repository, int limit, int offset)
    {
        PrintCustomers(repository.GetLimitedCustomersByOffset(limit, offset));
    }

    static void TestAddNewCustomer(ICustomerRepository repository, string firstName, string lastName, string company, string address, string city, string state, string country, string postalCode, string phone, string fax, string email, int supportRepId)
    {
        Customer customer = new Customer();

        customer.FirstName = firstName;
        customer.LastName = lastName;
        customer.Company = company;
        customer.Address = address;
        customer.City = city;
        customer.State = state;
        customer.Country = country;
        customer.PostalCode = postalCode;
        customer.Phone = phone;
        customer.Fax = fax;
        customer.Email = email;
        customer.SupportRepId = supportRepId;

        repository.AddNewCustomer(customer);
    }

    static void TestUpdateCustomer(ICustomerRepository repository, int id, string firstName, string lastName, string company, string address, string city, string state, string country, string postalCode, string phone, string fax, string email, int supportRepId)
    {
        Customer customer = new Customer();

        customer.CustomerId = id;
        customer.FirstName = firstName;
        customer.LastName = lastName;
        customer.Company = company;
        customer.Address = address;
        customer.City = city;
        customer.State = state;
        customer.Country = country;
        customer.PostalCode = postalCode;
        customer.Phone = phone;
        customer.Fax = fax;
        customer.Email = email;
        customer.SupportRepId = supportRepId;

        repository.UpdateCustomer(customer);
    }

    static void TestGetCustomerCountByCountry(ICustomerRepository repository)
    {
        PrintCountryCounts(repository.GetCustomerCountByCountry());
    }





    static void TestFavoriteGenre(ICustomerRepository repository)
    {
        PrintGenres(repository.GetGenreByCustomer(1));
    }
}