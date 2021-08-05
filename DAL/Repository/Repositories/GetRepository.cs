using DAL.Model.Response;
using DAL.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository.Repositories
{
    public class GetRepository : IGetRepository
    {
        public GetRepository()
        {

        }

        public ListDataResponse<dynamic> GetData()
        {
            throw new NotImplementedException();
        }
    }
}
