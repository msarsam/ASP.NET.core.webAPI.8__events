using System.ComponentModel.DataAnnotations;

namespace core_webAPI_tmplt
{
    public class Events
    {
        public List<Event> events { get; set; } = new List<Event>();
        public Status status { get; set; } = new Status();
    }

    public class Event
    {
        #region Properties
        public int eID { get; set; }
        public int catID { get; set; }
        public string catName { get; set; }
        public string eventDet { get; set; }
       /* public string datePosted { get; set; }*/
        #endregion
    }


    public class Status
    {
        #region Properties       
        public bool status { get; set; }
        public string detail { get; set; }
        #endregion
    }
}
