using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.RequestFeatures
{
    public abstract class RequestParameter
    {
        const int maxPageSize = 40;
        public int PageNumber { get; set; } = 1;

        private int _pageSize = 1;
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (value > maxPageSize) ? maxPageSize : value; }
        }

    }
    public class HamsterParameters : RequestParameter
    {

    }
    public class MatchParameters: RequestParameter
    {

    }
}
