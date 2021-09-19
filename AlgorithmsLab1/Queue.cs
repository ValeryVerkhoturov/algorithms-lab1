using System.Collections.Generic;

namespace AlgorithmsLab1
{
    class Queue<T>
    {
        private List<T> queue = new List<T>();

        // Добавление элемента в конец очереди
        public void Enqueue(T item)
        {
            queue.Add(item);
        }

        // Извлечение первого элемента
        public T Dequeu()
        {
            if (queue.Count == 0) 
                return default(T);
            T item = queue[0];
            queue.RemoveAt(0);
            return item;
        }
        
        // Чтение первого элемента
        public T TopElement()
        {
            if (queue.Count == 0) 
                return default(T);
            return queue[0];
        }
        
        // Чтение элемента по индексу из очереди
        public T ElementAt(int index)
        {
            if (queue.Count == 0 && index >= 0) 
                return default(T);
            T item = default(T);
            for (int _ = 0; _ < Length(); _++)
            {
                if (_ == index)
                    item = TopElement();
                Enqueue(Dequeu());
            }
            return item;
        }
        
        // Вставка элемента по индексу
        public void Replace(int index, T item)
        {
            if (index < 0)
                return;
            if (index >= Length())
            {
                int length = Length();
                for (int _ = 0; _ < index - length; _++)
                {
                    Enqueue(default(T));
                }
                Enqueue(item);
                return;
            }
            
            for (int _ = 0; _ < Length(); _++)
            {
                if (_ == index)
                {
                    Dequeu();
                    Enqueue(item);
                }
                else
                    Enqueue(Dequeu());
            }
        }
        
        // Поменять местами два элемента очереди
        public void InvertElements(int index1, int index2)
        {
            T temp = ElementAt(index1);
            Replace(index1, ElementAt(index2));
            Replace(index2, temp);
        }
        
        // Длина очереди
        public int Length()
        {
            return queue.Count;
        }
        
        public override string ToString()
        {
            string output = "[ ";
            for (int _ = 0; _ < Length(); _++)
            {
                if (_ == Length() - 1)
                    output += ElementAt(_).ToString() + " ";
                else
                    output += ElementAt(_).ToString() + ", ";
            }

            return output + "]";
        }
    }
}