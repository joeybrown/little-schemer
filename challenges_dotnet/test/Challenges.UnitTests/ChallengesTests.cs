using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Challenges.UnitTests
{
    public class EqualsListTests
    {
        [Fact]
        public void EqualsList_With_Two_Empty_Lists() =>
            Array.Empty<string>().EqualsList(Array.Empty<string>()).Should().BeTrue();

        [Fact]
        public void EqualsList_With_Uneven_Lists()
        {
            new [] {"foo"}.EqualsList(Array.Empty<string>()).Should().BeFalse();
            Array.Empty<string>().EqualsList(new [] {"foo"}).Should().BeFalse();
        }
        
        [Fact]
        public void EqualsList_With_Equal_Length_Lists()
        {
            new [] {"foo", "bar"}.EqualsList(new [] {"bar", "foo"}).Should().BeFalse();
            new [] {"bar", "foo"}.EqualsList(new [] {"foo", "bar"}).Should().BeFalse();
            new [] {"foo", "bar"}.EqualsList(new [] {"foo", "bar"}).Should().BeTrue();
        }
    }
}
