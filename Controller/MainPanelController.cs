using System;
using RekrutacjaK.Data;

namespace RekrutacjaK.Controller
{
    public class MainPanelController
    {
        private readonly DataWrapper _dataWrapper;

        public MainPanelController(DataWrapper dataWrapper)
        {
            _dataWrapper = dataWrapper;
        }

        public void SimulateData(int n, bool lastThreeDays , DateTime startDate, DateTime endDate)
        {
            _dataWrapper.SimulateData(n, lastThreeDays, startDate,endDate);
        }

        
    }
}