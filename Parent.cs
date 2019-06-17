namespace PrivateProtectedAccessModifier
{
    class Parent
    {
        // Member is declared as private protected 
        private protected int value;

        // value is Accessible only inside the class 
        public void setValue(int v)
        {
            value = v;
        }
        public int getValue()
        {
            return value;
        }
    }
}
