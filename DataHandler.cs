using System.Collections.Generic;

namespace BlueMageHelper
{
    public class DataHandler
    {
        public class MobData
        {
            public int Difficulty { get; set; }
        }
        
        public static MobData Mobs(int nameID)
        {
            if (mobs.TryGetValue(nameID, out MobData value)) return value;
            else return null;
        }

        private static readonly Dictionary<int, MobData> mobs = new Dictionary<int, MobData>()
        {
            { 405, new MobData { Difficulty=2 } },
            { 541, new MobData { Difficulty=1 } }
        };
    }
    
    
}