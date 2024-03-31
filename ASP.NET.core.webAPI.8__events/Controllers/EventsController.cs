using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace core_webAPI_tmplt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly ILogger<EventsController> _logger;
        private readonly IConfiguration _configuration;       

        public EventsController(ILogger<EventsController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        

        [HttpGet]    
        public Events Get()
        {

            /* get conection string */
            string myDb1ConnectionString = _configuration.GetConnectionString("DB1");
            /* get custom keys */
            string myCustomKey = _configuration.GetSection("myCustomKey").Value;

            Events evts = new Events();  
            Event evtItem1 = new Event();
                  evtItem1.eID = 1;
                  evtItem1.catID = 5;
                  evtItem1.catName = "catName";
                  evtItem1.eventDet = "evtItem1 details";
            evts.events.Add(evtItem1);
           
            Event evtItem2 = new Event();
                  evtItem2.eID = 2;
                  evtItem2.catID = 4;
                  evtItem2.catName = "catName";
                  evtItem2.eventDet = "evtItem2 details";
            evts.events.Add(evtItem2);

            evts.status.status = true;
            evts.status.detail = "transaction detail";

            /* JsonSerializer.Serialize(evts) */
            return evts;           
        }




        /*
        [HttpGet] 
        public Event Get(int id) {
            ...
            return evt;
        } 

        [HttpPost]
        public Status Post([FromBody] Event evt)
        {
            ...
            return status;
        }

        [HttpPut]
        public Status Put(int id, [FromBody] Event evt)
        {
            ...
            return status;
        }

        [HttpDelete]
        public Status Delete(int id)
        {
            ...
            return status;
        }
        */

    }
}
