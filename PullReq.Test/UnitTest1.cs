using System;
using Xunit;

namespace PullReq.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {   
            IGodClass god = new GodClass();

            var tst = "abcdefgh";
            Assert.Equal(tst, god.Echo(tst));
        }
    }
}
