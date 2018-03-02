using System;

namespace semaphore_proj.Models
{
    public abstract class BaseEntity {}
    public class User : BaseEntity
    {
        public int userid { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int semxp { get; set; }
        public int semlevel { get; set; }
        public int morxp { get;set; }
        public int morlevel { get;set; }        
        public DateTime created { get;set; }
        public DateTime updated { get;set; }
    }
}