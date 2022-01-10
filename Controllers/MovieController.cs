using Microsoft.AspNetCore.Mvc;
using MoiveAPICreationDapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoiveAPICreationDapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        MovieDAL mDAL = new MovieDAL();
        [HttpGet]
        public List<Movie> GetMovies()
        {
            return mDAL.GetAllMovies();
        }

        [HttpGet("Horror")]
        public List<Movie> GetHorror()
        {
            List<Movie> Horror = mDAL.GetAllMovies().Where(x => x.genre == "Horror").ToList();
            return Horror;
        }

        [HttpGet("Fantasy")]
        public List<Movie> GetFantasy()
        {
            List<Movie> Fantasy = mDAL.GetAllMovies().Where(x => x.genre == "Fantasy").ToList();
            return Fantasy;
        }

        [HttpGet("Action")]
        public List<Movie> GetAction()
        {
            List<Movie> Action = mDAL.GetAllMovies().Where(x => x.genre == "Action").ToList();
            return Action;
        }

        [HttpGet("Cartoon")]
        public List<Movie> GetCartoon()
        {
            List<Movie> Cartoon = mDAL.GetAllMovies().Where(x => x.genre == "Cartoon").ToList();
            return Cartoon;
        }

        [HttpGet("Mystery")]
        public List<Movie> GetMystery()
        {
            List<Movie> Mystery = mDAL.GetAllMovies().Where(x => x.genre == "Mystery").ToList();
            return Mystery;
        }

    }
}
    
