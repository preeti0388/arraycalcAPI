namespace PreetiArrayAPI.Interface
{
    public interface IArrayManipulation
    {
        int[] ReverseArray(string[] array);
        int[] DeleteArrayElement(string[] array, string position);
    }
}