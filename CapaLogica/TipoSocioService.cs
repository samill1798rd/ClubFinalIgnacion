using CapaDatos;
using Commom;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class TipoSocioService
    {
        private ClubFinalEntities _DBContext;
        public TipoSocioService()
        {
            _DBContext = new ClubFinalEntities();
        }
        public OperationResult<TipoSocio> CreateTipoSocio(TipoSocio tipoSocioModel)
        {
            var operationResult = new OperationResult<TipoSocio>();

            try
            {
                _DBContext.TipoSocios.Add(tipoSocioModel);
                _DBContext.SaveChanges();
                operationResult = OperationResultOperation(tipoSocioModel, true);
            }
            catch (Exception ex)
            {
                operationResult = OperationResultOperation(tipoSocioModel, true);
            }

            return operationResult;
        }

        public OperationResult<TipoSocio> UpdateTipoSocio(TipoSocio tipoSocioModel)
        {

            var operationResult = new OperationResult<TipoSocio>();
            var result = _DBContext.TipoSocios
                                    .Find(tipoSocioModel.IdTipoSocio);

            result.Descripcion = tipoSocioModel.Descripcion;

            try
            {
                _DBContext.TipoSocios.Attach(result);
                _DBContext.Entry(result).State = EntityState.Modified;
                _DBContext.SaveChanges();
                operationResult = OperationResultOperation(result, true);
            }
            catch (Exception ex)
            {
                operationResult = OperationResultOperation(result, true);
            }

            return operationResult;
        }

        public List<TipoSocio> GetallTipoSocios(string campo)
        {
            var query = new List<TipoSocio>();

            if (campo.Equals(string.Empty))
            {
                query = _DBContext.TipoSocios.ToList();
            }
            else
            {
                query = _DBContext.TipoSocios.Where(x => x.Descripcion.StartsWith(campo)).ToList();
            }

            return query;
        }


        public TipoSocio GetTipoSocioById(int id)
        {
            var tipoSocio = _DBContext.TipoSocios
                                      .Find(id);

            return tipoSocio;
        }

        public OperationResult<TipoSocio> DelecteTipoSocio(int id)
        {
            var operationResult = new OperationResult<TipoSocio>();
            var model = _DBContext.TipoSocios.Find(id);

            try
            {
                _DBContext.TipoSocios.Remove(model);
                _DBContext.SaveChanges();
                operationResult = OperationResultOperation(model, true);
            }
            catch (Exception ex)
            {
                operationResult = OperationResultOperation(model, true);
            }

            return operationResult;
        }

        private OperationResult<TipoSocio> OperationResultOperation(TipoSocio tipoSocioModel, bool status)
        {
            var result = new OperationResult<TipoSocio>();

            result.Model = tipoSocioModel;
            result.Messages.Add(status != true ? "Error" : "Success");
            result.Success = status;

            return result;
        }
    }


}
