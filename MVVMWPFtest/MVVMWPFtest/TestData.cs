using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMtest;

namespace MVVMWPFtest
{
    class TestData:NotifyObject
    {
        private DateTime _addDataTime;
        ///<summary>
        ///时间
        /// </summary>
       public DateTime AddDateTime
        {
            get { return _addDataTime; }
            set
            {
                if (_addDataTime!=value)
                {
                    _addDataTime = value;
                    RaisePropertyChanged("AddDateTime");

                }
            }
        }
        private int _intValue;
        public int IntValue
        {
            get { return _intValue; }
            set
            {
                if (_intValue!=value)
                {
                    _intValue = value;
                    RaisePropertyChanged("IntValue");
                }  
              }
        }
        private bool _boolValue;
        public bool BoolValue
        {
            get { return _boolValue; }
            set
            {
                if (_boolValue != value)
                {
                    _boolValue = value;
                    RaisePropertyChanged("BoolValue");
                }
            }
        }

        private string _stringValue;

        public string StringValue
        {
            get { return _stringValue; }
            set
            {
                if (_stringValue != value)
                {
                    _stringValue = value;
                    RaisePropertyChanged("StringValue");
                }
            }
        }
        ///<summary>
        ///初始化列表数据
        /// </summary>
        public static IEnumerable<TestData> GetTestData()
        {
            var rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < 100; i++)
            {
                yield return new TestData
                {
                    AddDateTime = DateTime.Now,
                    StringValue = "字符串测试 " + i.ToString("D2"),
                    IntValue = rand.Next(1000, 9999),
                    BoolValue = (rand.Next(0, 10) > 5),

                };
            }
        }


    }
}
