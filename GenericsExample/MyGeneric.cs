namespace GenericsExample
{
    internal class MyGeneric<T>
    {
        public int GenericMethod<T>(T a, T b)
        {
            return  (dynamic) a + (dynamic) b;
        }

        public J GenericWithThreeParams<T,J>(T a, J b, T c)
        {
            if ((dynamic) a > (dynamic) b) {
                dynamic d = (dynamic) a + (dynamic) b + (dynamic) c;
                return d;
            }
            else
            {
                dynamic e = (dynamic)a - (dynamic)c;
                return e;
            }
        }
    }
}
