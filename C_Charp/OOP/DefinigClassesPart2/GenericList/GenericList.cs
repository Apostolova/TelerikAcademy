using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T>
    {
        const int DefaulCapacity = 20;

        private T[] array;
        private int count;

        public GenericList()
        {
            array = new T[DefaulCapacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void Add(T element)
        {
            if (count >= array.Length)
            {
                throw new IndexOutOfRangeException("Capacity out");
                
            }
            else
            {
                this.array[count] = element;
                count++;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException("Incorrect index");
                }
                else
                {
                    return array[index];
                    
                }
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException("Incorrect index");
                }
                else
                {
                     array[index] = value;
                }
            }
        }

        public void RemoveElements(int index)
        {
             if (index <= count && index >= 0)
                {
                    T[] tempArr = new T[array.Length - 1];
                    int iter = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (iter == index)
                        {
                            i++;
                        }
                        tempArr[iter] = array[i];
                        iter++;
                    }
                    count--;
                    array = tempArr;
                }
                else throw new IndexOutOfRangeException();
         }

        public void InsertElements(int index, T element)
        {
            if (index <= count && index >= 0)
            {
                T[] tempArr = new T[array.Length + 1];
                int iter = 0;
                for (int i = 0; i < tempArr.Length; i++)
                {
                    if (i == index)
                    {
                        tempArr[i] = element;
                    }
                    else
                    {
                        tempArr[i] = array[iter];
                        iter++;
                    }
                }
                count++;
                array = tempArr;
            }
            else throw new IndexOutOfRangeException();
        }

        public T Min()
        {
            if (count == 0)
            {
                throw new Exception("Empty list");
            }
            else if (count == 1) return array[0];
            else if (array[0] is IComparable<T>)
            {
                T min = array[0];
                for (int i = 0; i < count; i++)
                {
                    if ((min as IComparable<T>).CompareTo(array[i]) > 0)
                    {
                        min = array[i];
                    }
                }
                return min;
            }
            else throw new TypeAccessException("Non-comparable list");
        }

        public T Max()
        {
            if (count == 0)
            {
                throw new Exception("Empty list");
            }
            else if (count == 1) return array[0];
            else if (array[0] is IComparable<T>)
            {
                T max = array[0];
                for (int i = 0; i < count; i++)
                {
                    if ((max as IComparable<T>).CompareTo(array[i]) < 0)
                    {
                        max = array[i];
                    }
                }
                return max;
            }
            else throw new TypeAccessException("Non-comparable list");
        }

        public void Clear()
        {
            array = new T[0];
            count = 0;
        }

        public override String ToString()
        {
            T[] temp = new T[count];
            Array.Copy(array, temp, count);
            return String.Join(", ", temp);
        }

    }
}
