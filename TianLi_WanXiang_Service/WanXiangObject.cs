using System.ComponentModel.DataAnnotations;

namespace TianLi_WanXiang_Service
{
    public class WanXiangObject
    {
        public DateTime Date { get; set; }

        public double X { get; set; }
        
        public double Y { get; set; }

        public double Z { get; set; }

        public int MapId { get; set; }
        
        [Required]
        public string ObjectName { get; set; } = string.Empty;

        public string ExtendedFieldJson { get; set; } = string.Empty;
    }
}