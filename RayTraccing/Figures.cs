using System.Collections.Generic;

namespace RayTraccing.Geometries
{
    class Figures : Figure
    {
        List<Figure> figures;

        public Figures()
        {
            figures = new List<Figure>();
        }

        public void Add(Figure geometry)
        {
            figures.Add(geometry);
        }

        public int Count()
        {
            return figures.Count;
        }

        public override void Initialize()
        {
            foreach (Figure geometry in figures)
                geometry.Initialize();
        }

        public override Hit Intersect(Ray ray)
        { 
            Hit minResult = null;
            Hit result;
            foreach (Figure f in figures)
            {
                result = f.Intersect(ray);
                if (result != null && ( minResult == null ? true : result.Distance < minResult.Distance))
                    minResult = result;
            }
            return minResult;
        }
    }
}
