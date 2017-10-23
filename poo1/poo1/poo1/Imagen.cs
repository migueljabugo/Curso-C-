namespace poo1
{
    class Imagen
    {
        private Pixel[] pixeles;
        private string nombre;
        private string extension;
        
        public Imagen() { }

        public Imagen(Pixel[] pixeles, string nombre, string extension)
        {
            this.pixeles = pixeles;
            this.nombre = nombre;
            this.extension = extension;
        }

        public Pixel[] GetPixeles()
        {
            return this.pixeles;
        }

        public void SetPixeles(Pixel[] pixeles)
        {
            this.pixeles = pixeles;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetExtension()
        {
            return this.extension;
        }

        public void SetExtension(string extension) {
            return this.extension;
        }
        

        
    }
}
