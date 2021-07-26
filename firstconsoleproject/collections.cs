using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace firstconsoleproject
{
    class collections
    {
        IList list = new ArrayList();
        public void UseCollections()
        {
            list.Add("some data");
            list.Add(1);
            list.Add(true);
            list.Add(3.455);


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
