using ApplicationStyles;

namespace BusinessInterfaces
{
    public interface IRequestForm : IForm
    {
        public TextForm Text { get; set; }
    }
}
