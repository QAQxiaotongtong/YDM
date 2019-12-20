using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._20
{
   public  class People:IEnumerabale
    {
        private Person[] _people;

        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];
            for(int i=0;i<pArray.Length;i++)
            {
                _people[i] = pArray[i];
                int adasdas=11111111111111111111111111111111;
            }
        }

        IEnumerator IEnumerabale.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }
}
