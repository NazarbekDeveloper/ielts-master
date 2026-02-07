namespace IeltsMaster
{
    public class Counter
    {
        decimal yigindi = 0;
        public void BallQosh(decimal ball)
        {
            yigindi += ball;
        }
        public decimal YigindiQaytar()
        {
            return yigindi;
        }
    }
}