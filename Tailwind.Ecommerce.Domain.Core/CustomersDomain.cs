using System;
using Tailwind.Ecommerce.Domain.Entity;
using Tailwind.Ecommerce.Domain.Interface;
using Tailwind.Ecommerce.Infrastructure.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Tailwind.Ecommerce.Domain.Core
{
    public class CustomersDomain: ICustomersDomain
    {
        private readonly ICustomersRepository _customerRepository;

        public CustomersDomain(ICustomersRepository customersRepository)
        {
            _customerRepository = customersRepository;
        }

        #region Métodos Síncronos
        public bool Insert(Customers customers)
        {
            return _customerRepository.Insert(customers);
        }
        public bool Update(Customers customers)
        {
            return _customerRepository.Update(customers);
        }
        public bool Delete(string customerId)
        {
            return _customerRepository.Delete(customerId);
        }
        public Customers Get(string customerId)
        {
            return _customerRepository.Get(customerId);
        }
        public IEnumerable<Customers> GetAll()
        {
            return _customerRepository.GetAll();
        }
        #endregion

        #region Métodos Asíncronos
        public async Task<bool> InsertAsync(Customers customers)
        {
            return await _customerRepository.InsertAsync(customers);
        }
        public async Task<bool> UpdateAsync(Customers customers)
        {
            return await _customerRepository.UpdateAsync(customers);
        }
        public async Task<bool> DeleteAsync(string customerId)
        {
            return await _customerRepository.DeleteAsync(customerId);
        }
        public async Task<Customers> GetAsync(string customerId)
        {
            return await _customerRepository.GetAsync(customerId);
        }
        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            return await _customerRepository.GetAllAsync();
        }
        #endregion
    }
}
