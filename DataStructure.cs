using System.Collections.Generic;
using System.Numerics;

namespace BlueMageHelper
{
    internal struct SpellAcquisition
    {
        public uint ActionID;
        public List<SpellAcquisitionMobs> Mobs;
    }

    internal struct SpellAcquisitionMobs
    {
        public uint MobID;
        public uint TerritoryID;
        public Vector2 Coordinate;
        public string Notes;
    }
}