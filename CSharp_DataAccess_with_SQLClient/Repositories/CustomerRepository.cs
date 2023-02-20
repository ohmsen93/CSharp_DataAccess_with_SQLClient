using CSharp_DataAccess_with_SQLClient.Models;
using Microsoft.Data.SqlClient;

namespace CSharp_DataAccess_with_SQLClient.Repositories;

public class CustomerRepository : ICustomerRepository
{
    public List<Customer> GetCustomers()
    {
        List<Customer> custList = new List<Customer>();
        string sql = "SELECT CustomerId, FirstName, LastName, " +
                     "ISNULL(Company, '') AS Company, " +
                     "ISNULL(Address, '') AS Address, " +
                     "ISNULL(City, '') AS City, " +
                     "ISNULL(State, '') AS State, " +
                     "ISNULL(Country, '') AS Country, " +
                     "ISNULL(PostalCode, '') AS PostalCode, " +
                     "ISNULL(Phone, '') AS Phone, " +
                     "ISNULL(Fax, '') AS Fax, " +
                     "Email " +
                     "FROM Customer";
        try
        {

            // Connect
            using (SqlConnection conn = new SqlConnection(ConnectionStringHelper.GetConnectionString()))
            {
                conn.Open();
                // Make a command

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {

                    // Reader
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Handle Result
                            Customer temp = new Customer();
                            temp.CustomerId = reader.GetInt32(0);
                            temp.FirstName = reader.GetString(1);
                            temp.LastName = reader.GetString(2);
                            temp.Country = reader.GetString(3);
                            temp.PostalCode = reader.GetString(4);
                            temp.City = reader.GetString(5);
                            temp.Phone = reader.GetString(6);
                            temp.Email = reader.GetString(7);
                            custList.Add(temp);
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            // Log
            Console.WriteLine(e);
            throw;
        }
        return custList;

    }

    public Customer GetCustomerById(int id)
    {
        Customer cust = new Customer();
        string sql = "SELECT CustomerId, FirstName, LastName, " +
                     "ISNULL(Company, '') AS Company, " +
                     "ISNULL(Address, '') AS Address, " +
                     "ISNULL(City, '') AS City, " +
                     "ISNULL(State, '') AS State, " +
                     "ISNULL(Country, '') AS Country, " +
                     "ISNULL(PostalCode, '') AS PostalCode, " +
                     "ISNULL(Phone, '') AS Phone, " +
                     "ISNULL(Fax, '') AS Fax, " +
                     "Email " +
                     "FROM Customer WHERE CustomerId = @CustomerId";
        try
        {

            // Connect
            using (SqlConnection conn = new SqlConnection(ConnectionStringHelper.GetConnectionString()))
            {
                conn.Open();
                // Make a command

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", id);

                    // Reader
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Handle Result
                            cust.CustomerId = reader.GetInt32(0);
                            cust.FirstName = reader.GetString(1);
                            cust.LastName = reader.GetString(2);
                            cust.Country = reader.GetString(3);
                            cust.PostalCode = reader.GetString(4);
                            cust.City = reader.GetString(5);
                            cust.Phone = reader.GetString(6);
                            cust.Email = reader.GetString(7);

                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            // Log
            Console.WriteLine(e);
            throw;
        }
        return cust;
    }

    public Customer GetCustomerByName(string firstName, string lastName)
    {
        Customer cust = new Customer();
        string sql = "SELECT CustomerId, FirstName, LastName, " +
                     "ISNULL(Company, '') AS Company, " +
                     "ISNULL(Address, '') AS Address, " +
                     "ISNULL(City, '') AS City, " +
                     "ISNULL(State, '') AS State, " +
                     "ISNULL(Country, '') AS Country, " +
                     "ISNULL(PostalCode, '') AS PostalCode, " +
                     "ISNULL(Phone, '') AS Phone, " +
                     "ISNULL(Fax, '') AS Fax, " +
                     "Email " +
                     "FROM Customer WHERE FirstName LIKE '%' + @firstName + '%' AND LastName LIKE '%' + @lastName + '%'";

        try
        {

            // Connect
            using (SqlConnection conn = new SqlConnection(ConnectionStringHelper.GetConnectionString()))
            {
                conn.Open();
                // Make a command

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    // Reader
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Handle Result
                            cust.CustomerId = reader.GetInt32(0);
                            cust.FirstName = reader.GetString(1);
                            cust.LastName = reader.GetString(2);
                            cust.Country = reader.GetString(3);
                            cust.PostalCode = reader.GetString(4);
                            cust.City = reader.GetString(5);
                            cust.Phone = reader.GetString(6);
                            cust.Email = reader.GetString(7);

                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            // Log
            Console.WriteLine(e);
            throw;
        }
        return cust;
    }

    public List<Customer> GetLimitedCustomersByOffset(int limit, int offset)
    {
        List<Customer> custList = new List<Customer>();
        string sql = "SELECT CustomerId, FirstName, LastName, " +
                     "ISNULL(Company, '') AS Company, " +
                     "ISNULL(Address, '') AS Address, " +
                     "ISNULL(City, '') AS City, " +
                     "ISNULL(State, '') AS State, " +
                     "ISNULL(Country, '') AS Country, " +
                     "ISNULL(PostalCode, '') AS PostalCode, " +
                     "ISNULL(Phone, '') AS Phone, " +
                     "ISNULL(Fax, '') AS Fax, " +
                     "Email " +
                     "FROM Customer ORDER BY CustomerId OFFSET @offset ROWS FETCH NEXT @limit ROWS ONLY";
        try
        {

            // Connect
            using (SqlConnection conn = new SqlConnection(ConnectionStringHelper.GetConnectionString()))
            {
                conn.Open();
                // Make a command

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@limit", limit);
                    cmd.Parameters.AddWithValue("@offset", offset);
                    // Reader
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Handle Result
                            Customer temp = new Customer();
                            temp.CustomerId = reader.GetInt32(0);
                            temp.FirstName = reader.GetString(1);
                            temp.LastName = reader.GetString(2);
                            temp.Country = reader.GetString(3);
                            temp.PostalCode = reader.GetString(4);
                            temp.City = reader.GetString(5);
                            temp.Phone = reader.GetString(6);
                            temp.Email = reader.GetString(7);
                            custList.Add(temp);
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            // Log
            Console.WriteLine(e);
            throw;
        }
        return custList;
    }

    public bool AddNewCustomer(Customer customer)
    {
        using (SqlConnection conn = new SqlConnection(ConnectionStringHelper.GetConnectionString()))
        {
            string sql = "INSERT INTO Customer (FirstName, LastName, Company, Address, City, State, Country, PostalCode, Phone, Fax, Email, SupportRepId) " +
                         "VALUES (@firstName, @lastName, @company, @address, @city, @state, @country, @postalCode, @phone, @fax, @email, @supportRepId)";

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                // Add parameters
                cmd.Parameters.AddWithValue("@firstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@lastName", customer.LastName);
                cmd.Parameters.AddWithValue("@company", customer.Company);
                cmd.Parameters.AddWithValue("@address", customer.Address);
                cmd.Parameters.AddWithValue("@city", customer.City);
                cmd.Parameters.AddWithValue("@state", customer.State);
                cmd.Parameters.AddWithValue("@country", customer.Country);
                cmd.Parameters.AddWithValue("@postalCode", customer.PostalCode);
                cmd.Parameters.AddWithValue("@phone", customer.Phone);
                cmd.Parameters.AddWithValue("@fax", customer.Fax);
                cmd.Parameters.AddWithValue("@email", customer.Email);
                cmd.Parameters.AddWithValue("@supportRepId", customer.SupportRepId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected == 1;
            }
        }
    }

    public bool UpdateCustomer(Customer customer)
    {
        string sql = "UPDATE Customer SET FirstName = @FirstName, LastName = @LastName, Company = @Company, " +
                     "Address = @Address, City = @City, State = @State, Country = @Country, PostalCode = @PostalCode, " +
                     "Phone = @Phone, Fax = @Fax, Email = @Email, SupportRepId = @SupportRepId " +
                     "WHERE CustomerId = @CustomerId";

        try
        {
            using (SqlConnection conn = new SqlConnection(ConnectionStringHelper.GetConnectionString()))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@Company", customer.Company);
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.Parameters.AddWithValue("@City", customer.City);
                cmd.Parameters.AddWithValue("@State", customer.State);
                cmd.Parameters.AddWithValue("@Country", customer.Country);
                cmd.Parameters.AddWithValue("@PostalCode", customer.PostalCode);
                cmd.Parameters.AddWithValue("@Phone", customer.Phone);
                cmd.Parameters.AddWithValue("@Fax", customer.Fax);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@SupportRepId", customer.SupportRepId);
                cmd.Parameters.AddWithValue("@CustomerId", customer.CustomerId);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected == 1;
            }
        }
        catch (Exception e)
        {
            // Log the error
            Console.WriteLine(e);
            throw;
        }
    }


    public List<CountryCount> GetCustomerCountByCountry()
    {
        List<CountryCount> countList = new List<CountryCount>();
        string sql = "SELECT Country, COUNT(CustomerId) AS Count FROM Customer GROUP BY Country ORDER BY Count DESC";

        try
        {

            // Connect
            using (SqlConnection conn = new SqlConnection(ConnectionStringHelper.GetConnectionString()))
            {
                conn.Open();
                // Make a command

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {

                    // Reader
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Handle Result
                            CountryCount temp = new CountryCount();

                            temp.Name = reader.GetString(0);
                            temp.Count = reader.GetInt32(1);
       
                            countList.Add(temp);
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            // Log
            Console.WriteLine(e);
            throw;
        }
        return countList;
    }

    public List<CustomerInvoice> GetCustomersBySpending()
    {
        List<CustomerInvoice> countList = new List<CustomerInvoice>();
        string sql = "SELECT a.FirstName, COUNT(b.CustomerId) AS Count FROM Customer a JOIN Invoice b ON a.CustomerId = b.CustomerId GROUP BY a.FirstName, a.LastName ORDER BY Count DESC;";

        try
        {

            // Connect
            using (SqlConnection conn = new SqlConnection(ConnectionStringHelper.GetConnectionString()))
            {
                conn.Open();
                // Make a command

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {

                    // Reader
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Handle Result
                            CustomerInvoice temp = new CustomerInvoice();

                            temp.FirstName = reader.GetString(0);
                            temp.InvoiceAmmount = reader.GetInt32(1);

                            countList.Add(temp);
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            // Log
            Console.WriteLine(e);
            throw;
        }
        return countList;
    }

    public List<CustomerInvoice> GetGenreByCustomer(int id)
    {
        List<CustomerInvoice> genreCustomerList = new List<CustomerInvoice>();
        string sql = "SELECT c.FirstName, g.Name AS FavoriteGenre, COUNT(*) AS InvoiceCount " +
                     "FROM Customer c " +
                     "JOIN Invoice i ON c.CustomerId = i.CustomerId " +
                     "JOIN InvoiceLine il ON i.InvoiceId = il.InvoiceId " +
                     "JOIN Track t ON il.TrackId = t.TrackId " +
                     "JOIN Genre g ON t.GenreId = g.GenreId " +
                     "WHERE c.CustomerId = @id " +
                     "GROUP BY c.CustomerId, g.GenreId, c.FirstName, g.Name " +
                     "HAVING COUNT(*) >= ALL(" +
                     "SELECT COUNT(*) " +
                     "FROM Customer c2 " +
                     "JOIN Invoice i2 ON c2.CustomerId = i2.CustomerId " +
                     "JOIN InvoiceLine il2 ON i2.InvoiceId = il2.InvoiceId " +
                     "JOIN Track t2 ON il2.TrackId = t2.TrackId " +
                     "JOIN Genre g2 ON t2.GenreId = g2.GenreId " +
                     "WHERE c2.CustomerId = c.CustomerId " +
                     "GROUP BY g2.GenreId " +
                     ") " +
                     "ORDER BY c.FirstName;";


        try
        {

            // Connect
            using (SqlConnection conn = new SqlConnection(ConnectionStringHelper.GetConnectionString()))
            {
                conn.Open();
                // Make a command

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    // Reader
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Handle Result
                            CustomerInvoice temp = new CustomerInvoice();

                            temp.FirstName = reader.GetString(0);
                            temp.Genre = reader.GetString(1);
                            temp.InvoiceAmmount = reader.GetInt32(2);

                            genreCustomerList.Add(temp);
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            // Log
            Console.WriteLine(e);
            throw;
        }
        return genreCustomerList;


    }
}