using StrategyDesignPaternApp.Model.Compression;
using StrategyDesignPaternApp.Model.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPaternApp.Model
{
    internal class ImageStore
    {
        private ICompressionStrategy _compressionStrategy;
        private IFilterStrategy _filterStrategy;

        public ImageStore(ICompressionStrategy compressionStrategy, IFilterStrategy filterStrategy)
        {
            _compressionStrategy = compressionStrategy;
            _filterStrategy = filterStrategy;
        }

        public void Store(byte[] data=null) {

            //filter-->BandWhite,HighConstract,GreyFilter
            //compression-->JpegCompression,PNGCompreesion
            _filterStrategy.Apply(data);
            _compressionStrategy.Compress(data);
            Console.WriteLine("Storing the image ");

        }
    }
}
