namespace BadCode.CodeSmells
{
    internal class CS05
    {
        private class Bad
        {
            private void main()
            {
                int area, perimeter, volume;
                if (DoCalculations(3, 4, out area, out perimeter, out volume))
                {
                    // do something
                }
            }

            private bool DoCalculations(int height, int width, out int area, out int perimeter, out int volume)
            {
                volume = 0;
                perimeter = 0;
                area = 0;
                return false;
            }
        }

        private class Good
        {
            private void main()
            {
                DoCalculationResult result = DoCalculation(3, 4);
                if (result.Success)
                {
                    // do something 
                    int p = result.Perimeter;
                }
            }

            private DoCalculationResult DoCalculation(int height, int width)
            {
                return new DoCalculationResult
                {
                    Success = false,
                    Area = 0,
                    Perimeter = 0,
                    Volume = 0
                };
            }
        }

        #region Utils

        private class DoCalculationResult
        {
            public bool Success { get; set; }
            public int Area { get; set; }
            public int Perimeter { get; set; }
            public int Volume { get; set; }
        }

        #endregion
    }
}