namespace QuadSpinner.Adjunct;

public static class ArrayHelper
{
    public static float[] Copy(this float[] array)
    {
        if (array.Length > 67108864) // 8K
        {
            return array.Clone() as float[];
        }

        float[] copy = new float[array.Length];
        Buffer.BlockCopy(array, 0, copy, 0, Buffer.ByteLength(array));
        return copy;
    }

    public static byte[] Copy(this byte[] array)
    {
        byte[] copy = new byte[array.Length];
        Buffer.BlockCopy(array, 0, copy, 0, array.Length);
        return copy;
    }
}