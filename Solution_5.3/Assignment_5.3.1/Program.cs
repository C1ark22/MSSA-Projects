// flowerbed problem
// sliding window algorithm solution
// store the original flowerbed array in a variable
// then have a loop to initialize the flowerbed array with 0s and 1s
// it would start at leftflowerbed is empty flowerbedarray i-1
// currentflowerdbed flowerbedarray i
// rightflowerbed flowerbedarray i+1
// if leftflowerbed and rightflowerbed are both 0,
// then we can plant a flower in the currentflowerbed

namespace Assignment_5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]flowerbed = {1,0,0,0,1};
            //int[]flowerbed = {1,0,0,0,0,0,1};
            int requiredToBePlanted = 1;
            //int requiredToBePlanted = 2;

            bool result = CanPlaceFlowers(flowerbed, requiredToBePlanted);

            Console.WriteLine(result);

            Console.WriteLine(CanPlaceFlowersV2(flowerbed, requiredToBePlanted));
        }
        static bool CanPlaceFlowers(int[] flowerbed, int requiredToBePlanted)
        {
            // making the length longer by 2
            int[]paddedFlowerBed = new int[flowerbed.Length+2];

            for (int i = 0; i < flowerbed.Length; i++)
            {
                paddedFlowerBed[i+1] = flowerbed[i];
            }

            for (int i = 1; i < paddedFlowerBed.Length; i++)
            {
                bool leftIsEmpty = paddedFlowerBed[i - 1] == 0;
                bool currentIsEmpty = paddedFlowerBed[i] == 0;
                bool rightIsEmpty = paddedFlowerBed[i + 1] == 0;

                // flowers can only be planted when all the flowers is empty
                if (leftIsEmpty && currentIsEmpty && rightIsEmpty)
                {
                    paddedFlowerBed[i] = 1;
                    requiredToBePlanted--;
                }
                // planted all the required plants
                if (requiredToBePlanted <= 0)
                {
                    return true;
                }
            }
            return requiredToBePlanted <= 0;
        }

        // another option
        // check the first plot if its empty
        // if it is equal to 1 make it 0
        // else make it 1
        // for loop to look at every plot in the flowerbed array
        // if flowerbed is equal to 1 
        // calculate how many flower plot can be planted in the empty plots
        // subtract the number of flowers that can be planted from the
        // number of flowers that need to be planted
        // reset because we have an existing flower = 0
        // else empty+1
        // then we calculate the flowerbed at the end 
        // empty /2
        // n -= flowers at the end
        // if n <= 0 return true else return false
        static bool CanPlaceFlowersV2(int[] flowerbed, int requiredToBePlanted)
        {
            int empty;

            if (flowerbed[0] == 1)
            {
                // starts at 0
                empty = 0;
            }
            else
            {
                // starts at 1
                empty = 1;
            }

            // checking the elements in the array 
            for (int i = 0; i < flowerbed.Length; i++)
            {
                // if the flower bed is equal to 1 then empty is 0
                if(flowerbed[i] == 1) 
                {
                    // once the element is 1 then it resets the empty to 0
                    int flowersThatCanFit = (empty - 1) / 2;

                    requiredToBePlanted = requiredToBePlanted - flowersThatCanFit;

                    empty = 0;
                }
                else
                {
                    // empty changes to 1,2,3
                    empty = empty + 1;
                }
            }

            // counts how many flowerbed can fit empty plots at the end
            int flowersAtTheEnd = empty / 2;

            // number of flowers needs planted
            requiredToBePlanted = requiredToBePlanted - flowersAtTheEnd;

            // check if requirements have been met
            if(requiredToBePlanted <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
