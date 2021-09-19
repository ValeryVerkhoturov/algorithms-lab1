using System.Collections.Generic;

namespace AlgorithmsLab1
{
    class Queue<T>
    {
        private List<T> queue;
        
        public Queue()  // 1
        {
            queue = new List<T>();  // 1
        }

        // Добавление элемента в конец очереди
        public void Enqueue(T item)  // 1
        {
            queue.Add(item);  // 1
        }

        // Извлечение первого элемента
        public T Dequeu()  // 2+2=4
        {
            if (IsEmpty())  // 1
                return default(T);
            T item = queue[0];  // 2
            queue.RemoveAt(0);  // 2
            return item;
        }
        
        // Чтение первого элемента
        public T TopElement()  // 1
        {
            if (IsEmpty())  // 1
                return default(T);
            return queue[0];  // 1
        }
        
        // Чтение элемента по индексу из очереди
        public T ElementAt(uint index)
        {
            if (IsEmpty())  // 1
                return default(T);
            T item = default(T);  // 1
            for (uint _ = 0; _ < Length(); _++)
            {
                if (_ == index)
                    item = TopElement();
                Enqueue(Dequeu());
            }
            return item;
        }
        
        // Вставка элемента по индексу
        public void Replace(uint index, T item)
        {
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
            
            for (uint _ = 0; _ < Length(); _++)
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
        public void SwapElements(uint index1, uint index2)
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

        // Проверить - список пуст
        public bool IsEmpty() // 1
        {
            return Length() == 0; // 1
        }
        
        public override string ToString()
        {
            string output = "[ ";
            for (uint _ = 0; _ < Length(); _++)
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