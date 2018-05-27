using RayTraccing.Materials;

namespace RayTraccing.Geometries
{
    abstract class Figure
    {
        Material material;

        public Material Material
        {
            get { return material; }
        }

        public Figure(Material material = null)
        {
            this.material = material;
        }
        
        public virtual void Initialize()
        {
        }
        
        public abstract Hit Intersect(Ray ray);
    }
}
