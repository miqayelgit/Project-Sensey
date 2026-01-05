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

        for (int i = 2; i < arr.Length; i += 2)
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
            if (k % i == 0)
                count++;
        }

        return count;
    }

    public static int NonZeroCount_220(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
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
        for (int i = 0; i < arr.Length; i++)
        {
            int abs = arr[i] < 0 ? arr[i] * -1 : arr[i];
            if (abs < k)
            {
                sumABS += abs * abs * abs;
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
            if (arr[i] - i > 0)
            {
                mult *= arr[i];
            }
        }

        return mult;
    }

    public static int EvenSumOfPow_231(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                sum += arr[i] * arr[i];
            }
        }

        return sum;
    }

    public static int EvenNumsCount_232(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
                count++;
        }

        return count;
    }


    public static int EvenNumsMult_233(int[] arr)
    {
        int mult = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
                mult *= arr[i];
        }

        return mult;

    }
    public static int EvenNumsSum_233(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
                sum += arr[i];
        }

        return sum;
    }

    public static int OddNumsAVGMiddle_234(int[] arr)
    {
        int count = 0;
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                count++;
                sum += arr[i];
            }
        }

        return sum / count;
    }

    public static int OddNumsCount_236(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                count++;
            }
        }

        return count;
    }

    public static int OddNumsMult_236(int[] arr)
    {
        int mult = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                mult *= arr[i];
            }
        }

        return mult;
    }

    public static int ZeroValueCount_237(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                count++;
            }
        }
        return count;
    }

    public static float ThreeMultAVG_238(int[] arr)
    {
        int count = 0;
        float sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 3 == 0)
            {
                sum += arr[i];
                count++;
            }
        }

        return sum / count;
    }

    public static float SevenMultCount_240(int[] arr)
    {
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 7 == 0)
                count++;
        }

        return count;
    }

    public static int SumElementsMultToK_241(int[] arr, int k)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % k == 0)
            {
                sum += arr[i];
            }
        }

        return sum;
    }
    public static int MultElementsMultToM_242(int[] arr, int m)
    {
        int mult = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % m == 0)
            {
                mult *= arr[i];
            }
        }

        return mult;
    }

    public static int CountElementsMultToT_243(int[] arr, int t)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % t == 0)
                count++;
        }

        return count;
    }

    public static int MultOfNumsWith2Remainder_244(int[] arr)
    {

        int mult = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 5 == 2)
            {
                mult *= arr[i];
            }
        }

        return mult;
    }

    public static int SumPowOfNumsWithNonRemainder_245(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if ((arr[i] + i) % 3 == 0)
            {
                sum += arr[i] * arr[i];
            }
        }

        return sum;
    }

    public static int AvgOfElWithIndexPow_246(int[] arr)
    {
        int count = 0;
        int sum = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            //TODO add validation part
            if (i < 5)
            {
                count++;
                sum += arr[i];
            }
        }
        return sum / count;
    }

    public static int SumOfElIndexPow_248(int[] arr, int k)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int powOfsumOfElAndIndex = (arr[i] + i) * (arr[i] + i);

            if (powOfsumOfElAndIndex % k == 0)
            {
                sum += arr[i];
            }
        }

        return sum;
    }

    public static int CountOfElValAndIndex_249(int[] arr, int k)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int subtract = arr[i] - i;
            subtract = subtract < 0 ? subtract * -1 : subtract;

            if (subtract > k)
                count++;
        }

        return count;
    }

    public static int PowMult_250(int[] arr)
    {
        int mult = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            int multOfValAndIndex = arr[i] * i;
            if (multOfValAndIndex % 3 == 2)
            {
                mult *= arr[i] * arr[i];
            }
        }
        return mult;
    }

    public static int LastSmallestValue_346(int[] arr)
    {
        int length = arr.Length;
        int smallestNumber = arr[0];
        int indexOfSmallestNumber = 0;
        int result = 1;

        for (int i = 1; i < length; i++)
        {
            if (arr[i] < smallestNumber)
            {
                smallestNumber = arr[i];
                indexOfSmallestNumber = i;
                result = 1;
                continue;
            }

            result *= arr[i];
        }

        if (indexOfSmallestNumber == 0)
        {
            return 0;
        }

        return result;
    }

    public static int SumOfValues_347(int[] arr, int b)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < b)
            {
                sum += arr[i];
            }
        }

        return sum;

    }

    public static int MultOfIndexes_347(int[] arr, int b)
    {
        int mult = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < b)
            {
                mult *= i;
            }
        }

        return mult;

    }

    public static int SumOfIndexes_348(float[] arr)
    {
        int sumOfIndexes = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int value = (int)arr[i];
            if (value % 2 == 0)
            {
                sumOfIndexes += i;
            }
        }

        return sumOfIndexes;
    }

    public static int OddValues_349(float[] arr)
    {
        int sumOfIndexes = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int value = (int)arr[i];
            if (value % 2 == 0)
            {
                sumOfIndexes += i;
            }
        }

        return sumOfIndexes;
    }

    public static int Value_352(int[] arr)
    {
        int mult = arr[0];
        int sum = mult;
        bool foundNegativeNumber = false;

        for (int i = 1; i < arr.Length; i++)
        {
            mult *= arr[i];
            sum += mult;

            if (!foundNegativeNumber)
            {
                if (arr[i] < 0)
                {
                    foundNegativeNumber = true;
                }
            }

            if (arr[i] < 0)
            {
                break;
            }
        }

        if (foundNegativeNumber)
        {
            return sum;
        }

        return 0;
    }

    public static int BiggestNumber_354(int[] arr)
    {
        int biigestNum = 0;
        int midIndex = arr.Length / 2;
        int lastIndex = arr.Length - 1;
        bool isNotSimetric = false;

        if (arr.Length % 2 != 0)
        {
            return 0;
        }

        for (int i = 0; i < midIndex; i++)
        {
            if (arr[i] != arr[lastIndex])
            {
                isNotSimetric = true;
            }

            if (isNotSimetric)
            {
                return 0;
            }

            if (biigestNum < arr[i])
            {
                biigestNum = arr[i];
            }

            lastIndex--;
        }

        return biigestNum;
    }
}