namespace Sum
{
    internal class Program
    {
        public static int[] RemoveDublicates(int[] arr1, int[] arr2)
        {
          
            int posArr1 = 0;
            int posArr2 = 0;
            int countArr1=arr1.Length;
            int countArr2=arr2.Length;
            List<int> list = new List<int>();
            while (posArr1 + posArr2 < countArr1 + countArr2-1)
            {
                if (posArr1< countArr1&&arr1[posArr1] < arr2[posArr2])
                {
                    list.Add( arr1[posArr1]);
                    if (posArr1 < countArr1 - 1) posArr1++;
                }
            
                else if (posArr2 < countArr2&&arr1[posArr1] > arr2[posArr2])
                {
                    list.Add( arr2[posArr1]);
                    if (posArr2 < countArr2 - 1) posArr2++;
                }
                else if (posArr1 < countArr1 && posArr2 < countArr2)
                {
                    list.Add( arr1[posArr1]);
                    posArr2++;
                }
                else
                {
                    if (arr1[posArr1]< arr2[posArr2])
                }
            }


            return list.ToArray();
        }
        static void Main(string[] args)
        {
            int[] mass1 = new int[] { 1, 2, 3, 3, 5, 7, 9 };
            int[] mass2 = new int[] { 10, 11, 12, };
            int[] mass3 = RemoveDublicates(mass1,mass2);
            foreach (int i in mass3)
            {
                Console.WriteLine(i);
            }

        }
    }
}
