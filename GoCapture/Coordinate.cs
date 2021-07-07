
namespace GoCapture
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
            return direction switch
            {
                Direction.North => new Coordinate(x, y + 1),
                Direction.South => new Coordinate(x, y - 1),
                Direction.East => new Coordinate(x + 1, y),
                Direction.West => new Coordinate(x - 1, y),
                _ => new Coordinate(x, y),
            };
        }
    }
}
