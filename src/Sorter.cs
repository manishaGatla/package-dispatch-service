using package_dispatch_service.Enumerations;

namespace package_dispatch_service.src
{
    public static class Sorter
    {
        public static string Sort(int width, int height, int length, int mass)
        {
            bool bulky = width >= 150 || height >= 150 || length >= 150 ||
                         (long)width * height * length >= 1000000;

            bool heavy = mass >= 20;

            if (bulky && heavy) return DispatchType.REJECTED.ToString();
            if (bulky || heavy) return DispatchType.SPECIAL.ToString();
            return DispatchType.STANDARD.ToString();
        }
    }
}
