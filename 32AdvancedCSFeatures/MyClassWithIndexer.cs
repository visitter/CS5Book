using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32AdvancedCSFeatures
{
    class MyPerson
    {
        public String Name { get; set; }
        public MyPerson(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return String.Format("My name is: {0}", Name);
        }
    }

    class MyClassWithIndexer : IEnumerable<MyPerson>
    {
        private List<MyPerson> aList = new List<MyPerson>();
        public MyPerson this[int index]
        {
            get
            {
                if (aList.Count > index)
                    return aList[index];
                else
                    return null;
            }
            set
            {
                if (aList.Capacity <= index)
                    aList.Capacity += 10;

                if (aList.Count < index)
                {
                    aList.Add(value);//add to end if index > than actual elements count
                }
                else
                {
                    aList.Insert(index, value);
                }
            }
        }

        public MyPerson this[String index]
        {
            get
            {
                return aList.Find(person => person.Name.Equals(index));
            }
            set
            {

            }
        }
        public IEnumerator<MyPerson> GetEnumerator()
        {
            return aList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return aList.GetEnumerator();
        }
    }
}