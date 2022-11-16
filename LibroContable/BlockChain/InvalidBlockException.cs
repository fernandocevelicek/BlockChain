namespace LibroContable
{
    [Serializable]
    class InvalidBlockException : Exception
    {
        public InvalidBlockException() { }

        public InvalidBlockException(string msg)
            : base(msg)
        {

        }
    }
}
