using CapaDatos;
using Commom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{

    public class SocioServices
    {
        private ClubFinalEntities _DBContext;

        public SocioServices()
        {
            _DBContext = new ClubFinalEntities();
        }

        public OperationResult<Socio> CreateSocios(Socio socioModel)
        {
            var operationResult = new OperationResult<Socio>();

            try
            {
                _DBContext.Socios.Add(socioModel);
                _DBContext.SaveChanges();
                operationResult = OperationResultOperation(socioModel, true);
            }
            catch (Exception ex)
            {
                operationResult = OperationResultOperation(socioModel, true);
            }

            return operationResult;
        }

        public OperationResult<Socio> UpdateSocios(Socio socioModel)
        {
            var operationResult = new OperationResult<Socio>();
            var result = _DBContext.Socios.Find(socioModel.Id);

            try
            {
                _DBContext.Socios.Attach(socioModel);
                _DBContext.Entry(socioModel).State = EntityState.Modified;
                _DBContext.SaveChanges();
                operationResult = OperationResultOperation(socioModel, true);
            }
            catch (Exception)
            {
                operationResult = OperationResultOperation(socioModel, true);
            }

            return operationResult;
        }

        public List<Socio> GetallSocios()
        {
            var sociosList = _DBContext.Socios
                                      .Include("TipoSocio")                         
                                      .OrderBy(x => x.Id)   
                                      //.Where(x => x.Estatus.Equals(1))
                                      .ToList();

            return sociosList;
        }

        public List<TipoSocio> GetallTipoSocio()
        {
            var sociosList = _DBContext.TipoSocios
                                      .OrderBy(x => x.IdTipoSocio)
                                      //.Where(x => x.Estatus.Equals(1))
                                      .ToList();

            return sociosList;
        }

        public OperationResult<Socio> DelecteSocio(int id)
        {
            var operationResult = new OperationResult<Socio>();
            var model = _DBContext.Socios.Find(id);

            try
            {
                _DBContext.Socios.Remove(model);
                _DBContext.SaveChanges();
                operationResult = OperationResultOperation(model, true);
            }
            catch (Exception)
            {
                operationResult = OperationResultOperation(model, true);
            }

            return operationResult;
        }




        private OperationResult<Socio> OperationResultOperation(Socio socioModel, bool status)
        {
            var result = new OperationResult<Socio>();

            result.Model = socioModel;
            result.Messages.Add(status != true ? "Error" : "Success");
            result.Success = status;

            return result;
        }
    }
}
