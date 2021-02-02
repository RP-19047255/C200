using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp_2.Models
{
   public class Detections
    {
        [Key]
        public long DetectionId { get; set; }
        public string DeviceId { get; set; }
        public string SensorId { get; set; }
        public string Classification { get; set; }
        public DateTime Timestamp { get; set; }
    }

}
