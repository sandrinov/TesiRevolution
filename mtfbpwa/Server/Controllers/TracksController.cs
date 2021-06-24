using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mtfbpwa.Shared;
using mtfbpwa.Server.Data;

namespace mtfbpwa.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TracksController : ControllerBase
    {
        private TrackManager trackManager;

        public TracksController(TrackManager _trackManager)
        {
            trackManager = _trackManager;
        }

        [HttpGet]
        public List<Track> Get()
        {
            return trackManager.AllTracks;
        }
    }
}
