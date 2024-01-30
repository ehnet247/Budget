﻿using System.Runtime.Serialization;

namespace BudgetMaui.Exceptions
{
    [Serializable]
    public class TypeNotRegisteredException : Exception
    {
        public TypeNotRegisteredException() { }
        public TypeNotRegisteredException(string message) : base(message) { }
        public TypeNotRegisteredException(string message, Exception inner) : base(message, inner) { }
        [Obsolete]
        protected TypeNotRegisteredException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
