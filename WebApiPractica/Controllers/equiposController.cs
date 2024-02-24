using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiPractica.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiPractica.Properties
{
    [Route("api/[controller]")]
    [ApiController]
    public class equiposController : ControllerBase
    {
        private readonly equiposContext _equiposContexto;

        public equiposController(equiposContext equiposContexto)
        {

            _equiposContexto = equiposContexto;


        }
            /// EndPoint que retorna el Lisado de todos los equipos existentes
            /// </summary>
            /// <returns></returns>
            [HttpGet]
            [Route("GetAll")]

            public IActionResult Get()
            {

                List<equipos> listadoEquipo = (from e in _equiposContexto.equipos
                                               select e).ToList();

                if (listadoEquipo.Count() = 0)
                {

                    return NotFound();

                }

                return Ok(listadoEquipo);

            }


        }
    }




