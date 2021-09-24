using System;
using System.Collections.Generic;

namespace AlgorithmsLab1_N_op
{
    class Queue<T>
    {
        private List<T> queue;

        public Queue()
        {
            queue = new List<T>(); Scorer.Increment();
        }

        /// Добавление элемента в конец очереди
        public void Enqueue(T item)
        {
            queue.Add(item); Scorer.Increment();
        }

        /// Извлечение первого элемента
        public T Dequeu()
        {
            if (IsEmpty())
                return default;
            T item = queue[0]; Scorer.Increment(2);
            queue.RemoveAt(0); Scorer.Increment();
            return item;
        }

        /// Чтение первого элемента
        public T TopElement()
        {
            if (IsEmpty())
                return default;
            Scorer.Increment();
            return queue[0];
        }

        /// Чтение элемента по индексу из очереди
        public T ElementAt(int index)
        {
            Scorer.Increment();
            if (index < 0)
            {
                Scorer.Increment();
                throw new ArgumentOutOfRangeException();
            }
            if (IsEmpty())
                return default;
            T item = default(T); Scorer.Increment();
            Scorer.Increment(2);
            for (int _ = 0; _ < Length(); _++)
            {
                if (_ == index)
                {
                    Scorer.Increment();
                    item = TopElement(); Scorer.Increment();
                }
                Enqueue(Dequeu()); Scorer.Increment();
                Scorer.Increment(2);
            }

            return item;
        }

        /// Вставка элемента по индексу
        public void Replace(int index, T item)
        {
            Scorer.Increment();
            if (index < 0)
            {
                Scorer.Increment();
                throw new ArgumentOutOfRangeException();
            }
            Scorer.Increment();
            if (index >= Length())
            {
                int length = Length(); Scorer.Increment();
                Scorer.Increment(3);
                for (int _ = 0; _ < index - length; _++)
                {
                    Enqueue(default(T)); Scorer.Increment();
                    Scorer.Increment(3);
                }

                Enqueue(item); Scorer.Increment();
                return;
            }

            Scorer.Increment(2);
            for (int _ = 0; _ < Length(); _++)
            {
                Scorer.Increment();
                if (_ == index)
                {
                    Dequeu();
                    Enqueue(item); Scorer.Increment();
                }
                else
                    Enqueue(Dequeu()); Scorer.Increment();
                Scorer.Increment();
            }
        }

        /// Поменять местами два элемента очереди
        public void SwapElements(int index1, int index2)
        {
            T temp = ElementAt(index1); Scorer.Increment();
            Replace(index1, ElementAt(index2)); Scorer.Increment(2);
            Replace(index2, temp); Scorer.Increment(2);
        }

        /// Длина очереди
        public int Length()
        {
            Scorer.Increment();
            return queue.Count; 
        }

        /// Проверить - список пуст
        public bool IsEmpty()
        {
            Scorer.Increment();
            return Length() == 0;
        }

        public override string ToString()
        {
            string output = "[ ";
            for (int _ = 0; _ < Length(); _++)
            {
                if (_ == Length() - 1)
                    output += ElementAt(_) + " ";
                else
                    output += ElementAt(_) + ", ";
            }

            return output + "]";
        }
    }
}