namespace SuperAPI.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name {get; set;} = "Spider-Man";
        public int HitPoints {get; set;} = 100;
        public int Strength {get; set;} = 40;
        public int Defense {get; set;} = 30;
        public int Intelligence {get; set;} = 80;
        public int Evasiveness {get; set;} = 90;
        public RpgClass Class { get; set; } = RpgClass.Tech;

    }
}