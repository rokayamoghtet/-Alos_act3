using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DelaiLivraisonAPI.Models;

namespace SampleAPI.Controllers.v2
{
    [ApiController]
    //[Route("api/v{version:apiVersion}/users")]
    [Route("api/users")]
    [ApiVersion("2.0")]
    public class UsersController : ControllerBase
    {
        [HttpGet()]
        public IActionResult AllUsers()
        {
            // mimiking db operation
            List<UserV2> users = new List<UserV2>()
            {
                new UserV2
                {
                    Track = 999999999,
                    ServiceUPS = "UPS Standard",
                    Poids ="16,00 Kg",
                    Adresse ="Dharma Paris France",
                    DateLivré="01-05-2022",
                    TempsLivré="14:40:20",
                    Signé="Donald"},
                new UserV2
                {
                    Track = 222222222,
                    ServiceUPS = "UPS Standard",
                    Poids ="22,00 Kg",
                    Adresse ="200 rue des fleur Paris France",  
                    DateLivré="05-05-2022",
                    TempsLivré="10:40:20",   
                    Signé="Neil"
                },
                new UserV2
                {
                   Track = 333333333,
                    ServiceUPS = "UPS Standard",
                    Poids ="32,00 Kg",
                    Adresse ="12000 Marseille France",  
                    DateLivré="30-05-2022",
                    TempsLivré="12:33:00",   
                    Signé="Duck"
                }
            };

            return Ok(users);
        }
    }
}