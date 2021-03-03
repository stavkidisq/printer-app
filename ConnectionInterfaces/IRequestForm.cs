using ApplicationStyles;

namespace BusinessInterfaces
{
    public interface IRequestForm : IForm
    {
        public DocumentForPrint Document { get; set; }
    }
}
