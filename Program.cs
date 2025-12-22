class Problems
{
    public static float PositiveAVG_211(int[] arr)
    {
        float positiveCount = 0;
        float sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                positiveCount++;
                sum += arr[i];
            }
        }

        return sum / positiveCount;

    }

    public static float SquareAVG_212(int[] arr) 
    {
        float sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            { 
                sum += arr[i] * arr[i];
            }
        }

        return sum / 1;
    }

    public static float NegativeAVG_214(int[] arr)
    {
        float negativeCount = 0;
        float sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                negativeCount++;
                sum += arr[i];
            }
        }

        return sum / negativeCount;
    }

    public static int EvenIndexNumSUM_215(int[] arr)
    {
        int sum = 0;

        for(int i = 2; i < arr.Length; i+=2)
        {
            sum += arr[i];
        }

        return sum;
    }

    public static int EvenIndexNumMultiple_216(int[] arr)
    {
        int multiple = 1;

        for (int i = 2; i < arr.Length; i += 2)
        {
            multiple *= arr[i];
        }

        return multiple;
    }

    public static int OddIndexPowMultiple_217(int[] arr)
    {
        int multiple = 1;

        for (int i = 1; i < arr.Length; i += 2) 
        {        
            multiple *= arr[i] * arr[i];
        }

        return multiple;
    }

    public static int OddIndexSumABS_218(int[] arr)
    {
        int sum = 0;

        for (int i = 1; i < arr.Length; i += 2)
        {
            sum += arr[i] > 0 ? arr[i] : arr[i] * -1;
            
        }   

        return sum;
    }

    public static int MultipleCount_219(int[] arr, int k)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++) 
        {
            if(k % i == 0) 
                count++;
        }

        return count;
    }

    public static int NonZeroCount_220(int[] arr)
    {
        int count = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0) count++;
        }

        return count;
    }
    public static int Sum_221(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum;
    }

    public static int Mult_222(int[] arr)
    {
        int mult = 1;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            mult *= arr[i];
        }

        return mult;
    }

    public static int Count_223(int[] arr)
    {
        return arr.Length - 2;
    }

    public static int Cub_224(int[] arr, int k)
    {
        int sumABS = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            int abs = arr[i] < 0 ? arr[i] * -1 : arr[i];
            if (abs < k)
            {
                sumABS += abs* abs* abs;
            }
        }
        return sumABS;
    }

    public static int Mult_225(int[] arr, int k)
    {
        int mult = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            int abs = arr[i] < 0 ? arr[i] * -1 : arr[i];
            if (abs < k)
            {
                mult *= abs;
            }
        }
        return mult;
    }
    public static int Count_226(int[] arr, int k)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int abs = arr[i] < 0 ? arr[i] * -1 : arr[i];
            if (abs < k) count++;
        }
        return count;
    }

    public static float AVGOfMultIndexes_227(int[] arr, int k)
    {
        int count = 0;
        float sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (k % i == 0)
            {
                sum += arr[i];
                count++;
            }
        }

        return sum / count;
    }

    public static int ModuloIndex_228(int[] arr, int k)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (i % k == 0)
            {
                sum += arr[i];
            }
        }

        return sum;
    }

    public static int ValueIndexPositive_229(int[] arr)
    {
        int mult = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] - i > 0)
            {
                mult *= arr[i];
            }
        }

        return mult;
    }
}