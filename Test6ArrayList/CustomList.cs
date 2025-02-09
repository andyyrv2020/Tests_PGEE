using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6ArrayList
{
    class CustomList<T>
    {
        private const int INITIAL_CAPACITY = 2;
        private T[] items;
        public int Length { get; set; }
        public int Capacity { get; set; }

        public CustomList()
        {
            this.items = new T[INITIAL_CAPACITY];//
            this.Capacity = INITIAL_CAPACITY;//
        }

        public T this[int index] //коригирана е грешката в синтаксиса
        {
            get
            {
                CheckIndexOutsideBounds(index);
                return this.items[index];
            }

            set
            {
                CheckIndexOutsideBounds(index);

                this.items[index] = value; //.items
            }
        }

        public void Add(T element)
        {
            if (this.Length == this.Capacity)
            {
                this.Capacity *= 2; // Поправено: правилно увеличаваме капацитета
                T[] temp = new T[this.Capacity];

                for (int i = 0; i < this.Length; i++) // Поправено: трябва да копираме само използваните елементи, не целия стар масив
                {
                    temp[i] = this.items[i];
                }

                this.items = temp;
            }

            this.items[this.Length] = element; // Поправено: правилно добавяме елемента в първото свободно място
            this.Length++;
        }
        public T Get(int index) // Поправено: Добавен липсващ тип за връщане
        {
            CheckIndexOutsideBounds(index);
            return this.items[index];
        }

        public void Set(int index, T element)
        {
            CheckIndexOutsideBounds(index);
            this.items[index] = element; // Поправено: добавена липсваща точка и запетая след CheckIndexOutsideBounds(index);
        }

        public void RemoveAt(int index)
        {
            CheckIndexOutsideBounds(index);
            for (int i = index; i < items.Length - 1; i++) //<
            {
                this.items[i] = items[i + 1]; //this.items
            }
            this.Length--; // Липсва --;
            this.items[this.Length] = default; //липсва
        }
        private void CheckIndexOutsideBounds(int index)
        {
            if (index < 0 || index >= this.Length)
            {
                throw new IndexOutOfRangeException(); // Поправено: добавено изхвърляне на изключение
            }
        }
        public IEnumerator<T> GetEnumerator() //<T> вместо () на интерфейсът
        {
            foreach (var item in items)
            {
                yield return item;
            }
        }
    }
}
