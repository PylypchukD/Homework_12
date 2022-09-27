namespace Task_03
{
    class Model
    {
        public string Add(int x, int y)
       {
           return $"{x + y}";
        }
        public string Sub(int x, int y)
        {
            return $"{x - y}";
        }
        public string Mul(int x, int y)
        {
            return $"{x * y}";
        }
        public string Div(int x, int y)
        {
            return y != 0 ? $"{x / y}" : "ошибка деления на 0";
        }
    }
}
