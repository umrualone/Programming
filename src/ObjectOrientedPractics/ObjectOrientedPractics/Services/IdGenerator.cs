namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// 
    /// </summary>
    public static class IdGenerator
    {
        /// <summary>
        /// 
        /// </summary>
        private static int _idItem = 0;

        /// <summary>
        /// 
        /// </summary>
        private static int _idCustomer = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int NewIdItem()
        {
            _idItem++;
            return _idItem;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int NewIdCustomer()
        {
            _idCustomer++;
            return _idCustomer;
        }
    }
}
