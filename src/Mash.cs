namespace AleaPRNG
{
    public class Mash
    {
        double n = 0xefc8249d;

        public double RunMash(string x)
        {
            var data = x;
            
            for (var i = 0; i < data.Length; i++)
            {
                n += data[i];
                
                var h = 0.02519603282416938 * n;
                n = (uint) h >> 0;
                h -= n;
                h *= n;
                n = (uint) h >> 0;
                h -= n;
                n += h * 0x100000000;
            }

            return ((uint) n >> 0) * 2.3283064365386963e-10;
        }
    }
}