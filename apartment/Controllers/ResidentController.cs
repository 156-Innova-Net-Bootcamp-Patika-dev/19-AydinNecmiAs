using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace apartment.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class ResidentController : Controller
    {
        public static List<Resident> ResidentList = new List<Resident>()
        {
            new Resident {
                ResidentName ="Mathias V. Friis",
                ResidentPhone ="08662 90 41 11",
                Id = 1,
                ApartmentNumber="1",
                FloorNumber="0",
                DuesStatus=true,
                RentStatus=false,
                Type="3+1",
                Bills="300",
            },
            new Resident {
                ResidentName ="James S. Shafer",
                ResidentPhone ="989-626-2322",
                Id = 2,
                ApartmentNumber="1",
                FloorNumber="0",
                DuesStatus=true,
                RentStatus=true,
                Type="3+1",
                Bills="200",
            },
             new Resident {
                ResidentName ="Velma J. Hebert",
                ResidentPhone ="770-563-7573",
                Id = 3,
                ApartmentNumber="3",
                FloorNumber="1",
                DuesStatus=false,
                RentStatus=false,
                Type="2+1",
                Bills="100",
            },
             new Resident {
                ResidentName ="Nancy J. Valentine",
                ResidentPhone ="477 2605",
                Id = 4,
                ApartmentNumber="3",
                FloorNumber="6",
                DuesStatus=true,
                RentStatus=true,
                Type="4+1",
                Bills="400",
            }


        };

        private readonly ILogger<ResidentController> _logger;

        public ResidentController(ILogger<ResidentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Resident> GetResidents()
        {
            return ResidentList;
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var resident = ResidentList.FirstOrDefault(x => x.Id == id);
            if (resident is null)
            {
                return NotFound("No resident with this id was found.");
            }
            return Ok(resident);
        }

        [HttpPost]
        public IActionResult AddResident([FromBody] Resident newResident)
        {

            var resident = ResidentList.SingleOrDefault(x => x.ResidentName == newResident.ResidentName || x.Id == newResident.Id);
            if (resident is not null)
            {
                return NotFound("Resident already exist");
            }
            ResidentList.Add(newResident);
            return Created("", "Resident added");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateResident([FromBody] Resident updatedResident, int id)
        {

            var resident = ResidentList.SingleOrDefault(x => x.Id == id);
            if (resident is null)
            {
                return NotFound("No resident with this id was found.");
            }
            resident.Id = updatedResident.Id != 0 ? updatedResident.Id : resident.Id;
            resident.ResidentName = updatedResident.ResidentName != "string" ? updatedResident.ResidentName : resident.ResidentName;
            resident.ResidentPhone = updatedResident.ResidentPhone != "string" ? updatedResident.ResidentPhone : resident.ResidentPhone;
            resident.RentStatus = updatedResident.RentStatus = true || false ? updatedResident.RentStatus : resident.RentStatus;
            resident.ApartmentNumber = updatedResident.ApartmentNumber != "string" ? updatedResident.ApartmentNumber : resident.ApartmentNumber;
            resident.Bills = updatedResident.Bills != "string" ? updatedResident.Bills : resident.Bills;
            resident.Type = updatedResident.Type != "string" ? updatedResident.Type : resident.Type;
            resident.FloorNumber = updatedResident.FloorNumber != "string" ? updatedResident.FloorNumber : resident.FloorNumber;
            resident.DuesStatus = updatedResident.DuesStatus != true || false ? updatedResident.DuesStatus : resident.DuesStatus;


            return Ok("Resident Updated.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteResident(int id)
        {
            
            var resident = ResidentList.FirstOrDefault(x => x.Id == id);
            if (resident is null)
            {
                return NotFound("No resident with this id was found.");
            }
            ResidentList.Remove(resident);
            return Ok("Resident removed");
        }

    }
}
