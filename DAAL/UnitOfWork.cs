using DAL.Repository.IRepositories;
using DAL.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        IGetRepository _ijobRepository;
        public IGetRepository getRepository
        {
            get
            {
                if (_ijobRepository == null)
                    _ijobRepository = new GetRepository();

                return _ijobRepository;
            }
        }
    }
}
