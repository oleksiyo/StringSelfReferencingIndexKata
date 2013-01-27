using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace SelfReferencingIndexKata
{
    public class IndexKata
    {
        private int[] result;

        public int[] Index(string input)
        {
            if (string.IsNullOrEmpty(input))
                return new int[0];

            result = new int[input.Length];
            result[0] = -1;

            return result;
        }
    }
    public class IndexKataTests
    {

        IndexKata indexKata;

        public IndexKataTests()
        {
            indexKata = new IndexKata();
        }

        [Fact]
        public void should_return_an_empty_array_if_the_input_is_null()
        {
            var result = indexKata.Index(null);
            result.Should().BeEmpty();
        }

        [Fact]
        public void shoould_return_an_empty_array_if_the_input_is_empty()
        {
            var result = indexKata.Index(string.Empty);
            result.Should().BeEmpty();
        }

        [Fact]
        public void the_index_array_should_have_the_same_number_of_elements_as_the_input()
        {
            var result = indexKata.Index("ABC");
            result.Length.Should().Be(3);
        }

        [Fact]
        public void the_index_array_values_should_default_to_0()
        {
            int[] expected = new int[3] { 0, 0, 0 };

            var result = indexKata.Index("ABC");
            result.Should().BeEquivalentTo(expected);
        }
        [Fact]
        public void the_first_value_of_the_index_array_should_always_be_minus_1()
        {
            int[] expected = new int[3] { -1, 0, 0 };

            var result = indexKata.Index("ABC");
            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void the_second_value_of_the_index_array_should_always_be_0()
        {
            int[] expected = new int[3] { -1, 0, 0 };
            var result = indexKata.Index("ABC");
            result.Should().BeEquivalentTo(expected);
        }
    }
}
