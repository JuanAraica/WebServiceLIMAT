using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebServiceLIMAT.Models;
using WebServiceLIMAT.Models.Request;
using WebServiceLIMAT.Models.Response;

namespace WebServiceLIMAT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult ViewClientes() {
            Respuesta oRespuesta = new Respuesta();
            try
            {
            using (gdlimatContext db= new gdlimatContext())
            {
                var lst = db.TblClientes.ToList();
                oRespuesta.Exito = 1;
                oRespuesta.Data = lst;
            }

            }
            catch (Exception ex)
            {

                oRespuesta.Mensaje=ex.Message;
            }
            return Ok(oRespuesta);
        }
        [HttpPost]
        public IActionResult AddCliente(ClienteRequest model)
        {
            Respuesta oRespuesta = new Respuesta();
            try
            {
                using (gdlimatContext db = new gdlimatContext())
                {
                    TblClientes oCliente = new TblClientes();
                    oCliente.NombreCliente = model.NombreCliente;
                    oCliente.Contacto = model.Contacto;
                    oCliente.Direccion = model.Direccion;
                    oCliente.Telefono = model.Telefono;
                    oCliente.Email = model.Email;
                    oCliente.Proyecto = model.Proyecto;
                    db.TblClientes.Add(oCliente);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {

                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }
        [HttpPut]
        public IActionResult EditCliente(ClienteRequest model)
        {
            Respuesta oRespuesta = new Respuesta();
            try
            {
                using (gdlimatContext db = new gdlimatContext())
                {
                    TblClientes oCliente = db.TblClientes.Find(model.NombreCliente);
                    oCliente.NombreCliente = model.NombreCliente;
                    oCliente.Contacto = model.Contacto;
                    oCliente.Direccion = model.Direccion;
                    oCliente.Telefono = model.Telefono;
                    oCliente.Email = model.Email;
                    oCliente.Proyecto = model.Proyecto;
                    db.Entry(oCliente).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {

                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }
        [HttpDelete("NombreCliente")]
        public IActionResult DeleteCliente(string NombreCliente)
        {
            Respuesta oRespuesta = new Respuesta();
            try
            {
                using (gdlimatContext db = new gdlimatContext())
                {
                    TblClientes oCliente = db.TblClientes.Find(NombreCliente);
                    db.Remove(oCliente);
                    db.SaveChanges();
                    oRespuesta.Exito = 1;
                }
            }
            catch (Exception ex)
            {

                oRespuesta.Mensaje = ex.Message;
            }

            return Ok(oRespuesta);
        }
    }
}
