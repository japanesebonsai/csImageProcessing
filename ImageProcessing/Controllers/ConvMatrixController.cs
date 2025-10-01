using ImageProcessing.Models;
using ImageProcessing.Services;
using ImageProcessing.Services.Utils;

namespace ImageProcessing.Controllers
{
    public class ConvMatrixController
    {
        private readonly SourceModel _model;
        private readonly ConvMatrixService _convService; 

        public ConvMatrixController(SourceModel model)
        {
            _model = model;
            _convService = new ConvMatrixService(_model);
        }

        public Bitmap ApplyFilter(FilterType filterType)
        {
            return _convService.ApplyFilter(filterType);
        }
    }
}
