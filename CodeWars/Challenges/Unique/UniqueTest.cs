﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges.Unique
{
    [TestFixture]
    public class UniqueTest
    {
        [TestCase(new[] { 1, 2, 2, 2 }, ExpectedResult = 1)]
        [TestCase(new[] { -2, 2, 2, 2 }, ExpectedResult = -2)]
        [TestCase(new[] { 11, 11, 14, 11, 11 }, ExpectedResult = 14)]
        public int BaseTest(IEnumerable<int> numbers)
        {
            return Unique.GetUnique(numbers);
        }
}
}
