
int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

Console.WriteLine(BinarySearch(arr, 1000));
static int BinarySearch(int[] arr , int value)
{
    int start = 0; 
    int end = arr.Length - 1;
    int result = 0;
    while (start <= end)
    {
        int mid = (start + end) / 2;  
        if (value == arr[mid])
        {
            result = arr[mid];
            return result;
        }
        else if (value > arr[mid])
        {
            start = mid + 1; 
        }
        else
        {
            end = mid - 1;
        }
    } 
    return -1;
}
