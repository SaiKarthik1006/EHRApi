using DAL.Model.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.IRepositories
{
    public interface IGetRepository
    {
        ListDataResponse<dynamic> GetData();
    }
}
