namespace poo1
{
    class Pixel : Punto2D
    {
        private string color;

        public Pixel() : base() {}

        public Pixel(float x, float y, string color) : base(x, y)
        {
            this.color = color;
        }

        #region Getters and Setters

        public string GetColor()
        {
            return this.color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        #endregion

    }
}
