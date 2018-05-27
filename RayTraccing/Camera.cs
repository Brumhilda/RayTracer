using System;

namespace RayTraccing
{
    class Camera
    {
        Vec3 eye;
        Vec3 front;
        Vec3 refUp;
        double fov;
        Vec3 right;
        Vec3 up;
        double fovScale;

        public Camera(Vec3 eye, Vec3 front, Vec3 refUp, double fov)
        {
            this.eye = eye;
            this.front = front;
            this.refUp = refUp;
            this.fov = fov;
            right = new Vec3(0, 0, 0);
            up = new Vec3(0, 0, 0);
            fovScale = 0;
        }
        public void Initialize()
        {
            right = front * refUp;
            up = right * front;
            fovScale = Math.Tan(fov * (Math.PI * 0.5f / 180)) * 2;
        }
        public Ray GenerateRay(double x, double y)
        {
            Vec3 r = right * ((x - 0.5) * fovScale);
            Vec3 u = up * ((y - 0.5) * fovScale);
            return new Ray(eye, (front + r + u).Normalize());
        }
    }
}
