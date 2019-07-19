using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_PROJECT
{
    public class DummyMaster
    {
        public int DummyID { get; set; }
        public string DummyName { get; set; }
        
        public DummyMaster()
        {

        }

        public DummyMaster(int dummyID, string dummyName)
        {
            DummyID = dummyID;
            DummyName = dummyName;
        }
    }
}