using CSharp_DataAccess_with_SQLClient.Models;

namespace CSharp_DataAccess_with_SQLClient.Repositories;

public interface ICustomerRepository
{

    public List<Customer> GetCustomers();
    public Customer GetCustomerById(int id);

    public Customer GetCustomerByName(string firstName, string lastName);

    public List<Customer> GetLimitedCustomersByOffset(int limit, int offset);

    public bool AddNewCustomer(Customer customer);

    public bool UpdateCustomer(Customer customer);

    public List<CountryCount> GetCustomerCountByCountry();

    public List<CustomerInvoice> GetCustomersBySpending();

    public List<CustomerInvoice> GetGenreByCustomer(int id);

}