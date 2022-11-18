using CarrerasBackEnd.entidades;
using CarrerasBackEnd.facade;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarrerasWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrerasController : ControllerBase
    {
        private Idatos _datos;
        public CarrerasController()
        {
            //_datos = factory.getInstance();
            _datos = new datosCarreras();
        }
        [HttpGet("/materias")]
        public IActionResult getMaterias()
        {
            if (_datos.GetMaterias!=null)
            {
                return Ok(_datos.GetMaterias());
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("/titulo")]
        public IActionResult GetTitulos()
        {
            if (_datos.GetTitulos != null)
            {
                return Ok(_datos.GetTitulos());
            }
            else
            {
                return NotFound();
            }
        }

        
        [HttpPost("/carrera")]
        public IActionResult PostCarrera(carreras Ocarrera)
        {
            try
            {
                if (Ocarrera==null)
                {
                    return BadRequest("datosDeCarreraIcorrecto");
                }

                return Ok(_datos.PostCarrera(Ocarrera));
            }
            catch (Exception)
            {
                return  StatusCode(500,"errorInterno!!!");
            }

        }

        //// PUT api/<CarrerasController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<CarrerasController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
