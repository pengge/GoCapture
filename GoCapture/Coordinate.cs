
namespace GoCheck
{
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Coordinate GetCoordinate(Coordinate coordinate, Direction direction)
        {
            var x = coordinate.X;
            var y = coordinate.Y;
            switch (direction)
            {
                case Direction.North:
                    return new Coordinate(x, y + 1);
                case Direction.South:
                    return new Coordinate(x, y - 1);
                case Direction.East:
                    return new Coordinate(x + 1, y);
                case Direction.West:
                    return new Coordinate(x - 1, y);
                default:
                    return new Coordinate(x, y);
            }
        }
    }
}
