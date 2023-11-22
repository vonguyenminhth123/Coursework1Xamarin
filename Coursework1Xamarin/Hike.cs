using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework1Xamarin
{
    [SQLite.Table("Hike")]
    public class Hike
    {
        [PrimaryKey, AutoIncrement]
        public int HikeId { get; set; }
        public string HikeName { get; set; }
        public string HikeLocation { get; set; }
        public DateTime HikeDate { get; set; }
        public bool HikeAvailability { get; set; }
        public string HikeLength { get; set; }
        public string HikeLevel { get; set; }
        public string HikeDescription { get; set; }
        public Hike() { }
        public Hike (int id, string name, string location, DateTime date, bool availability, string length, string level, string description)
        {
            HikeId = id;
            HikeName = name;
            HikeLocation = location;
            HikeDate = date;
            HikeAvailability = availability;
            HikeLength = length;
            HikeLevel = level;
            HikeDescription = description;
        }
    }
}
