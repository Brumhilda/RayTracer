 using System;
using System.Drawing;
using RayTraccing.Geometries;

namespace RayTraccing
{
    class Hit
    {
        Figure figure;

        public Figure Geometry
        {
            get { return figure; }
        }

        double distance;

        public double Distance
        {
            get { return distance; }
        }

        Vec3 position;

        public Vec3 Position
        {
            get { return position; }
        }

        Vec3 normal;

        public Vec3 Normal
        {
            get { return normal; }
        }

        public Hit(Figure figure, double distance, Vec3 position, Vec3 normal)
        {
            this.figure = figure;
            this.distance = distance;
            this.position = position;
            this.normal = normal;
        }

        public MyColor GetDepthColor(int maxDepth = 20)
        {
            if (figure == null)
                return new MyColor(0,0,0);
            double depth = 1.0 - Math.Min(distance / maxDepth, 1.0);
            return new MyColor(depth, depth, depth);
        }
    }
}
