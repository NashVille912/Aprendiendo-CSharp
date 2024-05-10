using System;
class AlmacenObjeto<T>
    {
        public AlmacenObjeto(int z)
        {

            datosElemento = new T[z];
        }

        public void agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public T getElemento(int i)
        {
            return datosElemento[i];
        }

        private T[] datosElemento;
        private int i = 0;

    }

