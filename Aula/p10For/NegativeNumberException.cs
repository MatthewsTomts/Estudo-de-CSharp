using System;

namespace p10For {
    public class NegativeNumberException : Exception {
        public NegativeNumberException() : base("Negative numbers are not allowed."){}
    }
}