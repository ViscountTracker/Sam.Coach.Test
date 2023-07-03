using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using Sam.Coach;
using Sam.Coach.Tests;


namespace Sam.Coach.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(new[] { 4, 3, 5, 8, 5, 0, 0, -3 }, new[] { 3, 5, 8 })]
        [InlineData(new[] { 9, 6, 4, 5, 2, 0 }, new[] { 4, 5 })]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
        [InlineData(new[] { 5, 4, 3, 2, 1 }, new[] { 5 })]
        [InlineData(new[] { 1, 3, 2, 4, 6, 5, 7 }, new[] { 1, 3, 4, 6, 7 })]
        [InlineData(new[] { 1, 1, 1, 1 }, new[] { 1, 1, 1, 1 })]                    
        [InlineData(new[] { 2, 2, 1, 2, 2 }, new[] { 1, 2, 2 })]                    
        [InlineData(new[] { -5, -4, -3, -2, -1 }, new[] { -5, -4, -3, -2, -1 })]    
        [InlineData(new[] { 5, 4, 3, 2, 3, 4, 5 }, new[] { 2, 3, 4, 5 })]           
        [InlineData(new[] { 1, 3, 2, 4, 2, 3, 5 }, new[] { 1, 3, 4, 5 })]           
        [InlineData(new[] { 5, 5, 5, 5, 5 }, new[] { 5, 5, 5, 5, 5 })]              
        [InlineData(new[] { -2, -1, -3, -1, -2 }, new[] { -3, -1 })]                
        [InlineData(new[] { 10, 9, 8, 7, 6 }, new[] { 10 })]                        
        [InlineData(new[] { 1, 2, 3, 2, 1 }, new[] { 1, 2, 3 })]
        // TODO: add more scenarios to ensure finder is working properly
        public async Task Can_Find(IEnumerable<int> data, IEnumerable<int> expected)
        {// TODO: create the finder instance and get the actual result
            var finder = new LongestRisingSequenceFinder();

            IEnumerable<int> actual = await finder.Find(data);
 
            actual.Should().Equal(expected);
        }
    }
}
