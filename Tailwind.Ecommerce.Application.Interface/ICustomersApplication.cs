﻿using System;
using System.Collections.Generic;
using System.Text;
using Tailwind.Ecommerce.Application.DTO;
using Tailwind.Ecommerce.Transversal.Common;
using System.Threading.Tasks;
namespace Tailwind.Ecommerce.Application.Interface
{
    public interface ICustomersApplication
    {
        #region Métodos Síncronos
        Response<bool> Insert(CustomersDto customer);
        Response<bool> Update(CustomersDto customer);
        Response<bool> Delete(string customerId);
        Response<CustomersDto> Get(string customerId);
        Response<IEnumerable<CustomersDto>> GetAll();
        #endregion

        #region Métodos Asíncronos
        Task<Response<bool>> InsertAsync(CustomersDto customer);
        Task<Response<bool>> UpdateAsync(CustomersDto customer);
        Task<Response<bool>> DeleteAsync(string customerId);
        Task<Response<CustomersDto>> GetAsync(string customerId);
        Task<Response<IEnumerable<CustomersDto>>> GetAllAsync();
        #endregion
    }
}
