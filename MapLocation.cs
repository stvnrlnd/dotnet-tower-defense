using System;

namespace TowerDefense
{
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException($"Sorry, [{x},{y}] is outside the boundaries of the map.");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
