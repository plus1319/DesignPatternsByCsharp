namespace AbstractFactory.Sample1
{
    public enum CodecType
    {
        BMP, JPG, PNG,
        MP3, WAV, AAC
    }
    public interface IConvertor
    {
        string Convert();
    }
}