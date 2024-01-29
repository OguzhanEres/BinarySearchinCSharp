using System;
namespace Oguz
{
    class binary_search
    {
        public static int binary(int[] dizi, int aranan, int buyuk, int kucuk)
        {
            if (buyuk >= kucuk)
            {
                int ortadeger = kucuk + (buyuk - kucuk) / 2;
                if (dizi[ortadeger] > aranan)
                {
                    return binary(dizi, aranan, ortadeger - 1, kucuk);
                }
                else if (dizi[ortadeger] < aranan)
                {
                    return binary(dizi, aranan, buyuk, ortadeger + 1);
                }
                else
                {
                    return ortadeger;
                }
            }
            return -1;
        }
        public static void Main()
        {
            int[] dizi = { 1, 2, 3, 45, 46, 49, 85, 95, 150 };
            //aranan index girilmesi gerekiyor
            Console.WriteLine("Lütfen index giriniz: ");
            int aranan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dizi[binary(dizi, dizi[aranan], dizi.Length - 1, 0)]);

        }
    }
}