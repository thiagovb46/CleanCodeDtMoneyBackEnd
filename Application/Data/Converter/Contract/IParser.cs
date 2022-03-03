namespace Application.Data.Converter
{
    public interface IParser <O,D>
    {
        D Parse(O oirigin);
        List<D> Parse(List<O> oirigin);
    }
}
