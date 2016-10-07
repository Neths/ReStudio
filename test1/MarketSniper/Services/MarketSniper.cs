using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketSniper.Services
{
    public class MarketSniper : IService
    {
        public void Init()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    public interface IService
    {
        void Init();
        void Start();
        void Stop();
    }
}
