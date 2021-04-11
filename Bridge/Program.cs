using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            HandSetBrand brand;

            brand = new HandSetBrandN();
            brand.SetHandSetSoft(new HandSetGame());
            brand.Run();
            brand.SetHandSetSoft(new HandSetAddressList());
            brand.Run();

            brand = new HandSetBrandM();
            brand.SetHandSetSoft(new HandSetGame());
            brand.Run();
            brand.SetHandSetSoft(new HandSetAddressList());
            brand.Run();
        }
    }
}
