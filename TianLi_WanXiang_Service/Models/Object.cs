namespace TianLi_WanXiang_Service.Models
{
    public class Object
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public int MapId { get; set; }
        public string ObjectName { get; set; } = string.Empty;
        public string ExtendedFieldJson { get; set; } = string.Empty;
    }
}
