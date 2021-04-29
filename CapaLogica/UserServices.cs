using CapaDatos;
using Commom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class UserServices
    {
        private ClubFinalEntities _DBContext;
        public UserServices()
        {
            _DBContext = new ClubFinalEntities();
        }

        public Loging LoginUser(string user, string clave)
        {

            var userModel = _DBContext.Logings.Where(x => x.Usuario.Equals(user) && x.Clave.Equals(clave)).SingleOrDefault();
            
            return userModel;
        }

        private OperationResult<Loging> OperationResultOperation(Loging logModel, bool status)
        {
            var result = new OperationResult<Loging>();

            result.Model = logModel;
            result.Messages.Add(status != true ? "Error" : "Success");
            result.Success = status;

            return result;
        }
    }
}
