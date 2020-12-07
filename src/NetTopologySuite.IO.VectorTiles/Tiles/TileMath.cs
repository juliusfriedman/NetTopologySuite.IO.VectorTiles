namespace NetTopologySuite.IO.VectorTiles.Tiles
{
    internal static class TileMath
    {
        internal const int EarthRadius = 6378137;
        internal const float PI2 = System.MathF.PI * 2;
        internal const float OriginShift = PI2 * EarthRadius / 2;
        internal const float PI2EarthRadius = PI2 * EarthRadius;
        internal const float OneRadian = 180.0f / System.MathF.PI;
        internal const float OneDegree = System.MathF.PI / 180.0f;
    }
}
