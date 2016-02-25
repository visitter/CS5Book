using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30CollectionsAndGenerics
{    
    class Program
    {
        class Person : IComparable, IDisposable {
            public String Name {get; set;}
            public Byte Age{get;set;}
            public override string ToString()
            {
                return Name + ' ' + Age.ToString();
            }

            public int CompareTo(Object obj)
            {
                
                return this.Age - (obj as Person).Age;
            }

            public void Dispose()
            {
            }
        }
        class PersonComparer : IComparer<Person>
        {
            public enum PersonCompareMode { DEEP, AGE, NAME }; 
            private PersonCompareMode compareMode = PersonCompareMode.DEEP;
                     
            public PersonComparer(PersonCompareMode pcm = PersonCompareMode.DEEP)
            {
                compareMode = pcm;
            }
            public int Compare(Person x, Person y)
            {
                switch (compareMode)
                {                    
                    case PersonCompareMode.AGE:
                        {
                            return x.Age - y.Age;                            
                        }
                    case PersonCompareMode.NAME:
                        {
                            return x.Name.CompareTo(y.Name.ToString());                            
                        }
                    
                    case PersonCompareMode.DEEP:
                    default:
                        {
                            return (x.Age - y.Age) + x.Name.CompareTo(y.Name.ToString());                             
                        }
                }
                
            }
        }        
        class MyPersonCollections : IEnumerable
        {
            private ArrayList arrPersons = new ArrayList();
            public Person getPerson(int index)
            {
                return (Person)arrPersons[index];
            }

            public void addPerson(Person p)
            {
                arrPersons.Add(p);
            }

            public void Clear()
            {
                arrPersons.Clear();
            }

            public IEnumerable GetMyEnumerator()
            {
                foreach( Person item in arrPersons)
                {
                    yield return item.Age;
                }
            }
                    
            public IEnumerator GetEnumerator()
            {                
                return arrPersons.GetEnumerator();
            }             
        }

        static void Main(string[] args)
        {
            //showMyArrayList();
            //showMyPersonCollection();
            //showMyPersonCollectionInit();
            //workWithGenericList();
            //workWithStack();
            //workWithQueue();
            //workWithSortedSet();
            //workWithObservableCollection();
            //myGenericSwap();
            wokrWithHashSet();
                        
            Console.ReadLine();
        }

        static void showMyPersonCollectionInit()
        {
            System.Collections.Generic.List<Person> arrPerson = new List<Person>{
                new Person{ Name = "Ivan", Age = 34 },
                new Person{ Name = "Emil", Age = 57 },
                new Person{ Name = "Mira", Age = 30 }
            };
            foreach (var item in arrPerson)
            {
                Console.WriteLine(item);
            }
        }
        static void showMyPersonCollection()
        {            
            MyPersonCollections collection = new MyPersonCollections();
            collection.addPerson(new Person(){ Name = "Ivan", Age = 34 });
            collection.addPerson(new Person() { Name = "Emil", Age = 57 });
            collection.addPerson(new Person() { Name = "Mira", Age = 30 });
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            
            foreach (var item in collection.GetMyEnumerator())
            {
                Console.WriteLine(item);
            }            
        }
        static void showMyArrayList()
        {
            ArrayList arrList = new ArrayList();
            arrList.AddRange(new String[] { "1", "2", "3" });
            Console.WriteLine("The count of the list is {0}", arrList.Count );

            ArrayList arrInts = new ArrayList();
            arrInts.AddRange(new int[] { 1, 2, 3, 4 });

            arrList.Add("4");
            Console.WriteLine("The count of the list is {0}", arrList.Count);

            Console.WriteLine("Listing the items in the list");
            foreach (object item in arrList)
            {
                int i = Int32.Parse(item.ToString());
                Console.WriteLine(i);
            }

            Console.WriteLine("Listing the items in the Ints");
            foreach (var item in arrInts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Hooba! Hooba!");

            Console.ReadLine();
        }
        static void showElements<T>(IEnumerator<T> e)
        {
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current.ToString());
            }            
        }
        static void workWithGenericList()
        {
            List<Person> alist = new List<Person>{ 
                new Person{ Name = "Ivan", Age = 34 },
                new Person{ Name = "Emil", Age = 57 },                
                new Person{ Name = "Zlatka", Age = 61 }
            };

            Console.WriteLine("My Family");
            showElements<Person>(alist.GetEnumerator());            
            Console.WriteLine("{0} is at {1} position",alist[1], alist.BinarySearch(alist[1], new PersonComparer()));
            Console.WriteLine();

            Console.WriteLine("My Family after I met Mira");
            alist.Insert(1, new Person { Name = "Mira", Age = 30 });
            showElements<Person>(alist.GetEnumerator());
            Console.WriteLine("{0} is at {1} position", alist[1], alist.BinarySearch(alist[1], new PersonComparer()));

            Console.WriteLine("\nMy Family by Age");
            alist.Sort();
            showElements<Person>(alist.GetEnumerator());
        }
        static void workWithStack()
        {
            Stack<Person> stack = new Stack<Person>();
            stack.Push(new Person { Age = 34, Name = "Ivan" });
            stack.Push(new Person { Age = 35, Name = "Petar" });
            stack.Push(new Person { Age = 32, Name = "Milen" });

            try
            {
                //stack.Count is ok too but now demonstrating peek
                while (stack.Peek() != null)
                {
                    Console.WriteLine(stack.Pop());
                }
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        }
        static void workWithQueue() 
        {
            Queue<Person> q = new Queue<Person>();
            q.Enqueue( new Person{ Age = 34, Name = "Ivan" });
            q.Enqueue( new Person { Age = 32, Name = "Ivano" });
            q.Enqueue( new Person { Age = 38, Name = "Ivan22" });
                        
            while (q.Count > 0)
            {
                Console.WriteLine( q.Dequeue() );
            }
        }
        static void workWithSortedSet()
        {
            SortedSet<Person> ssp = new SortedSet<Person>(new PersonComparer() );            
            //SortedSet<Person> ssp = new SortedSet<Person>();
            
            ssp.Add(new Person { Age = 1, Name = "Ivan1" });
            ssp.Add(new Person { Age = 3, Name = "Ivan3" });
            ssp.Add(new Person { Age = 2, Name = "Ivan2" });
            
            
            //items with existing age below and they will not be added to the set only with different age value
            ssp.Add(new Person { Age = 4, Name = "Ivan4" });
            ssp.Add(new Person { Age = 5, Name = "Ivan3" });
            ssp.Add(new Person { Age = 3, Name = "Ivan3" });

            foreach (Person item in ssp)
            {
                Console.WriteLine( item );
            }            
        }
        static void workWithObservableCollection()
        {
             List<Person> alist = new List<Person>{ 
                new Person{ Name = "Ivan", Age = 34 },
                new Person{ Name = "Emil", Age = 57 },                
                new Person{ Name = "Zlatka", Age = 61 }
            };            
            
            ObservableCollection<Person> obsCollection = new ObservableCollection<Person>(alist);
            
            obsCollection.CollectionChanged += obsCollection_CollectionChanged;
            
            obsCollection.Add(new Person { Name = "Zlatka", Age = 61 });
            obsCollection.Remove(obsCollection[0]);
        }
        static void obsCollection_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine(e.Action.ToString());
            if( (e.NewItems!=null)&&(e.NewItems.Count>0) )
            {
                foreach (Person item in e.NewItems)
                {
                    Console.WriteLine( item.ToString() );
                }
            }
            else if ((e.OldItems != null) && (e.OldItems.Count > 0))
            {
                foreach (Person item in e.OldItems)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
        static void Swap<T>(ref T a, ref T b)
            where T:struct //class, new->(new is always the last constraint)

        {
            Console.WriteLine("Swap method: You have sent me {0}",a.GetType().Name);
            T temp = a;
            a = b;
            b = temp;
        }
        static void myGenericSwap()
        {
            int x = 5, y = 6;
            
            Console.WriteLine("X={0}, Y={1}", x, y);
            Swap<int>(ref x, ref y);
            Console.WriteLine("X={0}, Y={1}", x, y);
        }
        static void wokrWithHashSet()
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(1);
            hs.Add(3);            
            hs.Add(2);
            hs.Add(3);
                        
            showElements<int>(hs.GetEnumerator());
        }
    }
}