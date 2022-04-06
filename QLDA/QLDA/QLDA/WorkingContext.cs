using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA
{
    
    public sealed class WorkingContext
    {
        public static WorkingContext _instance = null;
        public static WorkingContext Instance => _instance ?? (_instance = new WorkingContext());
        public QLDA _dbContext = null;
        private string _currentConnectionString;
        public LoginInfo CurrentLoginInfo;
        //private IUnitOfWork _unitofWork;
       // public LoginModel CurrentLoginInfo { get; set; }
        public string CurrentBranch { get; set; }
        public int CurrentBranchID { get; set; }
        public string CurrentLoginName { get; set; }
        private WorkingContext()
        { 

        }
        public void Inititalize(string connectionString)
        {
            _currentConnectionString = connectionString;
            _dbContext = new QLDA(_currentConnectionString);
           //_unitOfWork = new UnitOfWork(_dbContext);
        }

       /* public IUnitOfWork GetUnitOfWork()
        {
            return _unitofWork
        }*/
    }
}
