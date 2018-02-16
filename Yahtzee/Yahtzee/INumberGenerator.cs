namespace Yahtzee
{
    public interface INumberGenerator
    {
        int Next(int low, int high);
    }
}