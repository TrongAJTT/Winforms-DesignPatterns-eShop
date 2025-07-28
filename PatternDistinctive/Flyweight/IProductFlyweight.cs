using System.Drawing;

namespace _3S_eShop.PatternDistinctive.Flyweight
{
    // Lưu trữ các trạng thái và phương thức được chia sẻ chung (Intrint State)
    public interface IProductFlyweight
    {
        long ProductId { get; }
        string Name { get; }
        Image ThumbImage { get; }
    }
}
