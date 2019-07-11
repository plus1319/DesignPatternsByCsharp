namespace AbstractFactory.Sample1
{
    public interface IMediaFactory
    {
        IConvertor CreateConvertor(string fileInput, CodecType codecType);
    }
}