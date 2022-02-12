using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamASPNET.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EditController : ControllerBase
    {
        private readonly ILogger<ViewController> _logger;

        public EditController(ILogger<ViewController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name ="Add New Player")]
        public int Post(string name,string nickname,string team)
        {
            Team.players.Add(new Player() {Name = name,Nickname = nickname, Team = team });

            return StatusCodes.Status200OK;
        }
        [HttpDelete(Name = "Delete Player By Nickname")]
        public int Delete(string nickname)
        {
            if (Team.players.Where((player) => player.Nickname == nickname).ToList().Count != 0)
            {
                if (Team.players.Remove(Team.players.Where((player) => player.Nickname == nickname).First()))
                {
                    return StatusCodes.Status200OK;
                }
                return StatusCodes.Status204NoContent;
            }
            return StatusCodes.Status204NoContent;
        }

        [HttpPatch(Name = "Update Player")]
        public int Patch(string oldnickname, string name, string nickname, string team)
        {
            if (Team.players.Where((player) => player.Nickname == oldnickname).ToList().Count != 0)
            {
                var item = Team.players.IndexOf(Team.players.Where((player) => player.Nickname == oldnickname).First());
                if (item != -1)
                {
                    Team.players[item] = new Player() { Name = name, Nickname = nickname, Team = team };
                    return StatusCodes.Status200OK;
                }
                return StatusCodes.Status204NoContent;
            }
            else {
                return StatusCodes.Status204NoContent;
            }
        }

    }
}
