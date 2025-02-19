namespace Sum
{
    internal class Program
    {
        public static int[] RemoveDublicates(int[] arr1, int[] arr2)
        {
            if (arr1.Length == 0) return arr2;
            if (arr2.Length == 0) return arr1;
            int posArr1 = 0;
            int posArr2 = 0;
            int countArr1 = arr1.Length;
            int countArr2 = arr2.Length;
            int countOb = countArr1 + countArr2;
            int countIp = 1;
            bool flagArr1 = false;
            bool flagArr2 = false;
            List<int> list = new List<int>();
            if (arr1[0] <= arr2[0])
            {
                list.Add(arr1[0]); posArr1++;
            }
            else
            {
                list.Add(arr2[0]); posArr2++;

            }
            for (int i = 1; i < countOb; i++)
            {
                if (posArr1 == countArr1) flagArr1 = true;
                if (posArr2 == countArr2) flagArr2 = true;



                if (flagArr1)
                {
                    if (arr2[posArr2] != list[i - countIp])
                    {
                        list.Add(arr2[posArr2++]);
                    }
                    else
                    {
                        countIp++;
                        posArr2++;
                    }
                }
                else if (flagArr2)
                {
                    if (arr1[posArr1] != list[i - countIp])
                    {
                        list.Add(arr1[posArr1++]);
                    }
                    else
                    {
                        countIp++;
                        posArr1++;
                    }
                }
                else if (arr1[posArr1] < arr2[posArr2])
                {
                    if (arr1[posArr1] != list[i - countIp])
                    {
                        list.Add(arr1[posArr1++]);
                    }
                    else
                    {
                        countIp++;
                        posArr1++;
                    }
                }
                else if (arr1[posArr1] > arr2[posArr2])
                {
                    if (arr2[posArr2] != list[i - countIp])
                    {
                        list.Add(arr2[posArr2++]);
                    }
                    else
                    {
                        countIp++;
                        posArr2++;
                    }
                }
                else if (arr1[posArr1] == arr2[posArr2])
                {
                    if (arr1[posArr1] != list[i - countIp])
                    {
                        list.Add(arr1[posArr1++]);
                    }
                    else
                    {
                        countIp++;
                        posArr1++;
                    }
                    countIp++;
                    posArr2++;
                    i++;
                }
                else
                {
                    throw new Exception("FFFFFF");
                }

            }



            return list.ToArray();
        }
        static void Main(string[] args)
        {
            //int[] mass1 = new int[] { 1, 2, 3, 3, 5, 7, 9 };
            //int[] mass2 = new int[] { 10, 11, 12, };
            int[] mass1 = new int[] { 1, 2, 3, 3, 8, 111 };
            int[] mass2 = new int[] { 1,3,112 };




            int[] mass3 = RemoveDublicates(mass1, mass2);
            foreach (int i in mass3)
            {
                Console.WriteLine(i);
            }

        }
    }
}
