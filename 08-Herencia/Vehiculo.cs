using System;


namespace _08_Herencia
{
    class Vehiculo
    {

        public Vehiculo(string marca, int? ruedas, string tipoMotor) 
        {
            this.marca = marca;
            this.ruedas = ruedas;
            this.tipoMotor = tipoMotor;
        }


        private string marca;
        private int? ruedas;
        private string tipoMotor;

        public void getInfo()
        {
            if (this.ruedas == null)
            {
                ruedas = 0;
            }

            Console.WriteLine($"Marca: {marca} - Ruedas: {ruedas}  - Tipo de Motor: {tipoMotor}");
        }


        public void arrancarMotor()
        {
            Console.WriteLine("El motor ha sido arrancado...");
        }
        public void detenerMotor()
        {
            Console.WriteLine("Motor apagado...");
        }

        public virtual void conducir()
        {
            Console.WriteLine("Estamos conduciendo el vehiculo");
        }


    }
}
