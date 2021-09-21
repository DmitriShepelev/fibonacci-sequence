using System;
using System.Collections.Generic;
using System.Numerics;

namespace FibonacciTask
{
    /// <summary>
    /// Generator for Fibonacci sequence.
    /// </summary>
    /// <seealso cref="https://en.wikipedia.org/wiki/Fibonacci_number"/>
    public class FibonacciSequence
    {
        private long[] sequence;
        private int currentIndex = -1;

        /// <summary>
        /// Initializes a new instance of the <see cref="FibonacciSequence"/> class.
        /// </summary>
        /// <param name="count">Count of elements in Fibonacci sequence.</param>
        /// <exception cref="ArgumentException">Thrown if count of elements less than one.</exception>
        public FibonacciSequence(int count)
        {
            if (count < 1) 
                throw new ArgumentException($"{nameof(count)} of elements cannot be less than one.");

            long prev = 0;
            long curr = 1;
            this.sequence = new long[count];
            for (int i = 0; i < count; i++)
            {
                this.sequence[i] = prev;
                long temp = prev + curr;
                prev = curr;
                curr = temp;
            }

        }

        /// <summary>
        /// Current element in Fibonacci sequence.
        /// </summary>
        /// <value>
        /// Value of current element in Fibonacci sequence.
        /// </value>
        public BigInteger Current
        {
            get => this.sequence[currentIndex];
        }

        /// <summary>
        /// Moves to the next element in the sequence.
        /// </summary>
        /// <returns>
        /// True if there are elements in the sequence, false otherwise.
        /// </returns>
        public bool MoveNext()
        {
            currentIndex++;
            if (currentIndex < sequence.Length)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Resets the sequence to the beginning.
        /// </summary>
        public void Reset()
        {
            currentIndex = -1;
        }
    }
}