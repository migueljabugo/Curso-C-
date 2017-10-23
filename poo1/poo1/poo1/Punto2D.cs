namespace poo1
{
    class Punto2D
    {
        private float x;
        private float y;

        public Punto2D() { }

        public Punto2D(float x, float y) {
            this.x = x;
            this.y = y;
        }

    #region Getters and Setters

        public void SetX(float x)
        {
            this.x = x;
        }

        public float GetX()
        {
            return this.x;
        }

        public void SetY(float y) {
            this.y = y;
        }
        
        public float GetY()
        {
            return this.y;
        }

    #endregion

    }
}
