using System;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    int temp = numbers[index];
                    numbers[index] = numbers[i];
                    numbers[i] = temp;
                    index++;
                }
            }
            return numbers;
        }
    }
}
