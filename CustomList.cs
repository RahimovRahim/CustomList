using System;
using System.Collections;
using System.Collections.Generic;

class CustomList<T>
{
    private T[] list;
    private int capacity;
    private int count;
    public int Capacity
    {
        get { return capacity; }
    }
    public int Count
    {
        get { return count; }
    }

    

    public CustomList()
    {
        count = 0;
        capacity = 0;
        
    }
    public void Add(T item)
    {
        if (count == capacity)
        {
            if (capacity == 0)
                capacity = 4;
            else
                capacity *= 2;
            T[] newItems = new T[capacity];
            for (int i = 0; i < count; i++)
            {
                newItems[i] = list[i];
            }
            list = newItems;
        }
        list[count] = item;
        count++;
    }

    
    public T FindItem(Predicate<T> predicate)
    {
        return Array.Find(list,  predicate);
    }

    public List<T> FindAllItems(Predicate<T> predicate)
    {
        T[] foundItems =
            Array.FindAll(list.ToArray(), predicate);
        return new List<T>(foundItems);
    }
    
    public bool ContainsItem(T item)
    {
      if(count !=0 && Array.IndexOf(list, item) != -1)
        {
            return true;
        }
        return false;
    }
    public bool Exists(Predicate<T> match)
    {

        return Array.Exists(list, match);
    }



    public void Remove(T item)
    {
        int index = Array.IndexOf(list, item);

        if (index != -1)
        {
            for (int i = index; i < count - 1; i++)
            {
                list[i] = list[i + 1];
            }
            


        }
        count--;


    }
    }


