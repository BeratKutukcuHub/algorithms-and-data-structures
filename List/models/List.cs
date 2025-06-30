using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Farklı dizi ve koleksiyon türlerinin örnek kullanımı.
/// </summary>
public class CollectionExamples
{
    // ⚪️ 1. Dizi (Array) - Sabit boyutlu, genişletilemez.
    char[] charArray = new[] { 's', 'a' };
    Array fixedSizeArray = Array.CreateInstance(typeof(int), 2);

    // ⚪️ 2. ArrayList - Tip güvenliği yoktur (non-generic). Her şey object türündedir.
    ArrayList nonGenericList = new ArrayList() { "Ahmet", "Mehmet" };

    // ⚪️ 3. List<T> - Tip güvenliği olan, genişleyebilen generic koleksiyon.
    List<string> genericList = new() { "Ahmet", "Mehmet" };

    /// <summary>
    /// Koleksiyonlara örnek ekleme işlemleri.
    /// </summary>
    public void RunExamples()
    {
        fixedSizeArray.SetValue(1, 0);

        nonGenericList.Add(1);     // Boxing
        nonGenericList.Add('c');   // Boxing

        genericList.Add("Hüsnü");  // Tip güvenli
    }
}

/// <summary>
/// List<T>'e benzer şekilde çalışan, kendi koleksiyonumuzu temsil eden dinamik dizi sınıfı.
/// </summary>
public class DynamicArray<T> : IEnumerable<T>
{
    private T[] items;
    public int Count { get; private set; }
    public int Capacity => items.Length;

    public DynamicArray()
    {
        items = new T[5];
        Count = 0;
    }

    /// <summary>
    /// Dizi dolduğunda kapasiteyi iki katına çıkarır.
    /// </summary>
    private void DoubleCapacity()
    {
        var newItems = new T[items.Length * 2];
        for (int i = 0; i < items.Length; i++)
        {
            newItems[i] = items[i];
        }
        items = newItems;
    }

    /// <summary>
    /// Yeni bir öğe ekler. Gerekirse dizinin kapasitesini artırır.
    /// </summary>
    public void Add(T item)
    {
        if (Count == items.Length)
        {
            DoubleCapacity();
        }

        items[Count] = item;
        Count++;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
        {
            yield return items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

/// <summary>
/// Basit bir çalışan (employee) modeli.
/// </summary>
public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}